namespace SharedLib
{
    partial class DataIo3980xpiForm
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
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.groupBoxPortProperties = new System.Windows.Forms.GroupBox();
            this.propertyGridCom = new System.Windows.Forms.PropertyGrid();
            this.serialPortCom = new System.IO.Ports.SerialPort(this.components);
            this.labelLoadFile = new System.Windows.Forms.Label();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.labelProgramDevice = new System.Windows.Forms.Label();
            this.buttonProgramDevice = new System.Windows.Forms.Button();
            this.labelConfiguration = new System.Windows.Forms.Label();
            this.buttonGetConfiguration = new System.Windows.Forms.Button();
            this.labelDeviceStatus = new System.Windows.Forms.Label();
            this.buttonGetDeviceStatus = new System.Windows.Forms.Button();
            this.labelVerify = new System.Windows.Forms.Label();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.labelBitTest = new System.Windows.Forms.Label();
            this.labelBlankCheck = new System.Windows.Forms.Label();
            this.buttonBitTest = new System.Windows.Forms.Button();
            this.buttonBlankCheck = new System.Windows.Forms.Button();
            this.labelDeviceCheck = new System.Windows.Forms.Label();
            this.buttonDeviceCheck = new System.Windows.Forms.Button();
            this.labelCheckSum = new System.Windows.Forms.Label();
            this.buttonGetCheckSum = new System.Windows.Forms.Button();
            this.labelErrors = new System.Windows.Forms.Label();
            this.buttonGetErrors = new System.Windows.Forms.Button();
            this.labelSettings = new System.Windows.Forms.Label();
            this.buttonGetSettings = new System.Windows.Forms.Button();
            this.buttonSendEsc = new System.Windows.Forms.Button();
            this.textSendMessage = new System.Windows.Forms.TextBox();
            this.labelSendCRCCommand = new System.Windows.Forms.Label();
            this.textMessages = new System.Windows.Forms.TextBox();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxMessages.SuspendLayout();
            this.groupBoxPortProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Controls.Add(this.buttonSendCommand);
            this.groupBoxMessages.Controls.Add(this.groupBoxPortProperties);
            this.groupBoxMessages.Controls.Add(this.labelLoadFile);
            this.groupBoxMessages.Controls.Add(this.buttonLoadFile);
            this.groupBoxMessages.Controls.Add(this.labelProgramDevice);
            this.groupBoxMessages.Controls.Add(this.buttonProgramDevice);
            this.groupBoxMessages.Controls.Add(this.labelConfiguration);
            this.groupBoxMessages.Controls.Add(this.buttonGetConfiguration);
            this.groupBoxMessages.Controls.Add(this.labelDeviceStatus);
            this.groupBoxMessages.Controls.Add(this.buttonGetDeviceStatus);
            this.groupBoxMessages.Controls.Add(this.labelVerify);
            this.groupBoxMessages.Controls.Add(this.buttonVerify);
            this.groupBoxMessages.Controls.Add(this.labelBitTest);
            this.groupBoxMessages.Controls.Add(this.labelBlankCheck);
            this.groupBoxMessages.Controls.Add(this.buttonBitTest);
            this.groupBoxMessages.Controls.Add(this.buttonBlankCheck);
            this.groupBoxMessages.Controls.Add(this.labelDeviceCheck);
            this.groupBoxMessages.Controls.Add(this.buttonDeviceCheck);
            this.groupBoxMessages.Controls.Add(this.labelCheckSum);
            this.groupBoxMessages.Controls.Add(this.buttonGetCheckSum);
            this.groupBoxMessages.Controls.Add(this.labelErrors);
            this.groupBoxMessages.Controls.Add(this.buttonGetErrors);
            this.groupBoxMessages.Controls.Add(this.labelSettings);
            this.groupBoxMessages.Controls.Add(this.buttonGetSettings);
            this.groupBoxMessages.Controls.Add(this.buttonSendEsc);
            this.groupBoxMessages.Controls.Add(this.textSendMessage);
            this.groupBoxMessages.Controls.Add(this.labelSendCRCCommand);
            this.groupBoxMessages.Controls.Add(this.textMessages);
            this.groupBoxMessages.Location = new System.Drawing.Point(3, 0);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(1010, 608);
            this.groupBoxMessages.TabIndex = 16;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Messages";
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Location = new System.Drawing.Point(348, 573);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(75, 28);
            this.buttonSendCommand.TabIndex = 30;
            this.buttonSendCommand.Text = "Send";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // groupBoxPortProperties
            // 
            this.groupBoxPortProperties.Controls.Add(this.propertyGridCom);
            this.groupBoxPortProperties.Location = new System.Drawing.Point(716, 372);
            this.groupBoxPortProperties.Name = "groupBoxPortProperties";
            this.groupBoxPortProperties.Size = new System.Drawing.Size(288, 230);
            this.groupBoxPortProperties.TabIndex = 29;
            this.groupBoxPortProperties.TabStop = false;
            this.groupBoxPortProperties.Text = "COM Port Properties";
            // 
            // propertyGridCom
            // 
            this.propertyGridCom.Location = new System.Drawing.Point(6, 19);
            this.propertyGridCom.Name = "propertyGridCom";
            this.propertyGridCom.SelectedObject = this.serialPortCom;
            this.propertyGridCom.Size = new System.Drawing.Size(276, 205);
            this.propertyGridCom.TabIndex = 4;
            // 
            // serialPortCom
            // 
            this.serialPortCom.DtrEnable = true;
            this.serialPortCom.RtsEnable = true;
            this.serialPortCom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortCom_DataReceived);
            this.serialPortCom.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPortCom_PinChanged);
            this.serialPortCom.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPortCom_ErrorReceived);
            // 
            // labelLoadFile
            // 
            this.labelLoadFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoadFile.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadFile.Location = new System.Drawing.Point(808, 312);
            this.labelLoadFile.Name = "labelLoadFile";
            this.labelLoadFile.Size = new System.Drawing.Size(193, 23);
            this.labelLoadFile.TabIndex = 28;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(716, 312);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(89, 23);
            this.buttonLoadFile.TabIndex = 27;
            this.buttonLoadFile.Text = "Load File";
            this.buttonLoadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // labelProgramDevice
            // 
            this.labelProgramDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProgramDevice.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramDevice.Location = new System.Drawing.Point(808, 283);
            this.labelProgramDevice.Name = "labelProgramDevice";
            this.labelProgramDevice.Size = new System.Drawing.Size(193, 23);
            this.labelProgramDevice.TabIndex = 26;
            // 
            // buttonProgramDevice
            // 
            this.buttonProgramDevice.Location = new System.Drawing.Point(716, 283);
            this.buttonProgramDevice.Name = "buttonProgramDevice";
            this.buttonProgramDevice.Size = new System.Drawing.Size(89, 23);
            this.buttonProgramDevice.TabIndex = 25;
            this.buttonProgramDevice.Text = "Program";
            this.buttonProgramDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProgramDevice.UseVisualStyleBackColor = true;
            this.buttonProgramDevice.Click += new System.EventHandler(this.buttonProgramDevice_Click);
            // 
            // labelConfiguration
            // 
            this.labelConfiguration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelConfiguration.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfiguration.Location = new System.Drawing.Point(808, 78);
            this.labelConfiguration.Name = "labelConfiguration";
            this.labelConfiguration.Size = new System.Drawing.Size(193, 23);
            this.labelConfiguration.TabIndex = 24;
            // 
            // buttonGetConfiguration
            // 
            this.buttonGetConfiguration.Location = new System.Drawing.Point(716, 78);
            this.buttonGetConfiguration.Name = "buttonGetConfiguration";
            this.buttonGetConfiguration.Size = new System.Drawing.Size(89, 23);
            this.buttonGetConfiguration.TabIndex = 23;
            this.buttonGetConfiguration.Text = "Get Config";
            this.buttonGetConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetConfiguration.UseVisualStyleBackColor = true;
            this.buttonGetConfiguration.Click += new System.EventHandler(this.buttonGetConfiguration_Click);
            // 
            // labelDeviceStatus
            // 
            this.labelDeviceStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDeviceStatus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceStatus.Location = new System.Drawing.Point(808, 49);
            this.labelDeviceStatus.Name = "labelDeviceStatus";
            this.labelDeviceStatus.Size = new System.Drawing.Size(193, 23);
            this.labelDeviceStatus.TabIndex = 22;
            // 
            // buttonGetDeviceStatus
            // 
            this.buttonGetDeviceStatus.Location = new System.Drawing.Point(716, 49);
            this.buttonGetDeviceStatus.Name = "buttonGetDeviceStatus";
            this.buttonGetDeviceStatus.Size = new System.Drawing.Size(89, 23);
            this.buttonGetDeviceStatus.TabIndex = 21;
            this.buttonGetDeviceStatus.Text = "Get Status";
            this.buttonGetDeviceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetDeviceStatus.UseVisualStyleBackColor = true;
            this.buttonGetDeviceStatus.Click += new System.EventHandler(this.buttonGetDeviceStatus_Click);
            // 
            // labelVerify
            // 
            this.labelVerify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVerify.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerify.Location = new System.Drawing.Point(808, 253);
            this.labelVerify.Name = "labelVerify";
            this.labelVerify.Size = new System.Drawing.Size(193, 23);
            this.labelVerify.TabIndex = 20;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(716, 253);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(89, 23);
            this.buttonVerify.TabIndex = 19;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // labelBitTest
            // 
            this.labelBitTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBitTest.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitTest.Location = new System.Drawing.Point(808, 224);
            this.labelBitTest.Name = "labelBitTest";
            this.labelBitTest.Size = new System.Drawing.Size(193, 23);
            this.labelBitTest.TabIndex = 18;
            // 
            // labelBlankCheck
            // 
            this.labelBlankCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBlankCheck.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlankCheck.Location = new System.Drawing.Point(808, 195);
            this.labelBlankCheck.Name = "labelBlankCheck";
            this.labelBlankCheck.Size = new System.Drawing.Size(193, 23);
            this.labelBlankCheck.TabIndex = 14;
            // 
            // buttonBitTest
            // 
            this.buttonBitTest.Location = new System.Drawing.Point(716, 224);
            this.buttonBitTest.Name = "buttonBitTest";
            this.buttonBitTest.Size = new System.Drawing.Size(89, 23);
            this.buttonBitTest.TabIndex = 17;
            this.buttonBitTest.Text = "Bit Test";
            this.buttonBitTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBitTest.UseVisualStyleBackColor = true;
            this.buttonBitTest.Click += new System.EventHandler(this.buttonBitTest_Click);
            // 
            // buttonBlankCheck
            // 
            this.buttonBlankCheck.Location = new System.Drawing.Point(716, 195);
            this.buttonBlankCheck.Name = "buttonBlankCheck";
            this.buttonBlankCheck.Size = new System.Drawing.Size(89, 23);
            this.buttonBlankCheck.TabIndex = 13;
            this.buttonBlankCheck.Text = "Blank Check";
            this.buttonBlankCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBlankCheck.UseVisualStyleBackColor = true;
            this.buttonBlankCheck.Click += new System.EventHandler(this.buttonBlankCheck_Click);
            // 
            // labelDeviceCheck
            // 
            this.labelDeviceCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDeviceCheck.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeviceCheck.Location = new System.Drawing.Point(808, 166);
            this.labelDeviceCheck.Name = "labelDeviceCheck";
            this.labelDeviceCheck.Size = new System.Drawing.Size(193, 23);
            this.labelDeviceCheck.TabIndex = 12;
            // 
            // buttonDeviceCheck
            // 
            this.buttonDeviceCheck.Location = new System.Drawing.Point(716, 166);
            this.buttonDeviceCheck.Name = "buttonDeviceCheck";
            this.buttonDeviceCheck.Size = new System.Drawing.Size(89, 23);
            this.buttonDeviceCheck.TabIndex = 11;
            this.buttonDeviceCheck.Text = "Device Check";
            this.buttonDeviceCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeviceCheck.UseVisualStyleBackColor = true;
            this.buttonDeviceCheck.Click += new System.EventHandler(this.buttonDeviceCheck_Click);
            // 
            // labelCheckSum
            // 
            this.labelCheckSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCheckSum.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckSum.Location = new System.Drawing.Point(808, 137);
            this.labelCheckSum.Name = "labelCheckSum";
            this.labelCheckSum.Size = new System.Drawing.Size(193, 23);
            this.labelCheckSum.TabIndex = 10;
            // 
            // buttonGetCheckSum
            // 
            this.buttonGetCheckSum.Location = new System.Drawing.Point(716, 137);
            this.buttonGetCheckSum.Name = "buttonGetCheckSum";
            this.buttonGetCheckSum.Size = new System.Drawing.Size(89, 23);
            this.buttonGetCheckSum.TabIndex = 9;
            this.buttonGetCheckSum.Text = "Get Checksum";
            this.buttonGetCheckSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetCheckSum.UseVisualStyleBackColor = true;
            this.buttonGetCheckSum.Click += new System.EventHandler(this.buttonGetCheckSum_Click);
            // 
            // labelErrors
            // 
            this.labelErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelErrors.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrors.Location = new System.Drawing.Point(808, 108);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(193, 23);
            this.labelErrors.TabIndex = 8;
            // 
            // buttonGetErrors
            // 
            this.buttonGetErrors.Location = new System.Drawing.Point(716, 108);
            this.buttonGetErrors.Name = "buttonGetErrors";
            this.buttonGetErrors.Size = new System.Drawing.Size(89, 23);
            this.buttonGetErrors.TabIndex = 7;
            this.buttonGetErrors.Text = "Get Errors";
            this.buttonGetErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetErrors.UseVisualStyleBackColor = true;
            this.buttonGetErrors.Click += new System.EventHandler(this.buttonGetErrors_Click);
            // 
            // labelSettings
            // 
            this.labelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSettings.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.Location = new System.Drawing.Point(808, 17);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(193, 23);
            this.labelSettings.TabIndex = 6;
            // 
            // buttonGetSettings
            // 
            this.buttonGetSettings.Location = new System.Drawing.Point(716, 17);
            this.buttonGetSettings.Name = "buttonGetSettings";
            this.buttonGetSettings.Size = new System.Drawing.Size(89, 23);
            this.buttonGetSettings.TabIndex = 5;
            this.buttonGetSettings.Text = "Get Settings";
            this.buttonGetSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetSettings.UseVisualStyleBackColor = true;
            this.buttonGetSettings.Click += new System.EventHandler(this.buttonGetSettings_Click);
            // 
            // buttonSendEsc
            // 
            this.buttonSendEsc.Location = new System.Drawing.Point(715, 342);
            this.buttonSendEsc.Name = "buttonSendEsc";
            this.buttonSendEsc.Size = new System.Drawing.Size(286, 23);
            this.buttonSendEsc.TabIndex = 4;
            this.buttonSendEsc.Text = "Send Escape (Cancel/Abort Last Command)";
            this.buttonSendEsc.UseVisualStyleBackColor = true;
            this.buttonSendEsc.Click += new System.EventHandler(this.buttonSendEsc_Click);
            // 
            // textSendMessage
            // 
            this.textSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSendMessage.Location = new System.Drawing.Point(172, 574);
            this.textSendMessage.Name = "textSendMessage";
            this.textSendMessage.Size = new System.Drawing.Size(171, 26);
            this.textSendMessage.TabIndex = 2;
            this.textSendMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSendMessage_KeyDown);
            // 
            // labelSendCRCCommand
            // 
            this.labelSendCRCCommand.AutoSize = true;
            this.labelSendCRCCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSendCRCCommand.Location = new System.Drawing.Point(7, 577);
            this.labelSendCRCCommand.Name = "labelSendCRCCommand";
            this.labelSendCRCCommand.Size = new System.Drawing.Size(162, 20);
            this.labelSendCRCCommand.TabIndex = 1;
            this.labelSendCRCCommand.Text = "Send CRC Command";
            // 
            // textMessages
            // 
            this.textMessages.AcceptsReturn = true;
            this.textMessages.AcceptsTab = true;
            this.textMessages.BackColor = System.Drawing.Color.White;
            this.textMessages.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessages.Location = new System.Drawing.Point(7, 20);
            this.textMessages.Multiline = true;
            this.textMessages.Name = "textMessages";
            this.textMessages.ReadOnly = true;
            this.textMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMessages.Size = new System.Drawing.Size(703, 548);
            this.textMessages.TabIndex = 0;
            this.textMessages.Text = "Initialized";
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearHistory.Location = new System.Drawing.Point(99, 624);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(152, 52);
            this.buttonClearHistory.TabIndex = 15;
            this.buttonClearHistory.Text = "Clear History";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(3, 624);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 52);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // DataIo3980xpiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 682);
            this.Controls.Add(this.groupBoxMessages);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DataIo3980xpiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataIo3980xpiForm";
            this.Load += new System.EventHandler(this.DataIo3980xpiForm_Load);
            this.groupBoxMessages.ResumeLayout(false);
            this.groupBoxMessages.PerformLayout();
            this.groupBoxPortProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMessages;
        private System.Windows.Forms.TextBox textSendMessage;
        private System.Windows.Forms.Label labelSendCRCCommand;
        private System.Windows.Forms.TextBox textMessages;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.Button buttonExit;
        public System.IO.Ports.SerialPort serialPortCom;
        private System.Windows.Forms.Button buttonSendEsc;
        private System.Windows.Forms.Button buttonGetSettings;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Button buttonGetErrors;
        private System.Windows.Forms.Label labelCheckSum;
        private System.Windows.Forms.Button buttonGetCheckSum;
        private System.Windows.Forms.Label labelBitTest;
        private System.Windows.Forms.Label labelBlankCheck;
        private System.Windows.Forms.Button buttonBitTest;
        private System.Windows.Forms.Button buttonBlankCheck;
        private System.Windows.Forms.Label labelDeviceCheck;
        private System.Windows.Forms.Button buttonDeviceCheck;
        private System.Windows.Forms.Label labelVerify;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Label labelConfiguration;
        private System.Windows.Forms.Button buttonGetConfiguration;
        private System.Windows.Forms.Label labelDeviceStatus;
        private System.Windows.Forms.Button buttonGetDeviceStatus;
        private System.Windows.Forms.Label labelLoadFile;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Label labelProgramDevice;
        private System.Windows.Forms.Button buttonProgramDevice;
        private System.Windows.Forms.GroupBox groupBoxPortProperties;
        private System.Windows.Forms.PropertyGrid propertyGridCom;
        private System.Windows.Forms.Button buttonSendCommand;
    }
}