namespace AtecMain
{
    partial class ProgramEpromForm
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
            this.buttonEndProgram = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelPrg2Checksum = new System.Windows.Forms.Label();
            this.labelPrg1Checksum = new System.Windows.Forms.Label();
            this.labelTotalTested = new System.Windows.Forms.Label();
            this.labelCurrentTested = new System.Windows.Forms.Label();
            this.labelTotalGood = new System.Windows.Forms.Label();
            this.labelCurrentGood = new System.Windows.Forms.Label();
            this.labelPartNumber = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.progressBarBurn = new System.Windows.Forms.ProgressBar();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEndProgram
            // 
            this.buttonEndProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEndProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndProgram.Location = new System.Drawing.Point(203, 429);
            this.buttonEndProgram.Name = "buttonEndProgram";
            this.buttonEndProgram.Size = new System.Drawing.Size(185, 38);
            this.buttonEndProgram.TabIndex = 31;
            this.buttonEndProgram.TabStop = false;
            this.buttonEndProgram.Text = "End Programming";
            this.buttonEndProgram.UseVisualStyleBackColor = true;
            this.buttonEndProgram.Click += new System.EventHandler(this.buttonEndProgram_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.Location = new System.Drawing.Point(12, 429);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(185, 38);
            this.buttonContinue.TabIndex = 30;
            this.buttonContinue.TabStop = false;
            this.buttonContinue.Text = "Program EPROM";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelPrg2Checksum
            // 
            this.labelPrg2Checksum.BackColor = System.Drawing.Color.White;
            this.labelPrg2Checksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrg2Checksum.Location = new System.Drawing.Point(176, 122);
            this.labelPrg2Checksum.Name = "labelPrg2Checksum";
            this.labelPrg2Checksum.Size = new System.Drawing.Size(190, 24);
            this.labelPrg2Checksum.TabIndex = 29;
            // 
            // labelPrg1Checksum
            // 
            this.labelPrg1Checksum.BackColor = System.Drawing.Color.White;
            this.labelPrg1Checksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrg1Checksum.Location = new System.Drawing.Point(176, 94);
            this.labelPrg1Checksum.Name = "labelPrg1Checksum";
            this.labelPrg1Checksum.Size = new System.Drawing.Size(190, 24);
            this.labelPrg1Checksum.TabIndex = 28;
            // 
            // labelTotalTested
            // 
            this.labelTotalTested.BackColor = System.Drawing.Color.White;
            this.labelTotalTested.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTested.Location = new System.Drawing.Point(176, 66);
            this.labelTotalTested.Name = "labelTotalTested";
            this.labelTotalTested.Size = new System.Drawing.Size(190, 24);
            this.labelTotalTested.TabIndex = 27;
            this.labelTotalTested.Text = "0";
            // 
            // labelCurrentTested
            // 
            this.labelCurrentTested.BackColor = System.Drawing.Color.White;
            this.labelCurrentTested.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTested.Location = new System.Drawing.Point(767, 65);
            this.labelCurrentTested.Name = "labelCurrentTested";
            this.labelCurrentTested.Size = new System.Drawing.Size(190, 24);
            this.labelCurrentTested.TabIndex = 26;
            this.labelCurrentTested.Text = "0";
            // 
            // labelTotalGood
            // 
            this.labelTotalGood.BackColor = System.Drawing.Color.White;
            this.labelTotalGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGood.Location = new System.Drawing.Point(767, 37);
            this.labelTotalGood.Name = "labelTotalGood";
            this.labelTotalGood.Size = new System.Drawing.Size(190, 24);
            this.labelTotalGood.TabIndex = 25;
            this.labelTotalGood.Text = "0";
            // 
            // labelCurrentGood
            // 
            this.labelCurrentGood.BackColor = System.Drawing.Color.White;
            this.labelCurrentGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentGood.Location = new System.Drawing.Point(176, 37);
            this.labelCurrentGood.Name = "labelCurrentGood";
            this.labelCurrentGood.Size = new System.Drawing.Size(190, 24);
            this.labelCurrentGood.TabIndex = 24;
            this.labelCurrentGood.Text = "0";
            // 
            // labelPartNumber
            // 
            this.labelPartNumber.BackColor = System.Drawing.Color.White;
            this.labelPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartNumber.Location = new System.Drawing.Point(767, 9);
            this.labelPartNumber.Name = "labelPartNumber";
            this.labelPartNumber.Size = new System.Drawing.Size(390, 24);
            this.labelPartNumber.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 24);
            this.label14.TabIndex = 22;
            this.label14.Text = "Prg 2 Checksum";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "Prg 1 Checksum";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "Total Tested";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(600, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Current Tested";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(600, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total Good";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Current Good";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(600, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Part Number";
            // 
            // labelInstructions
            // 
            this.labelInstructions.BackColor = System.Drawing.Color.White;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(16, 230);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(776, 196);
            this.labelInstructions.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 206);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 20);
            this.label22.TabIndex = 32;
            this.label22.Text = "Instructions";
            // 
            // progressBarBurn
            // 
            this.progressBarBurn.Location = new System.Drawing.Point(395, 430);
            this.progressBarBurn.Name = "progressBarBurn";
            this.progressBarBurn.Size = new System.Drawing.Size(397, 37);
            this.progressBarBurn.TabIndex = 34;
            this.progressBarBurn.Visible = false;
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.BackColor = System.Drawing.Color.White;
            this.labelCurrentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentFile.Location = new System.Drawing.Point(177, 9);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(190, 24);
            this.labelCurrentFile.TabIndex = 36;
            this.labelCurrentFile.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Current File";
            // 
            // ProgramEpromForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 479);
            this.ControlBox = false;
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarBurn);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.buttonEndProgram);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelPrg2Checksum);
            this.Controls.Add(this.labelPrg1Checksum);
            this.Controls.Add(this.labelTotalTested);
            this.Controls.Add(this.labelCurrentTested);
            this.Controls.Add(this.labelTotalGood);
            this.Controls.Add(this.labelCurrentGood);
            this.Controls.Add(this.labelPartNumber);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 385);
            this.Name = "ProgramEpromForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Burn EEPROM";
            this.Load += new System.EventHandler(this.ProgramEpromForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProgramEpromForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEndProgram;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelPrg2Checksum;
        private System.Windows.Forms.Label labelPrg1Checksum;
        private System.Windows.Forms.Label labelTotalTested;
        private System.Windows.Forms.Label labelCurrentTested;
        private System.Windows.Forms.Label labelTotalGood;
        private System.Windows.Forms.Label labelCurrentGood;
        private System.Windows.Forms.Label labelPartNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ProgressBar progressBarBurn;
        private System.Windows.Forms.Label labelCurrentFile;
        private System.Windows.Forms.Label label2;
    }
}