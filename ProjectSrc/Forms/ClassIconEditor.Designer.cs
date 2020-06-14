namespace RobloxStudioModManager
{
    partial class ClassIconEditor
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
            this.iconContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.header = new System.Windows.Forms.Label();
            this.enableIconOverride = new System.Windows.Forms.CheckBox();
            this.editIcon = new System.Windows.Forms.Button();
            this.selectedIcon = new System.Windows.Forms.PictureBox();
            this.restoreOriginal = new System.Windows.Forms.Button();
            this.themeSwitcher = new System.Windows.Forms.Button();
            this.errors = new System.Windows.Forms.Label();
            this.showModified = new System.Windows.Forms.CheckBox();
            this.openIconFolder = new System.Windows.Forms.Button();
            this.iconSlotsTitle = new System.Windows.Forms.Label();
            this.itemSlots = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.selectedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSlots)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconContainer
            // 
            this.iconContainer.AutoScroll = true;
            this.iconContainer.AutoSize = true;
            this.iconContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iconContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconContainer.Location = new System.Drawing.Point(3, 41);
            this.iconContainer.Name = "iconContainer";
            this.iconContainer.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.iconContainer.Size = new System.Drawing.Size(299, 155);
            this.iconContainer.TabIndex = 0;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Dock = System.Windows.Forms.DockStyle.Left;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(3, 0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.header.Size = new System.Drawing.Size(108, 32);
            this.header.TabIndex = 2;
            this.header.Text = "初始化中...";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enableIconOverride
            // 
            this.enableIconOverride.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enableIconOverride.AutoSize = true;
            this.enableIconOverride.Location = new System.Drawing.Point(3, 8);
            this.enableIconOverride.Name = "enableIconOverride";
            this.enableIconOverride.Size = new System.Drawing.Size(96, 16);
            this.enableIconOverride.TabIndex = 4;
            this.enableIconOverride.Text = "覆盖已有图标";
            this.enableIconOverride.UseVisualStyleBackColor = true;
            this.enableIconOverride.CheckedChanged += new System.EventHandler(this.enableIconOverride_CheckedChanged);
            // 
            // editIcon
            // 
            this.editIcon.AutoSize = true;
            this.editIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editIcon.Location = new System.Drawing.Point(3, 35);
            this.editIcon.Name = "editIcon";
            this.editIcon.Size = new System.Drawing.Size(108, 26);
            this.editIcon.TabIndex = 5;
            this.editIcon.Text = "编辑图标 0";
            this.editIcon.UseVisualStyleBackColor = true;
            this.editIcon.Click += new System.EventHandler(this.editIcon_Click);
            // 
            // selectedIcon
            // 
            this.selectedIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectedIcon.BackColor = System.Drawing.Color.White;
            this.selectedIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selectedIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectedIcon.Location = new System.Drawing.Point(8, 13);
            this.selectedIcon.Margin = new System.Windows.Forms.Padding(8);
            this.selectedIcon.Name = "selectedIcon";
            this.selectedIcon.Size = new System.Drawing.Size(46, 43);
            this.selectedIcon.TabIndex = 3;
            this.selectedIcon.TabStop = false;
            // 
            // restoreOriginal
            // 
            this.restoreOriginal.AutoSize = true;
            this.restoreOriginal.Enabled = false;
            this.restoreOriginal.Location = new System.Drawing.Point(117, 35);
            this.restoreOriginal.Name = "restoreOriginal";
            this.restoreOriginal.Size = new System.Drawing.Size(89, 26);
            this.restoreOriginal.TabIndex = 6;
            this.restoreOriginal.Text = "恢复原始图标";
            this.restoreOriginal.UseCompatibleTextRendering = true;
            this.restoreOriginal.UseVisualStyleBackColor = true;
            this.restoreOriginal.Click += new System.EventHandler(this.restoreOriginal_Click);
            // 
            // themeSwitcher
            // 
            this.themeSwitcher.AutoSize = true;
            this.themeSwitcher.Dock = System.Windows.Forms.DockStyle.Right;
            this.themeSwitcher.Location = new System.Drawing.Point(220, 3);
            this.themeSwitcher.Name = "themeSwitcher";
            this.themeSwitcher.Size = new System.Drawing.Size(76, 26);
            this.themeSwitcher.TabIndex = 7;
            this.themeSwitcher.Text = "主题：默认";
            this.themeSwitcher.UseCompatibleTextRendering = true;
            this.themeSwitcher.UseVisualStyleBackColor = true;
            this.themeSwitcher.Click += new System.EventHandler(this.themeSwitcher_Click);
            // 
            // errors
            // 
            this.errors.AutoSize = true;
            this.errors.ForeColor = System.Drawing.Color.Red;
            this.errors.Location = new System.Drawing.Point(9, 268);
            this.errors.Name = "errors";
            this.errors.Size = new System.Drawing.Size(0, 12);
            this.errors.TabIndex = 10;
            // 
            // showModified
            // 
            this.showModified.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.showModified.AutoSize = true;
            this.showModified.Location = new System.Drawing.Point(117, 8);
            this.showModified.Name = "showModified";
            this.showModified.Size = new System.Drawing.Size(108, 16);
            this.showModified.TabIndex = 11;
            this.showModified.Text = "显示已覆盖图标";
            this.showModified.UseVisualStyleBackColor = true;
            this.showModified.CheckedChanged += new System.EventHandler(this.showModified_CheckedChanged);
            // 
            // openIconFolder
            // 
            this.openIconFolder.AutoSize = true;
            this.openIconFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openIconFolder.Location = new System.Drawing.Point(3, 311);
            this.openIconFolder.Name = "openIconFolder";
            this.openIconFolder.Size = new System.Drawing.Size(135, 22);
            this.openIconFolder.TabIndex = 12;
            this.openIconFolder.Text = "打开类图标所在文件夹";
            this.openIconFolder.UseVisualStyleBackColor = true;
            this.openIconFolder.Click += new System.EventHandler(this.openIconFolder_Click);
            // 
            // iconSlotsTitle
            // 
            this.iconSlotsTitle.AutoSize = true;
            this.iconSlotsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconSlotsTitle.Location = new System.Drawing.Point(3, 0);
            this.iconSlotsTitle.Name = "iconSlotsTitle";
            this.iconSlotsTitle.Size = new System.Drawing.Size(89, 27);
            this.iconSlotsTitle.TabIndex = 13;
            this.iconSlotsTitle.Text = "附加图标位置：";
            this.iconSlotsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemSlots
            // 
            this.itemSlots.Location = new System.Drawing.Point(98, 3);
            this.itemSlots.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.itemSlots.Name = "itemSlots";
            this.itemSlots.Size = new System.Drawing.Size(38, 21);
            this.itemSlots.TabIndex = 14;
            this.itemSlots.ValueChanged += new System.EventHandler(this.itemSlots_ValueChanged);
            this.itemSlots.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemSlots_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.openIconFolder, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.iconContainer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 336);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.header, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.themeSwitcher, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.selectedIcon, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 202);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(299, 70);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.editIcon, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.restoreOriginal, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.enableIconOverride, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.showModified, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(65, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(228, 64);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.iconSlotsTitle, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.itemSlots, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 278);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(190, 27);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // ClassIconEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.errors);
            this.Icon = global::RobloxStudioModManager.Properties.Resources.Icon;
            this.MinimumSize = new System.Drawing.Size(320, 370);
            this.Name = "ClassIconEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "类图标编辑器";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClassIconEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSlots)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel iconContainer;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.CheckBox enableIconOverride;
        private System.Windows.Forms.Button editIcon;
        private System.Windows.Forms.PictureBox selectedIcon;
        private System.Windows.Forms.Button restoreOriginal;
        private System.Windows.Forms.Button themeSwitcher;
        private System.Windows.Forms.Label errors;
        private System.Windows.Forms.CheckBox showModified;
        private System.Windows.Forms.Button openIconFolder;
        private System.Windows.Forms.Label iconSlotsTitle;
        private System.Windows.Forms.NumericUpDown itemSlots;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}