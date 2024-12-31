namespace SharedLib
{
    partial class AppLogForm
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
            this.textBoxAppLog = new System.Windows.Forms.RichTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClearLogFile = new System.Windows.Forms.Button();
            this.buttonClearErrorMode = new System.Windows.Forms.Button();
            this.labelErrorMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAppLog
            // 
            this.textBoxAppLog.BackColor = System.Drawing.Color.White;
            this.textBoxAppLog.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppLog.Location = new System.Drawing.Point(3, 4);
            this.textBoxAppLog.Name = "textBoxAppLog";
            this.textBoxAppLog.ReadOnly = true;
            this.textBoxAppLog.Size = new System.Drawing.Size(1011, 644);
            this.textBoxAppLog.TabIndex = 0;
            this.textBoxAppLog.Text = "";
            this.textBoxAppLog.WordWrap = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(3, 654);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 52);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClearLogFile
            // 
            this.buttonClearLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearLogFile.Location = new System.Drawing.Point(99, 654);
            this.buttonClearLogFile.Name = "buttonClearLogFile";
            this.buttonClearLogFile.Size = new System.Drawing.Size(152, 52);
            this.buttonClearLogFile.TabIndex = 10;
            this.buttonClearLogFile.Text = "Clear History";
            this.buttonClearLogFile.UseVisualStyleBackColor = true;
            this.buttonClearLogFile.Click += new System.EventHandler(this.buttonClearLogFile_Click);
            // 
            // buttonClearErrorMode
            // 
            this.buttonClearErrorMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearErrorMode.Location = new System.Drawing.Point(257, 654);
            this.buttonClearErrorMode.Name = "buttonClearErrorMode";
            this.buttonClearErrorMode.Size = new System.Drawing.Size(168, 52);
            this.buttonClearErrorMode.TabIndex = 11;
            this.buttonClearErrorMode.Text = "Clear Error Mode";
            this.buttonClearErrorMode.UseVisualStyleBackColor = true;
            this.buttonClearErrorMode.Click += new System.EventHandler(this.buttonClearErrorMode_Click);
            // 
            // labelErrorMode
            // 
            this.labelErrorMode.BackColor = System.Drawing.Color.Red;
            this.labelErrorMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMode.ForeColor = System.Drawing.Color.White;
            this.labelErrorMode.Location = new System.Drawing.Point(431, 654);
            this.labelErrorMode.Name = "labelErrorMode";
            this.labelErrorMode.Size = new System.Drawing.Size(583, 45);
            this.labelErrorMode.TabIndex = 12;
            this.labelErrorMode.Text = "ERROR MODE - See above ";
            this.labelErrorMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelErrorMode.Visible = false;
            // 
            // AppLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 708);
            this.Controls.Add(this.labelErrorMode);
            this.Controls.Add(this.buttonClearErrorMode);
            this.Controls.Add(this.buttonClearLogFile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxAppLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AppLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Log";
            this.Activated += new System.EventHandler(this.AppLogForm_Activated);
            this.Load += new System.EventHandler(this.AppLogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxAppLog;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClearLogFile;
        private System.Windows.Forms.Button buttonClearErrorMode;
        private System.Windows.Forms.Label labelErrorMode;

    }
}