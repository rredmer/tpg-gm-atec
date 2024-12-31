#region Comments
//
// AtecMainForm.cs - This is the main form for the ATEC EPROM Program.
//
// Revision History:
//    12/07/2007 v1.0.0 First functioning Beta Release.
// --------------------------------------------------------------------------
// Programming Notes:
// 
// Motorola EPROM Format File:
// Type: A 1 character field that specifies whether the record is an S0, S1, S2, S3, S5, S7, S8 or S9 field. 
// Record Length:  A 2 character (1 byte) field that specifies the number of character pairs (bytes) in the record, excluding the type and record length fields. 
// Address: A 2-, 3- or 4-byte address that specifies where the data in the S-record is to be loaded into memory. 
// Data: The executable code, memory-loadable data or descriptive information to be transferred. 
// Checksum: An 8-bit field that represents the least significant byte of the one's complement of the sum of the values represented by the pairs of characters making up the record's length, address, and data fields.
//
// Record Types:
// S0 This type of record is the header record for each block of S-records. The data field may contain any descriptive information identifying the following block of S-records. (It is commonly ''HDR'' on many systems.) The address field is normally zero. 
// S1 A record containing data and the 2-byte address at which the data is to reside. 
// S2 A record containing data and the 3-byte address at which the data is to reside. 
// S3 A record containing data and the 4-byte address at which the data is to reside. 
// S5 A record containing the number of S1, S2 and S3 records transmitted in a particular block. The count appears in the two-byte address field. There is no data field. 
// S6 A record containing the number of S1, S2 and S3 records transmitted in a particular block. The count appears in the three-byte address field. There is no data field. 
// S7 A termination record for a block of S3 records. The address field may contain the 4-byte address of the instruction to which control is passed. There is no data field. 
// S8 A termination record for a block of S2 records. The address field may optionally contain the 3-byte address of the instruction to which control is passed. There is no data field. 
// S9 A termination record for a block of S1 records. The address field may optionally contain the 2-byte address of the instruction to which control is passed. If not specified, the first entry point specification encountered in the object module input will be used. There is no data field.
//
// Turbo Pascal Data Types:
// integer    Whole numbers from -32768 to 32767
// byte       The integers from 0 to 255 
// real       Floating point numbers from 1E-38 to 1E+38 
// boolean    Can only have the value TRUE or FALSE
// char       Any character in the ASCII character set 
// shortint   The integers from -128 to 127 
// word       The integers from 0 to 65535 
// longint    The integers from -2147483648 to 2147483647 
// single     Real type with 7 significant digits
// double     Real type with 15 significant digits
// extended   Real type with 19 significant digits
// comp       The integers from about -10E18 to 10E18
//
// --------------------------------------------------------------------------
#endregion
using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Reflection.Emit;
using AtecMain.Properties;
using SharedLib;

namespace AtecMain
{
    public partial class frmAtecMain : Form
    {
        public const string DRIVE_ID = "C:\\";
        public const string ROOT_FOLDER = DRIVE_ID + "ATEC\\";
        public const string CALS_FOLDER = DRIVE_ID + "ATEC\\cals\\";
        public const string SOURCE_FOLDER = DRIVE_ID + "ATEC\\cals\\src\\";
        public const string MOTO_FOLDER = DRIVE_ID + "ATEC\\cals\\moto\\";
        public const string SETTINGS_FOLDER = DRIVE_ID + "ATEC\\settings\\";
        public const string LOGS_FOLDER = DRIVE_ID + "ATEC\\logs";     // no trailing backslash for logs module
        public const string MOTO_EXTENSION = ".S11";
        public const string PARTNO_EXTENSION = ".partno";
        public const string CHECKSUM_EXTENSION = ".checksum";
        public const string CMS_FILE = DRIVE_ID + "ATEC\\cals\\CMS" + MOTO_EXTENSION;
        public const string PART_FILE = DRIVE_ID + "ATEC\\cals\\PARTNUM.TXT";
        private const string XREF_FILE = SOURCE_FOLDER + "PartNum_Xref\\Assembly_Prom_Xref.txt";
        private const string SETTINGS_FILE = "ATEC.INI";
        private const string EVENT_FILE = LOGS_FOLDER + "\\" + "ATEC_EVENTS.XML";
        private const string EVENT_FILE_TIME_STAMP = "yyyy-MM-ddTHHmmss";
        private const string EVENT_TIME_STAMP = "MM/dd/yyyy HH:mm tt";

