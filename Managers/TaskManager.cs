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

//		public void CompleteTask(int TaskId)
//		{
//			Task task = new TaskAccessor ().Find (TaskId);
//
//			task.Duration = 100;
//
//			new TaskAccessor ().Save (task);
//
//
//		}
	}
}

