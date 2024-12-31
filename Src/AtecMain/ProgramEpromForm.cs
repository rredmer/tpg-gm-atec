using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SharedLib;

namespace AtecMain
{
    public partial class ProgramEpromForm : Form
    {
        private const string EEPROM_VERIFY_GOOD = ">";
        private const int EEPROM_BURN_DELAY = 11;
        private const string StartText = "Load fresh Eproms at bottom of sockets with notch pointing to top.\r\n\r\nPress SPACE BAR or click 'Program EPROM' button to continue.\r\n\r\nPress the enter key or click 'End Programming' to end programming.";
        private const string FinishText = "Programming completed.\r\n\r\nRemove RED Eproms to Error bin.  Label GREEN Eproms and remove to Good bin.\r\n" +
                "Load fresh Eproms at bottom of sockets with notch pointing to top.\r\n\r\nPress SPACE BAR or click 'Program EPROM' button to continue.\r\n\r\nPress the enter key or click 'End Programming' to end programming.";
        private const string ProgrammingText = "Programming EPROM(s).\r\n\r\nPlease do not exit or remove EPROM(s) until completed.";
        public bool PrintLabels = false;
        private frmAtecMain oMainForm;
        public string Part1 = string.Empty;
        public string Part2 = string.Empty;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramEpromForm"/> class.
        /// </summary>
        public ProgramEpromForm(frmAtecMain mainfrm)
        {
            InitializeComponent();
            oMainForm = mainfrm;
            oMainForm.oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Created EPROM form.");
        }

        /// <summary>
        /// Handles the Load event of the ProgramEpromForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ProgramEpromForm_Load(object sender, EventArgs e)
        {
            this.labelInstructions.Text = StartText;
        }

        /// <summary>
        /// Handles the Click event of the buttonContinue control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            string Verify1   = string.Empty;
            string Verify2   = string.Empty;

            string V1GoodBad = string.Empty;
            int    V1Failed  = 0;
            int    V1Good    = 0;
            int    V1Tried   = 0;

            string V2GoodBad = string.Empty;
            int    V2Failed  = 0;
            int    V2Good    = 0;
            int    V2Tried   = 0;

            bool V1Success  = false;
            bool V2Success  = false;

            // Initialize form controls
            this.buttonContinue.Enabled = false;
            this.labelInstructions.Text = ProgrammingText;
            this.labelCurrentGood.Text = "0";
            this.labelCurrentTested.Text = "0";
            this.labelPrg1Checksum.Text = string.Empty;
            this.labelPrg2Checksum.Text = string.Empty;
            this.progressBarBurn.Value = 0;
            this.progressBarBurn.Maximum = 12;
//            this.progressBarBurn.Visible = true;
            this.progressBarBurn.Visible = false;
            this.Refresh();

            // Program EPROM(s)
            if (oMainForm.oDataIo3980xpiForm1.IsConnected) oMainForm.oDataIo3980xpiForm1.ProgramEPROM();
            if (oMainForm.oDataIo3980xpiForm2.IsConnected) oMainForm.oDataIo3980xpiForm2.ProgramEPROM();

            // DG:  I simply add a hard-coded delay here - we should see if we can check the comm status from
            // the burner - that would be more accurate.
            //for (int secs=0; secs<EEPROM_BURN_DELAY; secs++)
            //{
            //    this.progressBarBurn.Value = (secs + 1);    // Update the progress bar value
            //    this.progressBarBurn.Refresh();             // Refresh the progress bar control
            //    Thread.Sleep(1 * 1000);                     // Sleep for one second
            //    Application.DoEvents();                     // Allow other app events to happen
            //}

            // Get the Checksums
            this.labelPrg1Checksum.Text = (oMainForm.oDataIo3980xpiForm1.IsConnected) ? oMainForm.oDataIo3980xpiForm1.Checksum() : "Disabled";
            this.labelPrg2Checksum.Text = (oMainForm.oDataIo3980xpiForm2.IsConnected) ? oMainForm.oDataIo3980xpiForm2.Checksum() : "Disabled";

            Verify1   = (oMainForm.oDataIo3980xpiForm1.IsConnected) ? this.oMainForm.oDataIo3980xpiForm1.VerifyEPROM() : "Disabled";
            V1Success = ( Verify1.Contains(EEPROM_VERIFY_GOOD)) ? true : false;

            V1Failed = 0;
            V1Good   = 0;
            V1Tried  = 0;

            if (oMainForm.oDataIo3980xpiForm1.IsConnected)
            {

               if (oMainForm.oDataIo3980xpiForm1.DeviceType.Contains(":"))
               {
                  if (V1Success)
                  {
                     V1Failed = 0;
                     V1Good = 1;
                     V1Tried = 1;
                  }
                  else
                  {
                     V1Failed = 1;
                     V1Good = 0;
                     V1Tried = 1;
                  }
               }
               else
               {
                  V1GoodBad = this.oMainForm.oDataIo3980xpiForm1.GetFailedCount();
                  V1Failed = Int32.Parse(V1GoodBad.Substring(0, V1GoodBad.IndexOf("-")));
                  V1Tried = Int32.Parse(V1GoodBad.Substring(V1GoodBad.IndexOf("-") + 1, 2));
                  V1Good = V1Tried - V1Failed;
               }
            }

