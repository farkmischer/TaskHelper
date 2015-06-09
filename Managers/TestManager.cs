using System;
using Accessors;

namespace Managers
{
	public class TestManager
	{
		public void RunEntityExample ()
		{
			Console.WriteLine ("Manager");
			new TestAccessor().RunEntityExample();
		}
	}
}

