using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SharedLib
{
    public partial class TouchPad : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TouchPad"/> class.
        /// </summary>
        public TouchPad()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Click event of the TouchPadPeriod control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPadPeriod_Click(object sender, EventArgs e)
        {
            SendKeys.Send(".");
        }
        /// <summary>
        /// Handles the Click event of the TouchPadCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPadCancel_Click(object sender, EventArgs e)
        {
            SendKeys.Send("/");
        }
        /// <summary>
        /// Handles the Click event of the TouchPadEnter control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPadEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad6 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad7 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad8 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad9 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }
        /// <summary>
        /// Handles the Click event of the TouchPad0 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TouchPad0_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
        }
    }
}
