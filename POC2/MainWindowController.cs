using System;
using ServiceClient;
using Foundation;
using AppKit;

namespace POC2
{
	public partial class MainWindowController : NSWindowController
	{

		private readonly IWork work; 

		public MainWindowController (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
		}

		public MainWindowController (IWork work) : base ("MainWindow")
		{
			this.work = work;
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			ClickMeButton.Activated += UpdateLabelEvent;
				
		}

		public void UpdateLabelEvent(object sender, EventArgs e)
		{
			OutputLabel.StringValue = DisplayCount ();
		}

		public string DisplayCount()
		{
			return "Count" + work.DoWork();
		}

		public new MainWindow Window {
			get { return (MainWindow)base.Window; }
		}
	}
}