        public AppLogForm oAppLogForm = new AppLogForm();
        public IntermecPF2iForm oPrinterForm1;
        public IntermecPF2iForm oPrinterForm2;
        public DataIo3980xpiForm oDataIo3980xpiForm1;
        public DataIo3980xpiForm oDataIo3980xpiForm2;
        public SettingsForm oSettingsForm = new SettingsForm();
        public ProgramEpromForm oProgramEpromForm;
        public string Part1 = string.Empty;
        public string Part2 = string.Empty;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAtecMain"/> class.
        /// </summary>
        public frmAtecMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        /// <summary>
        /// Handles the Load event of the frmAtecMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void frmAtecMain_Load(object sender, EventArgs e)
        {
            this.Text = "ATEC EPROM Programmer v" + Application.ProductVersion;
            oPrinterForm1 = new IntermecPF2iForm(oAppLogForm);
            oPrinterForm2 = new IntermecPF2iForm(oAppLogForm);
            oDataIo3980xpiForm1 = new DataIo3980xpiForm(oAppLogForm);
            oDataIo3980xpiForm2 = new DataIo3980xpiForm(oAppLogForm);
            oProgramEpromForm = new ProgramEpromForm(this);
            oAppLogForm.GetLogFileName(LOGS_FOLDER);
            LoadSettings();
            this.textKitNumber.Text = "";

            this.CreateAppFolders();
            this.ConnectProgrammers();
            this.ConnectLabelPrinters();
 
            if (File.Exists(EVENT_FILE))
                this.dataTableEventLog.ReadXml(EVENT_FILE);
            LogEvent("Program", "Started program");
            timerMain.Enabled = true;
        }

        /// <summary>
        /// Handles the Activated event of the frmAtecMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void frmAtecMain_Activated(object sender, EventArgs e)
        {
            this.listMainMenu.Focus();
        }

        /// <summary>
        /// Handles the Click event of the partNumberDialogToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void partNumberDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEvent("Program", "Accessed Kit Dialog");
            GetNewKitNumber();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listMainMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listMainMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessMenuOption(listMainMenu.SelectedIndex);
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listBoxPrinterMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listBoxPrinterMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int NumLabels = 1;
            switch (listBoxPrinterMenu.SelectedIndex)
            {
                case 0:         // Small on printer 1
                     NumLabels = this.GetNumberOfLabels();
                    for (int iLabel=0;iLabel<NumLabels;iLabel++)
                        this.oPrinterForm1.PrintSmall(this.Part1);
                    break;
                case 1:         // Large on printer 2
                    NumLabels = this.GetNumberOfLabels();
                    for (int iLabel = 0; iLabel < NumLabels; iLabel++)
                        this.oPrinterForm2.PrintLarge(this.Part1, this.Part2);
                    break;
                case 2:         // Large on printer 1
                    NumLabels = this.GetNumberOfLabels();
                    for (int iLabel = 0; iLabel < NumLabels; iLabel++)
                        this.oPrinterForm1.PrintLarge(this.Part1, this.Part2);
                    break;
                case 3:
                    {
                        listBoxPrinterMenu.Enabled = false;
                        listBoxPrinterMenu.Visible = false;
                        listMainMenu.Visible = true;
                        listMainMenu.Enabled = true;
                        break;
                    }
            }
        }

