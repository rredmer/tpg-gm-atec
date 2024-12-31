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
    public partial class PartNumberForm : Form
    {
        public bool IsCancel = false;
        public string PartNumber = string.Empty;
        public string SourceFolder = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="PartNumberForm"/> class.
        /// </summary>
        public PartNumberForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the buttonOK control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.textBoxPartNumber.Text.Length > 0)
            {
                PartNumber = this.textBoxPartNumber.Text;
                this.Hide();
            }
            else MessageBox.Show("Please enter a valid kit number.", "No kit Number Entered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// Handles the Click event of the buttonCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            PartNumber = "";
            IsCancel = true;
            this.Hide();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listBoxSourceFiles control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listBoxSourceFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxPartNumber.Text = this.listBoxSourceFiles.SelectedItem.ToString();
        }

        /// <summary>
        /// Handles the Load event of the PartNumberForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void PartNumberForm_Load(object sender, EventArgs e)
        {
            // Load the source file list
            try
            {
                this.listBoxSourceFiles.Items.Clear();
                FileInfo[] files = new DirectoryInfo(SourceFolder).GetFiles("*.EPROM");
                foreach (FileInfo fil in files)
                {
                    this.listBoxSourceFiles.Items.Add(fil.Name.Substring(0, fil.Name.LastIndexOf(".")));
                }
            }
            catch (Exception ex) { ;}
        }
    }
}