            Verify2   = (oMainForm.oDataIo3980xpiForm2.IsConnected) ? this.oMainForm.oDataIo3980xpiForm2.VerifyEPROM() : "Disabled";
            V2Success = ( Verify2.Contains(EEPROM_VERIFY_GOOD)) ? true : false;

            V2Failed  = 0;
            V2Tried   = 0;
            V2Good    = 0;

            if (oMainForm.oDataIo3980xpiForm2.IsConnected)
            {

               if (oMainForm.oDataIo3980xpiForm2.DeviceType.Contains(":"))
               {
                  if (V2Success)
                  {
                     V1Failed = 0;
                     V1Good = 1;
                     V1Tried = 1;
                  }
                  else
                  {
                     V1Failed = 1;
                     V1Good = 0;
                     V1Tried = 1;
                  }
               }
               else
               {
                  V2GoodBad = this.oMainForm.oDataIo3980xpiForm2.GetFailedCount();
                  V2Failed = Int32.Parse(V1GoodBad.Substring(0, V2GoodBad.IndexOf("-")));
                  V2Tried = Int32.Parse(V1GoodBad.Substring(V2GoodBad.IndexOf("-") + 1, 2));
                  V2Good = V2Tried - V2Failed;
               }
            }

            
            // DG: Add logic to check return values from Verify - we should also check the checksum as well.

            this.labelCurrentTested.Text = string.Format("{0}", V1Tried + V2Tried + Int32.Parse(this.labelCurrentTested.Text));
            this.labelTotalTested.Text = string.Format("{0}", V1Tried + V2Tried + Int32.Parse(this.labelTotalTested.Text));

            if ((oMainForm.oDataIo3980xpiForm1.IsConnected) && (this.labelPrg1Checksum.Text != string.Empty) && V1Success)
            {
                this.labelCurrentGood.Text = string.Format("{0}", V1Good + Int32.Parse(this.labelCurrentGood.Text));
                this.labelTotalGood.Text = string.Format("{0}", V1Good + Int32.Parse(this.labelTotalGood.Text));
            }

            if ((oMainForm.oDataIo3980xpiForm2.IsConnected) && (this.labelPrg1Checksum.Text != string.Empty) && V2Success)
            {
                this.labelCurrentGood.Text = string.Format("{0}", V2Good + Int32.Parse(this.labelCurrentGood.Text));
                this.labelTotalGood.Text = string.Format("{0}", V2Good + Int32.Parse(this.labelTotalGood.Text));
            }

            // Print the Labels
            if (this.PrintLabels)
            {
                if (oMainForm.oPrinterForm1.IsConnected) oMainForm.oPrinterForm1.PrintSmall(this.Part1);
                if (oMainForm.oPrinterForm2.IsConnected) oMainForm.oPrinterForm2.PrintLarge(this.Part1, this.Part2);
            }

            // Reset form for next part
            this.labelInstructions.Text = FinishText;
            this.progressBarBurn.Visible = false;
            this.buttonContinue.Enabled = true;
            oMainForm.LogEvent("Burned EPROM(s)", "Part#=" + this.labelPartNumber.Text + ", Type=" + oMainForm.oDataIo3980xpiForm1.DeviceType + 
                ", Chk1=" + this.labelPrg1Checksum.Text + ", Chk2=" + this.labelPrg2Checksum.Text + 
                ", Vfy1=" + Verify1 + ", Vfy2=" + Verify2);

            // This is to fake out the Forms processor to handle keyboard event ahead of button event (SPACEBAR/ENTER key).
            this.label10.Focus();
        }

        /// <summary>
        /// Handles the Click event of the buttonEndProgram control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonEndProgram_Click(object sender, EventArgs e)
        {
            this.labelInstructions.Text = StartText;
            this.Hide();
        }

        /// <summary>
        /// Handles the KeyDown event of the ProgramEpromForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        private void ProgramEpromForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                buttonContinue.PerformClick();
            }

            if (e.KeyData == Keys.Enter)
            {
                this.labelInstructions.Text = StartText;
                this.Hide();
            }
        }

        /// <summary>
        /// Sets the part number.
        /// </summary>
        /// <param name="PartNum">The part num.</param>
        public void SetPartNumber(string PartNum1, string PartNum2)
        {
            this.Part1 = PartNum1;
            this.Part2 = PartNum2;
            this.labelPartNumber.Text = PartNum1 + "," + PartNum2;
        }
    }
}