namespace GetHardwareInfo
{
    partial class LicenseForm
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
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.PropertyDataSet = new System.Data.DataSet();
            this.PropertiesDataTable = new System.Data.DataTable();
            this.dataColGroup = new System.Data.DataColumn();
            this.dataColSetting = new System.Data.DataColumn();
            this.dataColSettingValue = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataColCategory = new System.Data.DataColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteXmlButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 72;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 503;
            // 
            // PropertyDataSet
            // 
            this.PropertyDataSet.DataSetName = "NewDataSet";
            this.PropertyDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.PropertiesDataTable});
            // 
            // PropertiesDataTable
            // 
            this.PropertiesDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColGroup,
            this.dataColSetting,
            this.dataColSettingValue,
            this.dataColCategory});
            this.PropertiesDataTable.TableName = "Properties";
            // 
            // dataColGroup
            // 
            this.dataColGroup.ColumnName = "Group";
            // 
            // dataColSetting
            // 
            this.dataColSetting.ColumnName = "Setting";
            // 
            // dataColSettingValue
            // 
            this.dataColSettingValue.ColumnName = "SettingValue";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.groupDataGridViewTextBoxColumn,
            this.settingDataGridViewTextBoxColumn,
            this.settingValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Properties";
            this.dataGridView1.DataSource = this.PropertyDataSet;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 395);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataColCategory
            // 
            this.dataColCategory.ColumnName = "Category";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // settingDataGridViewTextBoxColumn
            // 
            this.settingDataGridViewTextBoxColumn.DataPropertyName = "Setting";
            this.settingDataGridViewTextBoxColumn.HeaderText = "Setting";
            this.settingDataGridViewTextBoxColumn.Name = "settingDataGridViewTextBoxColumn";
            this.settingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // settingValueDataGridViewTextBoxColumn
            // 
            this.settingValueDataGridViewTextBoxColumn.DataPropertyName = "SettingValue";
            this.settingValueDataGridViewTextBoxColumn.HeaderText = "SettingValue";
            this.settingValueDataGridViewTextBoxColumn.Name = "settingValueDataGridViewTextBoxColumn";
            this.settingValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WriteXmlButton
            // 
            this.WriteXmlButton.Location = new System.Drawing.Point(1, 404);
            this.WriteXmlButton.Name = "WriteXmlButton";
            this.WriteXmlButton.Size = new System.Drawing.Size(134, 50);
            this.WriteXmlButton.TabIndex = 3;
            this.WriteXmlButton.Text = "Write XML";
            this.WriteXmlButton.UseVisualStyleBackColor = true;
            this.WriteXmlButton.Click += new System.EventHandler(this.WriteXmlButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 457);
            this.Controls.Add(this.WriteXmlButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Get Hardware Information";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Data.DataSet PropertyDataSet;
        private System.Data.DataTable PropertiesDataTable;
        private System.Data.DataColumn dataColGroup;
        private System.Data.DataColumn dataColSetting;
        private System.Data.DataColumn dataColSettingValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataColumn dataColCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settingValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button WriteXmlButton;
    }
}