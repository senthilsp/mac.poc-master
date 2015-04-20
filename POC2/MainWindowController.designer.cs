// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace POC2
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		AppKit.NSButton ClickMeButton { get; set; }

		[Outlet]
		AppKit.NSTextField OutputLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ClickMeButton != null) {
				ClickMeButton.Dispose ();
				ClickMeButton = null;
			}

			if (OutputLabel != null) {
				OutputLabel.Dispose ();
				OutputLabel = null;
			}
		}
	}
}
