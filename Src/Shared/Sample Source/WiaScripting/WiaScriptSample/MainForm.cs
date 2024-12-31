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
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Reflection;

using WIALib;
using WIAVIDEOLib;

namespace WiaScriptSample
{
	/// <summary> MainForm is the main form for this sample. </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.StatusBar statusBarMain;
		private System.Windows.Forms.StatusBarPanel statBarPrim;
		private System.Windows.Forms.TreeView treeWiaItems;
		private System.Windows.Forms.ImageList imgLstTree;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.ListView listWiaProps;
		private System.Windows.Forms.ColumnHeader colPropName;
		private System.Windows.Forms.ColumnHeader colPropValue;
		private System.Windows.Forms.ColumnHeader colPropID;
		private System.Windows.Forms.Panel previewPanel;
		private System.Windows.Forms.PictureBox pictWiaItem;
		private System.Windows.Forms.MainMenu mainMenuApp;
		private System.Windows.Forms.MenuItem menuTopFile;
		private System.Windows.Forms.MenuItem menuTopDevice;
		private System.Windows.Forms.MenuItem menuTopAcquire;
		private System.Windows.Forms.MenuItem menuTopVideo;
		private System.Windows.Forms.MenuItem menuFileSaveAs;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuDevSelVUI;
		private System.Windows.Forms.MenuItem menuDevSelCUI;
		private System.Windows.Forms.MenuItem menuAcqFromUI;
		private System.Windows.Forms.MenuItem menuAcqTakePic;
		private System.Windows.Forms.MenuItem menuVideoTakePic;
		private System.Windows.Forms.MenuItem menuVideoPlay;
		private System.Windows.Forms.MenuItem menuVideoPause;
		private System.ComponentModel.IContainer components;

		public MainForm()
		{
			// Required for Windows Form Designer support
			InitializeComponent();
			
			Assembly thisAsm = Assembly.GetExecutingAssembly();		// get some symbols from assembly resources:
			transfImg = Image.FromStream( thisAsm.GetManifestResourceStream( "WiaScriptSample.Transfering.bmp" ) );
			readyImg  = Image.FromStream( thisAsm.GetManifestResourceStream( "WiaScriptSample.Stopwatch.bmp" ) );

			CreateManager();		// create WIA manager
		}

