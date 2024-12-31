/******************************************************
                WIA Scripting sample
		      netmaster@swissonline.ch
*******************************************************/
//					ItemHolder
// this is a 'wrapper' class for WIA items

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;

using WIALib;

namespace WiaScriptSample
{

	/// <summary> Sample wrapper for WIA items (ItemClass). </summary>
public class ItemHolder : IDisposable
	{

		/// <summary> Constructor for a concrete holder. </summary>
	public ItemHolder( ItemClass item )
		{
		this.item = item;
		name = item.Name;
		flags = (WiaItemFlag) item.GetPropById( (WiaItemPropertyId) 4101 );		// ItemFlags
		}

		/// <summary> Constructor for a virtual holder. </summary>
	public ItemHolder( string name, WiaItemFlag flags )
		{
		this.flags = flags;
		this.name = name;
		}


		/// <summary> Dispose used resources and all references to COM. </summary>
	public void Dispose()
	{
		node = null;

		if( fromItem != null )
		{
			Marshal.ReleaseComObject( fromItem );
			fromItem = null;
		}

		if( item != null )
		{
			Marshal.ReleaseComObject( item );
			item = null;
		}

		if( fileName != null )
		{								// try to delete the temporary image file
			try {
				File.Delete( fileName );
			}
			catch( Exception ee )
			{
				string ss = ee.Message;
			}
		}
	}


		/// <summary> Start download of image to temporary disk file. </summary>
	public void Transfer()
		{
		if( fromItem != null )
			{
			fileName = Path.GetTempFileName();
			fromItem.Transfer( fileName, true );
			}
		else if( item != null )
			{
			fileName = Path.GetTempFileName();
			item.Transfer( fileName, true );
			}
		else
			return;
		state = TransState.Transfering;
		}

		/// <summary> For some scanners, do transfer from separate device item. </summary>
	public void TransferFrom( ItemClass fromItem )
	{
		this.fromItem = fromItem;
	}


		/// <summary> Download to temporary disk file completed. </summary>
	public void TransferCompleted()
	{
		state = TransState.Completed;
		if( fromItem != null )
		{
			Marshal.ReleaseComObject( fromItem );		// we transfered from separate device item, release it now
			fromItem = null;
		}
	}



		/// <summary> Evaluate corresponding icon for this item. </summary>
	public WiaIcon GetWiaIcon()
	{
		if( (flags & WiaItemFlag.Disconnected) != 0 )
			return WiaIcon.Disconn;
		if( (flags & WiaItemFlag.Deleted) != 0 )
			return WiaIcon.Deleted;

		if( (flags & WiaItemFlag.Root) != 0 )
		{
			if( (devType & WiaDevType.Mask) == WiaDevType.Scanner )
				return WiaIcon.Scanner;
			else if( (devType & WiaDevType.Mask) == WiaDevType.DigiCam )
				return WiaIcon.DigiCam;
			else if( (devType & WiaDevType.Mask) == WiaDevType.Video )
				return WiaIcon.Video;
			return WiaIcon.Default;
		}

		if( (flags & WiaItemFlag.Device) != 0 )
		{
			if( (devType & WiaDevType.Mask) == WiaDevType.Scanner )
				return WiaIcon.Scanner;
			else if( (devType & WiaDevType.Mask) == WiaDevType.DigiCam )
				return WiaIcon.DigiCam;
			else if( (devType & WiaDevType.Mask) == WiaDevType.Video )
				return WiaIcon.Video;
			return WiaIcon.Default;
		}

		if( (flags & WiaItemFlag.Folder) != 0 )		// folder
			return WiaIcon.Thumbnails;

		if( (flags & WiaItemFlag.File) != 0 )			// file
		{
			if( (flags & WiaItemFlag.Image) != 0 )		// image
				return WiaIcon.Image;
			return WiaIcon.Unknown;
		}

		return WiaIcon.Folder;
	}


		/// <summary> Load image from known disk file. </summary>
	public Image GetImage()
	{
		if( fileName == null )
			return null;
		
		Image img = null;
		try {
			img = Image.FromFile( fileName );
		}
		catch( Exception ee ) {
			string em = ee.Message;
		}
		return img;
	}


	public bool IsRoot
		{ get { return (flags & WiaItemFlag.Root) != 0; } }

	public bool IsDevice
		{ get { return (flags & WiaItemFlag.Device) != 0; } }

	public bool IsImage
		{ get { return (flags & (WiaItemFlag.Image|WiaItemFlag.File)) == (WiaItemFlag.Image|WiaItemFlag.File); } }


		/// <summary> Detect if device can take video picure. </summary>
	public bool CanTakePic {
		get {
			if( (flags & WiaItemFlag.Root) == 0 )
				return false;
			return (devType & WiaDevType.Mask) == WiaDevType.DigiCam;
		} }


		/// <summary> Detect if device can take video picure. </summary>
	public bool CanTakeVideoPic {
		get {
			if( (flags & WiaItemFlag.Root) == 0 )
				return false;
			return (devType & WiaDevType.Mask) == WiaDevType.Video;
		} }



		/// <summary> The real WIA item for this holder. </summary>
	public ItemClass Item
	{
		get { return item;  }
	}

		/// <summary> Friendly name of item. </summary>
	public string Name
		{ get { return name; } }

		/// <summary> Image file name on disk. </summary>
	public string FileName
	{
		get { return fileName; }
		set { fileName = value; }
	}

		/// <summary> State of download. </summary>
	public TransState State
	{
		get { return state;  }
		set { state = value; }
	}


		/// <summary> Used to save corresponding TreeNode. </summary>
	public Object Node
	{
		get { return node;  }
		set { node = value; }
	}


		/// <summary> The real WIA item for this holder. </summary>
	private ItemClass	item;

		/// <summary> Friendly name of item. </summary>
	private string		name;

		/// <summary> WIA item flags (WiaItemTypeX). </summary>
	private	WiaItemFlag	flags;

		/// <summary> Image file name on disk. </summary>
	private string		fileName;

		/// <summary> State of download. </summary>
	private TransState	state;

		/// <summary> For some scanners, we have to transfer from separate device item. </summary>
	private ItemClass	fromItem;

		/// <summary> Used to save corresponding TreeNode. </summary>
	private object		node;

		/// <summary> Type (scanner/video...) of current device. </summary>
	public static WiaDevType devType;
	}





	/// <summary> Enumerates the download states of a holder. </summary>
public enum TransState
	{
	Idle		= 0,
	Ready		= 1,
	Transfering	= 2,
	Completed	= 3
	}

	/// <summary> Icon to show for a Wia item </summary>
[Flags]
public enum WiaIcon
	{						// NOTE: must match MainForm.imgLstTree for this sample!
	Default		= 0,
	Scanner		= 1,
	DigiCam		= 2,
	Video		= 3,
	Folder		= 4,
	Thumbnails	= 5,
	Image		= 6,
	Deleted		= 7,
	Disconn		= 8,
	Unknown		= 9
	}

}
