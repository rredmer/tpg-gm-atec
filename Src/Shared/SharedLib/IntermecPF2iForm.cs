using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using SharedLib;

namespace SharedLib
{
    public partial class IntermecPF2iForm : Form
    {
        public bool IsConnected = false;
        public bool IsSerial = false;
        public bool ExitFlag = false;
        private string sPrinterAddress = string.Empty;
        private int iPrinterPort = 0;
        private TcpClient oTcpClient = new TcpClient();
        private string sInput = string.Empty;
        private AppLogForm oAppLogForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntermecPF2iForm"/> class.
        /// </summary>
        public IntermecPF2iForm(AppLogForm logfrm)
        {
            InitializeComponent();
            oAppLogForm = logfrm;
        }

        /// <summary>
        /// Handles the KeyDown event of the textSendMessage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyEventArgs"/> instance containing the event data.</param>
        private void textSendMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.WriteString(this.textSendMessage.Text);
                this.textSendMessage.Text = "";
                e.Handled = true;
            }
        }

        /// <summary>
        /// Connects the specified TCP/IP address.
        /// </summary>
        /// <param name="sAddress">The TCP/IP address.</param>
        /// <param name="iPort">The TCP/IP port.</param>
        /// <returns></returns>
        public bool Connect(string sAddress, int iPort)
        {
            if (IsSerial)
            {
                try
                {
                    this.labelPrinterAddress.Text = this.serialPortCom.PortName;
                    this.Text = "Intermec PF2i Printer on " + this.labelPrinterAddress.Text;
                    serialPortCom.Open();
                    IsConnected = true;
                }
                catch (Exception ex) { oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error opening com port: " + ex.Message); }
            }
            else
            {
                sPrinterAddress = sAddress;
                iPrinterPort = iPort;
                this.labelPrinterAddress.Text = string.Format("{0},Port={1}", sAddress, iPort);
                this.Text = "Intermec PF2i Printer on " + this.labelPrinterAddress.Text;
                oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Connecting to Intermec Printer on " + this.labelPrinterAddress.Text);
                IsConnected = false;
                try
                {
                    oTcpClient.Connect(sPrinterAddress, iPrinterPort);
                    IsConnected = true;
                    this.labelPrinterStatus.Text = "Connected.";
                }
                catch (Exception ex) { oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Connect Error " + ex.Message); }
            }
            return (IsConnected);
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
        /// Handles the Click event of the buttonClearHistory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            this.textMessages.Text = "";
        }

        /// <summary>
        /// Handles the Load event of the IntermecPF2iForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void IntermecPF2iForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!IsSerial)
            {
                if (oTcpClient.Available > 0)
                {
                    try
                    {
                        byte[] test = new byte[oTcpClient.Available];
                        oTcpClient.GetStream().Read(test, 0, oTcpClient.Available);
                        this.textMessages.Text += Encoding.ASCII.GetString(test, 0, test.Length);
                    }
                    catch (Exception ex) { oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Receive Error " + ex.Message); }
                }
            }
        }

        /// <summary>
        /// Writes the string.
        /// </summary>
        /// <param name="Msg">The MSG.</param>
        /// <returns></returns>
        public bool WriteString(string Msg)
        {
            bool IsOK = false;
            try
            {
                if (IsSerial)
                {
                    this.serialPortCom.Write(Msg + Environment.NewLine);
                }
                else
                {
                    oTcpClient.GetStream().Write(Encoding.ASCII.GetBytes(Msg + Environment.NewLine), 0, Msg.Length + 2);
                    oTcpClient.GetStream().Flush();
                }
                IsOK = true;
            }
            catch (Exception ex) { oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "WriteString Error " + ex.Message); }
            return (IsOK);
        }

        /// <summary>
        /// Writes the bytes.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns></returns>
        public bool WriteBytes(byte[] bytes)
        {
            bool IsOK = false;
            try
            {
                if (IsSerial)
                {
                    this.serialPortCom.Write(bytes, 0, bytes.Length);
                }
                else
                {
                    oTcpClient.GetStream().Write(bytes, 0, bytes.Length);
                    oTcpClient.GetStream().Flush();
                }
                IsOK = true;
            }
            catch (Exception ex) { oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "WriteBytes Error " + ex.Message); }
            return (IsOK);
        }

        /// <summary>
        /// Prints the small labels
        ///     procedure prsmall(x:integer);
        ///         write(lptx^,#13,#27,#73,#2,#18,#15,#27,#71);
        ///         LocalDelay(200);
        ///         for y:=1 to 2 do
        ///             write(lptx^,' ',part.second,'          ');
        ///         writeln(lptx^,'');
        ///         writeln(lptx^,'');
        ///         writeln(lptx^,#18);
        ///         LocalDelay(200);
        /// </summary>
        /// <returns></returns>
        public void PrintSmall(string PartID)
        {
            if (IsConnected)
            {
                WriteBytes(new byte[] { 13, 27, 73, 2, 18, 15, 27, 71 });
                Thread.Sleep(200);
                for (int RepeatCount=0; RepeatCount<2 ; RepeatCount++)
                    WriteString(" " + PartID + "           ");
                WriteString("");
                WriteString("");
                WriteBytes(new byte[] {18});
                Thread.Sleep(200);
            }
        }

        /// <summary>
        /// Prints the Large labels
        ///     procedure prlarge(x:integer);
        ///         write(lptx^,#13,#27,#58,#27,#73,#1,#27,#72);LocalDelay(200);
        ///         for z:=1 to 15 do
        ///             write(lptx^,'                 ELECTRONIC CNTRL UNIT');
        ///             for y:=1 to 39 do write(lptx^,#8);
        ///         writeln(lptx^,'');
        ///         for z:=1 to 15 do
        ///             write(lptx^,'                 ASSEMBLY NO: ',part.first);
        ///             for y:=1 to 39 do write(lptx^,#8);
        ///         writeln(lptx^,'');
        ///         for z:=1 to 15 do
        ///             write(lptx^,'                 SERVICE KIT: ',part.second);
        ///         for y:=1 to 39 do
        ///             write(lptx^,#8);
        ///         writeln(lptx^,'');
        ///         for y:=1 to 9 do writeln(lptx^,'');
        ///         LocalDelay(200);
        /// </summary>
        /// <returns></returns>
        public void PrintLarge(string PartID1, string PartID2)
        {
            if (IsConnected)
            {
                WriteBytes(new byte[] { 13, 27, 58, 27, 73, 1, 27, 72 });
                Thread.Sleep(200);
                for (int RepeatCount = 0; RepeatCount < 15; RepeatCount++)
                {
                    WriteString("                 ELECTRONIC CNTRL UNIT");
                    for (int LineChar = 0; LineChar < 39; LineChar++) WriteBytes(new byte[] { 8 });
                }
                WriteString("");
                for (int RepeatCount = 0; RepeatCount < 15; RepeatCount++)
                {
                    WriteString("                 ASSEMBLY NO: " + PartID1);
                    for (int LineChar = 0; LineChar < 39; LineChar++) WriteBytes(new byte[] { 8 });
                }
                WriteString("");
                for (int RepeatCount = 0; RepeatCount < 15; RepeatCount++)
                {
                    WriteString("                 SERVICE KIT: " + PartID2);
                    for (int LineChar = 0; LineChar < 39; LineChar++) WriteBytes(new byte[] { 8 });
                }
                WriteString("");
                for (int RepeatCount = 0; RepeatCount < 9; RepeatCount++)
                    WriteString("");
                Thread.Sleep(200);
            }
        }

        private void buttonPrintLarge_Click(object sender, EventArgs e)
        {
            this.PrintLarge("TEST", "TEST");
        }

        private void buttonSmallLabel_Click(object sender, EventArgs e)
        {
            this.PrintSmall("TEST");
        }

    }
}

