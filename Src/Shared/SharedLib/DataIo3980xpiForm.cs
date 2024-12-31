#region Comments
//function dofunc (port:word; st:string):boolean;
//var ptr,failed,total : integer;
//    c   : char;  (* the throw away key pressed value *)
//    ch  : char;  (* the echoed value if any from the programmer *)
//    valid: boolean;
//    st1,st2 : string;
//    loops : integer;
//begin
//  dofunc:=false;
//  while (keypressed) do c:=readkey;
//  case st[1] of
//    'P':  begin
//            writecom(port,'5C24@');
//            valid:=waitforready(port,100);
//            writecom(port,'P');
//            repeat
//              genericbool := ComInReady(Port);
//            until (genericbool) ;
//            GetReplyString (Port);
//            if pos('>',ReplyString) > 0
//              then
//                dofunc := true
//              else
//                dofunc := false;
//          end;
//    'F':  begin
//            writecom(port,'FF^');
//          end;
//    'S':  begin
//            dofunc := dochecksum(Port);
//          end;
//    '/':  begin
//            writecom(port,st);
//            maxattempts := 300000;
//            attempts := 0;
//            repeat
//              genericbool := ComInReady(Port);
//              delay (1);
//              inc (attempts);
//            until (genericbool) or (attempts > maxattempts);
//            GetReplyString (Port);
//            if length (replystring) = 7
//              then
//                begin
//                  tempstr := copy (replystring,1,2);
//                  val (tempstr,DevicesFailed,code);
//                  tempstr := copy (replystring,4,2);
//                  val (tempstr,DevicesTested,code);
//                  DevicesPassed := DevicesTested-DevicesFailed;
//                end
//              else
//                begin
//                  DevicesTested := 0;
//                  DevicesPassed := 0;
//                  DevicesFailed := 0;
//                end;
//            Failed := DevicesFailed;
//            total := DevicesTested;
//            current.testedproms:=current.testedproms+total;
//            current.goodproms:=current.goodproms+(total-failed);
//          end;
//    'B':  begin
//            maxattempts := 500000;
//            attempts := 0;
//            writecom(port,st);
//            repeat
//              genericbool := cominready(port);
//              delay (1);
//              inc (attempts);
//            until (genericbool) or (attempts > maxattempts) ;
//            getreplystring (Port);
//            if pos('>',replystring) > 0
//              then
//                dofunc := true
//              else
//                dofunc := false;
//          end;
//    'I':  begin
//            writecom(port,'082A');  (* set programmer to S1 format *)
//            LocalDelay(100);
//            c:=ComInChar(port);
//            writecom(port,'I');
//            LocalDelay(50);
//            if cominready(port)
//              then
//                c:=ComInChar(port);
//          end;
//    else
//          if not waitforready(port,100)
//            then
//              begin
//                writeln('Programmer on COM',port+1,': not responding.');
//                writeln('Prev char, Last Char ',integer(PrevInCh),
//                         ' ',integer (LastInCh));
//                waitkey(3000);
//                blop;
//                dofunc := false;
//              end
//            else
//              begin
//                writecom(port,st);
//                maxattempts := 30000;
//                attempts := 0;
//                repeat
//                  genericbool := cominready(port);
//                  inc (attempts);
//                until (genericbool) or (attempts > maxattempts);
//                getreplystring(port);
//                if pos('>',replystring) > 0
//                  then
//                    genericbool := true
//                  else
//                    genericbool := false;
//                dofunc:=genericbool;
//              end;
//  end;  (* case *)
//end;
//function dochecksum (Port: word) : boolean;
//var
//  ch : char;
//  loops : integer;
//  genericbool : boolean;
//begin
//  writecom(Port,'S');
//  maxattempts := 500000;
//  attempts := 0;
//  repeat
//    genericbool := cominready(port);
//    delay (1);
//    inc (attempts);
//  until (genericbool) or (attempts > maxattempts);
//  getreplystring (port);
//  promcheck[port+1] := '';
//  highbyte := '';
//  if pos('>',replystring) = 7
//    then
//      begin
//        highbyte := replystring[1] + replystring[2];
//        promcheck[port+1] := replystring[3] + replystring[4] + replystring[5] + replystring[6];
//        genericbool := true;
//      end
//    else
//      begin
//        genericbool := false;
//      end;
//  dochecksum := genericbool;
//end;
//function waitforready(port:word;count:longint):boolean;
//var
//  replyfound : boolean;
//begin
//  ReplyFound := false;
//  repeat
//    GetReplyString (port);
//    if LastInCh in ['>','?','F',char(#13)]
//      then
//        replyFound := true
//      else
//        begin
//          writecom(port,'H');
//          localdelay (10);
//        end;
//  until replyFound;
//  waitforready := replyfound;
//end;

