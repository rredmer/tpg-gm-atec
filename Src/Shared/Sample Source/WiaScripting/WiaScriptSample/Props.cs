/******************************************************
                WIA Scripting sample
		      netmaster@swissonline.ch
*******************************************************/
//					WIA Imaging
//  useful definitions from wiadef.h, NOT strictly part of WIA scripting!

using System;
using System.Diagnostics;
using System.Windows.Forms;

using WIALib;

namespace WiaScriptSample
{

[Flags]
public enum WiaDevType
	{
	Default		= unchecked( (int) 0x00000000 ),
	Scanner		= unchecked( (int) 0x00010000 ),
	DigiCam		= unchecked( (int) 0x00020000 ),
	Video		= unchecked( (int) 0x00030000 ),
	Mask		= unchecked( (int) 0x000F0000 )
	}


[Flags]
public enum WiaItemFlag
	{
	Free				= 0x00000000,
	Image				= 0x00000001,
	File				= 0x00000002,
	Folder				= 0x00000004,
	Root				= 0x00000008,
	Analyze				= 0x00000010,
	Audio				= 0x00000020,
	Device				= 0x00000040,
	Deleted				= 0x00000080,
	Disconnected		= 0x00000100,
	HPanorama			= 0x00000200,
	VPanorama			= 0x00000400,
	Burst				= 0x00000800,
	Storage				= 0x00001000,
	Transfer			= 0x00002000,
	Generated			= 0x00004000,
	HasAttachments		= 0x00008000,
	Video				= 0x00010000,
	TWAIN				= 0x00020000,
	Removed				= unchecked( (int) 0x80000000 ),
	Mask				= unchecked( (int) 0x8003FFFF )
	}

public struct DevicePropMap
	{
	public static readonly int[] id = new int[] {
		2,3,4,5,6,7,8,9,10,11,12,13,14,15,  1026,1027,1028 };

	public static readonly string[]	name = new string[] {
		"Unique Device ID","Manufacturer","Description","Type","Port","Name","Server","Remote Device ID",
		"UI Class ID","Hardware Configuration","BaudRate","STI Generic Capabilities","WIA Version","Driver Version",
		"Firmware Version","Connect Status","Device Time" };
	}

public struct ScannerDevicePropMap
	{
	public static readonly int[] id = new int[] {
		3074,3075,3076,3077,3078,3079,
		3080,3081,3082,3083,3084,3085,3086,3087,3088,3089,
		3090,3091,3092,3093,3094,3095,3096,3097,3098,3099,
		3100,3101,3102,3103,3104,3105 };

	public static readonly string[]	name = new string[] {
		"Horizontal Bed Size","Vertical Bed Size","Horizontal Sheet Feed Size","Vertical Sheet Feed Size",
		"Sheet Feeder Registration","Horizontal Bed Registration","Vertical Bed Registration","Platen Color",
		"Pad Color","Filter Select","Dither Select","Dither Pattern Data","Document Handling Capabilities",
		"Document Handling Status","Document Handling Select","Document Handling Capacity",
		"Horizontal Optical Resolution","Vertical Optical Resolution","Endorser Characters","Endorser String",
		"Scan Ahead Pages","Max Scan Time","Pages","Page Size","Page Width","Page Height","Preview",
		"Transparency Adapter","Transparency Adapter Select","Show preview control",
		"Minimum Horizontal Sheet Feed Size","Minimum Vertical Sheet Feed Size" };
	}

public struct DigiCamDevicePropMap
	{
	public static readonly int[] id = new int[] {
		2050,2051,2052,2053,2054,2055,2056,2057,2058,2059,
		2060,2061,2062,2063,2064,2065,2066,2067,2068,2069,
		2070,2071,2072,2073,2074,2075,2076,2077,2078,2079,
		2080,2081,2082,2083,2084,2085,2086,2087,2088,2089,
		2090,2091,2092 };

