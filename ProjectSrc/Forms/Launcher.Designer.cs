namespace RobloxStudioModManager
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.launchStudio = new System.Windows.Forms.Button();
            this.manageMods = new System.Windows.Forms.Button();
            this.branchSelect = new System.Windows.Forms.ComboBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.forceRebuild = new System.Windows.Forms.CheckBox();
            this.openFlagEditor = new System.Windows.Forms.Button();
            this.editExplorerIcons = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.openStudioDirectory = new System.Windows.Forms.CheckBox();
            this.targetVersionLabel = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.targetVersion = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.quietStartWhenHavingArgs = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // launchStudio
            // 
            this.launchStudio.AccessibleName = "Launch Roblox Studio";
            this.launchStudio.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.launchStudio.Cursor = System.Windows.Forms.Cursors.Default;
            this.launchStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchStudio.Location = new System.Drawing.Point(23, 95);
            this.launchStudio.Name = "launchStudio";
            this.launchStudio.Size = new System.Drawing.Size(142, 21);
            this.launchStudio.TabIndex = 6;
            this.launchStudio.Text = "启动 Studio";
            this.launchStudio.UseVisualStyleBackColor = true;
            this.launchStudio.Click += new System.EventHandler(this.launchStudio_Click);
            // 
            // manageMods
            // 
            this.manageMods.AccessibleName = "Open Mod Folder";
            this.manageMods.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageMods.Location = new System.Drawing.Point(23, 122);
            this.manageMods.Name = "manageMods";
            this.manageMods.Size = new System.Drawing.Size(142, 21);
            this.manageMods.TabIndex = 9;
            this.manageMods.Text = "打开模组文件夹";
            this.manageMods.UseVisualStyleBackColor = true;
            this.manageMods.Click += new System.EventHandler(this.manageMods_Click);
            // 
            // branchSelect
            // 
            this.branchSelect.AccessibleName = "Branch Selector";
            this.branchSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchSelect.FormattingEnabled = true;
            this.branchSelect.Items.AddRange(new object[] {
            "roblox",
            "sitetest1.robloxlabs",
            "sitetest2.robloxlabs",
            "sitetest3.robloxlabs"});
            this.branchSelect.Location = new System.Drawing.Point(181, 104);
            this.branchSelect.Name = "branchSelect";
            this.branchSelect.Size = new System.Drawing.Size(152, 20);
            this.branchSelect.TabIndex = 10;
            this.branchSelect.SelectedIndexChanged += new System.EventHandler(this.branchSelect_SelectedIndexChanged);
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.BackColor = System.Drawing.Color.Transparent;
            this.branchLabel.CausesValidation = false;
            this.branchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.branchLabel.Location = new System.Drawing.Point(178, 90);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(79, 13);
            this.branchLabel.TabIndex = 11;
            this.branchLabel.Text = "Studio 分支： ";
            // 
            // forceRebuild
            // 
            this.forceRebuild.AccessibleName = "强制进行重新安装";
            this.forceRebuild.AutoSize = true;
            this.forceRebuild.Location = new System.Drawing.Point(181, 167);
            this.forceRebuild.Margin = new System.Windows.Forms.Padding(2);
            this.forceRebuild.Name = "forceRebuild";
            this.forceRebuild.Size = new System.Drawing.Size(120, 16);
            this.forceRebuild.TabIndex = 12;
            this.forceRebuild.Text = "强制进行重新安装";
            this.forceRebuild.UseVisualStyleBackColor = true;
            // 
            // openFlagEditor
            // 
            this.openFlagEditor.AccessibleName = "Open Flag Editor";
            this.openFlagEditor.Location = new System.Drawing.Point(23, 149);
            this.openFlagEditor.Name = "openFlagEditor";
            this.openFlagEditor.Size = new System.Drawing.Size(142, 21);
            this.openFlagEditor.TabIndex = 15;
            this.openFlagEditor.Text = "编辑快速参数";
            this.openFlagEditor.UseVisualStyleBackColor = true;
            this.openFlagEditor.Click += new System.EventHandler(this.editFVariables_Click);
            // 
            // editExplorerIcons
            // 
            this.editExplorerIcons.AccessibleName = "Open Flag Editor";
            this.editExplorerIcons.Location = new System.Drawing.Point(23, 175);
            this.editExplorerIcons.Name = "editExplorerIcons";
            this.editExplorerIcons.Size = new System.Drawing.Size(142, 21);
            this.editExplorerIcons.TabIndex = 16;
            this.editExplorerIcons.Text = "编辑对象图标";
            this.editExplorerIcons.UseVisualStyleBackColor = true;
            this.editExplorerIcons.Click += new System.EventHandler(this.editExplorerIcons_Click);
            // 
            // logo
            // 
            this.logo.Image = global::RobloxStudioModManager.Properties.Resources.Logo;
            this.logo.Location = new System.Drawing.Point(40, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(70, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 19;
            this.logo.TabStop = false;
            // 
            // openStudioDirectory
            // 
            this.openStudioDirectory.AccessibleName = "只打开 Studio 文件夹";
            this.openStudioDirectory.AutoSize = true;
            this.openStudioDirectory.Location = new System.Drawing.Point(181, 186);
            this.openStudioDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.openStudioDirectory.Name = "openStudioDirectory";
            this.openStudioDirectory.Size = new System.Drawing.Size(144, 16);
            this.openStudioDirectory.TabIndex = 14;
            this.openStudioDirectory.Text = "只打开 Studio 文件夹";
            this.openStudioDirectory.UseVisualStyleBackColor = true;
            // 
            // targetVersionLabel
            // 
            this.targetVersionLabel.AutoSize = true;
            this.targetVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.targetVersionLabel.CausesValidation = false;
            this.targetVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetVersionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.targetVersionLabel.Location = new System.Drawing.Point(178, 126);
            this.targetVersionLabel.Name = "targetVersionLabel";
            this.targetVersionLabel.Size = new System.Drawing.Size(91, 13);
            this.targetVersionLabel.TabIndex = 17;
            this.targetVersionLabel.Text = "目标分支版本：";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(116, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(205, 48);
            this.title.TabIndex = 20;
            this.title.Text = "Roblox Studio\r\n模组管理器";
            // 
            // targetVersion
            // 
            this.targetVersion.AccessibleName = "Target Version";
            this.targetVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetVersion.FormattingEnabled = true;
            this.targetVersion.Items.AddRange(new object[] {
            "（使用最新版）"});
            this.targetVersion.Location = new System.Drawing.Point(181, 141);
            this.targetVersion.Name = "targetVersion";
            this.targetVersion.Size = new System.Drawing.Size(152, 20);
            this.targetVersion.TabIndex = 18;
            this.targetVersion.SelectedIndexChanged += new System.EventHandler(this.targetVersion_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 199);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 12);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "作者：CloneTrooper1019";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(21, 216);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(89, 12);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "翻译：SteveXMH";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // quietStartWhenHavingArgs
            // 
            this.quietStartWhenHavingArgs.AccessibleName = "携带参数时直接启动";
            this.quietStartWhenHavingArgs.AutoSize = true;
            this.quietStartWhenHavingArgs.Checked = true;
            this.quietStartWhenHavingArgs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quietStartWhenHavingArgs.Location = new System.Drawing.Point(182, 206);
            this.quietStartWhenHavingArgs.Name = "quietStartWhenHavingArgs";
            this.quietStartWhenHavingArgs.Size = new System.Drawing.Size(132, 16);
            this.quietStartWhenHavingArgs.TabIndex = 24;
            this.quietStartWhenHavingArgs.Text = "携带参数时直接启动";
            this.quietStartWhenHavingArgs.UseVisualStyleBackColor = true;
            this.quietStartWhenHavingArgs.CheckedChanged += new System.EventHandler(this.quietStartWhenHavingArgs_CheckedChanged);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(354, 237);
            this.Controls.Add(this.quietStartWhenHavingArgs);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.targetVersion);
            this.Controls.Add(this.targetVersionLabel);
            this.Controls.Add(this.editExplorerIcons);
            this.Controls.Add(this.openFlagEditor);
            this.Controls.Add(this.openStudioDirectory);
            this.Controls.Add(this.forceRebuild);
            this.Controls.Add(this.branchLabel);
            this.Controls.Add(this.branchSelect);
            this.Controls.Add(this.manageMods);
            this.Controls.Add(this.launchStudio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::RobloxStudioModManager.Properties.Resources.Icon;
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roblox Studio 模组管理器";
            this.Load += new System.EventHandler(this.Launcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchStudio;
        private System.Windows.Forms.Button manageMods;
        private System.Windows.Forms.ComboBox branchSelect;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.CheckBox forceRebuild;
        private System.Windows.Forms.Button openFlagEditor;
        private System.Windows.Forms.Button editExplorerIcons;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox openStudioDirectory;
        private System.Windows.Forms.Label targetVersionLabel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox targetVersion;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox quietStartWhenHavingArgs;
    }
}
