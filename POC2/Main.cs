using System;
using SimpleInjector;
using AppKit;

namespace POC2
{
	static class MainClass
	{

		static void Main (string[] args)
		{
			NSApplication.Init ();
			NSApplication.Main (args);
		}
			
	}
}
