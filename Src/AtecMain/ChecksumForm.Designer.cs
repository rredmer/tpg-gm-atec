namespace AtecMain
{
    partial class ChecksumForm
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
            this.labelCheckSumLabel = new System.Windows.Forms.Label();
            this.labelPartial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPartialChecksum = new System.Windows.Forms.Label();
            this.labelTotalChecksum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(12, 219);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 52);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCheckSumLabel
            // 
            this.labelCheckSumLabel.AutoSize = true;
            this.labelCheckSumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckSumLabel.Location = new System.Drawing.Point(12, 85);
            this.labelCheckSumLabel.Name = "labelCheckSumLabel";
            this.labelCheckSumLabel.Size = new System.Drawing.Size(96, 20);
            this.labelCheckSumLabel.TabIndex = 17;
            this.labelCheckSumLabel.Text = "Checksums:";
            // 
            // labelPartial
            // 
            this.labelPartial.AutoSize = true;
            this.labelPartial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartial.Location = new System.Drawing.Point(129, 55);
            this.labelPartial.Name = "labelPartial";
            this.labelPartial.Size = new System.Drawing.Size(53, 20);
            this.labelPartial.TabIndex = 18;
            this.labelPartial.Text = "Partial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total";
            // 
            // labelPartialChecksum
            // 
            this.labelPartialChecksum.AutoSize = true;
            this.labelPartialChecksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartialChecksum.Location = new System.Drawing.Point(129, 85);
            this.labelPartialChecksum.Name = "labelPartialChecksum";
            this.labelPartialChecksum.Size = new System.Drawing.Size(27, 20);
            this.labelPartialChecksum.TabIndex = 20;
            this.labelPartialChecksum.Text = "00";
            // 
            // labelTotalChecksum
            // 
            this.labelTotalChecksum.AutoSize = true;
            this.labelTotalChecksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalChecksum.Location = new System.Drawing.Point(216, 85);
            this.labelTotalChecksum.Name = "labelTotalChecksum";
            this.labelTotalChecksum.Size = new System.Drawing.Size(27, 20);
            this.labelTotalChecksum.TabIndex = 21;
            this.labelTotalChecksum.Text = "00";
            // 
            // ChecksumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 283);
            this.ControlBox = false;
            this.Controls.Add(this.labelTotalChecksum);
            this.Controls.Add(this.labelPartialChecksum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPartial);
            this.Controls.Add(this.labelCheckSumLabel);
            this.Controls.Add(this.buttonExit);
            this.Name = "ChecksumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorola File Checksum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCheckSumLabel;
        private System.Windows.Forms.Label labelPartial;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelPartialChecksum;
        public System.Windows.Forms.Label labelTotalChecksum;
    }
}