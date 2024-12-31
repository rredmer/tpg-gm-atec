namespace AtecMain
{
    partial class SettingsForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxPrinterSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxUsePrinter2 = new System.Windows.Forms.CheckBox();
            this.checkBoxUsePrinter1 = new System.Windows.Forms.CheckBox();
            this.textBoxPrinter2Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrinter1Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxProgrammerSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxUseProgrammer2 = new System.Windows.Forms.CheckBox();
            this.checkBoxUseProgrammer1 = new System.Windows.Forms.CheckBox();
            this.textBoxProgrammer2Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProgrammer1Port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxPrinter1Serial = new System.Windows.Forms.CheckBox();
            this.checkBoxPrinter2Serial = new System.Windows.Forms.CheckBox();
            this.groupBoxPrinterSettings.SuspendLayout();
            this.groupBoxProgrammerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(3, 625);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 52);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBoxPrinterSettings
            // 
            this.groupBoxPrinterSettings.Controls.Add(this.checkBoxPrinter2Serial);
            this.groupBoxPrinterSettings.Controls.Add(this.checkBoxPrinter1Serial);
            this.groupBoxPrinterSettings.Controls.Add(this.checkBoxUsePrinter2);
            this.groupBoxPrinterSettings.Controls.Add(this.checkBoxUsePrinter1);
            this.groupBoxPrinterSettings.Controls.Add(this.textBoxPrinter2Address);
            this.groupBoxPrinterSettings.Controls.Add(this.label2);
            this.groupBoxPrinterSettings.Controls.Add(this.textBoxPrinter1Address);
            this.groupBoxPrinterSettings.Controls.Add(this.label1);
            this.groupBoxPrinterSettings.Location = new System.Drawing.Point(3, 12);
            this.groupBoxPrinterSettings.Name = "groupBoxPrinterSettings";
            this.groupBoxPrinterSettings.Size = new System.Drawing.Size(300, 280);
            this.groupBoxPrinterSettings.TabIndex = 22;
            this.groupBoxPrinterSettings.TabStop = false;
            this.groupBoxPrinterSettings.Text = "Printer Settings";
            // 
            // checkBoxUsePrinter2
            // 
            this.checkBoxUsePrinter2.AutoSize = true;
            this.checkBoxUsePrinter2.Checked = global::AtecMain.Properties.Settings.Default.UsePrinter2;
            this.checkBoxUsePrinter2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AtecMain.Properties.Settings.Default, "UsePrinter2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUsePrinter2.Location = new System.Drawing.Point(8, 160);
            this.checkBoxUsePrinter2.Name = "checkBoxUsePrinter2";
            this.checkBoxUsePrinter2.Size = new System.Drawing.Size(87, 17);
            this.checkBoxUsePrinter2.TabIndex = 27;
            this.checkBoxUsePrinter2.Text = "Use Printer 2";
            this.checkBoxUsePrinter2.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsePrinter1
            // 
            this.checkBoxUsePrinter1.AutoSize = true;
            this.checkBoxUsePrinter1.Checked = global::AtecMain.Properties.Settings.Default.UsePrinter1;
            this.checkBoxUsePrinter1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AtecMain.Properties.Settings.Default, "UsePrinter1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUsePrinter1.Location = new System.Drawing.Point(8, 137);
            this.checkBoxUsePrinter1.Name = "checkBoxUsePrinter1";
            this.checkBoxUsePrinter1.Size = new System.Drawing.Size(87, 17);
            this.checkBoxUsePrinter1.TabIndex = 26;
            this.checkBoxUsePrinter1.Text = "Use Printer 1";
            this.checkBoxUsePrinter1.UseVisualStyleBackColor = true;
            // 
            // textBoxPrinter2Address
            // 
            this.textBoxPrinter2Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AtecMain.Properties.Settings.Default, "PrinterAddress2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPrinter2Address.Location = new System.Drawing.Point(102, 39);
            this.textBoxPrinter2Address.Name = "textBoxPrinter2Address";
            this.textBoxPrinter2Address.Size = new System.Drawing.Size(146, 20);
            this.textBoxPrinter2Address.TabIndex = 25;
            this.textBoxPrinter2Address.Text = global::AtecMain.Properties.Settings.Default.PrinterAddress2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Printer 2 Address:";
            // 
            // textBoxPrinter1Address
            // 
            this.textBoxPrinter1Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AtecMain.Properties.Settings.Default, "PrinterAddress1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPrinter1Address.Location = new System.Drawing.Point(102, 13);
            this.textBoxPrinter1Address.Name = "textBoxPrinter1Address";
            this.textBoxPrinter1Address.Size = new System.Drawing.Size(146, 20);
            this.textBoxPrinter1Address.TabIndex = 23;
            this.textBoxPrinter1Address.Text = global::AtecMain.Properties.Settings.Default.PrinterAddress1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Printer 1 Address:";
            // 
            // groupBoxProgrammerSettings
            // 
            this.groupBoxProgrammerSettings.Controls.Add(this.checkBoxUseProgrammer2);
            this.groupBoxProgrammerSettings.Controls.Add(this.checkBoxUseProgrammer1);
            this.groupBoxProgrammerSettings.Controls.Add(this.textBoxProgrammer2Port);
            this.groupBoxProgrammerSettings.Controls.Add(this.label3);
            this.groupBoxProgrammerSettings.Controls.Add(this.textBoxProgrammer1Port);
            this.groupBoxProgrammerSettings.Controls.Add(this.label4);
            this.groupBoxProgrammerSettings.Location = new System.Drawing.Point(4, 298);
            this.groupBoxProgrammerSettings.Name = "groupBoxProgrammerSettings";
            this.groupBoxProgrammerSettings.Size = new System.Drawing.Size(300, 125);
            this.groupBoxProgrammerSettings.TabIndex = 23;
            this.groupBoxProgrammerSettings.TabStop = false;
            this.groupBoxProgrammerSettings.Text = "EPROM Programmer Settings";
            // 
            // checkBoxUseProgrammer2
            // 
            this.checkBoxUseProgrammer2.AutoSize = true;
            this.checkBoxUseProgrammer2.Checked = global::AtecMain.Properties.Settings.Default.UseBurner2;
            this.checkBoxUseProgrammer2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AtecMain.Properties.Settings.Default, "UseBurner2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUseProgrammer2.Location = new System.Drawing.Point(9, 93);
            this.checkBoxUseProgrammer2.Name = "checkBoxUseProgrammer2";
            this.checkBoxUseProgrammer2.Size = new System.Drawing.Size(113, 17);
            this.checkBoxUseProgrammer2.TabIndex = 33;
            this.checkBoxUseProgrammer2.Text = "Use Programmer 2";
            this.checkBoxUseProgrammer2.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseProgrammer1
            // 
            this.checkBoxUseProgrammer1.AutoSize = true;
            this.checkBoxUseProgrammer1.Checked = global::AtecMain.Properties.Settings.Default.UseBurner1;
            this.checkBoxUseProgrammer1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseProgrammer1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AtecMain.Properties.Settings.Default, "UseBurner1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUseProgrammer1.Location = new System.Drawing.Point(9, 70);
            this.checkBoxUseProgrammer1.Name = "checkBoxUseProgrammer1";
            this.checkBoxUseProgrammer1.Size = new System.Drawing.Size(113, 17);
            this.checkBoxUseProgrammer1.TabIndex = 32;
            this.checkBoxUseProgrammer1.Text = "Use Programmer 1";
            this.checkBoxUseProgrammer1.UseVisualStyleBackColor = true;
            // 
            // textBoxProgrammer2Port
            // 
            this.textBoxProgrammer2Port.Location = new System.Drawing.Point(102, 39);
            this.textBoxProgrammer2Port.Name = "textBoxProgrammer2Port";
            this.textBoxProgrammer2Port.Size = new System.Drawing.Size(146, 20);
            this.textBoxProgrammer2Port.TabIndex = 31;
            this.textBoxProgrammer2Port.Text = "COM2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Programmer 2 Port:";
            // 
            // textBoxProgrammer1Port
            // 
            this.textBoxProgrammer1Port.Location = new System.Drawing.Point(102, 13);
            this.textBoxProgrammer1Port.Name = "textBoxProgrammer1Port";
            this.textBoxProgrammer1Port.Size = new System.Drawing.Size(146, 20);
            this.textBoxProgrammer1Port.TabIndex = 29;
            this.textBoxProgrammer1Port.Text = "COM1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Programmer 1 Port:";
            // 
            // checkBoxPrinter1Serial
            // 
            this.checkBoxPrinter1Serial.AutoSize = true;
            this.checkBoxPrinter1Serial.Checked = global::AtecMain.Properties.Settings.Default.Printer1Serial;
            this.checkBoxPrinter1Serial.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AtecMain.Properties.Settings.Default, "Printer1Serial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxPrinter1Serial.Location = new System.Drawing.Point(113, 137);
            this.checkBoxPrinter1Serial.Name = "checkBoxPrinter1Serial";
            this.checkBoxPrinter1Serial.Size = new System.Drawing.Size(149, 17);
            this.checkBoxPrinter1Serial.TabIndex = 28;
            this.checkBoxPrinter1Serial.Text = "Printer 1 Connected Serial";
            this.checkBoxPrinter1Serial.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrinter2Serial
            // 
            this.checkBoxPrinter2Serial.AutoSize = true;
            this.checkBoxPrinter2Serial.Checked = global::AtecMain.Properties.Settings.Default.Printer2Serial;
            this.checkBoxPrinter2Serial.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AtecMain.Properties.Settings.Default, "Printer2Serial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxPrinter2Serial.Location = new System.Drawing.Point(113, 160);
            this.checkBoxPrinter2Serial.Name = "checkBoxPrinter2Serial";
            this.checkBoxPrinter2Serial.Size = new System.Drawing.Size(149, 17);
            this.checkBoxPrinter2Serial.TabIndex = 29;
            this.checkBoxPrinter2Serial.Text = "Printer 2 Connected Serial";
            this.checkBoxPrinter2Serial.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 680);
            this.Controls.Add(this.groupBoxProgrammerSettings);
            this.Controls.Add(this.groupBoxPrinterSettings);
            this.Controls.Add(this.buttonExit);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBoxPrinterSettings.ResumeLayout(false);
            this.groupBoxPrinterSettings.PerformLayout();
            this.groupBoxProgrammerSettings.ResumeLayout(false);
            this.groupBoxProgrammerSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBoxPrinterSettings;
        private System.Windows.Forms.CheckBox checkBoxUsePrinter2;
        private System.Windows.Forms.CheckBox checkBoxUsePrinter1;
        private System.Windows.Forms.TextBox textBoxPrinter2Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrinter1Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxProgrammerSettings;
        private System.Windows.Forms.CheckBox checkBoxUseProgrammer2;
        private System.Windows.Forms.CheckBox checkBoxUseProgrammer1;
        private System.Windows.Forms.TextBox textBoxProgrammer2Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProgrammer1Port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxPrinter2Serial;
        private System.Windows.Forms.CheckBox checkBoxPrinter1Serial;
    }
}