namespace SharedLib
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
            this.dataSetLicense = new System.Data.DataSet();
            this.dataTableProperties = new System.Data.DataTable();
            this.dataColGroup = new System.Data.DataColumn();
            this.dataColSetting = new System.Data.DataColumn();
            this.dataColSettingValue = new System.Data.DataColumn();
            this.dataColCategory = new System.Data.DataColumn();
            this.dataTableRegistration = new System.Data.DataTable();
            this.dataColRegGroup = new System.Data.DataColumn();
            this.dataColRegCategory = new System.Data.DataColumn();
            this.dataColRegSetting = new System.Data.DataColumn();
            this.dataColRegSettingValue = new System.Data.DataColumn();
            this.buttonWriteRegistrationFile = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReadLicenseFile = new System.Windows.Forms.Button();
            this.tabControlLicense = new System.Windows.Forms.TabControl();
            this.tabPageRegistration = new System.Windows.Forms.TabPage();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelRegistrationDate = new System.Windows.Forms.Label();
            this.labelKeyCode = new System.Windows.Forms.Label();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelRegisteredUser = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelExpirationDateLabel = new System.Windows.Forms.Label();
            this.labelRegistrationDateLabel = new System.Windows.Forms.Label();
            this.labelKeyCodeLabel = new System.Windows.Forms.Label();
            this.labelSerialNumberLabel = new System.Windows.Forms.Label();
            this.labelRegisteredUserLabel = new System.Windows.Forms.Label();
            this.labelCompanyNameLabel = new System.Windows.Forms.Label();
            this.labelRegistrationStatus = new System.Windows.Forms.Label();
            this.labelRegistrationStatusLabel = new System.Windows.Forms.Label();
            this.gridViewRegistration = new System.Windows.Forms.DataGridView();
            this.SSetting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.gridViewProperties = new System.Windows.Forms.DataGridView();
            this.dgvColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColSetting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColSettingValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSettingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRegistration)).BeginInit();
            this.tabControlLicense.SuspendLayout();
            this.tabPageRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegistration)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProperties)).BeginInit();
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
            // dataSetLicense
            // 
            this.dataSetLicense.DataSetName = "RegDataSet";
            this.dataSetLicense.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableProperties,
            this.dataTableRegistration});
            // 
            // dataTableProperties
            // 
            this.dataTableProperties.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColGroup,
            this.dataColSetting,
            this.dataColSettingValue,
            this.dataColCategory});
            this.dataTableProperties.TableName = "Properties";
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
            // dataColCategory
            // 
            this.dataColCategory.ColumnName = "Category";
            // 
            // dataTableRegistration
            // 
            this.dataTableRegistration.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColRegGroup,
            this.dataColRegCategory,
            this.dataColRegSetting,
            this.dataColRegSettingValue});
            this.dataTableRegistration.TableName = "LicenseSettings";
            // 
            // dataColRegGroup
            // 
            this.dataColRegGroup.Caption = "Group";
            this.dataColRegGroup.ColumnName = "SGroup";
            // 
            // dataColRegCategory
            // 
            this.dataColRegCategory.Caption = "Category";
            this.dataColRegCategory.ColumnName = "SCategory";
            // 
            // dataColRegSetting
            // 
            this.dataColRegSetting.Caption = "Setting";
            this.dataColRegSetting.ColumnName = "SSetting";
            // 
            // dataColRegSettingValue
            // 
            this.dataColRegSettingValue.Caption = "Value";
            this.dataColRegSettingValue.ColumnName = "SValue";
            // 
            // buttonWriteRegistrationFile
            // 
            this.buttonWriteRegistrationFile.Enabled = false;
            this.buttonWriteRegistrationFile.Location = new System.Drawing.Point(879, 655);
            this.buttonWriteRegistrationFile.Name = "buttonWriteRegistrationFile";
            this.buttonWriteRegistrationFile.Size = new System.Drawing.Size(134, 50);
            this.buttonWriteRegistrationFile.TabIndex = 3;
            this.buttonWriteRegistrationFile.Text = "Write Registration File";
            this.buttonWriteRegistrationFile.UseVisualStyleBackColor = true;
            this.buttonWriteRegistrationFile.Visible = false;
            this.buttonWriteRegistrationFile.Click += new System.EventHandler(this.buttonWriteXml_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(4, 655);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(134, 50);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReadLicenseFile
            // 
            this.buttonReadLicenseFile.Location = new System.Drawing.Point(144, 655);
            this.buttonReadLicenseFile.Name = "buttonReadLicenseFile";
            this.buttonReadLicenseFile.Size = new System.Drawing.Size(134, 50);
            this.buttonReadLicenseFile.TabIndex = 15;
            this.buttonReadLicenseFile.Text = "Read License File";
            this.buttonReadLicenseFile.UseVisualStyleBackColor = true;
            this.buttonReadLicenseFile.Click += new System.EventHandler(this.buttonReadLicenseFile_Click);
            // 
            // tabControlLicense
            // 
            this.tabControlLicense.Controls.Add(this.tabPageRegistration);
            this.tabControlLicense.Controls.Add(this.tabPageSettings);
            this.tabControlLicense.Location = new System.Drawing.Point(4, 3);
            this.tabControlLicense.Name = "tabControlLicense";
            this.tabControlLicense.SelectedIndex = 0;
            this.tabControlLicense.Size = new System.Drawing.Size(1013, 646);
            this.tabControlLicense.TabIndex = 18;
            // 
            // tabPageRegistration
            // 
            this.tabPageRegistration.Controls.Add(this.labelExpirationDate);
            this.tabPageRegistration.Controls.Add(this.labelRegistrationDate);
            this.tabPageRegistration.Controls.Add(this.labelKeyCode);
            this.tabPageRegistration.Controls.Add(this.labelSerialNumber);
            this.tabPageRegistration.Controls.Add(this.labelRegisteredUser);
            this.tabPageRegistration.Controls.Add(this.labelCompanyName);
            this.tabPageRegistration.Controls.Add(this.labelExpirationDateLabel);
            this.tabPageRegistration.Controls.Add(this.labelRegistrationDateLabel);
            this.tabPageRegistration.Controls.Add(this.labelKeyCodeLabel);
            this.tabPageRegistration.Controls.Add(this.labelSerialNumberLabel);
            this.tabPageRegistration.Controls.Add(this.labelRegisteredUserLabel);
            this.tabPageRegistration.Controls.Add(this.labelCompanyNameLabel);
            this.tabPageRegistration.Controls.Add(this.labelRegistrationStatus);
            this.tabPageRegistration.Controls.Add(this.labelRegistrationStatusLabel);
            this.tabPageRegistration.Controls.Add(this.gridViewRegistration);
            this.tabPageRegistration.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegistration.Name = "tabPageRegistration";
            this.tabPageRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistration.Size = new System.Drawing.Size(1005, 620);
            this.tabPageRegistration.TabIndex = 0;
            this.tabPageRegistration.Text = "Registration";
            this.tabPageRegistration.UseVisualStyleBackColor = true;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.BackColor = System.Drawing.Color.White;
            this.labelExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpirationDate.Location = new System.Drawing.Point(158, 200);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(376, 24);
            this.labelExpirationDate.TabIndex = 33;
            this.labelExpirationDate.Text = "Unregistered";
            // 
            // labelRegistrationDate
            // 
            this.labelRegistrationDate.BackColor = System.Drawing.Color.White;
            this.labelRegistrationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationDate.Location = new System.Drawing.Point(158, 169);
            this.labelRegistrationDate.Name = "labelRegistrationDate";
            this.labelRegistrationDate.Size = new System.Drawing.Size(376, 24);
            this.labelRegistrationDate.TabIndex = 32;
            this.labelRegistrationDate.Text = "Unregistered";
            // 
            // labelKeyCode
            // 
            this.labelKeyCode.BackColor = System.Drawing.Color.White;
            this.labelKeyCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKeyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyCode.Location = new System.Drawing.Point(158, 138);
            this.labelKeyCode.Name = "labelKeyCode";
            this.labelKeyCode.Size = new System.Drawing.Size(376, 24);
            this.labelKeyCode.TabIndex = 31;
            this.labelKeyCode.Text = "Unregistered";
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.BackColor = System.Drawing.Color.White;
            this.labelSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumber.Location = new System.Drawing.Point(158, 107);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(376, 24);
            this.labelSerialNumber.TabIndex = 30;
            this.labelSerialNumber.Text = "Unregistered";
            // 
            // labelRegisteredUser
            // 
            this.labelRegisteredUser.BackColor = System.Drawing.Color.White;
            this.labelRegisteredUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegisteredUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisteredUser.Location = new System.Drawing.Point(158, 76);
            this.labelRegisteredUser.Name = "labelRegisteredUser";
            this.labelRegisteredUser.Size = new System.Drawing.Size(376, 24);
            this.labelRegisteredUser.TabIndex = 29;
            this.labelRegisteredUser.Text = "Unregistered";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.BackColor = System.Drawing.Color.White;
            this.labelCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Location = new System.Drawing.Point(158, 45);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(376, 24);
            this.labelCompanyName.TabIndex = 28;
            this.labelCompanyName.Text = "Unregistered";
            // 
            // labelExpirationDateLabel
            // 
            this.labelExpirationDateLabel.AutoSize = true;
            this.labelExpirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpirationDateLabel.Location = new System.Drawing.Point(6, 203);
            this.labelExpirationDateLabel.Name = "labelExpirationDateLabel";
            this.labelExpirationDateLabel.Size = new System.Drawing.Size(118, 20);
            this.labelExpirationDateLabel.TabIndex = 27;
            this.labelExpirationDateLabel.Text = "Expiration Date";
            // 
            // labelRegistrationDateLabel
            // 
            this.labelRegistrationDateLabel.AutoSize = true;
            this.labelRegistrationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationDateLabel.Location = new System.Drawing.Point(6, 172);
            this.labelRegistrationDateLabel.Name = "labelRegistrationDateLabel";
            this.labelRegistrationDateLabel.Size = new System.Drawing.Size(134, 20);
            this.labelRegistrationDateLabel.TabIndex = 26;
            this.labelRegistrationDateLabel.Text = "Registration Date";
            // 
            // labelKeyCodeLabel
            // 
            this.labelKeyCodeLabel.AutoSize = true;
            this.labelKeyCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyCodeLabel.Location = new System.Drawing.Point(6, 141);
            this.labelKeyCodeLabel.Name = "labelKeyCodeLabel";
            this.labelKeyCodeLabel.Size = new System.Drawing.Size(77, 20);
            this.labelKeyCodeLabel.TabIndex = 25;
            this.labelKeyCodeLabel.Text = "Key Code";
            // 
            // labelSerialNumberLabel
            // 
            this.labelSerialNumberLabel.AutoSize = true;
            this.labelSerialNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSerialNumberLabel.Location = new System.Drawing.Point(6, 110);
            this.labelSerialNumberLabel.Name = "labelSerialNumberLabel";
            this.labelSerialNumberLabel.Size = new System.Drawing.Size(109, 20);
            this.labelSerialNumberLabel.TabIndex = 24;
            this.labelSerialNumberLabel.Text = "Serial Number";
            // 
            // labelRegisteredUserLabel
            // 
            this.labelRegisteredUserLabel.AutoSize = true;
            this.labelRegisteredUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisteredUserLabel.Location = new System.Drawing.Point(6, 79);
            this.labelRegisteredUserLabel.Name = "labelRegisteredUserLabel";
            this.labelRegisteredUserLabel.Size = new System.Drawing.Size(125, 20);
            this.labelRegisteredUserLabel.TabIndex = 23;
            this.labelRegisteredUserLabel.Text = "Registered User";
            // 
            // labelCompanyNameLabel
            // 
            this.labelCompanyNameLabel.AutoSize = true;
            this.labelCompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyNameLabel.Location = new System.Drawing.Point(6, 48);
            this.labelCompanyNameLabel.Name = "labelCompanyNameLabel";
            this.labelCompanyNameLabel.Size = new System.Drawing.Size(122, 20);
            this.labelCompanyNameLabel.TabIndex = 22;
            this.labelCompanyNameLabel.Text = "Company Name";
            // 
            // labelRegistrationStatus
            // 
            this.labelRegistrationStatus.BackColor = System.Drawing.Color.White;
            this.labelRegistrationStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegistrationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationStatus.Location = new System.Drawing.Point(158, 14);
            this.labelRegistrationStatus.Name = "labelRegistrationStatus";
            this.labelRegistrationStatus.Size = new System.Drawing.Size(376, 24);
            this.labelRegistrationStatus.TabIndex = 21;
            this.labelRegistrationStatus.Text = "Unregistered";
            // 
            // labelRegistrationStatusLabel
            // 
            this.labelRegistrationStatusLabel.AutoSize = true;
            this.labelRegistrationStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationStatusLabel.Location = new System.Drawing.Point(6, 17);
            this.labelRegistrationStatusLabel.Name = "labelRegistrationStatusLabel";
            this.labelRegistrationStatusLabel.Size = new System.Drawing.Size(146, 20);
            this.labelRegistrationStatusLabel.TabIndex = 20;
            this.labelRegistrationStatusLabel.Text = "Registration Status";
            // 
            // gridViewRegistration
            // 
            this.gridViewRegistration.AllowUserToAddRows = false;
            this.gridViewRegistration.AllowUserToDeleteRows = false;
            this.gridViewRegistration.AutoGenerateColumns = false;
            this.gridViewRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRegistration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SSetting,
            this.SValue,
            this.sGroupDataGridViewTextBoxColumn,
            this.sCategoryDataGridViewTextBoxColumn,
            this.sSettingDataGridViewTextBoxColumn,
            this.sValueDataGridViewTextBoxColumn});
            this.gridViewRegistration.DataMember = "LicenseSettings";
            this.gridViewRegistration.DataSource = this.dataSetLicense;
            this.gridViewRegistration.Location = new System.Drawing.Point(10, 253);
            this.gridViewRegistration.Name = "gridViewRegistration";
            this.gridViewRegistration.ReadOnly = true;
            this.gridViewRegistration.Size = new System.Drawing.Size(860, 361);
            this.gridViewRegistration.TabIndex = 19;
            // 
            // SSetting
            // 
            this.SSetting.DataPropertyName = "SSetting";
            this.SSetting.Frozen = true;
            this.SSetting.HeaderText = "Setting";
            this.SSetting.Name = "SSetting";
            this.SSetting.ReadOnly = true;
            this.SSetting.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SSetting.Width = 300;
            // 
            // SValue
            // 
            this.SValue.DataPropertyName = "SValue";
            this.SValue.HeaderText = "Value";
            this.SValue.Name = "SValue";
            this.SValue.ReadOnly = true;
            this.SValue.Width = 500;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.gridViewProperties);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(1005, 620);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // gridViewProperties
            // 
            this.gridViewProperties.AllowUserToAddRows = false;
            this.gridViewProperties.AllowUserToDeleteRows = false;
            this.gridViewProperties.AutoGenerateColumns = false;
            this.gridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColCategory,
            this.dgvColGroup,
            this.dgvColSetting,
            this.dgvColSettingValue});
            this.gridViewProperties.DataMember = "Properties";
            this.gridViewProperties.DataSource = this.dataSetLicense;
            this.gridViewProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewProperties.Location = new System.Drawing.Point(3, 3);
            this.gridViewProperties.Name = "gridViewProperties";
            this.gridViewProperties.ReadOnly = true;
            this.gridViewProperties.Size = new System.Drawing.Size(999, 614);
            this.gridViewProperties.TabIndex = 3;
            // 
            // dgvColCategory
            // 
            this.dgvColCategory.DataPropertyName = "Category";
            this.dgvColCategory.Frozen = true;
            this.dgvColCategory.HeaderText = "Category";
            this.dgvColCategory.Name = "dgvColCategory";
            this.dgvColCategory.ReadOnly = true;
            this.dgvColCategory.Width = 200;
            // 
            // dgvColGroup
            // 
            this.dgvColGroup.DataPropertyName = "Group";
            this.dgvColGroup.HeaderText = "Group";
            this.dgvColGroup.Name = "dgvColGroup";
            this.dgvColGroup.ReadOnly = true;
            this.dgvColGroup.Width = 200;
            // 
            // dgvColSetting
            // 
            this.dgvColSetting.DataPropertyName = "Setting";
            this.dgvColSetting.HeaderText = "Setting";
            this.dgvColSetting.Name = "dgvColSetting";
            this.dgvColSetting.ReadOnly = true;
            this.dgvColSetting.Width = 200;
            // 
            // dgvColSettingValue
            // 
            this.dgvColSettingValue.DataPropertyName = "SettingValue";
            this.dgvColSettingValue.HeaderText = "SettingValue";
            this.dgvColSettingValue.Name = "dgvColSettingValue";
            this.dgvColSettingValue.ReadOnly = true;
            this.dgvColSettingValue.Width = 300;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileLicense";
            // 
            // sGroupDataGridViewTextBoxColumn
            // 
            this.sGroupDataGridViewTextBoxColumn.DataPropertyName = "SGroup";
            this.sGroupDataGridViewTextBoxColumn.HeaderText = "SGroup";
            this.sGroupDataGridViewTextBoxColumn.Name = "sGroupDataGridViewTextBoxColumn";
            this.sGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sCategoryDataGridViewTextBoxColumn
            // 
            this.sCategoryDataGridViewTextBoxColumn.DataPropertyName = "SCategory";
            this.sCategoryDataGridViewTextBoxColumn.HeaderText = "SCategory";
            this.sCategoryDataGridViewTextBoxColumn.Name = "sCategoryDataGridViewTextBoxColumn";
            this.sCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSettingDataGridViewTextBoxColumn
            // 
            this.sSettingDataGridViewTextBoxColumn.DataPropertyName = "SSetting";
            this.sSettingDataGridViewTextBoxColumn.HeaderText = "SSetting";
            this.sSettingDataGridViewTextBoxColumn.Name = "sSettingDataGridViewTextBoxColumn";
            this.sSettingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sValueDataGridViewTextBoxColumn
            // 
            this.sValueDataGridViewTextBoxColumn.DataPropertyName = "SValue";
            this.sValueDataGridViewTextBoxColumn.HeaderText = "SValue";
            this.sValueDataGridViewTextBoxColumn.Name = "sValueDataGridViewTextBoxColumn";
            this.sValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 708);
            this.Controls.Add(this.tabControlLicense);
            this.Controls.Add(this.buttonReadLicenseFile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWriteRegistrationFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Information";
            this.Activated += new System.EventHandler(this.LicenseForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRegistration)).EndInit();
            this.tabControlLicense.ResumeLayout(false);
            this.tabPageRegistration.ResumeLayout(false);
            this.tabPageRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegistration)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Data.DataSet dataSetLicense;
        private System.Data.DataTable dataTableProperties;
        private System.Data.DataColumn dataColGroup;
        private System.Data.DataColumn dataColSetting;
        private System.Data.DataColumn dataColSettingValue;
        private System.Data.DataColumn dataColCategory;
        private System.Windows.Forms.Button buttonWriteRegistrationFile;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReadLicenseFile;
        private System.Data.DataTable dataTableRegistration;
        private System.Data.DataColumn dataColRegGroup;
        private System.Data.DataColumn dataColRegCategory;
        private System.Data.DataColumn dataColRegSetting;
        private System.Data.DataColumn dataColRegSettingValue;
        private System.Windows.Forms.TabControl tabControlLicense;
        private System.Windows.Forms.TabPage tabPageRegistration;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.DataGridView gridViewProperties;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView gridViewRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn SValue;
        private System.Windows.Forms.Label labelExpirationDateLabel;
        private System.Windows.Forms.Label labelRegistrationDateLabel;
        private System.Windows.Forms.Label labelKeyCodeLabel;
        private System.Windows.Forms.Label labelSerialNumberLabel;
        private System.Windows.Forms.Label labelRegisteredUserLabel;
        private System.Windows.Forms.Label labelCompanyNameLabel;
        private System.Windows.Forms.Label labelRegistrationStatus;
        private System.Windows.Forms.Label labelRegistrationStatusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColSettingValue;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label labelRegistrationDate;
        private System.Windows.Forms.Label labelKeyCode;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelRegisteredUser;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSettingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sValueDataGridViewTextBoxColumn;
    }
}