namespace AtecMain
{
    partial class frmAtecMain
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxEventHistory = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetMain = new System.Data.DataSet();
            this.dataTableEventLog = new System.Data.DataTable();
            this.dataColEventTime = new System.Data.DataColumn();
            this.dataColumnEventType = new System.Data.DataColumn();
            this.dataColumnEventDescription = new System.Data.DataColumn();
            this.groupBoxMainMenu = new System.Windows.Forms.GroupBox();
            this.listMainMenu = new System.Windows.Forms.ListBox();
            this.listBoxPrinterMenu = new System.Windows.Forms.ListBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEPROMLabel = new System.Windows.Forms.Label();
            this.textEpromType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPartNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textKitNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPartNumFile = new System.Windows.Forms.TextBox();
            this.groupBoxHardwareStatus = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelProgrammer1Status = new System.Windows.Forms.Label();
            this.labelProgrammer2Status = new System.Windows.Forms.Label();
            this.labelPrinter1Status = new System.Windows.Forms.Label();
            this.labelPrinter2Status = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertDataFileToMotorolaFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMotorolaFormatFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programEPROMSAndPrintLabelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSmallLabelsOnPrinter1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printLargeLabelsOnPrinter2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printLargeLabelsOnPrinter1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burnEPROMSOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectEPROMTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearEventHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partNumberDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printer1DiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printer2DiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmer1DiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmer2DiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.groupBoxEventHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEventLog)).BeginInit();
            this.groupBoxMainMenu.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxHardwareStatus.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEventHistory
            // 
            this.groupBoxEventHistory.Controls.Add(this.dataGridView1);
            this.groupBoxEventHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventHistory.Location = new System.Drawing.Point(4, 240);
            this.groupBoxEventHistory.Name = "groupBoxEventHistory";
            this.groupBoxEventHistory.Size = new System.Drawing.Size(1425, 606);
            this.groupBoxEventHistory.TabIndex = 13;
            this.groupBoxEventHistory.TabStop = false;
            this.groupBoxEventHistory.Text = "Event History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventTimeDataGridViewTextBoxColumn,
            this.eventTypeDataGridViewTextBoxColumn,
            this.eventDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "tblEventLog";
            this.dataGridView1.DataSource = this.dataSetMain;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.Size = new System.Drawing.Size(1408, 574);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // eventTimeDataGridViewTextBoxColumn
            // 
            this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
            this.eventTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventTimeDataGridViewTextBoxColumn.Width = 300;
            // 
            // eventTypeDataGridViewTextBoxColumn
            // 
            this.eventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.eventTypeDataGridViewTextBoxColumn.Name = "eventTypeDataGridViewTextBoxColumn";
            this.eventTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // eventDescriptionDataGridViewTextBoxColumn
            // 
            this.eventDescriptionDataGridViewTextBoxColumn.DataPropertyName = "EventDescription";
            this.eventDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.eventDescriptionDataGridViewTextBoxColumn.Name = "eventDescriptionDataGridViewTextBoxColumn";
            this.eventDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.eventDescriptionDataGridViewTextBoxColumn.Width = 800;
            // 
            // dataSetMain
            // 
            this.dataSetMain.DataSetName = "NewDataSet";
            this.dataSetMain.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableEventLog});
            // 
            // dataTableEventLog
            // 
            this.dataTableEventLog.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColEventTime,
            this.dataColumnEventType,
            this.dataColumnEventDescription});
            this.dataTableEventLog.TableName = "tblEventLog";
            // 
            // dataColEventTime
            // 
            this.dataColEventTime.Caption = "Time";
            this.dataColEventTime.ColumnName = "EventTime";
            // 
            // dataColumnEventType
            // 
            this.dataColumnEventType.ColumnName = "EventType";
            // 
            // dataColumnEventDescription
            // 
            this.dataColumnEventDescription.ColumnName = "EventDescription";
            // 
            // groupBoxMainMenu
            // 
            this.groupBoxMainMenu.Controls.Add(this.listMainMenu);
            this.groupBoxMainMenu.Controls.Add(this.listBoxPrinterMenu);
            this.groupBoxMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMainMenu.Location = new System.Drawing.Point(3, 26);
            this.groupBoxMainMenu.Name = "groupBoxMainMenu";
            this.groupBoxMainMenu.Size = new System.Drawing.Size(374, 208);
            this.groupBoxMainMenu.TabIndex = 14;
            this.groupBoxMainMenu.TabStop = false;
            this.groupBoxMainMenu.Text = "Main Menu";
            // 
            // listMainMenu
            // 
            this.listMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMainMenu.FormattingEnabled = true;
            this.listMainMenu.ItemHeight = 24;
            this.listMainMenu.Items.AddRange(new object[] {
            "1. Convert data file to Motorola format",
            "2. Load Motorola format file",
            "3. Program EPROMS and print labels",
            "4. Print labels only",
            "5. Burn EPROMS only",
            "6. Select EPROM type",
            "7. End session and return to Windows"});
            this.listMainMenu.Location = new System.Drawing.Point(3, 25);
            this.listMainMenu.Name = "listMainMenu";
            this.listMainMenu.Size = new System.Drawing.Size(368, 172);
            this.listMainMenu.TabIndex = 1;
            this.listMainMenu.SelectedIndexChanged += new System.EventHandler(this.listMainMenu_SelectedIndexChanged);
            // 
            // listBoxPrinterMenu
            // 
            this.listBoxPrinterMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPrinterMenu.Enabled = false;
            this.listBoxPrinterMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrinterMenu.FormattingEnabled = true;
            this.listBoxPrinterMenu.ItemHeight = 24;
            this.listBoxPrinterMenu.Items.AddRange(new object[] {
            "1. Print Small Labels on Printer 1",
            "2. Print Large Labels on Printer 2",
            "3. Print Large Labels on Printer 1",
            "4. Return to Main Menu"});
            this.listBoxPrinterMenu.Location = new System.Drawing.Point(3, 25);
            this.listBoxPrinterMenu.Name = "listBoxPrinterMenu";
            this.listBoxPrinterMenu.Size = new System.Drawing.Size(368, 172);
            this.listBoxPrinterMenu.TabIndex = 2;
            this.listBoxPrinterMenu.Visible = false;
            this.listBoxPrinterMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxPrinterMenu_SelectedIndexChanged);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSettings.Location = new System.Drawing.Point(1054, 26);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(374, 208);
            this.groupBoxSettings.TabIndex = 15;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.6049F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.3951F));
            this.tableLayoutPanel1.Controls.Add(this.labelEPROMLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textEpromType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textPartNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textKitNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textPartNumFile, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 180);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelEPROMLabel
            // 
            this.labelEPROMLabel.BackColor = System.Drawing.Color.White;
            this.labelEPROMLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEPROMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEPROMLabel.Location = new System.Drawing.Point(4, 1);
            this.labelEPROMLabel.Name = "labelEPROMLabel";
            this.labelEPROMLabel.Size = new System.Drawing.Size(120, 43);
            this.labelEPROMLabel.TabIndex = 22;
            this.labelEPROMLabel.Text = "EPROM Type";
            // 
            // textEpromType
            // 
            this.textEpromType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEpromType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEpromType.Enabled = false;
            this.textEpromType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEpromType.Location = new System.Drawing.Point(131, 4);
            this.textEpromType.MaxLength = 20;
            this.textEpromType.Name = "textEpromType";
            this.textEpromType.Size = new System.Drawing.Size(233, 19);
            this.textEpromType.TabIndex = 23;
            this.textEpromType.Text = "5C24";
            this.textEpromType.Leave += new System.EventHandler(this.textEpromType_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 43);
            this.label1.TabIndex = 24;
            this.label1.Text = "Part Number";
            // 
            // textPartNumber
            // 
            this.textPartNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPartNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPartNumber.Enabled = false;
            this.textPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPartNumber.Location = new System.Drawing.Point(131, 48);
            this.textPartNumber.MaxLength = 20;
            this.textPartNumber.Name = "textPartNumber";
            this.textPartNumber.Size = new System.Drawing.Size(233, 19);
            this.textPartNumber.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 43);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kit Number";
            // 
            // textKitNumber
            // 
            this.textKitNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textKitNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textKitNumber.Enabled = false;
            this.textKitNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKitNumber.Location = new System.Drawing.Point(131, 92);
            this.textKitNumber.MaxLength = 20;
            this.textKitNumber.Name = "textKitNumber";
            this.textKitNumber.Size = new System.Drawing.Size(233, 19);
            this.textKitNumber.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 46);
            this.label3.TabIndex = 28;
            this.label3.Text = "Part File";
            // 
            // textPartNumFile
            // 
            this.textPartNumFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPartNumFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPartNumFile.Enabled = false;
            this.textPartNumFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPartNumFile.Location = new System.Drawing.Point(131, 136);
            this.textPartNumFile.MaxLength = 20;
            this.textPartNumFile.Name = "textPartNumFile";
            this.textPartNumFile.Size = new System.Drawing.Size(233, 19);
            this.textPartNumFile.TabIndex = 29;
            this.textPartNumFile.Text = "PARTNUM.TXT";
            // 
            // groupBoxHardwareStatus
            // 
            this.groupBoxHardwareStatus.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxHardwareStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHardwareStatus.Location = new System.Drawing.Point(384, 26);
            this.groupBoxHardwareStatus.Name = "groupBoxHardwareStatus";
            this.groupBoxHardwareStatus.Size = new System.Drawing.Size(664, 208);
            this.groupBoxHardwareStatus.TabIndex = 16;
            this.groupBoxHardwareStatus.TabStop = false;
            this.groupBoxHardwareStatus.Text = "Hardware Status";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelProgrammer1Status, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelProgrammer2Status, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelPrinter1Status, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelPrinter2Status, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(651, 172);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Programmer 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 43);
            this.label5.TabIndex = 1;
            this.label5.Text = "Programmer 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 43);
            this.label6.TabIndex = 2;
            this.label6.Text = "Printer 1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "Printer 2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProgrammer1Status
            // 
            this.labelProgrammer1Status.AutoSize = true;
            this.labelProgrammer1Status.BackColor = System.Drawing.Color.White;
            this.labelProgrammer1Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgrammer1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgrammer1Status.Location = new System.Drawing.Point(190, 1);
            this.labelProgrammer1Status.Name = "labelProgrammer1Status";
            this.labelProgrammer1Status.Size = new System.Drawing.Size(457, 43);
            this.labelProgrammer1Status.TabIndex = 4;
            this.labelProgrammer1Status.Text = "Missing";
            this.labelProgrammer1Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProgrammer2Status
            // 
            this.labelProgrammer2Status.AutoSize = true;
            this.labelProgrammer2Status.BackColor = System.Drawing.Color.White;
            this.labelProgrammer2Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgrammer2Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgrammer2Status.Location = new System.Drawing.Point(190, 45);
            this.labelProgrammer2Status.Name = "labelProgrammer2Status";
            this.labelProgrammer2Status.Size = new System.Drawing.Size(457, 43);
            this.labelProgrammer2Status.TabIndex = 5;
            this.labelProgrammer2Status.Text = "Missing";
            this.labelProgrammer2Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrinter1Status
            // 
            this.labelPrinter1Status.AutoSize = true;
            this.labelPrinter1Status.BackColor = System.Drawing.Color.White;
            this.labelPrinter1Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrinter1Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrinter1Status.Location = new System.Drawing.Point(190, 89);
            this.labelPrinter1Status.Name = "labelPrinter1Status";
            this.labelPrinter1Status.Size = new System.Drawing.Size(457, 43);
            this.labelPrinter1Status.TabIndex = 6;
            this.labelPrinter1Status.Text = "Missing";
            this.labelPrinter1Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrinter2Status
            // 
            this.labelPrinter2Status.AutoSize = true;
            this.labelPrinter2Status.BackColor = System.Drawing.Color.White;
            this.labelPrinter2Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrinter2Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrinter2Status.Location = new System.Drawing.Point(190, 133);
            this.labelPrinter2Status.Name = "labelPrinter2Status";
            this.labelPrinter2Status.Size = new System.Drawing.Size(457, 38);
            this.labelPrinter2Status.TabIndex = 7;
            this.labelPrinter2Status.Text = "Missing";
            this.labelPrinter2Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1434, 24);
            this.menuStripMain.TabIndex = 17;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertDataFileToMotorolaFormatToolStripMenuItem,
            this.loadMotorolaFormatFileToolStripMenuItem,
            this.programEPROMSAndPrintLabelsToolStripMenuItem,
            this.printLabToolStripMenuItem,
            this.burnEPROMSOnlyToolStripMenuItem,
            this.selectEPROMTypeToolStripMenuItem,
            this.clearEventHistoryToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // convertDataFileToMotorolaFormatToolStripMenuItem
            // 
            this.convertDataFileToMotorolaFormatToolStripMenuItem.Name = "convertDataFileToMotorolaFormatToolStripMenuItem";
            this.convertDataFileToMotorolaFormatToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.convertDataFileToMotorolaFormatToolStripMenuItem.Text = "Convert data file to Motorola format";
            this.convertDataFileToMotorolaFormatToolStripMenuItem.Click += new System.EventHandler(this.convertDataFileToMotorolaFormatToolStripMenuItem_Click);
            // 
            // loadMotorolaFormatFileToolStripMenuItem
            // 
            this.loadMotorolaFormatFileToolStripMenuItem.Name = "loadMotorolaFormatFileToolStripMenuItem";
            this.loadMotorolaFormatFileToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.loadMotorolaFormatFileToolStripMenuItem.Text = "Load Motorola format file";
            this.loadMotorolaFormatFileToolStripMenuItem.Click += new System.EventHandler(this.loadMotorolaFormatFileToolStripMenuItem_Click);
            // 
            // programEPROMSAndPrintLabelsToolStripMenuItem
            // 
            this.programEPROMSAndPrintLabelsToolStripMenuItem.Name = "programEPROMSAndPrintLabelsToolStripMenuItem";
            this.programEPROMSAndPrintLabelsToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.programEPROMSAndPrintLabelsToolStripMenuItem.Text = "Program EPROMS and print labels";
            this.programEPROMSAndPrintLabelsToolStripMenuItem.Click += new System.EventHandler(this.programEPROMSAndPrintLabelsToolStripMenuItem_Click);
            // 
            // printLabToolStripMenuItem
            // 
            this.printLabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSmallLabelsOnPrinter1ToolStripMenuItem,
            this.printLargeLabelsOnPrinter2ToolStripMenuItem,
            this.printLargeLabelsOnPrinter1ToolStripMenuItem});
            this.printLabToolStripMenuItem.Name = "printLabToolStripMenuItem";
            this.printLabToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.printLabToolStripMenuItem.Text = "Print labels only";
            this.printLabToolStripMenuItem.Click += new System.EventHandler(this.printLabToolStripMenuItem_Click);
            // 
            // printSmallLabelsOnPrinter1ToolStripMenuItem
            // 
            this.printSmallLabelsOnPrinter1ToolStripMenuItem.Name = "printSmallLabelsOnPrinter1ToolStripMenuItem";
            this.printSmallLabelsOnPrinter1ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.printSmallLabelsOnPrinter1ToolStripMenuItem.Text = "Print Small Labels on Printer 1";
            // 
            // printLargeLabelsOnPrinter2ToolStripMenuItem
            // 
            this.printLargeLabelsOnPrinter2ToolStripMenuItem.Name = "printLargeLabelsOnPrinter2ToolStripMenuItem";
            this.printLargeLabelsOnPrinter2ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.printLargeLabelsOnPrinter2ToolStripMenuItem.Text = "Print Large Labels on Printer 2";
            // 
            // printLargeLabelsOnPrinter1ToolStripMenuItem
            // 
            this.printLargeLabelsOnPrinter1ToolStripMenuItem.Name = "printLargeLabelsOnPrinter1ToolStripMenuItem";
            this.printLargeLabelsOnPrinter1ToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.printLargeLabelsOnPrinter1ToolStripMenuItem.Text = "Print Large Labels on Printer 1";
            // 
            // burnEPROMSOnlyToolStripMenuItem
            // 
            this.burnEPROMSOnlyToolStripMenuItem.Name = "burnEPROMSOnlyToolStripMenuItem";
            this.burnEPROMSOnlyToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.burnEPROMSOnlyToolStripMenuItem.Text = "Burn EPROMS only";
            this.burnEPROMSOnlyToolStripMenuItem.Click += new System.EventHandler(this.burnEPROMSOnlyToolStripMenuItem_Click);
            // 
            // selectEPROMTypeToolStripMenuItem
            // 
            this.selectEPROMTypeToolStripMenuItem.Name = "selectEPROMTypeToolStripMenuItem";
            this.selectEPROMTypeToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.selectEPROMTypeToolStripMenuItem.Text = "Select EPROM type";
            this.selectEPROMTypeToolStripMenuItem.Click += new System.EventHandler(this.selectEPROMTypeToolStripMenuItem_Click);
            // 
            // clearEventHistoryToolStripMenuItem
            // 
            this.clearEventHistoryToolStripMenuItem.Name = "clearEventHistoryToolStripMenuItem";
            this.clearEventHistoryToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.clearEventHistoryToolStripMenuItem.Text = "Clear Event History";
            this.clearEventHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearEventHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(256, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partNumberDialogToolStripMenuItem,
            this.printer1DiagnosticsToolStripMenuItem,
            this.printer2DiagnosticsToolStripMenuItem,
            this.programmer1DiagnosticsToolStripMenuItem,
            this.programmer2DiagnosticsToolStripMenuItem,
            this.toolStripSeparator1,
            this.viewLogFileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // partNumberDialogToolStripMenuItem
            // 
            this.partNumberDialogToolStripMenuItem.Name = "partNumberDialogToolStripMenuItem";
            this.partNumberDialogToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.partNumberDialogToolStripMenuItem.Text = "Enter Kit Number";
            this.partNumberDialogToolStripMenuItem.Click += new System.EventHandler(this.partNumberDialogToolStripMenuItem_Click);
            // 
            // printer1DiagnosticsToolStripMenuItem
            // 
            this.printer1DiagnosticsToolStripMenuItem.Name = "printer1DiagnosticsToolStripMenuItem";
            this.printer1DiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.printer1DiagnosticsToolStripMenuItem.Text = "Printer 1 Diagnostics";
            this.printer1DiagnosticsToolStripMenuItem.Click += new System.EventHandler(this.printer1DiagnosticsToolStripMenuItem_Click);
            // 
            // printer2DiagnosticsToolStripMenuItem
            // 
            this.printer2DiagnosticsToolStripMenuItem.Name = "printer2DiagnosticsToolStripMenuItem";
            this.printer2DiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.printer2DiagnosticsToolStripMenuItem.Text = "Printer 2 Diagnostics";
            this.printer2DiagnosticsToolStripMenuItem.Click += new System.EventHandler(this.printer2DiagnosticsToolStripMenuItem_Click);
            // 
            // programmer1DiagnosticsToolStripMenuItem
            // 
            this.programmer1DiagnosticsToolStripMenuItem.Name = "programmer1DiagnosticsToolStripMenuItem";
            this.programmer1DiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.programmer1DiagnosticsToolStripMenuItem.Text = "Programmer 1 Diagnostics";
            this.programmer1DiagnosticsToolStripMenuItem.Click += new System.EventHandler(this.programmer1DiagnosticsToolStripMenuItem_Click);
            // 
            // programmer2DiagnosticsToolStripMenuItem
            // 
            this.programmer2DiagnosticsToolStripMenuItem.Name = "programmer2DiagnosticsToolStripMenuItem";
            this.programmer2DiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.programmer2DiagnosticsToolStripMenuItem.Text = "Programmer 2 Diagnostics";
            this.programmer2DiagnosticsToolStripMenuItem.Click += new System.EventHandler(this.programmer2DiagnosticsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // viewLogFileToolStripMenuItem
            // 
            this.viewLogFileToolStripMenuItem.Name = "viewLogFileToolStripMenuItem";
            this.viewLogFileToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.viewLogFileToolStripMenuItem.Text = "View Log File";
            this.viewLogFileToolStripMenuItem.Click += new System.EventHandler(this.viewLogFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // frmAtecMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 858);
            this.Controls.Add(this.groupBoxHardwareStatus);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxMainMenu);
            this.Controls.Add(this.groupBoxEventHistory);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmAtecMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.frmAtecMain_Load);
            this.Activated += new System.EventHandler(this.frmAtecMain_Activated);
            this.groupBoxEventHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEventLog)).EndInit();
            this.groupBoxMainMenu.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxHardwareStatus.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBoxEventHistory;
        private System.Windows.Forms.GroupBox groupBoxMainMenu;
        private System.Windows.Forms.ListBox listMainMenu;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.GroupBox groupBoxHardwareStatus;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertDataFileToMotorolaFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMotorolaFormatFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programEPROMSAndPrintLabelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burnEPROMSOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectEPROMTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEPROMLabel;
        private System.Windows.Forms.TextBox textEpromType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPartNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKitNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPartNumFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelProgrammer1Status;
        private System.Windows.Forms.Label labelProgrammer2Status;
        private System.Windows.Forms.Label labelPrinter1Status;
        private System.Windows.Forms.Label labelPrinter2Status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printer1DiagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printer2DiagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmer1DiagnosticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmer2DiagnosticsToolStripMenuItem;
        private System.Data.DataSet dataSetMain;
        private System.Data.DataTable dataTableEventLog;
        private System.Data.DataColumn dataColEventTime;
        private System.Data.DataColumn dataColumnEventType;
        private System.Data.DataColumn dataColumnEventDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearEventHistoryToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxPrinterMenu;
        private System.Windows.Forms.ToolStripMenuItem printSmallLabelsOnPrinter1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printLargeLabelsOnPrinter2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printLargeLabelsOnPrinter1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partNumberDialogToolStripMenuItem;
    }
}