        /// <summary>
        /// Handles the Click event of the convertDataFileToMotorolaFormatToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void convertDataFileToMotorolaFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessMenuOption(0);
        }

        /// <summary>
        /// Handles the Click event of the loadMotorolaFormatFileToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void loadMotorolaFormatFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessMenuOption(1);
        }

        /// <summary>
        /// Handles the Click event of the programEPROMSAndPrintLabelsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void programEPROMSAndPrintLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessMenuOption(2);
        }

        /// <summary>
        /// Handles the Click event of the printLabToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void printLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessMenuOption(3);
        }

        /// <summary>
        /// Handles the Click event of the burnEPROMSOnlyToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void burnEPROMSOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessMenuOption(4);
        }

        /// <summary>
        /// Handles the Click event of the selectEPROMTypeToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void selectEPROMTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessMenuOption(5);
        }

        /// <summary>
        /// Handles the Click event of the viewLogFileToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void viewLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEvent("Program", "Accessed application log");
            oAppLogForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the clearEventHistoryToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void clearEventHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Clear History", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                LogEvent("Program", "User cleared event history.");
                ClearEventHistory();
            }
        }

        /// <summary>
        /// Handles the Click event of the exitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessMenuOption(6);
        }
        
        /// <summary>
        /// Handles the Leave event of the textEpromType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textEpromType_Leave(object sender, EventArgs e)
        {
            textEpromType.Enabled = false;
            LogEvent("Program", "Updated EPROM type to '" + this.textEpromType.Text + "'");
            SaveSettings();                     // Update Config File
        }

        /// <summary>
        /// Handles the Tick event of the timerMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (oDataIo3980xpiForm1.IsConnected)
            {
                if (oDataIo3980xpiForm1.IsTimedOut) this.labelProgrammer1Status.Text = "Communications Error.";
                else this.labelProgrammer1Status.Text = "Connected on " + oDataIo3980xpiForm1.serialPortCom.PortName;
            }

            if (oDataIo3980xpiForm2.IsConnected)
            {
                if (oDataIo3980xpiForm2.IsTimedOut) this.labelProgrammer2Status.Text = "Communications Error.";
                else labelProgrammer2Status.Text = "Connected on " + oDataIo3980xpiForm2.serialPortCom.PortName;
            }
        }

        /// <summary>
        /// Handles the Click event of the printer1DiagnosticsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void printer1DiagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEvent("Program", "Accessed Printer 1 Diagnostics");
            oPrinterForm1.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the printer2DiagnosticsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void printer2DiagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEvent("Program", "Accessed Printer 2 Diagnostics");
            oPrinterForm2.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the programmer1DiagnosticsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void programmer1DiagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEvent("Program", "Accessed Programmer 1 Diagnostics");
            oDataIo3980xpiForm1.ShowDialog();
            this.SaveSettings();
        }

        /// <summary>
        /// Handles the Click event of the programmer2DiagnosticsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void programmer2DiagnosticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEvent("Program", "Accessed Programmer 2 Diagnostics");
            oDataIo3980xpiForm2.ShowDialog();
            this.SaveSettings();
        }

        /// <summary>
        /// Handles the Click event of the optionsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogEvent("Program", "Accessed Program Options");
            oSettingsForm.Show();
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Processes the menu option.
        /// </summary>
        /// <param name="option">The option.</param>
        private void ProcessMenuOption(int option)
        {
            switch (option)
            {
                case 0:                                     // Convert to Motorola Format
                {
                    if (this.textKitNumber.Text == "" || this.textPartNumber.Text == "")
                    {
                        if (this.GetNewKitNumber() == false) break;
                    }
                    ConvertMotorolaFile();
                    break;
                }
                case 1:                                     // Load Motorola Format File
                {
                    if (this.textKitNumber.Text == "" || this.textPartNumber.Text == "")
                    {
                        if (this.GetNewKitNumber() == false) break;
                    }
                    LoadMotorolaFile();
                    break;
                }
                case 2:                                     // Burn EPROMS and Print Labels
                {
                    LogEvent("Program", "Accessed Program EPROMs and Print Labels");
                    if (this.textKitNumber.Text == "" || this.textPartNumber.Text == "")
                    {
                        if (this.GetNewKitNumber() == false) break;
                    }
                    ProgramEEPROMS(true);
                    break;
                }
                case 3:                                     // Print Labels submenu
                {
                    LogEvent("Program", "Accessed Print Labels Menu");
                    this.listMainMenu.Enabled = false;
                    this.listMainMenu.Visible = false;
                    this.listBoxPrinterMenu.Visible = true;
                    this.listBoxPrinterMenu.Enabled = true;
                    break;
                }
                case 4:                                     // Burn EPROMS only
                {
                    LogEvent("Program", "Accessed Burn EPROMs");
                    if (this.textKitNumber.Text == "" || this.textPartNumber.Text == "")
                    {
                        if (this.GetNewKitNumber() == false) break;
                    }
                    ProgramEEPROMS(false);
                    break;
                }
                case 5:                                     // Enter EPROM type
                {
                    textEpromType.Enabled = true;
                    textEpromType.Focus();
                    break;
                }
                case 6:                                     // End program
                {
                    if (MessageBox.Show("Are you sure?", "Exit the program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        LogEvent("Program", "Exited the program");
                        timerMain.Enabled = false;
                        oPrinterForm1.ExitFlag = true;
                        oPrinterForm1.Dispose();
                        Application.Exit();
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Creates the app folders.
        /// </summary>
        private void CreateAppFolders()
        {
            try
            {
                if (!Directory.Exists(ROOT_FOLDER)) Directory.CreateDirectory(ROOT_FOLDER);
                if (!Directory.Exists(SETTINGS_FOLDER)) Directory.CreateDirectory(SETTINGS_FOLDER);
                if (!Directory.Exists(LOGS_FOLDER)) Directory.CreateDirectory(LOGS_FOLDER);
                if (!Directory.Exists(CALS_FOLDER)) Directory.CreateDirectory(CALS_FOLDER);
                if (!Directory.Exists(MOTO_FOLDER)) Directory.CreateDirectory(MOTO_FOLDER);
                if (!Directory.Exists(SOURCE_FOLDER)) Directory.CreateDirectory(SOURCE_FOLDER);
            }
            catch (Exception ex)
            {
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error creating folders " + ex.InnerException.ToString());
            }
        }

        /// <summary>
        /// Programs the EEPROMS.
        /// </summary>
        /// <param name="PrintLabels">if set to <c>true</c> [print labels].</param>
        private void ProgramEEPROMS(bool PrintLabels)
        {
            this.listMainMenu.Enabled = false;
            oProgramEpromForm.PrintLabels = PrintLabels;
            if (oDataIo3980xpiForm1.IsConnected == false && oDataIo3980xpiForm2.IsConnected == false)
               {
                MessageBox.Show("Please connect at least one EPROM Programmer and Enable it in View\\Options.", "BURN EPROMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LogEvent("Program", "Cancelled Program EEPROMS - No EPROM Programmer connected.");
            }
            else
            {
                if (textPartNumber.Text.Trim() != "")
                {
                    oProgramEpromForm.SetPartNumber(this.Part1, this.Part2);
                    oProgramEpromForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please enter a Part Number.", "BURN EPROMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.GetNewKitNumber();
                }
            }
            this.textKitNumber.Text = "";
            this.textPartNumber.Text = "";
            this.listMainMenu.Enabled = true;
        }

        /// <summary>
        /// Converts the motorola file.
        /// 
        /// If the user selects CMS.DAT, this routine will simply create CMS.S11 and copy the PARTNO file for the
        /// currently selected Kit/Part to PARTNUM.TXT
        /// 
        /// If the user selects a valid EPROM file, this routine will create the motorola file and copy the Motorola file
        /// to CMS.S11.  If will copy the selected EPROM file to CMS.DAT and will copy the PARTNO file to PARTNUM.TXT.
        /// </summary>
        private void ConvertMotorolaFile()
        {
            LogEvent("Program", "Accessed Convert to Motorola Format");
            bool ConvertOK = false;

            // Get the data file to convert (Kit and Part Number are loaded)
            EnterDataFileForm oEnterDataFileForm = new EnterDataFileForm();
            oEnterDataFileForm.SourcePath = SOURCE_FOLDER;
            oEnterDataFileForm.ShowDialog();
            if (oEnterDataFileForm.IsValid)
            {
                string PartFile = oEnterDataFileForm.textBoxDataFile.Text;
                if (PartFile == "CMS.DAT")
                {
                    string SrcFile = CALS_FOLDER + "CMS.DAT";
                    string MotoFile = CALS_FOLDER + "CMS" + MOTO_EXTENSION;
                    ConvertOK = ConvertFileToMotorolaFormat(SrcFile, MotoFile, false);
                }
                else
                {
                    // ORIGINAL CODE:  string MotoFileName = MOTO_FOLDER + sFileName.Substring(sFileName.LastIndexOf("\\") + 1, sFileName.LastIndexOf(".") - (sFileName.LastIndexOf("\\") + 1)) + MOTO_EXTENSION;
                    string SrcFile = SOURCE_FOLDER + PartFile + ".EPROM";
                    string MotoFile = MOTO_FOLDER + PartFile + MOTO_EXTENSION;
                    string DestFile = CALS_FOLDER + PartFile + MOTO_EXTENSION;
                    ConvertOK = ConvertFileToMotorolaFormat(SrcFile, MotoFile, false);
                    if (ConvertOK && File.Exists(MotoFile))
                    {
                        File.Copy(MotoFile, DestFile, true);                // Copy Moto File for the part to CMS.S11
                        File.Copy(SrcFile, CALS_FOLDER + "CMS.DAT", true);  // Copy EPROM file to CMS.DAT
                    }
                }

                if (ConvertOK)
                {
                    // Copy partno file to PARTNUM.TXT File in CALS Folder
                    string NewPartFile = SOURCE_FOLDER + textPartNumber.Text.Trim() + PARTNO_EXTENSION;
                    if (File.Exists(NewPartFile))
                    {
                        File.Copy(NewPartFile, PART_FILE, true);
                        this.ReadPartNumberFile();
                    }
                    else
                    {
                        // The partno file does not exist - create PARTNUM.TXT File in CALS Folder
                        this.CreatePartNumberFile(textPartNumber.Text, textPartNumber.Text);
                        MessageBox.Show("The PartNumber file for the part was not found.", "Please Locate this file before proceeding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        }

        /// <summary>
        /// Converts the file to motorola format.
        /// </summary>
        /// <param name="sFileName">Name of the s file.</param>
        /// <param name="ShowCompleteMessage">if set to <c>true</c> [show complete message].</param>
        /// <returns></returns>
        private bool ConvertFileToMotorolaFormat(string sFileName, string MotoFileName, bool ShowCompleteMessage)
        {
            bool retval = false;
            short AddrOffset = 0;
            ushort byteval=0,checksum=0,byteaddress=0,romcheck=0,romlast=0;
            string instring="",outstring="",chksum="",chksum_last="";
            try
            {
                StreamReader rdr = new StreamReader(sFileName, Encoding.ASCII);
                StreamWriter wrt = new StreamWriter(MotoFileName, false, Encoding.ASCII);
                while (!rdr.EndOfStream)
                {
                    checksum = 0;
                    outstring = "";
                    instring = rdr.ReadLine();
                    outstring = instring.Replace(" ", "");                      // Remove embedded spaces

                    // Compute Checksums
                    for (int idx = 1; idx <= outstring.Length / 2; idx++)
                    {
                        byteval = ushort.Parse(outstring.Substring(2 * idx - 2, 2), System.Globalization.NumberStyles.HexNumber);
                        romlast = romcheck;
                        romcheck = (ushort)(romcheck + byteval);
                        checksum = (ushort)check((short)(checksum + byteval));
                    }
                    AddrOffset = (short)(outstring.Length / 2);
                    checksum = check((short)(checksum + AddrOffset + 3));
                    checksum = check((short)(checksum + (byteaddress / 256)));
                    checksum = check((short)(checksum + (byteaddress & 255)));
                    checksum = (ushort)((~checksum) & 255);
                    wrt.WriteLine("{0}{1:X2}{2:X4}{3}{4:X2}", "S1", AddrOffset + 3, byteaddress, outstring, checksum);
                    // Display on screen...
                    byteaddress = (ushort)(byteaddress + AddrOffset);
                    chksum_last = string.Format("{0:X2}", romlast);
                    chksum = string.Format("{0:X4}", romcheck);
                }
                wrt.WriteLine("S9030000FC");
                rdr.Close();
                wrt.Close();

                // Display checksum form
                ChecksumForm oChecksumForm = new ChecksumForm();
                oChecksumForm.labelPartialChecksum.Text = chksum_last.Substring(2, 2);
                oChecksumForm.labelTotalChecksum.Text = chksum;
                oChecksumForm.ShowDialog();

                LogEvent("ConvertFile", "Converted '" + sFileName + "' Address="+byteaddress+", Checksum="+chksum+", LastChksum="+chksum_last);
                if (ShowCompleteMessage) MessageBox.Show("The file has been converted successfully.", "Conversion completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                retval = true;
            }
            catch (Exception ex)
            {
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error Converting Motorola File=" + ex.InnerException.ToString());
            }
            return retval;
        }

        /// <summary>
        /// Checks the specified test.
        /// </summary>
        /// <param name="test">The test.</param>
        /// <returns></returns>
        private ushort check(short test)
        {
            ushort chk = 0;
            if (test > 255) chk = (ushort)(test - 256);
            else chk = (ushort)test;
            return chk;
        }

        /// <summary>
        /// Loads the motorola file.
        /// </summary>
        private void LoadMotorolaFile()
        {
            LogEvent("Program", "Accessed Load Motorola Format File");

            // Get the partnum file to load (Kit and Part Number are loaded)
            EnterPartNumFileForm oEnterPartNumFileForm = new EnterPartNumFileForm();
            oEnterPartNumFileForm.SourcePath = SOURCE_FOLDER;
            oEnterPartNumFileForm.ShowDialog();
            if (oEnterPartNumFileForm.IsValid == false) return;

            if (oEnterPartNumFileForm.textBoxPartFile.Text != PART_FILE)
            {
                this.textPartNumFile.Text = oEnterPartNumFileForm.textBoxPartFile.Text + ".partno";
                string NewPartFile = SOURCE_FOLDER + oEnterPartNumFileForm.textBoxPartFile.Text + ".partno";
                if (File.Exists(NewPartFile))
                    File.Copy(NewPartFile, PART_FILE, true);
                this.ReadPartNumberFile();
            }

            // Get the partnum file to load (Kit and Part Number are loaded)
            EnterExorciserForm oEnterExorciserForm = new EnterExorciserForm();
            oEnterExorciserForm.SourcePath = MOTO_FOLDER;
            oEnterExorciserForm.ShowDialog();
            if (oEnterExorciserForm.IsValid == false) return;

            // Load the Motorola File
            string RawFile = oEnterExorciserForm.textBoxPartFile.Text;
            string MotoFile = "";
            if (RawFile == "CMS.S11") MotoFile = CALS_FOLDER + RawFile;
            else MotoFile = MOTO_FOLDER + RawFile + MOTO_EXTENSION;

            LoadMotorolaFormat(MotoFile);

        }

        /// <summary>
        /// Loads the motorola file.
        /// </summary>
        /// <param name="FileName">Name of the file.</param>
        /// <returns></returns>
        private bool LoadMotorolaFormat(string sFileName)
        {
            bool retval = false;

            if (oDataIo3980xpiForm1.IsConnected == false && oDataIo3980xpiForm2.IsConnected == false)
            {
                MessageBox.Show("Please connect at least one EPROM Programmer and Enable it in View\\Options.", "Load Motorola File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LogEvent("Program", "Cancelled Load Motorola File - No EPROM Programmer connected.");
            }
            else
            {
                try
                {
                    using (StreamReader rdr = new StreamReader(sFileName, Encoding.ASCII))
                    {
                        if (oDataIo3980xpiForm1.IsConnected)
                        {
                            oDataIo3980xpiForm1.ComWrite("082A");       //S1 File
                            if (oDataIo3980xpiForm1.WaitForReady(2500))
                            {
                                oDataIo3980xpiForm1.ComWrite("I");
                                oDataIo3980xpiForm1.WaitForReady(700);
                            }
                            else
                            {
                                oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Initialization command timed out.");
                                MessageBox.Show("Programmer not responding");
                                return (false);
                            }
                        }

                        if (oDataIo3980xpiForm2.IsConnected)
                        {
                            oDataIo3980xpiForm2.ComWrite("082A");       //S1 File
                            if (oDataIo3980xpiForm2.WaitForReady(2500))
                            {
                                oDataIo3980xpiForm2.ComWrite("I");
                                oDataIo3980xpiForm2.WaitForReady(700);
                            }
                            else
                            {
                                oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Initialization command timed out.");
                                MessageBox.Show("Programmer not responding");
                                return (false);
                            }
                        }

                        while (!rdr.EndOfStream)
                        {
                            string buf = rdr.ReadLine();
                            oAppLogForm.LogWrite(AppLogForm.LogLevel.Debug, "Writing [" + buf + "]");
                            if (oDataIo3980xpiForm1.IsConnected)
                            {
                                oDataIo3980xpiForm1.ComWrite(buf);
                            }
                            if (oDataIo3980xpiForm2.IsConnected) oDataIo3980xpiForm2.ComWrite(buf);
                        }
                    }
                    this.LogEvent("LoadFile", "Loaded '" + sFileName + "'");
                    this.textPartNumber.Text = sFileName.Substring(sFileName.LastIndexOf("\\") + 1, sFileName.LastIndexOf(".") - (sFileName.LastIndexOf("\\") + 1));
                    
                    //this.textKitNumber.Text = sFileName.Substring(sFileName.LastIndexOf("\\") + 1);
                    
                    retval = true;
                }
                catch (Exception ex)
                {
                    oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error Loading Motorola File=" + ex.InnerException.ToString());
                }
            }
            return retval;
        }

        /// <summary>
        /// Loads the settings.
        /// </summary>
        private void LoadSettings()
        {
            try
            {
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Loading settings...");
                Settings.Default.Reload();
                this.textEpromType.Text = Settings.Default.EPromType;
                // -- 02 28 2008 - THIS WILL ALWAYS LOAD AS BLANK - this.textDataFile.Text = Settings.Default.DataFile;
                // this.textKitNumber.Text = Settings.Default.MotorolaFile;
                oDataIo3980xpiForm1.serialPortCom.PortName = Settings.Default.SerialPortComPort1;
                oDataIo3980xpiForm1.serialPortCom.BaudRate = Settings.Default.SerialPortBaud1;
                oDataIo3980xpiForm2.serialPortCom.PortName = Settings.Default.SerialPortComPort2;
                oDataIo3980xpiForm2.serialPortCom.BaudRate = Settings.Default.SerialPortBaud2;
                oPrinterForm1.serialPortCom.PortName = Settings.Default.Printer1SerialPort;
                oPrinterForm2.serialPortCom.PortName = Settings.Default.Printer2SerialPort;
                oDataIo3980xpiForm1.DeviceType = this.textEpromType.Text.Trim();
                oDataIo3980xpiForm2.DeviceType = this.textEpromType.Text.Trim();
                oPrinterForm1.IsSerial = Settings.Default.Printer1Serial;
                oPrinterForm2.IsSerial = Settings.Default.Printer2Serial;
            }
            catch (Exception ex)
            {
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error Loading Settings=" + ex.InnerException.ToString());
            }
        }

        /// <summary>
        /// Saves the settings.
        /// </summary>
        private void SaveSettings()
        {
            try
            {
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Saving settings...");
                Settings.Default.EPromType = this.textEpromType.Text;
                Settings.Default.SerialPortComPort1 = oDataIo3980xpiForm1.serialPortCom.PortName;
                Settings.Default.SerialPortBaud1 = oDataIo3980xpiForm1.serialPortCom.BaudRate;
                Settings.Default.SerialPortComPort2 = oDataIo3980xpiForm2.serialPortCom.PortName;
                Settings.Default.SerialPortBaud2 = oDataIo3980xpiForm2.serialPortCom.BaudRate;
                Settings.Default.Printer1SerialPort = oPrinterForm1.serialPortCom.PortName;
                Settings.Default.Printer2SerialPort = oPrinterForm2.serialPortCom.PortName;
                Settings.Default.Save();
                oDataIo3980xpiForm1.DeviceType = this.textEpromType.Text.Trim();
                oDataIo3980xpiForm2.DeviceType = this.textEpromType.Text.Trim();

            }
            catch (Exception ex)
            {
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error Saving Settings=" + ex.InnerException.ToString());
            }
        }

        /// <summary>
        /// Connects the programmers.
        /// </summary>
        private void ConnectProgrammers()
        {
            if (Settings.Default.UseBurner1)
            {
                if (oDataIo3980xpiForm1.Connect())
                {
                   oDataIo3980xpiForm1.GetConfiguration();
                    labelProgrammer1Status.Text = "Connected on " + oDataIo3980xpiForm1.serialPortCom.PortName;
                }
                else labelProgrammer1Status.Text = "Not found on " + oDataIo3980xpiForm1.serialPortCom.PortName;
            }
            else labelProgrammer1Status.Text = "Disabled.";

            if (Settings.Default.UseBurner2)
            {
                if (oDataIo3980xpiForm2.Connect())
                {
                   oDataIo3980xpiForm2.GetConfiguration();
                    labelProgrammer2Status.Text = "Connected on " + oDataIo3980xpiForm2.serialPortCom.PortName;
                }
                else labelProgrammer2Status.Text = "Not found on " + oDataIo3980xpiForm2.serialPortCom.PortName;
            }
            else labelProgrammer2Status.Text = "Disabled.";
        }

        /// <summary>
        /// Connects the label printers.
        /// </summary>
        private void ConnectLabelPrinters()
        {
            string sPrinterAddress1 = Settings.Default.PrinterAddress1;
            string sPrinterAddress2 = Settings.Default.PrinterAddress2;
            if (Settings.Default.UsePrinter1)
            {
                if (oPrinterForm1.Connect(sPrinterAddress1, 9100)) this.labelPrinter1Status.Text = "Connected on " + sPrinterAddress1;
            }
            else
            {
                this.labelPrinter1Status.Text = "Disabled.";
            }
            if (Settings.Default.UsePrinter2)
            {
                if (oPrinterForm2.Connect(sPrinterAddress2, 9100)) this.labelPrinter2Status.Text = "Connected on " + sPrinterAddress2;
            }
            else
            {
                this.labelPrinter2Status.Text = "Disabled.";
            }
        }

        /// <summary>
        /// Clears the event history.
        /// </summary>
        private void ClearEventHistory()
        {
            this.dataTableEventLog.Rows.Clear();
            FileInfo oFile = new FileInfo(EVENT_FILE);
            oFile.MoveTo(LOGS_FOLDER + "\\" + System.DateTime.Now.ToString(EVENT_FILE_TIME_STAMP) + "_ATEC_EVENTS.XML");
        }

        /// <summary>
        /// Logs the event.
        /// </summary>
        /// <param name="EventType">Type of the event.</param>
        /// <param name="EventDescription">The event description.</param>
        public void LogEvent(string EventType, string EventDescription)
        {
            try
            {
                DataRow row = this.dataTableEventLog.NewRow();
                row[dataColEventTime] = System.DateTime.Now.ToString(EVENT_TIME_STAMP);
                row[dataColumnEventType] = EventType;
                row[dataColumnEventDescription] = EventDescription;
                this.dataTableEventLog.Rows.Add(row);
                this.dataTableEventLog.WriteXml(EVENT_FILE);

                // Auto scroll grid
                int TargetRow = dataGridView1.Rows[dataGridView1.Rows.Count-1].Index;
                this.dataGridView1.FirstDisplayedScrollingRowIndex = TargetRow;
            }
            catch (Exception ex)
            {
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error adding event row =" + ex.InnerException.ToString());
            }
        }

        /// <summary>
        /// Gets the number of labels.
        /// </summary>
        /// <returns></returns>
        private int GetNumberOfLabels()
        {
            int NumLabels = 0;
            InputBoxResult result = InputBox.Show("Number of labels to print:", "Print Labels", "1", null);
            if (result.OK)
            {
                NumLabels = int.Parse(result.Text);
            }
            return (NumLabels);
        }

        /// <summary>
        /// Creates the part number file.
        /// </summary>
        /// <param name="PartNum">The part num.</param>
        /// <returns></returns>
        private void CreatePartNumberFile(string PartNum1, string PartNum2)
        {
            try
            {
                StreamWriter wrt = new StreamWriter(PART_FILE, false, Encoding.ASCII);
                wrt.WriteLine(PartNum1);
                wrt.WriteLine(PartNum2);
                wrt.Close();
            }
            catch (Exception ex)
            {
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error writing part number file " + ex.InnerException.ToString());
            }
        }

        private void ReadPartNumberFile()
        {
            try
            {
                string[] Parts = File.ReadAllLines(PART_FILE, Encoding.ASCII);
                if (Parts.Length == 2)
                {
                    this.textPartNumFile.Text = Parts[0].Trim() + "," + Parts[1].Trim();
                    Part1 = Parts[0].Trim();
                    Part2 = Parts[1].Trim();
                }
                else
                {
                    this.textPartNumFile.Text = "INVALID PARTFILE";
                    Part1 = "INVALID";
                    Part2 = "INVALID";
                }
            }
            catch (Exception ex)
            {
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error writing part number file " + ex.InnerException.ToString());
            }
        }


        /// <summary>
        /// Gets the new part number.
        /// </summary>
        private bool GetNewKitNumber()
        {
            bool IsValid = false;
            this.textKitNumber.Text = "";
            this.textPartNumber.Text = "";
            while (!IsValid)
            {
                PartNumberForm oPartNumberForm = new PartNumberForm();
                oPartNumberForm.SourceFolder = SOURCE_FOLDER;
                oPartNumberForm.ShowDialog();
                if (oPartNumberForm.IsCancel)       // User cancelled, exit the routine
                    break;
                else
                {
                    try
                    {
                        // Look for a valid EPROM file in source folder
                        string SrcFile = SOURCE_FOLDER + oPartNumberForm.PartNumber.Trim() + ".EPROM";

                        // If the file does not exit - check the XREF File
                        if (!File.Exists(SrcFile))
                        {
                            if (File.Exists(XREF_FILE))
                            {
                                string[] AllLines = File.ReadAllLines(XREF_FILE, Encoding.ASCII);
                                for (int iFile = 2; iFile < AllLines.Length; iFile++)
                                {
                                    if (AllLines[iFile].Substring(9, 8) == oPartNumberForm.PartNumber.Trim())
                                    {
                                        string xrefpart = AllLines[iFile].Substring(0, 8);
                                        LogEvent("Program", oPartNumberForm.PartNumber + " found in XREF: using " + xrefpart);
                                        oPartNumberForm.PartNumber = xrefpart;
                                        SrcFile = SOURCE_FOLDER + oPartNumberForm.PartNumber.Trim() + ".EPROM";
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                LogEvent("Program", "XREF file not found.");
                            }
                        }
                        if (File.Exists(SrcFile))
                        {
                            this.textKitNumber.Text = oPartNumberForm.PartNumber;
                            this.textPartNumber.Text = oPartNumberForm.PartNumber;
                            IsValid = true;
                        }
                        else MessageBox.Show("The source file for the part was not found.", "Invalid Part Number Entered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    catch (Exception ex)
                    {
                        oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error converting part files " + ex.InnerException.ToString());
                        break;
                    }
                }
            }
            return (IsValid);
        }




        private void ConvertFileOldCode()
        {
            // Create MOTO File
            //bool ConvertOK = ConvertFileToMotorolaFormat(SrcFile, false);
            //string MotoFile = MOTO_FOLDER + oPartNumberForm.PartNumber.Trim() + MOTO_EXTENSION;

            //// Copy MOTO File to CMS.DAT in CALS Folder
            //if (ConvertOK && File.Exists(MotoFile))
            //{
            //    File.Copy(MotoFile, CMS_FILE, true);
            //    if (File.Exists(CMS_FILE))
            //    {

            //        // Copy partno file to PARTNUM.TXT File in CALS Folder
            //        string PartFile = SOURCE_FOLDER + oPartNumberForm.PartNumber.Trim() + PARTNO_EXTENSION;
            //        if (File.Exists(PartFile))
            //        {
            //            File.Copy(PartFile, PART_FILE, true);
            //            this.ReadPartNumberFile();
            //        }
            //        else
            //        {
            //            // The partno file does not exist - create PARTNUM.TXT File in CALS Folder
            //            //this.CreatePartNumberFile(oPartNumberForm.PartNumber.Trim(), oPartNumberForm.PartNumber.Trim());
            //            MessageBox.Show("The PartNumber file for the part was not found.", "Please Locate this file before proceeding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //        }

            //        // Load to Programmer
            //        if (this.LoadMotorolaFormat(CMS_FILE) == true)
            //        {
            //            // Update main form Part Number
            //            textPartNumber.Text = oPartNumberForm.PartNumber.Trim();
            //            textKitNumber.Text = oPartNumberForm.PartNumber.Trim();
            //            LogEvent("Loaded Part", "Loaded Part Number '" + textPartNumber.Text + "'");

            //            // Load the checksum file
            //            string ChecksumFile = SOURCE_FOLDER + oPartNumberForm.PartNumber.Trim() + CHECKSUM_EXTENSION;
            //            if (File.Exists(ChecksumFile))
            //            {
            //                string[] chk = File.ReadAllLines(ChecksumFile);
            //                LogEvent("Check-sum", chk[1]);
            //            }

            //            IsValid = true;
            //        }
            //    }
            //    else
            //        MessageBox.Show("Error copying motorola format file to " + CMS_FILE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //}
            //else MessageBox.Show("Unable to convert to Motorola format.", "Invalid Source File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
         }
        #endregion
    }
}