#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SharedLib;

namespace SharedLib
{
    public partial class DataIo3980xpiForm : Form
    {
        public string      DeviceType       = string.Empty;
        public bool        IsConnected      = false;
        public bool        IsTimedOut       = true;
        private AppLogForm oAppLogForm;
        private string     RcvBuffer        = string.Empty;
        public string      strGoodsFailures = string.Empty;
 
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="DataIo3980xpiForm"/> class.
        /// </summary>
        public DataIo3980xpiForm(AppLogForm logfrm)
        {
            InitializeComponent();
            oAppLogForm = logfrm;
        }
        #endregion

        #region Events
        /// <summary>
        /// Handles the Load event of the DataIo3980xpiForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void DataIo3980xpiForm_Load(object sender, EventArgs e)
        {
            // Initialize form controls if necessary
            textMessages.Text = "Initialized" + Environment.NewLine;
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Loading DataIo3980xpiForm");
        }

        /// <summary>
        /// Handles the Click event of the buttonExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "User exit of DataIo3980xpiForm");
            this.Hide();
        }

        /// <summary>
        /// Handles the Click event of the buttonClearHistory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Clearing history.");
            this.textMessages.Text = "";
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
                SendCommand();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonSendCommand control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSendCommand_Click(object sender, EventArgs e)
        {
            SendCommand();
        }

        /// <summary>
        /// Handles the Click event of the buttonGetSettings control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonGetSettings_Click(object sender, EventArgs e)
        {
            GetSettings();
        }

        /// <summary>
        /// Handles the Click event of the buttonGetErrors control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonGetErrors_Click(object sender, EventArgs e)
        {
            GetErrors();
        }

        /// <summary>
        /// Handles the Click event of the buttonGetCheckSum control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonGetCheckSum_Click(object sender, EventArgs e)
        {
            Checksum();
        }

        /// <summary>
        /// Handles the Click event of the buttonDeviceCheck control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonDeviceCheck_Click(object sender, EventArgs e)
        {
            DeviceCheck();
        }

        /// <summary>
        /// Handles the Click event of the buttonBlankCheck control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonBlankCheck_Click(object sender, EventArgs e)
        {
            BlankCheck();
        }

        /// <summary>
        /// Handles the Click event of the buttonBitTest control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonBitTest_Click(object sender, EventArgs e)
        {
            BitTest();
        }

        /// <summary>
        /// Handles the Click event of the buttonVerify control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonVerify_Click(object sender, EventArgs e)
        {
            VerifyEPROM();
        }

        /// <summary>
        /// Handles the Click event of the buttonGetDeviceStatus control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonGetDeviceStatus_Click(object sender, EventArgs e)
        {
            GetDeviceStatus();
        }

        /// <summary>
        /// Handles the Click event of the buttonGetConfiguration control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonGetConfiguration_Click(object sender, EventArgs e)
        {
            GetConfiguration();
        }

        /// <summary>
        /// Handles the Click event of the buttonProgramDevice control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonProgramDevice_Click(object sender, EventArgs e)
        {
            ProgramEPROM();
        }

