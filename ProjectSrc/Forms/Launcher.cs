﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Windows.Forms;

using Microsoft.Win32;

namespace RobloxStudioModManager
{
    public partial class Launcher : Form
    {
        private static RegistryKey versionRegistry = Program.GetSubKey("VersionData");

        private WebClient http = new WebClient();
        private string[] args = null;

        public Launcher(params string[] mainArgs)
        {
            if (mainArgs.Length > 0)
                args = mainArgs;

            InitializeComponent();
        }

        private string getSelectedBranch()
        {
            var result = branchSelect.SelectedItem;
            return result.ToString();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            quietStartWhenHavingArgs.Checked = Program.GetBool("QuietStartWhenHavingArgs");

            if (args != null)
            {
                openStudioDirectory.Enabled = false;
            }
            
            string build = Program.GetString("BuildBranch");
            int buildIndex = branchSelect.Items.IndexOf(build);

            branchSelect.SelectedIndex = Math.Max(buildIndex, 0);
            if (quietStartWhenHavingArgs.Checked && args != null)
            {
                launchStudio_Click();
            }
        }

        public string getModPath()
        {
            string appData = Environment.GetEnvironmentVariable("AppData");
            string root = Path.Combine(appData, "RbxModManager", "ModFiles");

            if (!Directory.Exists(root))
            {
                // Build a folder structure so the usage of my mod manager is more clear.

                string[] folderPaths = new string[]
                {
                    "BuiltInPlugins",
                    "ClientSettings",

                    "content/avatar",
                    "content/fonts",
                    "content/models",
                    "content/scripts",
                    "content/sky",
                    "content/sounds",
                    "content/textures",
                    "content/translations"
                };

                foreach (string f in folderPaths)
                {
                    string path = Path.Combine(root, f.Replace("/", "\\"));
                    Directory.CreateDirectory(path);
                }
            }

            return root;
        }

        private void manageMods_Click(object sender, EventArgs e)
        {
            string modPath = getModPath();
            Process.Start(modPath);
        }

        private static Form createFlagWarningPrompt()
        {
            var warningForm = new Form()
            {
                Text = "危险操作警告！",
                
                Width = 425, Height = 250,
                MaximizeBox = false, MinimizeBox = false,

                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,

                ShowInTaskbar = false
            };

            var errorIcon = new PictureBox()
            {
                Image = SystemIcons.Error.ToBitmap(),
                Location = new Point(12, 12),
                Size = new Size(32, 32),
            };

            var dontShowAgain = new CheckBox()
            {
                AutoSize = true,
                Location = new Point(54, 145),
                Text = "不再显示本警告",
                Font = new Font("Microsoft Sans Serif", 9.75f),
            };

            var buttonPanel = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.RightToLeft,
                BackColor = SystemColors.ControlLight,
                Padding = new Padding(4),
                Dock = DockStyle.Bottom,
                Size = new Size(0, 40)
            };

            var infoLabel = new Label()
            {
                AutoSize = true,

                Font = new Font("Microsoft Sans Serif", 9.75f),
                Text = "编辑参数可能会让你的 Roblox Studio 出现未知异常，且很有可能损坏你的游戏工程文件数据。\n\n" +
                       "除非你只是希望尝试一些特殊的新功能，否则极不建议编辑这些参数。\n\n" +
                       "是否确定继续？",
                /*
                Text = "Editing flags can make Roblox Studio unstable, and could potentially corrupt your places and game data.\n\n" +
                       "You should not edit them unless you are just experimenting with new features locally, and you know what you're doing.\n\n" +
                       "Are you sure you would like to continue?",
                       */
                Location = new Point(50, 14),
                MaximumSize = new Size(350, 0),
            };

            var yes = new Button()
            {
                Size = new Size(100, 23),
                Text = "是",
            };

            var no = new Button()
            {
                Size = new Size(100, 23),
                Text = "否",
            };

