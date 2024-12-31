/******************************************************
                WIA Scripting sample
		      netmaster@swissonline.ch
*******************************************************/
//					VideoForm
// This is the main form of the sample application

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

using WIALib;
using WIAVIDEOLib;

namespace WiaEasyVideo
{
	/// <summary> Main Form </summary>
	public class VideoForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panelVideo;
		private System.Windows.Forms.Splitter splitterVertical;
		private System.Windows.Forms.Panel panelPicture;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ToolBar toolBar;
		private System.Windows.Forms.ToolBarButton toolBtnPlay;
		private System.Windows.Forms.ToolBarButton toolBtnPause;
		private System.Windows.Forms.ToolBarButton toolBtnSnap;
		private System.Windows.Forms.ToolBarButton toolBtnSave;
		private System.Windows.Forms.ImageList imageListBtn;
		private System.ComponentModel.IContainer components;

		public VideoForm()
		{
			// Required for Windows Form Designer support
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				DisposePicure();
				if( wiaVideo != null )										// release any COM instances
					Marshal.ReleaseComObject( wiaVideo ); wiaVideo = null;
				if( wiaCamera != null )
					Marshal.ReleaseComObject( wiaCamera ); wiaCamera = null;
				if( wiaManager != null )
					Marshal.ReleaseComObject( wiaManager ); wiaManager = null;
					
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(VideoForm));
			this.panelVideo = new System.Windows.Forms.Panel();
			this.splitterVertical = new System.Windows.Forms.Splitter();
			this.panelPicture = new System.Windows.Forms.Panel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.toolBar = new System.Windows.Forms.ToolBar();
			this.toolBtnPlay = new System.Windows.Forms.ToolBarButton();
			this.toolBtnPause = new System.Windows.Forms.ToolBarButton();
			this.toolBtnSnap = new System.Windows.Forms.ToolBarButton();
			this.toolBtnSave = new System.Windows.Forms.ToolBarButton();
			this.imageListBtn = new System.Windows.Forms.ImageList(this.components);
			this.panelPicture.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelVideo
			// 
			this.panelVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelVideo.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelVideo.Location = new System.Drawing.Point(0, 40);
			this.panelVideo.Name = "panelVideo";
			this.panelVideo.Size = new System.Drawing.Size(296, 285);
			this.panelVideo.TabIndex = 1;
			this.panelVideo.Resize += new System.EventHandler(this.panelVideo_Resize);
			// 
			// splitterVertical
			// 
			this.splitterVertical.Location = new System.Drawing.Point(296, 40);
			this.splitterVertical.Name = "splitterVertical";
			this.splitterVertical.Size = new System.Drawing.Size(4, 285);
			this.splitterVertical.TabIndex = 2;
			this.splitterVertical.TabStop = false;
			// 
			// panelPicture
			// 
			this.panelPicture.AutoScroll = true;
			this.panelPicture.AutoScrollMargin = new System.Drawing.Size(8, 8);
			this.panelPicture.AutoScrollMinSize = new System.Drawing.Size(32, 32);
			this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelPicture.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.pictureBox});
			this.panelPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPicture.Location = new System.Drawing.Point(300, 40);
			this.panelPicture.Name = "panelPicture";
			this.panelPicture.Size = new System.Drawing.Size(276, 285);
			this.panelPicture.TabIndex = 3;
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(8, 8);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(56, 48);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// toolBar
			// 
			this.toolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					   this.toolBtnPlay,
																					   this.toolBtnPause,
																					   this.toolBtnSnap,
																					   this.toolBtnSave});
			this.toolBar.ButtonSize = new System.Drawing.Size(58, 36);
			this.toolBar.DropDownArrows = true;
			this.toolBar.ImageList = this.imageListBtn;
			this.toolBar.Name = "toolBar";
			this.toolBar.ShowToolTips = true;
			this.toolBar.Size = new System.Drawing.Size(576, 40);
			this.toolBar.TabIndex = 0;
			this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
			// 
			// toolBtnPlay
			// 
			this.toolBtnPlay.Enabled = false;
			this.toolBtnPlay.ImageIndex = 0;
			this.toolBtnPlay.Text = "Play";
			this.toolBtnPlay.ToolTipText = "Start playing the video stream";
			// 
			// toolBtnPause
			// 
			this.toolBtnPause.ImageIndex = 1;
			this.toolBtnPause.Text = "Pause";
			this.toolBtnPause.ToolTipText = "Freeze the video stream";
			// 
			// toolBtnSnap
			// 
			this.toolBtnSnap.ImageIndex = 2;
			this.toolBtnSnap.Text = "Snap";
			this.toolBtnSnap.ToolTipText = "Take still picture";
			// 
			// toolBtnSave
			// 
			this.toolBtnSave.Enabled = false;
			this.toolBtnSave.ImageIndex = 3;
			this.toolBtnSave.Text = "Save...";
			this.toolBtnSave.ToolTipText = "Save image as";
			// 
			// imageListBtn
			// 
			this.imageListBtn.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListBtn.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBtn.ImageStream")));
			this.imageListBtn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// VideoForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(576, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panelPicture,
																		  this.splitterVertical,
																		  this.panelVideo,
																		  this.toolBar});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(270, 150);
			this.Name = "VideoForm";
			this.Text = "WIA Easy Video";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.VideoForm_Closing);
			this.Activated += new System.EventHandler(this.VideoForm_Activated);
			this.panelPicture.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run( new VideoForm() );
		}


			/// <summary> Rised whenever this form was activated, check if it is the first time. </summary>
		private void VideoForm_Activated(object sender, System.EventArgs e)
		{
			if( ! firstActive )
			{
				firstActive = true;			// it is the first time..
				if( ! CreateCamera() )		// create WIA camera device
					{
					Application.Exit();
					return;
					}

				if( ! CreateVideo() )		// as the form is visible now, we can insert the video overlay
					Application.Exit();
			}
		}

			/// <summary> Rised whenever the video panel was resized. </summary>
		private void panelVideo_Resize(object sender, System.EventArgs e)
		{
			try {
				if( wiaVideo != null )
					wiaVideo.ResizeVideo( 0 );		// also resize the video overlay area
			} catch( Exception ) {}
		}


			/// <summary> Rised when this form is closing. </summary>
		private void VideoForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try {
				if( wiaVideo != null )
					wiaVideo.DestroyVideo();		// stop the video overlay stream
			} catch( Exception ) {}
		}




			/// <summary> Any toolbar button was clicked. </summary>
		private void toolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if( wiaVideo == null )
				return;

			switch( toolBar.Buttons.IndexOf(e.Button) )
			{
				case 0:										// Play
					toolBtnPlay.Enabled = false;
					toolBtnPause.Enabled = true;
					try {
						wiaVideo.Play();
					} catch( Exception ) {}
					break; 

				case 1:										// Pause
					toolBtnPause.Enabled = false;
					toolBtnPlay.Enabled = true;
					try {
						wiaVideo.Pause();
					} catch( Exception ) {}
					break; 

				case 2:										// Snap
					SnapPicture();
					break; 

				case 3:										// Save...
					SavePicture();
					break; 
				}
		
		}



			/// <summary> Find any WIA streaming video camera devices,
			/// ask user which to select if multiple are found </summary>
		private bool CreateCamera()
		{
			bool done = false;
			CollectionClass wiaDevs = null;
			DeviceInfoClass devInfo = null;
			
			try {
				wiaManager = new WiaClass();

				object foundID = null;
				int foundCount = 0;
				wiaDevs = wiaManager.Devices as CollectionClass;		// call Wia.Devices to get all devices
				if( wiaDevs != null )
				{
					foreach( object wiaObj in wiaDevs )
					{
						devInfo = (DeviceInfoClass) Marshal.CreateWrapperOfType( wiaObj, typeof(DeviceInfoClass) );
						Marshal.ReleaseComObject( wiaObj );
						if( devInfo.Type.IndexOf( "Video" ) > 0 )
						{
							foundID = devInfo.Id;
							foundCount++;
						}
						Marshal.ReleaseComObject( devInfo ); devInfo = null;
					}
				}
				if( foundCount < 1 )
				{
					MessageBox.Show( this, "no WIA video devices found!", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
					return false;
				}

				if( foundCount > 1 )
					foundID = System.Reflection.Missing.Value;
				wiaCamera = (ItemClass) wiaManager.Create( ref foundID );  // ask user if more then one video device
				done = wiaCamera != null;
				return done;
			}
			catch( Exception ) {
				MessageBox.Show( this, "Create WIA camera failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
				return false;
			}
			finally {
				if( devInfo != null )
					Marshal.ReleaseComObject( devInfo );
				if( wiaDevs != null )
					Marshal.ReleaseComObject( wiaDevs );
				if( ! done )
				{
					if( wiaCamera != null )
						Marshal.ReleaseComObject( wiaCamera ); wiaCamera = null;
					if( wiaManager != null )
						Marshal.ReleaseComObject( wiaManager ); wiaManager = null;
				}
			}
		}



			/// <summary> Instantiate the video interface and create overlay. </summary>
		private bool CreateVideo()
		{
			Cursor.Current = Cursors.WaitCursor;
			try {
				wiaVideo = new WiaVideoClass();

				// according MSDN, set IWiaVideo::ImagesDirectory to WIA_DPV_IMAGES_DIRECTORY:
				string videoDir = (string) wiaCamera.GetPropById( (WiaItemPropertyId) 3587 );		// 3587 = WIA_DPV_IMAGES_DIRECTORY
				wiaVideo.ImagesDirectory = videoDir;		// connect video directory

				string cameraID = wiaCamera.GetPropById( (WiaItemPropertyId) WiaDeviceInfoPropertyId.DeviceInfoDevId ) as string;
				wiaVideo.CreateVideoByWiaDevID( cameraID, panelVideo.Handle, 0, 1 );	// overlay into video panel
				return true;
			}
			catch( Exception ) {
				if( wiaVideo != null )
					Marshal.ReleaseComObject( wiaVideo ); wiaVideo = null;
				MessageBox.Show( this, "Create video stream failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
				return false;
			}
			finally {
				Cursor.Current = Cursors.Default;
			}
		}

			/// <summary> Take a picture from video stream. </summary>
		private void SnapPicture()
		{
			try {
				toolBtnSave.Enabled = false;			// disable toolbar button
				DisposePicure();

				wiaVideo.TakePicture( out jpgFile );			// call IWiaVideo::TakePicture
				if( jpgFile != null )
					{
					pictureBox.Image = Image.FromFile( jpgFile );	// load jpeg file into preview
					toolBtnSave.Enabled = true;						// enable toolbar button
					}
			}
			catch( Exception ) {}
		}


			/// <summary> Save current still-image to a disk file. </summary>
		private void SavePicture()
		{
			if( pictureBox.Image == null )		// nothing to do
				return;
				
			try {
				SaveFileDialog sd = new SaveFileDialog();
				sd.FileName = "snap.jpg";
				sd.Title = "Save Image as...";
				sd.Filter = "JPEG file (*.jpg)|*.jpg";		// this sample is hard coded to jpeg
				sd.FilterIndex = 1;
				if( sd.ShowDialog() != DialogResult.OK )	// ask user for file path & name
					return;

				pictureBox.Image.Save( sd.FileName, ImageFormat.Jpeg );		// save to new file
			}
			catch( Exception ) {
				MessageBox.Show( this, "Save to file failed", "WIA sample", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			}
		}


			/// <summary> Dispose current picture, this sample just deletes the snap file. </summary>
		private void DisposePicure()
		{
			try {
				Image oldImg = pictureBox.Image;		// release previous picture
				pictureBox.Image = null;
				if( oldImg != null )
					oldImg.Dispose();

				if( jpgFile != null )				// delete jpg file on disk
					File.Delete( jpgFile );

				jpgFile = null;
			}
			catch( Exception ) {}
			finally{ jpgFile = null; }
		}


		/// <summary> WIA manager COM object. </summary>
	private WiaClass		wiaManager;

		/// <summary> WIA camera device item. </summary>
	private ItemClass		wiaCamera;

		/// <summary> WIA video interface. </summary>
	private WiaVideoClass	wiaVideo;

		/// <summary> flag if this form was activated the first time. </summary>
	private bool			firstActive;

		/// <summary> file name of video jpeg picture. </summary>
	private string			jpgFile;
	}
}
