/******************************************************
                WIA Scripting sample
		      netmaster@swissonline.ch
*******************************************************/
//					MainForm
// This is the main form of the sample application

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

using WIALib;		// namespace of imported WIA Scripting COM component


namespace WiaEasyImage
{
	/// <summary> MainForm for this WIA sample </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuTopFile;
		private System.Windows.Forms.MenuItem menuFileAcquire;
		private System.Windows.Forms.MenuItem menuFileSaveAs;
		private System.Windows.Forms.MenuItem menuFileSep1;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.PictureBox pictureBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				DisposeImage();
				
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuTopFile = new System.Windows.Forms.MenuItem();
			this.menuFileAcquire = new System.Windows.Forms.MenuItem();
			this.menuFileSaveAs = new System.Windows.Forms.MenuItem();
			this.menuFileSep1 = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuTopFile});
			// 
			// menuTopFile
			// 
			this.menuTopFile.Index = 0;
			this.menuTopFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuFileAcquire,
																						this.menuFileSaveAs,
																						this.menuFileSep1,
																						this.menuFileExit});
			this.menuTopFile.Text = "&File";
			// 
			// menuFileAcquire
			// 
			this.menuFileAcquire.Index = 0;
			this.menuFileAcquire.Text = "Acquire...";
			this.menuFileAcquire.Click += new System.EventHandler(this.menuFileAcquire_Click);
			// 
			// menuFileSaveAs
			// 
			this.menuFileSaveAs.Enabled = false;
			this.menuFileSaveAs.Index = 1;
			this.menuFileSaveAs.Text = "Save &As...";
			this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
			// 
			// menuFileSep1
			// 
			this.menuFileSep1.Index = 2;
			this.menuFileSep1.Text = "-";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 3;
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(8, 8);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(488, 357);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(520, 377);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pictureBox});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu;
			this.MinimumSize = new System.Drawing.Size(256, 256);
			this.Name = "MainForm";
			this.Text = "WIA Easy Image";
			this.ResumeLayout(false);

		}
		#endregion

	/// <summary> The main entry point for the application. </summary>
	[STAThread]
	static void Main() 
	{
		Application.Run(new MainForm());
	}

	private void menuFileExit_Click( object sender, System.EventArgs e )
	{
		Close();
	}

	private void menuFileAcquire_Click( object sender, System.EventArgs e )
	{
		WiaClass		wiaManager	= null;		// WIA manager COM object
		CollectionClass	wiaDevs		= null;		// WIA devices collection COM object
		ItemClass		wiaRoot		= null;		// WIA root device COM object
		CollectionClass	wiaPics		= null;		// WIA collection COM object
		ItemClass		wiaItem		= null;		// WIA image COM object
		
		try {
			wiaManager = new WiaClass();		// create COM instance of WIA manager

			wiaDevs = wiaManager.Devices as CollectionClass;			// call Wia.Devices to get all devices
			if( (wiaDevs == null) || (wiaDevs.Count == 0) )
			{
				MessageBox.Show( this, "No WIA devices found!", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
				Application.Exit();
				return;
			}
			
			object selectUsingUI = System.Reflection.Missing.Value;			// = Nothing
			wiaRoot = (ItemClass) wiaManager.Create( ref selectUsingUI );	// let user select device
			if( wiaRoot == null )											// nothing to do
				return;

			// this call shows the common WIA dialog to let the user select a picture:
			wiaPics = wiaRoot.GetItemsFromUI( WiaFlag.SingleImage, WiaIntent.ImageTypeColor ) as CollectionClass;
			if( wiaPics == null )
				return;

			bool takeFirst = true;						// this sample uses only one single picture
			foreach( object wiaObj in wiaPics )			// enumerate all the pictures the user selected
			{
				if( takeFirst )
				{
					DisposeImage();						// remove previous picture
					wiaItem = (ItemClass) Marshal.CreateWrapperOfType( wiaObj, typeof(ItemClass) );
					imageFileName = Path.GetTempFileName();				// create temporary file for image
					Cursor.Current = Cursors.WaitCursor;				// could take some time
					this.Refresh();
					wiaItem.Transfer( imageFileName, false );			// transfer picture to our temporary file
					pictureBox.Image = Image.FromFile( imageFileName );	// create Image instance from file
					menuFileSaveAs.Enabled = true;						// enable "Save as" menu entry
					takeFirst = false;									// first and only one done.
				}
				Marshal.ReleaseComObject( wiaObj );					// release enumerated COM object
			}
		}
		catch( Exception ee ) {
			MessageBox.Show( this, "Acquire from WIA Imaging failed\r\n" + ee.Message, "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			Application.Exit();
		}
		finally {
			if( wiaItem != null )
				Marshal.ReleaseComObject( wiaItem );		// release WIA image COM object
			if( wiaPics != null )
				Marshal.ReleaseComObject( wiaPics );		// release WIA collection COM object
			if( wiaRoot != null )
				Marshal.ReleaseComObject( wiaRoot );		// release WIA root device COM object
			if( wiaDevs != null )
				Marshal.ReleaseComObject( wiaDevs );		// release WIA devices collection COM object
			if( wiaManager != null )
				Marshal.ReleaseComObject( wiaManager );		// release WIA manager COM object
			Cursor.Current = Cursors.Default;				// restore cursor
		}
	}

		/// <summary> User selected menu entry to save image. </summary>
	private void menuFileSaveAs_Click( object sender, System.EventArgs e )
	{
		if( pictureBox.Image == null )				// no bitmap exists
			return;

		SaveFileDialog sd = new SaveFileDialog();
		sd.Title = "Save Image As...";
		sd.FileName = "WIAEasyImageFile.bmp";
		sd.Filter = "Bitmap file (*.bmp)|*.bmp";	// bmp bitmap file format
		if( sd.ShowDialog() != DialogResult.OK )
			return;

		pictureBox.Image.Save( sd.FileName );		// save to file
	}


		/// <summary> Remove image from screen, dispose object and delete the temporary file. </summary>
	private void DisposeImage()
	{
		menuFileSaveAs.Enabled = false;				// disable "Save As" menu entry
		Image oldImg = pictureBox.Image;
		pictureBox.Image = null;					// empty picture box
		if( oldImg != null )
			oldImg.Dispose();						// dispose old image (free memory, unlock file)

		if( imageFileName != null ) {				// try to delete the temporary image file
			try {
				File.Delete( imageFileName );
			}
			catch( Exception )
			{ }
		}
	}


									/// <summary> temporary image file. </summary>
	private string			imageFileName;
}

}