            yes.Click += (sender, e) =>
            {
                warningForm.DialogResult = DialogResult.Yes;
                warningForm.Enabled = dontShowAgain.Checked;
                warningForm.Close();
            };

            no.Click += (sender, e) =>
            {
                warningForm.DialogResult = DialogResult.No;
                warningForm.Enabled = dontShowAgain.Checked;
                warningForm.Close();
            };

            buttonPanel.Controls.Add(no);
            buttonPanel.Controls.Add(yes);

            warningForm.Controls.Add(errorIcon);
            warningForm.Controls.Add(infoLabel);
            warningForm.Controls.Add(buttonPanel);
            warningForm.Controls.Add(dontShowAgain);

            return warningForm;
        }

        private async void editFVariables_Click(object sender, EventArgs e)
        {
            bool allow = true;

            // Create a warning prompt if the user hasn't disabled this warning.
            var warningDisabled = Program.GetBool("Disable Flag Warning");

            if (!warningDisabled)
            {
                SystemSounds.Hand.Play();
                allow = false;

                Form warningPrompt = createFlagWarningPrompt();
                warningPrompt.ShowDialog();

                DialogResult result = warningPrompt.DialogResult;

                if (result == DialogResult.Yes)
                {
                    Program.SetValue("Disable Flag Warning", warningPrompt.Enabled);
                    allow = true;
                }
            }

            if (allow)
            {
                string branch = getSelectedBranch();

                Enabled = false;
                UseWaitCursor = true;

                ClientVersionInfo info = await StudioBootstrapper.GetCurrentVersionInfo(branch);
                Hide();

                await StudioBootstrapper.BringUpToDate(branch, info.Guid, "某些新参数可能无法在旧版本使用！");

                FlagEditor editor = new FlagEditor(branch);
                editor.ShowDialog();

                Show();
                BringToFront();

                Enabled = true;
                UseWaitCursor = false;
            }
        }

        private async void editExplorerIcons_Click(object sender, EventArgs e)
        {
            Enabled = false;
            UseWaitCursor = true;

            string branch = (string)branchSelect.SelectedItem;
            ClientVersionInfo info = await StudioBootstrapper.GetCurrentVersionInfo(branch);

            Hide();
            await StudioBootstrapper.BringUpToDate(branch, info.Guid, "对象图标可能已被更新。");

            var editor = new ClassIconEditor(branch);
            editor.ShowDialog();

            Show();
            BringToFront();

            Enabled = true;
            UseWaitCursor = false;
        }

