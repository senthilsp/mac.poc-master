using System;

namespace ServiceClient
{
	public class Work : IWork 
	{
		int i = 0;

		public string DoWork()
		{
			return i++.ToString();
		}
	}
}

