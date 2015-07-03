using System;
using Accessors;
using DataContracts;
using System.Collections.Generic;

namespace Managers
{
	public class TaskManager
	{
		public List<Task> FindAll ()
		{
			Console.WriteLine ("Manager");
			return new TaskAccessor().FindAll();
		}

		public List<Task> FindByTaskGroup (int TaskGroupId)
		{
			return new TaskAccessor ().FindByTaskGroup (TaskGroupId);
		}
	}
}