	public static readonly string[]	name = new string[] {
		"Pictures Taken","Pictures Remaining","Exposure Mode","Exposure Compensation","Exposure Time","F Number",
		"Flash Mode","Focus Mode","Focus Manual Dist","Zoom Position","Pan Position","Tilt Position",
		"Timer Mode","Timer Value","Power Mode","Battery Status","Thumbnail Width","Thumbnail Height",
		"Picture Width","Picture Height","Dimension","Compression Setting","Focus Metering Mode",
		"Timelapse Interval","Timelapse Number","Burst Interval","Burst Number","Effect Mode","Digital Zoom",
		"Sharpness","Contrast","Capture Mode","Capture Delay","Exposure Index","Exposure Metering Mode",
		"Focus Distance","Focus Length","RGB Gain","White Balance","Upload URL","Artist","Copyright Info" };
	}

public struct VideoDevicePropMap
	{
	public static readonly int[] id = new int[] {
		3586,3587,3588 };

	public static readonly string[]	name = new string[] {
		"Last Picture Taken","Images Directory","Directshow Device Path" };
	}


public struct ItemPropMap
	{
	public static readonly int[] id = new int[] {
		4098,4099,
		4100,4101,4102,4103,4104,4105,4106,4107,4108,4109,
		4110,4111,4112,4113,4114,4115,4116,4117,4118,4119,
		4120,4121,4122,4123,4124 };

	public static readonly string[]	name = new string[] {
		"Item Name","Full Item Name","Item Time Stamp","Item Flags","Access Rights","Data Type","Bits Per Pixel",
		"Preferred Format","Format","Compression","Media Type","Channels Per Pixel","Bits Per Channel","Planar",
		"Pixels Per Line","Bytes Per Line","Number of Lines","Gamma Curves","Item Size","Color Profiles",
		"Buffer Size","Region Type","Color Profile Name","Application Applies Color Mapping",
		"Stream Compatibility ID","Filename extension","Suppress a property page" };
	}




public struct DigiCamItemPropMap
	{
	public static readonly int[] id = new int[] {
		5122,5123,5124,5125,5126,5127,5128,5129,5130 };

	public static readonly string[]	name = new string[] {
		"Thumbnail Data","Thumbnail Width","Thumbnail Height","Audio Available","Audio Format","Audio Data",
		"Pictures per Row","Sequence Number","Time Delay" };
	}

public struct ScannerItemPropMap
	{
	public static readonly int[] id = new int[] {
		6146,6147,6148,6149,
		6150,6151,6152,6153,6154,6155,6156,6157,6158,6159,
		6160,6161 };

	public static readonly string[]	name = new string[] {
		"Current Intent","Horizontal Resolution","Vertical Resolution","Horizontal Start Position",
		"Vertical Start Position","Horizontal Extent","Vertical Extent","Photometric Interpretation",
		"Brightness","Contrast","Orientation","Rotation","Mirror","Threshold","Invert","Lamp Warm up Time" };
	}



public class PropertyHelper
	{

