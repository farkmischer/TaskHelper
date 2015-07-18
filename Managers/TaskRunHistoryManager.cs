using System;
using Accessors;
using DataContracts;
using System.Collections.Generic;

namespace Managers
{
	public class TaskRunHistoryManager
	{
//		public List<Task> FindAll ()
//		{
//			Console.WriteLine ("Manager");
//			return new TaskAccessor().FindAll();
//		}

		public List<TaskRunHistory> FindByTaskGroup (int TaskGroupId)
		{
			return new TaskRunHistoryAccessor ().FindByTaskGroup (TaskGroupId);
		}

		public ActionResult<TaskRunHistory> CompleteTask(int TaskId)
		{
			TaskRunHistory task = new TaskRunHistoryAccessor ().Find (TaskId);

			task.CompletedAt = DateTime.Now;

			return new TaskRunHistoryAccessor ().Save (task);


		}

		public TaskRunHistory FindNextOpenTask(int TaskRunGroupHistoryId)
		{
			return new TaskRunHistoryAccessor().FindNextOpenTask (TaskRunGroupHistoryId);
		}

		public ActionResult<TaskRunHistory> Save(TaskRunHistory saveTask)
		{
			return new TaskRunHistoryAccessor().Save(saveTask);
		}
	}
}