        /// <summary>
        /// Handles the Click event of the buttonLoadFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonLoadFile_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the DataReceived event of the serialPortCom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.IO.Ports.SerialDataReceivedEventArgs"/> instance containing the event data.</param>
        private void serialPortCom_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Use this event to process asynch messages.
            // Warning - this did not work very well in testing, it did not fire consistently.
        }

        /// <summary>
        /// Handles the ErrorReceived event of the serialPortCom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.IO.Ports.SerialErrorReceivedEventArgs"/> instance containing the event data.</param>
        private void serialPortCom_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            // Error
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "serialPortCom_ErrorReceived event=" + e.EventType.ToString());
        }

        /// <summary>
        /// Handles the PinChanged event of the serialPortCom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.IO.Ports.SerialPinChangedEventArgs"/> instance containing the event data.</param>
        private void serialPortCom_PinChanged(object sender, System.IO.Ports.SerialPinChangedEventArgs e)
        {
            // This routine never fires...
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "serialPortCom_ErrorReceived event=" + e.EventType.ToString());
        }

        /// <summary>
        /// Handles the Click event of the buttonSendEsc control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonSendEsc_Click(object sender, EventArgs e)
        {
            CancelCommand();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Connects this instance.
        /// </summary>
        /// <returns></returns>
        public bool Connect()
        {
            this.Text = "DataIO 3980xpi on " + serialPortCom.PortName;
            IsConnected = false;
            try
            {
                serialPortCom.Open();
                IsConnected = true;
            }
            catch (Exception ex) { oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error opening com port: " + ex.Message); }
            return IsConnected;
        }

        /// <summary>
        /// Sends the command.
        /// </summary>
        private void SendCommand()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Sending user command: " + textSendMessage.Text);
            serialPortCom.Write(new byte[] { 27 }, 0, 1);
            Thread.Sleep(100);
            this.WaitForReady(100);
            this.ComWrite(textSendMessage.Text);
            Thread.Sleep(100);
            this.textSendMessage.Text = "";
            WaitForReady(500);
        }

        /// <summary>
        /// Write to the serial communications port
        /// </summary>
        /// <param name="outbuf">The output buffer to send.</param>
        /// <returns></returns>
        public bool ComWrite(string outbuf)
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Sending command: " + outbuf);
            bool IsOK = false;
            try
            {
                RcvBuffer = "";
                serialPortCom.Write(outbuf + "\r");
                this.textMessages.AppendText(outbuf + Environment.NewLine);
                IsOK = true;
            }
            catch (Exception ex) { oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error writing com port: " + ex.Message); }
            return IsOK;
        }

        /// <summary>
        /// Waits for ready.
        /// </summary>
        /// <param name="TimeOut">The time out.</param>
        /// <returns></returns>
       public bool WaitForReady(int TimeOut)
        {
           bool IsOK = false;
           int lTimer = 0;
           RcvBuffer = string.Empty;
           try
           {
              while (!IsOK && (lTimer < TimeOut))
              {
                 if (serialPortCom.BytesToRead > 0)
                    RcvBuffer += serialPortCom.ReadExisting();
                 if (RcvBuffer.Contains(">") || RcvBuffer.Contains("?") || RcvBuffer.Contains("F") || RcvBuffer.Contains("\r"))
                 {
                    oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Received " + RcvBuffer);
                    IsOK = true;
                    IsTimedOut = false;
                 }
                 else
                 {
                    // ComWrite("H");          // Send NO-OP
                 }
                 lTimer++;
                 Thread.Sleep(10);           // Wait 10ms

              }
              if (RcvBuffer.Length > 0)
              {
                 if (this.textMessages.Text.Length > 4096) this.textMessages.Text = "";
                 this.textMessages.AppendText(RcvBuffer + Environment.NewLine);
                 this.textMessages.ScrollToCaret();
              }
              if (lTimer == TimeOut)
              {
                 this.textMessages.AppendText("Timed out.  Check communications." + Environment.NewLine);
                 oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Timed out.  Check communications.");
                 IsTimedOut = true;
              }
           }
           catch (Exception ex)
           {
              oAppLogForm.LogWrite(AppLogForm.LogLevel.Error, "Error reading com port: " + ex.Message);
           }
           return (IsOK);
        }

        /// <summary>
        /// Retrieves the checksum from the EEPROM.
        /// </summary>
        /// <returns></returns>
        public string Checksum()
        {
            string chk = string.Empty;
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Reading checksum...");
            this.labelCheckSum.Text = "";
            this.ComWrite("S");
            Thread.Sleep(200);
            if (WaitForReady(900))
            {
                chk = RcvBuffer;
                this.labelCheckSum.Text = chk;
            }
            return (chk);
        }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        public void GetSettings()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Getting settings...");
            this.labelSettings.Text = "";
            this.ComWrite("01]");
            Thread.Sleep(100);
            if (WaitForReady(500))
            {
                this.labelSettings.Text = RcvBuffer;
            }
        }

        /// <summary>
        /// Devices the check.
        /// </summary>
        public void DeviceCheck()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Checking Device...");
            this.labelDeviceCheck.Text = "";
            this.ComWrite("DC]");
            Thread.Sleep(100);
            if (WaitForReady(500))
            {
                this.labelDeviceCheck.Text = RcvBuffer;
            }
        }

        /// <summary>
        /// Gets the errors.
        /// </summary>
        public void GetErrors()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Getting Errors...");
            this.labelErrors.Text = "";
            this.ComWrite("X");
            Thread.Sleep(100);
            if (WaitForReady(500))
            {
                this.labelErrors.Text = RcvBuffer;
            }
        }

        /// <summary>
        /// Blanks the check.
        /// </summary>
        public void BlankCheck()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Blank Check...");
            this.labelBlankCheck.Text = "";
            this.ComWrite("B");
            Thread.Sleep(100);
            if (WaitForReady(500))
            {
                this.labelBlankCheck.Text = RcvBuffer;
            }
        }

        /// <summary>
        /// Bits the test.
        /// </summary>
        public void BitTest()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Bit Test...");
            this.labelBitTest.Text = "";
            this.ComWrite("T");
            Thread.Sleep(100);
            if (WaitForReady(500))
            {
                this.labelBitTest.Text = RcvBuffer;
            }
        }

        /// <summary>
        /// Verifies the EPROM.
        /// </summary>
        public string VerifyEPROM()
        {
            string vfy = string.Empty;
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Verifying EPROM...");
            this.labelVerify.Text = "";
            this.ComWrite("V");
            Thread.Sleep(100);
            if (WaitForReady(500))
            {
                vfy = RcvBuffer;
                this.labelVerify.Text = vfy;
            }
            return (vfy);
        }

        /// <summary>
        /// Gets the device status.
        /// </summary>
        public void GetDeviceStatus()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Getting device status...");
            this.labelDeviceStatus.Text = "";
            this.ComWrite("R");
            Thread.Sleep(100);
            if (WaitForReady(500))
            {
                this.labelDeviceStatus.Text = RcvBuffer;
            }
        }

        /// <summary>
        /// Gets the device status.
        /// </summary>
        public string GetFailedCount()
        {
           string strGoodsFailures = string.Empty;

           strGoodsFailures = "F";
           oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Getting number of goods/failures...");
           this.labelDeviceStatus.Text = "";
           this.ComWrite("/");
           Thread.Sleep(100);
           if (WaitForReady(500))
           {
              strGoodsFailures = RcvBuffer;
              oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, strGoodsFailures);
           }

           return (strGoodsFailures);
        }

        /// <summary>
        /// Programs the EPROM.
        /// </summary>
        public void ProgramEPROM()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Programming Device...");
            this.labelProgramDevice.Text = "";

            // Set device type
            //            writecom(port,'5C24@');
            //            valid:=waitforready(port,100);
            if (DeviceType.Contains(":"))
            {
                this.ComWrite(DeviceType.Substring(0, DeviceType.IndexOf(":")) + "33]");
                WaitForReady(100);
                this.ComWrite(DeviceType.Substring(DeviceType.IndexOf(":")+1) + "34]");
                WaitForReady(100);
            }
            else
            {
                this.ComWrite(DeviceType.Trim() + "@");         // Ex. 5C24@
                WaitForReady(100);
            }

          
            this.ComWrite("P");
            Thread.Sleep(100);
            if (WaitForReady(1400))
            {
                this.labelProgramDevice.Text = RcvBuffer;
            }
            // DG:  Need to check current code to see how response is handled, i.e. how do we know the
            // chip is programmed - we need to loop in the main burn routine (ProgramEpromForm) to check on status
        }

        /// <summary>
        /// Gets the configuration from the programmer.
        /// </summary>
        public void GetConfiguration()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Getting Configuration...");
            this.labelConfiguration.Text = "";
            this.ComWrite("G");
            Thread.Sleep(100);
            if (WaitForReady(500))
            {
                this.labelConfiguration.Text = RcvBuffer;
            }
        }

        /// <summary>
        /// Cancels the command.
        /// </summary>
        public void CancelCommand()
        {
            oAppLogForm.LogWrite(AppLogForm.LogLevel.Info, "Sending comm cancel...");
            serialPortCom.Write(new byte[] { 27 }, 0, 1);
            Thread.Sleep(100);
            this.WaitForReady(100);
        }
        #endregion
    }
}