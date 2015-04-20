using System;
using NUnit.Framework;
using ServiceClient;
using POC2;
using AppKit;


namespace UnitTest
{
	[TestFixture]
	public class WorkUnitTest
	{
		[Test]
		public void DoWorkEmpty()
		{
			string result = new ServiceClient.Work ().DoWork ();

			Assert.IsNotEmpty (result);
			//Assert.AreNotSame("0",result);
		}
		[Test]
		public void DoWorkEqual()
		{
			string result = new ServiceClient.Work ().DoWork ();

			//Assert.IsNotEmpty (result);
			Assert.AreEqual("1",result);
		}

	}



}

