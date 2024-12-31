/******************************************************
                WIA Scripting sample
		      netmaster@swissonline.ch
*******************************************************/
//				   SelectDevice
// this is a custom dialog to let user select a WIA device

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using WIALib;

namespace WiaScriptSample
{
		/// <summary> SelectDevice is a custom dialog to let user select a WIA device. </summary>
	public class SelectDevice : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listDevs;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colType;
		private System.Windows.Forms.ColumnHeader colPort;
		private System.Windows.Forms.ColumnHeader colManufact;
		private System.Windows.Forms.ColumnHeader colID;
		private System.Windows.Forms.Button buttonOK;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;


		/// <summary> Prepare dialog to show all installed WIA devices. </summary>
		public SelectDevice( CollectionClass wiaDevs )
		{
			// Required for Windows Form Designer support
			InitializeComponent();
			
			listDevs.BeginUpdate();
			string[]	itemstrings = new string[ 5 ];
			try {
				foreach( Object wiaObj in wiaDevs )
				{
					DeviceInfoClass devInfo = (DeviceInfoClass) Marshal.CreateWrapperOfType( wiaObj, typeof(DeviceInfoClass) );
					Marshal.ReleaseComObject( wiaObj );
					itemstrings[0] = devInfo.Name;
					itemstrings[1] = devInfo.Type;
					itemstrings[2] = devInfo.Port;
					itemstrings[3] = devInfo.Manufacturer;
					itemstrings[4] = devInfo.Id;
					ListViewItem it = new ListViewItem( itemstrings );
					it.Tag = devInfo.Id;
					listDevs.Items.Add( it );
					Marshal.ReleaseComObject( devInfo ); devInfo = null;
				}

				// preselect top item in ListView
				listDevs.Items[0].Selected = true;
			}
			catch( Exception )
				{}
			listDevs.EndUpdate();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listDevs = new System.Windows.Forms.ListView();
			this.colName = new System.Windows.Forms.ColumnHeader();
			this.colType = new System.Windows.Forms.ColumnHeader();
			this.colPort = new System.Windows.Forms.ColumnHeader();
			this.colManufact = new System.Windows.Forms.ColumnHeader();
			this.colID = new System.Windows.Forms.ColumnHeader();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listDevs
			// 
			this.listDevs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.colName,
																					   this.colType,
																					   this.colPort,
																					   this.colManufact,
																					   this.colID});
			this.listDevs.Dock = System.Windows.Forms.DockStyle.Top;
			this.listDevs.FullRowSelect = true;
			this.listDevs.GridLines = true;
			this.listDevs.HideSelection = false;
			this.listDevs.MultiSelect = false;
			this.listDevs.Name = "listDevs";
			this.listDevs.Size = new System.Drawing.Size(530, 240);
			this.listDevs.TabIndex = 1;
			this.listDevs.View = System.Windows.Forms.View.Details;
			this.listDevs.DoubleClick += new System.EventHandler(this.buttonOK_Click);
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 160;
			// 
			// colType
			// 
			this.colType.Text = "Type";
			this.colType.Width = 108;
			// 
			// colPort
			// 
			this.colPort.Text = "Port";
			this.colPort.Width = 96;
			// 
			// colManufact
			// 
			this.colManufact.Text = "Manufacturer";
			this.colManufact.Width = 120;
			// 
			// colID
			// 
			this.colID.Text = "ID";
			this.colID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.colID.Width = 350;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(225, 256);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(80, 32);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// SelectDevice
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(530, 295);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonOK,
																		  this.listDevs});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectDevice";
			this.ShowInTaskbar = false;
			this.Text = "Select WIA Device";
			this.ResumeLayout(false);

		}
		#endregion


	private void buttonOK_Click(object sender, System.EventArgs e)
	{
		if( listDevs.SelectedItems.Count != 1 )
			return;
		ListViewItem	selitem = listDevs.SelectedItems[0];
		SelectedID = selitem.Tag as string;

		// exit this form
		Close();
	}


		/// <summary> Gets the device ID string of user selected device. </summary>
	public string SelectedID = null;
}


}
