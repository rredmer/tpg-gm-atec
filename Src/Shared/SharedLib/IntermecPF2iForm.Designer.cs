namespace SharedLib
{
    partial class IntermecPF2iForm
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
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.buttonSmallLabel = new System.Windows.Forms.Button();
            this.buttonPrintLarge = new System.Windows.Forms.Button();
            this.textSendMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textMessages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrinterAddress = new System.Windows.Forms.Label();
            this.labelPrinterStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPortCom = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxPortProperties = new System.Windows.Forms.GroupBox();
            this.propertyGridCom = new System.Windows.Forms.PropertyGrid();
            this.groupBoxMessages.SuspendLayout();
            this.groupBoxPortProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearHistory.Location = new System.Drawing.Point(99, 628);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(152, 52);
            this.buttonClearHistory.TabIndex = 12;
            this.buttonClearHistory.Text = "Clear History";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(3, 628);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 52);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxMessages
            // 
            this.groupBoxMessages.Controls.Add(this.groupBoxPortProperties);
            this.groupBoxMessages.Controls.Add(this.buttonSmallLabel);
            this.groupBoxMessages.Controls.Add(this.buttonPrintLarge);
            this.groupBoxMessages.Controls.Add(this.textSendMessage);
            this.groupBoxMessages.Controls.Add(this.label1);
            this.groupBoxMessages.Controls.Add(this.textMessages);
            this.groupBoxMessages.Location = new System.Drawing.Point(3, 4);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.Size = new System.Drawing.Size(1010, 608);
            this.groupBoxMessages.TabIndex = 13;
            this.groupBoxMessages.TabStop = false;
            this.groupBoxMessages.Text = "Messages";
            // 
            // buttonSmallLabel
            // 
            this.buttonSmallLabel.Location = new System.Drawing.Point(820, 58);
            this.buttonSmallLabel.Name = "buttonSmallLabel";
            this.buttonSmallLabel.Size = new System.Drawing.Size(184, 32);
            this.buttonSmallLabel.TabIndex = 4;
            this.buttonSmallLabel.Text = "Print Small Label";
            this.buttonSmallLabel.UseVisualStyleBackColor = true;
            this.buttonSmallLabel.Click += new System.EventHandler(this.buttonSmallLabel_Click);
            // 
            // buttonPrintLarge
            // 
            this.buttonPrintLarge.Location = new System.Drawing.Point(820, 20);
            this.buttonPrintLarge.Name = "buttonPrintLarge";
            this.buttonPrintLarge.Size = new System.Drawing.Size(184, 32);
            this.buttonPrintLarge.TabIndex = 3;
            this.buttonPrintLarge.Text = "Print Large Label";
            this.buttonPrintLarge.UseVisualStyleBackColor = true;
            this.buttonPrintLarge.Click += new System.EventHandler(this.buttonPrintLarge_Click);
            // 
            // textSendMessage
            // 
            this.textSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSendMessage.Location = new System.Drawing.Point(130, 574);
            this.textSendMessage.Name = "textSendMessage";
            this.textSendMessage.Size = new System.Drawing.Size(439, 26);
            this.textSendMessage.TabIndex = 2;
            this.textSendMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSendMessage_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send Message";
            // 
            // textMessages
            // 
            this.textMessages.AcceptsReturn = true;
            this.textMessages.AcceptsTab = true;
            this.textMessages.BackColor = System.Drawing.Color.White;
            this.textMessages.Location = new System.Drawing.Point(7, 20);
            this.textMessages.Multiline = true;
            this.textMessages.Name = "textMessages";
            this.textMessages.ReadOnly = true;
            this.textMessages.Size = new System.Drawing.Size(700, 548);
            this.textMessages.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Printer IP Address";
            // 
            // labelPrinterAddress
            // 
            this.labelPrinterAddress.BackColor = System.Drawing.Color.White;
            this.labelPrinterAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrinterAddress.Location = new System.Drawing.Point(664, 618);
            this.labelPrinterAddress.Name = "labelPrinterAddress";
            this.labelPrinterAddress.Size = new System.Drawing.Size(225, 24);
            this.labelPrinterAddress.TabIndex = 15;
            this.labelPrinterAddress.Text = "Unknown";
            // 
            // labelPrinterStatus
            // 
            this.labelPrinterStatus.BackColor = System.Drawing.Color.White;
            this.labelPrinterStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrinterStatus.Location = new System.Drawing.Point(664, 649);
            this.labelPrinterStatus.Name = "labelPrinterStatus";
            this.labelPrinterStatus.Size = new System.Drawing.Size(225, 24);
            this.labelPrinterStatus.TabIndex = 17;
            this.labelPrinterStatus.Text = "Unknown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 650);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Printer Status";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPortCom
            // 
            this.serialPortCom.DtrEnable = true;
            this.serialPortCom.RtsEnable = true;
            // 
            // groupBoxPortProperties
            // 
            this.groupBoxPortProperties.Controls.Add(this.propertyGridCom);
            this.groupBoxPortProperties.Location = new System.Drawing.Point(713, 338);
            this.groupBoxPortProperties.Name = "groupBoxPortProperties";
            this.groupBoxPortProperties.Size = new System.Drawing.Size(288, 230);
            this.groupBoxPortProperties.TabIndex = 30;
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
            // IntermecPF2iForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 685);
            this.Controls.Add(this.labelPrinterStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPrinterAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxMessages);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IntermecPF2iForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intermec PF2i Diagnostics";
            this.Load += new System.EventHandler(this.IntermecPF2iForm_Load);
            this.groupBoxMessages.ResumeLayout(false);
            this.groupBoxMessages.PerformLayout();
            this.groupBoxPortProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxMessages;
        private System.Windows.Forms.TextBox textSendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrinterAddress;
        private System.Windows.Forms.Label labelPrinterStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSmallLabel;
        private System.Windows.Forms.Button buttonPrintLarge;
        public System.IO.Ports.SerialPort serialPortCom;
        private System.Windows.Forms.GroupBox groupBoxPortProperties;
        private System.Windows.Forms.PropertyGrid propertyGridCom;
    }
}