		/// <summary> Fill list with current item properties. </summary>
	public static void FillItemProperties( ItemClass itm, WiaDevType devType, ListView view )
		{
		view.BeginUpdate();
		string[]	itemstrings = new string[ 3 ];
		WiaItemFlag flags = (WiaItemFlag) itm.GetPropById( (WiaItemPropertyId) 4101 );		// ItemFlags
		try {
			itemstrings[0] = "Name"; itemstrings[1] = itm.Name;
			view.Items.Add( new ListViewItem( itemstrings ) );
			itemstrings[0] = "Full Name"; itemstrings[1] = itm.FullName;
			view.Items.Add( new ListViewItem( itemstrings ) );
			itemstrings[0] = "Item Type"; itemstrings[1] = itm.ItemType;
			view.Items.Add( new ListViewItem( itemstrings ) );

			bool dim = false;
			if( (flags & WiaItemFlag.Image) != 0 )
				dim = true;

			if( (flags & WiaItemFlag.Device) != 0 )
				{
				itemstrings[0] = "Connect Status"; itemstrings[1] = itm.ConnectStatus;
				view.Items.Add( new ListViewItem( itemstrings ) );
				itemstrings[0] = "Firmware Version"; itemstrings[1] = itm.FirmwareVersion;
				view.Items.Add( new ListViewItem( itemstrings ) );
				itemstrings[0] = "Device Time"; itemstrings[1] = itm.Time;
				view.Items.Add( new ListViewItem( itemstrings ) );

				if( (devType & WiaDevType.Mask) == WiaDevType.Scanner )
					dim = true;
				
				if( (devType & WiaDevType.Mask) == WiaDevType.DigiCam )
					{
					itemstrings[0] = "Picture Height"; itemstrings[1] = itm.PictureHeight.ToString();
					view.Items.Add( new ListViewItem( itemstrings ) );
					itemstrings[0] = "Picture Width"; itemstrings[1] = itm.PictureWidth.ToString();
					view.Items.Add( new ListViewItem( itemstrings ) );
					dim = true;
					}
				}

			if( dim )
				{
				itemstrings[0] = "Height"; itemstrings[1] = itm.Height.ToString();
				view.Items.Add( new ListViewItem( itemstrings ) );
				itemstrings[0] = "Width"; itemstrings[1] = itm.Width.ToString();
				view.Items.Add( new ListViewItem( itemstrings ) );
				}

			int thumb = itm.ThumbHeight;
			if( thumb > 0 )
				{
				itemstrings[0] = "Thumb Height"; itemstrings[1] = itm.ThumbHeight.ToString();
				view.Items.Add( new ListViewItem( itemstrings ) );
				itemstrings[0] = "Thumb Width"; itemstrings[1] = itm.ThumbWidth.ToString();
				view.Items.Add( new ListViewItem( itemstrings ) );
				itemstrings[0] = "Thumbnail"; itemstrings[1] = itm.Thumbnail;
				view.Items.Add( new ListViewItem( itemstrings ) );
				}


			// ==============================================================================
			// property lists below are not WIA Scripting properties, try to get them by ID

			if( (flags & WiaItemFlag.Device) != 0 )		// device
				{
				itemstrings[0] = "-------------------"; itemstrings[1] = "-------------------";
				view.Items.Add( new ListViewItem( itemstrings ) );
				
				FillPropsById( itm, view, DevicePropMap.id, DevicePropMap.name );
				if( (devType & WiaDevType.Mask) == WiaDevType.Scanner )						// Scanner device
					FillPropsById( itm, view, ScannerDevicePropMap.id, ScannerDevicePropMap.name );
				else if( (devType & WiaDevType.Mask) == WiaDevType.DigiCam )				// DigiCam device
					FillPropsById( itm, view, DigiCamDevicePropMap.id, DigiCamDevicePropMap.name );
				else if( (devType & WiaDevType.Mask) == WiaDevType.Video )					// Video device
					FillPropsById( itm, view, VideoDevicePropMap.id, VideoDevicePropMap.name );

				}

			itemstrings[0] = "-------------------"; itemstrings[1] = "-------------------";
			view.Items.Add( new ListViewItem( itemstrings ) );

			FillPropsById( itm, view, ItemPropMap.id, ItemPropMap.name );

			if( (flags & WiaItemFlag.Image) != 0 )
				{
				if( (devType & WiaDevType.Mask) == WiaDevType.Scanner )						// Scanner device
					FillPropsById( itm, view, ScannerItemPropMap.id, ScannerItemPropMap.name );
				else if( (devType & WiaDevType.Mask) == WiaDevType.DigiCam )				// DigiCam device
					FillPropsById( itm, view, DigiCamItemPropMap.id, DigiCamItemPropMap.name );
				}

			}
		catch( Exception )
			{
			}
		view.EndUpdate();
		}

		/// <summary> get a group of item properties. </summary>
	public static void FillPropsById( ItemClass itm, ListView view, int[] ids, string[] names )
		{
		long start = Environment.TickCount;		// WARNING: start timer for slow serial cable devices
		
		string[]	itemstrings = new string[ 3 ];
		for( int i = 0; i < ids.Length; i++ )
			{
			int tick = Environment.TickCount;		// WARNING: slow serial cable devices take too long for me
			if( (tick - start) > 100 )				// just stop after 100ms
				break;
			
			object val = itm.GetPropById( (WiaItemPropertyId) ids[ i ] );
			if( val != null )
				{
				itemstrings[0] = names[i]; itemstrings[1] = val.ToString(); itemstrings[2] = ids[i].ToString();
				view.Items.Add( new ListViewItem( itemstrings ) );
				Trace.WriteLine( "    --> got: " + itemstrings[1] );
				}
			}
		}
	}

}