		/// <summary> Clean up any resources being used. </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( wiaMgr != null )
					Marshal.ReleaseComObject( wiaMgr );
				wiaMgr = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.mainMenuApp = new System.Windows.Forms.MainMenu();
			this.menuTopFile = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuFileSaveAs = new System.Windows.Forms.MenuItem();
			this.menuTopDevice = new System.Windows.Forms.MenuItem();
			this.menuDevSelVUI = new System.Windows.Forms.MenuItem();
			this.menuDevSelCUI = new System.Windows.Forms.MenuItem();
			this.menuTopAcquire = new System.Windows.Forms.MenuItem();
			this.menuAcqFromUI = new System.Windows.Forms.MenuItem();
			this.menuAcqTakePic = new System.Windows.Forms.MenuItem();
			this.menuTopVideo = new System.Windows.Forms.MenuItem();
			this.menuVideoTakePic = new System.Windows.Forms.MenuItem();
			this.menuVideoPlay = new System.Windows.Forms.MenuItem();
			this.menuVideoPause = new System.Windows.Forms.MenuItem();
			this.statusBarMain = new System.Windows.Forms.StatusBar();
			this.statBarPrim = new System.Windows.Forms.StatusBarPanel();
			this.treeWiaItems = new System.Windows.Forms.TreeView();
			this.imgLstTree = new System.Windows.Forms.ImageList(this.components);
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.listWiaProps = new System.Windows.Forms.ListView();
			this.colPropName = new System.Windows.Forms.ColumnHeader();
			this.colPropValue = new System.Windows.Forms.ColumnHeader();
			this.colPropID = new System.Windows.Forms.ColumnHeader();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.previewPanel = new System.Windows.Forms.Panel();
			this.pictWiaItem = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.statBarPrim)).BeginInit();
			this.previewPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuApp
			// 
			this.mainMenuApp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuTopFile,
																						this.menuTopDevice,
																						this.menuTopAcquire,
																						this.menuTopVideo});
			// 
			// menuTopFile
			// 
			this.menuTopFile.Index = 0;
			this.menuTopFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuFileExit,
																						this.menuFileSaveAs});
			this.menuTopFile.Text = "&File";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 0;
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuFileSaveAs
			// 
			this.menuFileSaveAs.Index = 1;
			this.menuFileSaveAs.Text = "Save &As...";
			this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
			// 
			// menuTopDevice
			// 
			this.menuTopDevice.Index = 1;
			this.menuTopDevice.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.menuDevSelVUI,
																						  this.menuDevSelCUI});
			this.menuTopDevice.Text = "&Device";
			// 
			// menuDevSelVUI
			// 
			this.menuDevSelVUI.Index = 0;
			this.menuDevSelVUI.Text = "Select using &vendor UI";
			this.menuDevSelVUI.Click += new System.EventHandler(this.menuDevSelVUI_Click);
			// 
			// menuDevSelCUI
			// 
			this.menuDevSelCUI.Index = 1;
			this.menuDevSelCUI.Text = "Select using custom UI";
			this.menuDevSelCUI.Click += new System.EventHandler(this.menuDevSelCUI_Click);
			// 
			// menuTopAcquire
			// 
			this.menuTopAcquire.Index = 2;
			this.menuTopAcquire.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuAcqFromUI,
																						   this.menuAcqTakePic});
			this.menuTopAcquire.Text = "&Acquire";
			// 
			// menuAcqFromUI
			// 
			this.menuAcqFromUI.Enabled = false;
			this.menuAcqFromUI.Index = 0;
			this.menuAcqFromUI.Text = "Get from &UI";
			this.menuAcqFromUI.Click += new System.EventHandler(this.menuAcqFromUI_Click);
			// 
			// menuAcqTakePic
			// 
			this.menuAcqTakePic.Enabled = false;
			this.menuAcqTakePic.Index = 1;
			this.menuAcqTakePic.Text = "&Take Picture";
			this.menuAcqTakePic.Click += new System.EventHandler(this.menuAcqTakePic_Click);
			// 
			// menuTopVideo
			// 
			this.menuTopVideo.Enabled = false;
			this.menuTopVideo.Index = 3;
			this.menuTopVideo.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuVideoTakePic,
																						 this.menuVideoPlay,
																						 this.menuVideoPause});
			this.menuTopVideo.Text = "&Video";
			// 
			// menuVideoTakePic
			// 
			this.menuVideoTakePic.Index = 0;
			this.menuVideoTakePic.Text = "&Take Still Picture";
			this.menuVideoTakePic.Click += new System.EventHandler(this.menuVideoTakePic_Click);
			// 
			// menuVideoPlay
			// 
			this.menuVideoPlay.Index = 1;
			this.menuVideoPlay.Text = "&Play";
			this.menuVideoPlay.Click += new System.EventHandler(this.menuVideoPlay_Click);
			// 
			// menuVideoPause
			// 
			this.menuVideoPause.Index = 2;
			this.menuVideoPause.Text = "P&ause";
			this.menuVideoPause.Click += new System.EventHandler(this.menuVideoPause_Click);
			// 
			// statusBarMain
			// 
			this.statusBarMain.Location = new System.Drawing.Point(0, 395);
			this.statusBarMain.Name = "statusBarMain";
			this.statusBarMain.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																							 this.statBarPrim});
			this.statusBarMain.ShowPanels = true;
			this.statusBarMain.Size = new System.Drawing.Size(584, 22);
			this.statusBarMain.TabIndex = 0;
			// 
			// statBarPrim
			// 
			this.statBarPrim.Text = "IDLE.";
			this.statBarPrim.Width = 160;
			// 
			// treeWiaItems
			// 
			this.treeWiaItems.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeWiaItems.FullRowSelect = true;
			this.treeWiaItems.HideSelection = false;
			this.treeWiaItems.ImageList = this.imgLstTree;
			this.treeWiaItems.Name = "treeWiaItems";
			this.treeWiaItems.Size = new System.Drawing.Size(152, 395);
			this.treeWiaItems.TabIndex = 2;
			this.treeWiaItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeWiaItems_AfterSelect);
			// 
			// imgLstTree
			// 
			this.imgLstTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgLstTree.ImageSize = new System.Drawing.Size(16, 16);
			this.imgLstTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstTree.ImageStream")));
			this.imgLstTree.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(152, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(6, 395);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// listWiaProps
			// 
			this.listWiaProps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						   this.colPropName,
																						   this.colPropValue,
																						   this.colPropID});
			this.listWiaProps.Dock = System.Windows.Forms.DockStyle.Top;
			this.listWiaProps.FullRowSelect = true;
			this.listWiaProps.GridLines = true;
			this.listWiaProps.HideSelection = false;
			this.listWiaProps.Location = new System.Drawing.Point(158, 0);
			this.listWiaProps.MultiSelect = false;
			this.listWiaProps.Name = "listWiaProps";
			this.listWiaProps.Size = new System.Drawing.Size(426, 127);
			this.listWiaProps.TabIndex = 4;
			this.listWiaProps.View = System.Windows.Forms.View.Details;
			// 
			// colPropName
			// 
			this.colPropName.Text = "Property";
			this.colPropName.Width = 200;
			// 
			// colPropValue
			// 
			this.colPropValue.Text = "Value";
			this.colPropValue.Width = 150;
			// 
			// colPropID
			// 
			this.colPropID.Text = "ID";
			this.colPropID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(158, 127);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(426, 5);
			this.splitter2.TabIndex = 5;
			this.splitter2.TabStop = false;
			// 
			// previewPanel
			// 
			this.previewPanel.AutoScroll = true;
			this.previewPanel.AutoScrollMargin = new System.Drawing.Size(8, 8);
			this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.previewPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.pictWiaItem});
			this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewPanel.Location = new System.Drawing.Point(158, 132);
			this.previewPanel.Name = "previewPanel";
			this.previewPanel.Size = new System.Drawing.Size(426, 263);
			this.previewPanel.TabIndex = 6;
			this.previewPanel.Resize += new System.EventHandler(this.previewPanel_Resize);
			// 
			// pictWiaItem
			// 
			this.pictWiaItem.Location = new System.Drawing.Point(8, 8);
			this.pictWiaItem.Name = "pictWiaItem";
			this.pictWiaItem.Size = new System.Drawing.Size(400, 240);
			this.pictWiaItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictWiaItem.TabIndex = 0;
			this.pictWiaItem.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(584, 417);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.previewPanel,
																		  this.splitter2,
																		  this.listWiaProps,
																		  this.splitter1,
																		  this.treeWiaItems,
																		  this.statusBarMain});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenuApp;
			this.Name = "MainForm";
			this.Text = "WIA Scripting Sample";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			((System.ComponentModel.ISupportInitialize)(this.statBarPrim)).EndInit();
			this.previewPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

	/// <summary> The main entry point for the application. </summary>
	[STAThread]
	static void Main() 
	{
		Application.Run( new MainForm() );
	}


		/// <summary> If activated for the first time, we let the user select a WIA device </summary>
	private void MainForm_Activated( object sender, System.EventArgs e )
	{
		if( ! firstActive )
		{
			firstActive = true;
			if( SelectDevice() )
				FillTree();
			else
				Close();
		}
	}

		/// <summary> Menu item clicked: "select device using vendor UI" </summary>
	private void menuDevSelVUI_Click( object sender, System.EventArgs e )
	{
		ReleaseDevice();				// first release previous device
		if( SelectDevice() )
			FillTree();
	}

		/// <summary> call Wia.Create showing vendor UI </summary>
	private bool SelectDevice()
	{
		try {
			object selUI = System.Reflection.Missing.Value;
			ItemClass wiaRoot = (ItemClass) wiaMgr.Create( ref selUI );
			if( wiaRoot == null )
				return false;
			
			CreateRootHolder( wiaRoot );		// attach to the root device item
		}
		catch( Exception )
		{
			MessageBox.Show( this, "no WIA devices found!", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			return false;
		}
		return true;
	}


		/// <summary> Menu item clicked: "select device using custom UI" </summary>
	private void menuDevSelCUI_Click(object sender, System.EventArgs e)
	{
		ReleaseDevice();				// first release previous device
		if( SelectDeviceCustomUI() )
			FillTree();
	}

		/// <summary> We show our own custom UI to select a WIA device</summary>
	private bool SelectDeviceCustomUI()
	{
		CollectionClass wiaDevs = null;		// All WIA devices / DeviceInfo.
		selectedID = null;

		try {
			wiaDevs = wiaMgr.Devices as CollectionClass;		// call Wia.Devices to get all devices
			int count = wiaDevs.Count;
			if( count < 1 )
			{
				MessageBox.Show( this, "no WIA devices found!", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
				return false;
			}
			else if( count >= 1 )
			{									// show our own dialog to select device:
				SelectDevice	frmSel = new SelectDevice( wiaDevs );
				frmSel.ShowDialog( this );
				selectedID = frmSel.SelectedID;
			}
			else
			{
				DeviceInfoClass devInfo = (DeviceInfoClass) Marshal.CreateWrapperOfType( wiaDevs[0], typeof(DeviceInfoClass) );
				selectedID = devInfo.Id;
				Marshal.ReleaseComObject( devInfo ); devInfo = null;
			}
			if( selectedID == null )
				return false;

			object ot = selectedID;
			ItemClass wiaRoot = (ItemClass) wiaMgr.Create( ref ot );
			CreateRootHolder( wiaRoot );								// attach to the root device item
			return true;
		}
		catch( Exception ) {
			MessageBox.Show( this, "Failed to select device!", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			return false;
		}
		finally {
			if( wiaDevs != null )
				Marshal.ReleaseComObject( wiaDevs );
		}
	}


		/// <summary> User selected menu entry to quit. </summary>
	private void menuFileExit_Click(object sender, System.EventArgs e)
	{
		ReleaseDevice();
		Close();
	}

		/// <summary> Form is closing, do cleanup. </summary>
	private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
	{
		if( wiaMgr != null )
		{													// disconnect WIA events
			wiaMgr.OnDeviceDisconnected	-= wiaEvtDisc;
			wiaMgr.OnTransferComplete	-= wiaEvtTransfer;
		}
		ReleaseDevice();			// cleanup
	}

		/// <summary> Event handling for Wia.OnDeviceDisconnected </summary>
	public void wia_OnDeviceDisconnected( string Id )
	{
		if( Id == selectedID )
		{								// our device got unplugged!
			ReleaseDevice();
			MessageBox.Show( this, "Device disconnected", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
		}
	}



		/// <summary> Fill TreeView of WIA items. </summary>
	private void FillTree()
		{
		Cursor.Current = Cursors.WaitCursor;
		treeWiaItems.Nodes.Clear();
		treeWiaItems.BeginUpdate();
		try {
			int img = (int) rootHolder.GetWiaIcon();
			TreeNode	rootNode = new TreeNode( devName, img, img );		// create the root tree node
			rootHolder.Node = rootNode;
			rootNode.Tag = rootHolder;
			FillTreeRecursive( rootNode, rootHolder );			// recursively enumerate all childs
			treeWiaItems.Nodes.Add( rootNode );

			treeWiaItems.SelectedNode = rootNode;		// preselect root node
			treeWiaItems.ExpandAll();
			KeepTransfering();				// start download of images
			}
		catch( Exception )
			{
			MessageBox.Show( this, "Fill tree with WIA items failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			}
		treeWiaItems.EndUpdate();
		Cursor.Current = Cursors.Default;
		}

		/// <summary> Recursively fill all WIA child items to TreeView nodes. </summary>
	private void FillTreeRecursive( TreeNode parentNode, ItemHolder parentHolder )
		{
		try {			// call Item.Children:
			CollectionClass childItems = parentHolder.Item.Children as CollectionClass;
			foreach( Object oc in childItems )
				{
				ItemClass wiaChild = (ItemClass) Marshal.CreateWrapperOfType( oc, typeof(ItemClass) );
				ItemHolder childHolder = new ItemHolder( wiaChild );
				wiaChild = null;
				
				int img = (int) childHolder.GetWiaIcon();
				TreeNode newNode = new TreeNode( childHolder.Item.Name, img, img );
				childHolder.Node = newNode;
				newNode.Tag = childHolder;
				allItems.Add( childHolder );
				if( childHolder.IsImage && (! childHolder.IsDevice) )
				{															// prepare download of image
					childHolder.State = TransState.Ready;
					pendingTransfers.Add( childHolder );
				}
				FillTreeRecursive( newNode, childHolder );			// recursive to next branch down
				parentNode.Nodes.Add( newNode );
				}
			}
		catch( Exception ) {
			MessageBox.Show( this, "Recursive fill tree with WIA items failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			}
		}


		/// <summary> User selected another node in TreeView. </summary>
	private void treeWiaItems_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
	{
		SetNewImage( null, false );		// hide current preview
		listWiaProps.Items.Clear();		// clear list view

		currentHolder = e.Node.Tag as ItemHolder;		// the new selected node
		if( currentHolder == null )
			return;

		menuAcqFromUI.Enabled	= currentHolder.IsRoot;			// update menu states:
		menuAcqTakePic.Enabled	= currentHolder.CanTakePic;
		menuTopVideo.Enabled	= false;
		menuFileSaveAs.Enabled	= false;

		if( currentHolder.IsImage )		// if item is an image, show preview:
		{
			if( currentHolder.State == TransState.Completed )
			{													// transfer was completed, show the real image
				SetNewImage( currentHolder.GetImage(), true );
				menuFileSaveAs.Enabled = true;
			}
			else if( currentHolder.State == TransState.Transfering )	// still transfering
				SetNewImage( transfImg, false );
			else if( currentHolder.State == TransState.Ready )			// ready for transfer
				SetNewImage( readyImg, false );
		}

		// check if item is video root device, if so show preview video
		if( (currentHolder.IsRoot) &&
			((devType & WiaDevType.Mask) == WiaDevType.Video))
		{
			CreateVideoPreview();
			menuTopVideo.Enabled = videoVisible;
		}
			

		if( currentHolder.Item != null )
		{
			Cursor.Current = Cursors.WaitCursor;
			PropertyHelper.FillItemProperties( currentHolder.Item, devType, listWiaProps );
			Cursor.Current = Cursors.Default;
		}
	}
		



		/// <summary> User selected menu entry to acquire image using the Wia GUI. </summary>
	private void menuAcqFromUI_Click( object sender, System.EventArgs e )
	{
		TreeNode selectedNode = treeWiaItems.SelectedNode;
		ItemHolder context = selectedNode.Tag as ItemHolder;
		if( context == null )
			return;

		try {
			SetNewImage( null, false );
			if( videoLive )
			{									// we have to destroy our video preview for WIA's own GUI
				wiaVideo.DestroyVideo();
				videoLive = false;
			}

			CollectionClass newPics;
			newPics = context.Item.GetItemsFromUI( WiaFlag.SingleImage, WiaIntent.ImageTypeColor ) as CollectionClass;
			if( newPics == null )
				return;

			foreach( Object oc in newPics )
			{
				ItemClass item = (ItemClass) Marshal.CreateWrapperOfType( oc, typeof(ItemClass) );
				OnNewItem( item );
			}

			KeepTransfering();
		}
		catch( Exception ) {
			MessageBox.Show( this, "Get items from UI failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
		}
	}



		/// <summary> User selected menu entry to take picture from Digi-Cam. </summary>
	private void menuAcqTakePic_Click( object sender, System.EventArgs e )
	{
		TreeNode selectedNode = treeWiaItems.SelectedNode;
		ItemHolder context = selectedNode.Tag as ItemHolder;
		if( context == null )
			return;

		Cursor.Current = Cursors.WaitCursor;
		try {
			object takenPic = context.Item.TakePicture();		// call WIA Item.TakePicture
			ItemClass item = (ItemClass) takenPic;
			OnNewItem( item );								// add as new tree node
		}
		catch( Exception ) {
			MessageBox.Show( this, "Take picture failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
		}
		Cursor.Current = Cursors.Default;
	}


		/// <summary> Establish a new Wia image item and add it to the TreeView. </summary>
	private void OnNewItem( ItemClass item )
	{
		// currently only image types are handled:
		WiaItemFlag flags = (WiaItemFlag) item.GetPropById( (WiaItemPropertyId) 4101 );
		if( (flags & (WiaItemFlag.Image|WiaItemFlag.File)) == 0 )
		{
			Marshal.ReleaseComObject( item );
			return;
		}

		ItemHolder	picture		= null;
		TreeNode	parentNode	= null;

		if( (flags & WiaItemFlag.Device) != 0 )		//  the item represents a scanning device (e.g. 'Top':
		{
			string name = "Image " + DateTime.Now.ToString( "HH:mm:ss" );
			picture = new ItemHolder( name, WiaItemFlag.Image|WiaItemFlag.File );	// create virtual image item
			picture.TransferFrom( item );
			parentNode = FindNodeByFullName( item.FullName );		// append it under the scanning device
		}
		else
			picture = new ItemHolder( item );

		item = null;
		allItems.Add( picture );

		int img = (int) picture.GetWiaIcon();
		TreeNode newNode = new TreeNode( picture.Name, img, img );		// create new node with corresponding icon
		picture.Node = newNode;					// linking tree node & holder...
		newNode.Tag = picture;

		if( parentNode == null )
			parentNode = treeWiaItems.SelectedNode;		// add this new node
		parentNode.Nodes.Add( newNode );
		parentNode.Expand();							// just make it visible by expanding parent

		picture.State = TransState.Ready;			// prepare the image download...
		pendingTransfers.Add( picture );
	}



		/// <summary> Sequentially download prepared images (asynchronous). </summary>
	private void KeepTransfering()
	{														// do all pending asynch. tranfers
		foreach( ItemHolder holder in pendingTransfers )
		{
			if( holder.State == TransState.Transfering )	// already one pending
			{
				this.statBarPrim.Text = "TRANSFERING...";
				return;
			}
		}

		foreach( ItemHolder holder in pendingTransfers )
		{
			if( holder.State == TransState.Ready )		// a next one to download...
			{
				holder.Transfer();
				this.statBarPrim.Text = "TRANSFER!";
				return;
			}
		}
		this.statBarPrim.Text = "READY.";					// status bar text
	}


		/// <summary> Callback event from Wia - a download completed. </summary>
	public void wia_OnTransferComplete( WIALib.Item item, string path )
		{
		foreach( ItemHolder holder in pendingTransfers )
			{
			if( holder.State == TransState.Transfering )	// pending holder found...
				{
				pendingTransfers.Remove( holder );			// remove from list and complete holder...
				holder.TransferCompleted();
				if( holder == currentHolder )			// it is the currently selected item in tree...
					{
					Application.DoEvents();				// NOTE: bug? file named by 'path' still locked sometimes !?
					Thread.Sleep( 50 );					// WORKAROUND?!
					Application.DoEvents();
					SetNewImage( holder.GetImage(), true );		// view the downloaded image
					menuFileSaveAs.Enabled = true;				// let user save this image as a file.
					}
				break;
				}
			}
		KeepTransfering();			// immediately starts a next download if any pending
		}


		/// <summary> User selected menu entry to save image. </summary>
	private void menuFileSaveAs_Click( object sender, System.EventArgs e )
	{
		try {
			TreeNode selectedNode = treeWiaItems.SelectedNode;
			ItemHolder context = selectedNode.Tag as ItemHolder;
			if( context == null )
				return;

			string name = context.Name.Replace( ':', '_' );		// our special image names could contain invalid file name characters
			name = name.Replace( '.', '_' );
			SaveFileDialog sd = new SaveFileDialog();
			sd.FileName = name;
			sd.Title = "Save Image as...";
			sd.Filter = "Bitmap file (*.bmp)|*.bmp";
			sd.FilterIndex = 1;
			if( sd.ShowDialog() != DialogResult.OK )
				return;

			Image img = context.GetImage();		// get image from known file
			if( img == null )
				return;
			img.Save( sd.FileName );		// save to new bmp file
			img.Dispose();
		}
		catch( Exception ) {
			MessageBox.Show( this, "Save image to file failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
		}
	}



		/// <summary> Get the WIA manager COM object, subscribe to WIA events. </summary>
	private void CreateManager()
	{
		try {
			wiaMgr = new WiaClass();

			wiaEvtDisc = new _IWiaEvents_OnDeviceDisconnectedEventHandler( this.wia_OnDeviceDisconnected );
			wiaMgr.OnDeviceDisconnected += wiaEvtDisc;

			wiaEvtTransfer = new _IWiaEvents_OnTransferCompleteEventHandler( this.wia_OnTransferComplete );
			wiaMgr.OnTransferComplete += wiaEvtTransfer;
		}
		catch( Exception ) {
			MessageBox.Show( this, "Create WIA manager object failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
			Application.Exit();
		}
	}


		/// <summary> Establish the WIA root device item. </summary>
	private void CreateRootHolder( ItemClass wiaRoot )
	{
		selectedID = wiaRoot.GetPropById( (WiaItemPropertyId) WiaDeviceInfoPropertyId.DeviceInfoDevId ) as string;
		devName = wiaRoot.GetPropById( (WiaItemPropertyId) WiaDeviceInfoPropertyId.DeviceInfoDevName ) as string;
		devType = (WiaDevType) wiaRoot.GetPropById( (WiaItemPropertyId) WiaDeviceInfoPropertyId.DeviceInfoDevType );
		ItemHolder.devType = devType;
		rootHolder = new ItemHolder( wiaRoot );
		allItems.Add( rootHolder );
	}


		/// <summary> Cleanup the current WIA device and release all references. </summary>
	private void ReleaseDevice()
		{
		menuAcqFromUI.Enabled	= false;		// disable all menues...
		menuAcqTakePic.Enabled	= false;
		menuTopVideo.Enabled	= false;
		menuFileSaveAs.Enabled	= false;

		SetNewImage( null, false );			// hide preview picture / video
		currentHolder = null;
		listWiaProps.Items.Clear();
		treeWiaItems.Nodes.Clear();
		pendingTransfers.Clear();

		if( wiaVideo != null )
		{								// destroy video stream
			if( videoLive )
			{
				wiaVideo.DestroyVideo();
				videoLive = false;
			}
			Marshal.ReleaseComObject( wiaVideo );		// release video COM object
			wiaVideo = null;
		}

		foreach( ItemHolder holder in allItems )		// release all WIA COM objects
			holder.Dispose();
		allItems.Clear();
		rootHolder = null;
		}


		/// <summary> Show another preview image. </summary>
	private void SetNewImage( Image newImg, bool forceDispose )
		{
		if( videoVisible )
			{									// make any video overlay invisible
			videoVisible = false;
			wiaVideo.PreviewVisible = 0;
			}

		Image oldImg = pictWiaItem.Image;
		pictWiaItem.Image = null;
		if( (oldImg != null) && forceImgDispose )		// do release memory of old image (also unlocks bmp file)
			oldImg.Dispose();
		pictWiaItem.Image = newImg;				// show the new image in preview panel
		forceImgDispose = forceDispose;
		}

	#region WiaVideo

		/// <summary> Create a preview video device. </summary>
	private void CreateVideoPreview()
	{
		Cursor.Current = Cursors.WaitCursor;
		try {
			if( wiaVideo == null )
			{										// no video interfaces yet, create one
				wiaVideo = new WiaVideoClass();

				// wiaVideo.ImagesDirectory = Path.GetTempPath();

				// according MSDN, set IWiaVideo::ImagesDirectory to WIA_DPV_IMAGES_DIRECTORY:
				string videoDir = (string) currentHolder.Item.GetPropById( (WiaItemPropertyId) 3587 );		// 3587 = WIA_DPV_IMAGES_DIRECTORY
				wiaVideo.ImagesDirectory = videoDir;		// connect video directory
			}

			if( ! videoLive )
			{
				wiaVideo.CreateVideoByWiaDevID( selectedID, previewPanel.Handle, 0, 0 );	// overlay into preview panel
				videoLive = true;				// mark video as running
				wiaVideo.PreviewVisible = 1;
				menuVideoPlay.Enabled = false;	// enable menu entry according play state
				menuVideoPause.Enabled = true;
				wiaVideo.Play();				// start live stream!
			}
			else
				wiaVideo.PreviewVisible = 1;

			videoVisible = true;
		}
		catch( Exception ) {
			MessageBox.Show( this, "create video preview failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
		}
		Cursor.Current = Cursors.Default;
	}

		/// <summary> User clicked menu entry to take still video picure. </summary>
	private void menuVideoTakePic_Click( object sender, System.EventArgs e )
		{
		Cursor.Current = Cursors.WaitCursor;
		try {
			string newJpg;
			wiaVideo.TakePicture( out newJpg );			// call IWiaVideo::TakePicture
			if( newJpg == null )
				return;

			string name = "Take " + DateTime.Now.ToString( "HH:mm:ss.f" );
			ItemHolder picture = new ItemHolder( name, WiaItemFlag.Image|WiaItemFlag.File );
			picture.FileName = newJpg;
			picture.State = TransState.Completed;
			int img = (int) picture.GetWiaIcon();
			TreeNode newNode = new TreeNode( picture.Name, img, img );
			picture.Node = newNode;
			newNode.Tag = picture;
			allItems.Add( picture );
			treeWiaItems.SelectedNode.Nodes.Add( newNode );
			treeWiaItems.SelectedNode.Expand();
		}
		catch( Exception ) {
			MessageBox.Show( this, "Take still video picture failed", "WIA", MessageBoxButtons.OK, MessageBoxIcon.Stop );
		}
		Cursor.Current = Cursors.Default;
		}

		/// <summary> User clicked menu entry to pause video. </summary>
	private void menuVideoPause_Click( object sender, System.EventArgs e )
	{
		if( videoVisible )
		{
			menuVideoPause.Enabled = false;
			menuVideoPlay.Enabled = true;
			wiaVideo.Pause();
		}
	}

		/// <summary> User clicked menu entry to play video. </summary>
	private void menuVideoPlay_Click( object sender, System.EventArgs e )
	{
		if( videoVisible )
		{
			menuVideoPlay.Enabled = false;
			menuVideoPause.Enabled = true;
			wiaVideo.Play();
		}
	}

		/// <summary> Notify video overlay about size changes. </summary>
	private void previewPanel_Resize( object sender, System.EventArgs e )
	{
		if( videoVisible )
			wiaVideo.ResizeVideo( 0 );
	}
	#endregion


		/// <summary> Search all holders by name to get the corresponding tree-node. </summary>
	private TreeNode FindNodeByFullName( string fullName )
		{
		foreach( ItemHolder holder in allItems )
			{
			if( holder.Item == null )
				continue;
			if( holder.Item.FullName == fullName )
				return holder.Node as TreeNode;
			}
		return null;
		}


		/// <summary> WIA manager COM object. </summary>
	private WiaClass		wiaMgr;

		/// <summary> WIA ID of currently selected device. </summary>
	private string			selectedID;

		/// <summary> Friendly name of WIA device. </summary>
	private string			devName;

		/// <summary> WIA device type (scanner/video..). </summary>
	private WiaDevType		devType		= WiaDevType.Default;



		/// <summary> WIA root device item. </summary>
	private ItemHolder		rootHolder;

		/// <summary> Holder for currently selected item in tree. </summary>
	private ItemHolder		currentHolder;

		/// <summary> Array of all existing ItemHolder. </summary>
	private ArrayList		allItems			= new ArrayList();

		/// <summary> Array of ItemHolder for transfers. </summary>
	private ArrayList		pendingTransfers	= new ArrayList();



		/// <summary> To detect first form activation. </summary>
	private bool			firstActive;

		/// <summary> Flag: dispose current preview image? </summary>
	private bool			forceImgDispose;

		/// <summary> Symbol while transfer pending. </summary>
	private Image			transfImg;

		/// <summary> Symbol while transfer ready. </summary>
	private Image			readyImg;



		/// <summary> IWiaVideo video COM interface wrapper. </summary>
	private WiaVideoClass	wiaVideo;

		/// <summary> Flag: is video stream created? </summary>
	private bool			videoLive;

		/// <summary> Flag: is video visible? </summary>
	private bool			videoVisible;



		/// <summary> WIA disconnect event callback. </summary>
	private _IWiaEvents_OnDeviceDisconnectedEventHandler	wiaEvtDisc;

		/// <summary> WIA transfer-complete event callback. </summary>
	private _IWiaEvents_OnTransferCompleteEventHandler		wiaEvtTransfer;
	}

}
