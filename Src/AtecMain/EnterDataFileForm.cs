using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtecMain
{
    public partial class EnterDataFileForm : Form
    {
        public bool IsValid = false;
        public string SourcePath = "";

        public EnterDataFileForm()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Title = "Enter data file to convert";
                openFileDialog.InitialDirectory = SourcePath;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName != "")
                    {
                        this.textBoxDataFile.Text = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.IndexOf("."));
                    }
                }
            }
            catch (Exception ex)
            {
                ;
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.textBoxDataFile.Text.Trim() == "")
                this.textBoxDataFile.Text = "CMS.DAT";
            IsValid = true;
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            IsValid = false;
            this.Hide();
        }
    }
}