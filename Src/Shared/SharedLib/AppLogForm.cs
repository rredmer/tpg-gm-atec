using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SharedLib
{
    public partial class AppLogForm : Form
    {
        #region Declarations
        public const long MAXLENGTH = (1024 * 1024) * 10;
        public enum LogLevel { Info, Warn, Error, Debug }
        public bool IsErrorMode = false;
        public string LogFolder = string.Empty;
        public string LogFileName = string.Empty;
        public string LogFolderUsb = string.Empty;
        public string LogFileNameUsb = string.Empty;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="AppLogForm"/> class.
        /// </summary>
        public AppLogForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        /// <summary>
        /// Handles the Load event of the AppLogForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AppLogForm_Load(object sender, EventArgs e)
        {
            LogWrite(LogLevel.Debug, "Loading application log form.");
        }
        /// <summary>
        /// Handles the Activated event of the AppLogForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AppLogForm_Activated(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader rdr = new StreamReader(LogFileName))
                {
                    this.textBoxAppLog.Text = rdr.ReadToEnd();
                }
            }
            catch { ;}
        }
        /// <summary>
        /// Handles the Click event of the buttonExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// Handles the Click event of the buttonClearLogFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonClearLogFile_Click(object sender, EventArgs e)
        {
            this.ClearLogFiles();
        }
        /// <summary>
        /// Handles the Click event of the buttonClearErrorMode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonClearErrorMode_Click(object sender, EventArgs e)
        {
            this.IsErrorMode = false;
            this.labelErrorMode.Visible = false;
        }        
        #endregion

        #region Public Methods
        /// <summary>
        /// Gets the name of the log file.
        /// </summary>
        /// <param name="Folder">The folder.</param>
        public void GetLogFileName(string Folder)
        {
            LogFolder = Folder;
            LogFileName = Folder + "\\AppLog_" + (DateTime.Now.ToString("yyyy-MM-ddTHHmmss") + ".txt");
        }
        /// <summary>
        /// Gets the log file name usb.
        /// </summary>
        /// <param name="Folder">The folder.</param>
        public void GetLogFileNameUsb(string Folder)
        {
            LogFolderUsb = Folder;
            LogFileNameUsb = Folder + "\\AppLog_" + (DateTime.Now.ToString("yyyy-MM-ddTHHmmss") + ".txt");
        }
        /// <summary>
        /// Logs the write.
        /// </summary>
        /// <param name="lvl">The LVL.</param>
        /// <param name="msg">The MSG.</param>
        /// <returns></returns>
        public bool LogWrite(LogLevel lvl, string msg)
        {
            if (lvl == LogLevel.Error)
            {
                this.labelErrorMode.Visible = true;
                IsErrorMode = true;
            }
            if (LogFolder == string.Empty) return false;
            try
            {
                using (StreamWriter wrt = new StreamWriter(LogFileName, true))
                {
                    wrt.WriteLine("{0:s} {1,5} {2}", DateTime.Now, lvl, msg);
                }
                FileInfo nfo = new FileInfo(LogFileName);
                if (nfo.Length > MAXLENGTH) RollLogFile();
            }
            catch { ;}
            if (LogFolderUsb == string.Empty) return false;
            try
            {
                using (StreamWriter wrt = new StreamWriter(LogFileNameUsb, true))
                {
                    wrt.WriteLine("{0:s} {1,5} {2}", DateTime.Now, lvl, msg);
                }
                FileInfo nfo = new FileInfo(LogFileNameUsb);
                if (nfo.Length > MAXLENGTH) RollLogFile();
            }
            catch { ;}
            return true;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Rolls the log file.
        /// </summary>
        private void RollLogFile()
        {
            GetLogFileName(LogFolder);
            if (LogFileNameUsb != string.Empty) GetLogFileNameUsb(LogFolderUsb);
        }
        /// <summary>
        /// Clears the log files.
        /// </summary>
        /// <returns></returns>
        private bool ClearLogFiles()
        {
            try
            {
                DirectoryInfo nfo = new DirectoryInfo(LogFolder);
                foreach (FileInfo fil in nfo.GetFiles("AppLog*.txt"))
                    if (fil.Name != LogFileName) fil.Delete();
            }
            catch { ;}
            return (true);
        }
        #endregion
    }
}