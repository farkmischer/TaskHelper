﻿using System;
using Accessors;
using DataContracts;
using System.Collections.Generic;

namespace Managers
{
	public class TestManager
	{
		public List<TaskGroup> FindAll ()
		{
			Console.WriteLine ("Manager");
			return new TaskGroupAccessor().FindAll();
		}
	}
}

