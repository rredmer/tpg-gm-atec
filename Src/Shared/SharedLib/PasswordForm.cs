using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SharedLib
{
    public partial class PasswordForm : Form
    {
        public bool IsCancelPressed = false;
        public bool IsTouchPadEnabled = false;
        public string Password { get { return this.textBoxPassword.Text; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordForm"/> class.
        /// </summary>
        public PasswordForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Click event of the buttonContinue control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Handles the Activated event of the PasswordForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void PasswordForm_Activated(object sender, EventArgs e)
        {
            this.textBoxPassword.Text = string.Empty;
            IsCancelPressed = false;
            touchPadSecurity.Visible = IsTouchPadEnabled;
            touchPadSecurity.Enabled = IsTouchPadEnabled;
        }
        /// <summary>
        /// Handles the Click event of the buttonExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            IsCancelPressed = true;
            this.Hide();
        }
    }
}