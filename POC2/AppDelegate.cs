using System;
using ServiceClient;
using Foundation;
using AppKit;

using SimpleInjector;

namespace POC2
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		MainWindowController mainWindowController;
		public static Container container;

		public AppDelegate ()
		{
			container = new Container();
			RegisterDependencies ();
		}

		void RegisterDependencies()
		{
			container.Register<IWork, Work>();
			container.Register<MainWindowController>(() => new MainWindowController(container.GetInstance<IWork>()));
			container.Verify ();
		}

		public override void DidFinishLaunching (NSNotification notification)
		{
			//mainWindowController = new MainWindowController (new Work());
			mainWindowController = container.GetInstance<MainWindowController>();
			mainWindowController.Window.MakeKeyAndOrderFront (this);
		}
	}
}

