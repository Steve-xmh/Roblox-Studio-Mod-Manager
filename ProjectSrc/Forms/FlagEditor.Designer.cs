namespace RobloxStudioModManager
{
    partial class FlagEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabs = new System.Windows.Forms.TabControl();
            this.viewFlagsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flagDataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flagSearchFilter = new System.Windows.Forms.TextBox();
            this.searchTitle = new System.Windows.Forms.Label();
            this.overrideSelected = new System.Windows.Forms.Button();
            this.overrideStatus = new System.Windows.Forms.Label();
            this.overridesTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.overrideDataGridView = new System.Windows.Forms.DataGridView();
            this.overrideNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overrideTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialOverrideValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.removeSelected = new System.Windows.Forms.Button();
            this.removeAll = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.viewFlagsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.overridesTab.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overrideDataGridView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.viewFlagsTab);
            this.tabs.Controls.Add(this.overridesTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(4);
            this.tabs.Name = "tabs";
            this.tabs.Padding = new System.Drawing.Point(20, 5);
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(624, 441);
            this.tabs.TabIndex = 0;
            // 
            // viewFlagsTab
            // 
            this.viewFlagsTab.Controls.Add(this.tableLayoutPanel1);
            this.viewFlagsTab.Controls.Add(this.overrideStatus);
            this.viewFlagsTab.Location = new System.Drawing.Point(4, 26);
            this.viewFlagsTab.Name = "viewFlagsTab";
            this.viewFlagsTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewFlagsTab.Size = new System.Drawing.Size(616, 411);
            this.viewFlagsTab.TabIndex = 0;
            this.viewFlagsTab.Text = "查看参数";
            this.viewFlagsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flagDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 405);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // flagDataGridView
            // 
            this.flagDataGridView.AllowUserToAddRows = false;
            this.flagDataGridView.AllowUserToDeleteRows = false;
            this.flagDataGridView.AllowUserToResizeColumns = false;
            this.flagDataGridView.AllowUserToResizeRows = false;
            this.flagDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.flagDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.typeColumn,
            this.valueColumn,
            this.descColumn});
            this.flagDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flagDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.flagDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.flagDataGridView.Location = new System.Drawing.Point(3, 69);
            this.flagDataGridView.MultiSelect = false;
            this.flagDataGridView.Name = "flagDataGridView";
            this.flagDataGridView.RowHeadersVisible = false;
            this.flagDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.flagDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.flagDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flagDataGridView.Size = new System.Drawing.Size(604, 341);
            this.flagDataGridView.TabIndex = 0;
            this.flagDataGridView.VirtualMode = true;
            this.flagDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.flagDataGridView_CellFormatting);
            this.flagDataGridView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.flagDataGridView_CellValueNeeded);
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.FillWeight = 250F;
            this.nameColumn.HeaderText = "名称";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // typeColumn
            // 
            this.typeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeColumn.FillWeight = 50F;
            this.typeColumn.HeaderText = "数据类型";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            this.typeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // valueColumn
            // 
            this.valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueColumn.FillWeight = 150F;
            this.valueColumn.HeaderText = "值";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            this.valueColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descColumn
            // 
            this.descColumn.HeaderText = "说明";
            this.descColumn.Name = "descColumn";
            this.descColumn.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.overrideSelected, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(604, 60);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flagSearchFilter, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.searchTitle, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(598, 23);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // flagSearchFilter
            // 
            this.flagSearchFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.flagSearchFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.flagSearchFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flagSearchFilter.Location = new System.Drawing.Point(46, 1);
            this.flagSearchFilter.Margin = new System.Windows.Forms.Padding(1);
            this.flagSearchFilter.Name = "flagSearchFilter";
            this.flagSearchFilter.Size = new System.Drawing.Size(551, 21);
            this.flagSearchFilter.TabIndex = 2;
            this.flagSearchFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.flagSearchFilter_KeyDown);
            this.flagSearchFilter.Leave += new System.EventHandler(this.flagSearchFilter_Leave);
            // 
            // searchTitle
            // 
            this.searchTitle.AutoSize = true;
            this.searchTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle.Location = new System.Drawing.Point(1, 0);
            this.searchTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(43, 23);
            this.searchTitle.TabIndex = 1;
            this.searchTitle.Text = "搜索：";
            this.searchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overrideSelected
            // 
            this.overrideSelected.Location = new System.Drawing.Point(3, 32);
            this.overrideSelected.Name = "overrideSelected";
            this.overrideSelected.Size = new System.Drawing.Size(117, 25);
            this.overrideSelected.TabIndex = 3;
            this.overrideSelected.Text = "更改已选项目";
            this.overrideSelected.UseVisualStyleBackColor = true;
            this.overrideSelected.Click += new System.EventHandler(this.overrideSelected_Click);
            // 
            // overrideStatus
            // 
            this.overrideStatus.AutoSize = true;
            this.overrideStatus.Location = new System.Drawing.Point(182, 33);
            this.overrideStatus.Name = "overrideStatus";
            this.overrideStatus.Size = new System.Drawing.Size(0, 12);
            this.overrideStatus.TabIndex = 4;
            // 
            // overridesTab
            // 
            this.overridesTab.Controls.Add(this.tableLayoutPanel4);
            this.overridesTab.Location = new System.Drawing.Point(4, 26);
            this.overridesTab.Name = "overridesTab";
            this.overridesTab.Padding = new System.Windows.Forms.Padding(3);
            this.overridesTab.Size = new System.Drawing.Size(616, 411);
            this.overridesTab.TabIndex = 1;
            this.overridesTab.Text = "已更改参数";
            this.overridesTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.overrideDataGridView, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(610, 405);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // overrideDataGridView
            // 
            this.overrideDataGridView.AllowUserToAddRows = false;
            this.overrideDataGridView.AllowUserToDeleteRows = false;
            this.overrideDataGridView.AllowUserToResizeColumns = false;
            this.overrideDataGridView.AllowUserToResizeRows = false;
            this.overrideDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.overrideDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overrideDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overrideDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.overrideNameColumn,
            this.overrideTypeColumn,
            this.initialOverrideValueColumn});
            this.overrideDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overrideDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.overrideDataGridView.Location = new System.Drawing.Point(3, 36);
            this.overrideDataGridView.MultiSelect = false;
            this.overrideDataGridView.Name = "overrideDataGridView";
            this.overrideDataGridView.RowHeadersVisible = false;
            this.overrideDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.overrideDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.overrideDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.overrideDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.overrideDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.overrideDataGridView.Size = new System.Drawing.Size(604, 366);
            this.overrideDataGridView.TabIndex = 1;
            this.overrideDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.overrideDataGridView_CellEndEdit);
            this.overrideDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.overrideDataGridView_CellMouseEnter);
            this.overrideDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.overrideDataGridView_CellMouseLeave);
            // 
            // overrideNameColumn
            // 
            this.overrideNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.overrideNameColumn.DataPropertyName = "Name";
            this.overrideNameColumn.FillWeight = 150F;
            this.overrideNameColumn.HeaderText = "Name";
            this.overrideNameColumn.Name = "overrideNameColumn";
            this.overrideNameColumn.ReadOnly = true;
            this.overrideNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // overrideTypeColumn
            // 
            this.overrideTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.overrideTypeColumn.DataPropertyName = "Type";
            this.overrideTypeColumn.FillWeight = 40F;
            this.overrideTypeColumn.HeaderText = "Type";
            this.overrideTypeColumn.Name = "overrideTypeColumn";
            this.overrideTypeColumn.ReadOnly = true;
            this.overrideTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // initialOverrideValueColumn
            // 
            this.initialOverrideValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.initialOverrideValueColumn.DataPropertyName = "Value";
            this.initialOverrideValueColumn.HeaderText = "Value";
            this.initialOverrideValueColumn.Name = "initialOverrideValueColumn";
            this.initialOverrideValueColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.removeSelected, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.removeAll, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(446, 27);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // removeSelected
            // 
            this.removeSelected.Location = new System.Drawing.Point(3, 3);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(217, 21);
            this.removeSelected.TabIndex = 2;
            this.removeSelected.Text = "删除已选项目";
            this.removeSelected.UseVisualStyleBackColor = true;
            this.removeSelected.Click += new System.EventHandler(this.removeSelected_Click);
            // 
            // removeAll
            // 
            this.removeAll.Location = new System.Drawing.Point(226, 3);
            this.removeAll.Name = "removeAll";
            this.removeAll.Size = new System.Drawing.Size(217, 21);
            this.removeAll.TabIndex = 3;
            this.removeAll.Text = "删除全部";
            this.removeAll.UseVisualStyleBackColor = true;
            this.removeAll.Click += new System.EventHandler(this.removeAll_Click);
            // 
            // FlagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabs);
            this.DoubleBuffered = true;
            this.Icon = global::RobloxStudioModManager.Properties.Resources.Icon;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FlagEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数编辑器";
            this.Load += new System.EventHandler(this.FlagEditor_Load);
            this.tabs.ResumeLayout(false);
            this.viewFlagsTab.ResumeLayout(false);
            this.viewFlagsTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.overridesTab.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overrideDataGridView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage viewFlagsTab;
        private System.Windows.Forms.TabPage overridesTab;
        private System.Windows.Forms.DataGridView flagDataGridView;
        private System.Windows.Forms.TextBox flagSearchFilter;
        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.Button overrideSelected;
        private System.Windows.Forms.DataGridView overrideDataGridView;
        private System.Windows.Forms.Label overrideStatus;
        private System.Windows.Forms.Button removeAll;
        private System.Windows.Forms.Button removeSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn overrideNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overrideTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialOverrideValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}