        private async void launchStudio_Click(object sender = null, EventArgs e = null)
        {
            string branch = getSelectedBranch();
            StudioBootstrapper installer = new StudioBootstrapper(forceRebuild.Checked);

            Hide();
            await installer.RunInstaller(branch, /* bool setStartEvent = */ true);

            string studioRoot = StudioBootstrapper.GetStudioDirectory();
            string modPath = getModPath();

            string[] studioFiles = Directory.GetFiles(studioRoot);
            string[] modFiles = Directory.GetFiles(modPath, "*.*", SearchOption.AllDirectories);

            foreach (string modFile in modFiles)
            {
                try
                {
                    byte[] fileContents = File.ReadAllBytes(modFile);
                    FileInfo modFileControl = new FileInfo(modFile);
                    
                    string relativeFile = modFile.Replace(modPath, studioRoot);
                    string relativeDir = Directory
                        .GetParent(relativeFile)
                        .ToString();

                    if (!Directory.Exists(relativeDir))
                        Directory.CreateDirectory(relativeDir);

                    if (File.Exists(relativeFile))
                    {
                        byte[] relativeContents = File.ReadAllBytes(relativeFile);

                        if (fileContents.SequenceEqual(relativeContents))
                            continue;

                        modFileControl.CopyTo(relativeFile, true);
                        continue;
                    }

                    File.WriteAllBytes(relativeFile, fileContents);
                }
                catch
                {
                    Console.WriteLine("Failed to overwrite {0}!", modFile);
                }
            }

            var robloxStudioInfo = new ProcessStartInfo()
            {
                FileName = StudioBootstrapper.GetStudioPath(),
                Arguments = $"-startEvent {installer.StartEvent.Name}"
            };

            if (args != null)
            {
                string firstArg = args[0];

                if (firstArg != null && firstArg.StartsWith("roblox-studio"))
                {
                    // Arguments were passed by URI.
                    var argMap = new Dictionary<string, string>();

                    foreach (string commandPair in firstArg.Split('+'))
                    {
                        if (commandPair.Contains(':'))
                        {
                            string[] kvPair = commandPair.Split(':');

                            string key = kvPair[0];
                            string val = kvPair[1];

                            if (key == "gameinfo")
                            {
                                // The user is authenticating. This argument is a special case.
                                robloxStudioInfo.Arguments += " -url https://www.roblox.com/Login/Negotiate.ashx -ticket " + val;
                            }
                            else
                            {
                                argMap.Add(key, val);
                                robloxStudioInfo.Arguments += " -" + key + ' ' + val;
                            }
                        }
                    }

                    if (argMap.ContainsKey("launchmode") && !argMap.ContainsKey("task"))
                    {
                        string launchMode = argMap["launchmode"];
                        
                        if (launchMode == "plugin")
                        {
                            string pluginId = argMap["pluginid"];
                            robloxStudioInfo.Arguments += "-task InstallPlugin -pluginId " + pluginId;
                        }
                        else if (launchMode == "edit")
                        {
                            robloxStudioInfo.Arguments += "-task EditPlace";
                        } 
                    }
                }
                else
                {
                    // Arguments were passed directly.
                    string fullArg = string.Join(" ", args);
                    robloxStudioInfo.Arguments += fullArg;
                }
            }

            if (openStudioDirectory.Checked)
            {
                Process.Start(studioRoot);
                Environment.Exit(0);
            }
            else
            {
                string currentVersion = versionRegistry.GetString("VersionGuid");
                versionRegistry.SetValue("LastExecutedVersion", currentVersion);

                Process.Start(robloxStudioInfo);
            }
        }

        private async void branchSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save the user's branch preference.
            string branch = getSelectedBranch();
            Program.SetValue("BuildBranch", branch);
            
            // Grab the version currently being targetted.
            string targetId = Program.GetString("TargetVersion");

            // Clear the current list of target items.
            targetVersion.Items.Clear();
            targetVersion.Items.Add("（使用最新版）");

            // Populate the items list using the deploy history.
            Enabled = false;
            UseWaitCursor = true;

            StudioDeployLogs deployLogs = await StudioDeployLogs.Get(branch);

            Enabled = true;
            UseWaitCursor = false;

            HashSet<DeployLog> targets;

            if (Environment.Is64BitOperatingSystem)
                targets = deployLogs.CurrentLogs_x64;
            else
                targets = deployLogs.CurrentLogs_x86;

            var items = targets
                .OrderByDescending(log => log.Changelist)
                .Cast<object>()
                .Skip(1)
                .ToArray();

            targetVersion.Items.AddRange(items);

            // Select the deploy log being targetted.
            DeployLog target = targets
                .Where(log => log.VersionId == targetId)
                .FirstOrDefault();

            if (target != null)
            {
                targetVersion.SelectedItem = target;
                return;
            }

            // If the target isn't valid, fallback to the latest version.
            targetVersion.SelectedIndex = 0;
        }

        private void targetVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (targetVersion.SelectedIndex == 0)
            {
                Program.SetValue("TargetVersion", "");
                return;
            }

            var target = targetVersion.SelectedItem as DeployLog;
            Program.SetValue("TargetVersion", target.VersionId);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Steve-xmh");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/CloneTrooper1019");
        }

        private void quietStartWhenHavingArgs_CheckedChanged(object sender, EventArgs e)
        {
            Program.SetValue("QuietStartWhenHavingArgs", quietStartWhenHavingArgs.Checked);
        }
    }
}
