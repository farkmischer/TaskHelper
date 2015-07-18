using System;
using Accessors;
using DataContracts;
using System.Collections.Generic;

namespace Managers
{
	public class TaskRunGroupHistoryManager
	{
//		public List<Task> FindAll ()
//		{
//			Console.WriteLine ("Manager");
//			return new TaskAccessor().FindAll();
//		}

		public List<TaskRunGroupHistory> FindByTaskGroup (int TaskGroupId)
		{
			return new TaskRunGroupHistoryAccessor ().FindByTaskGroup (TaskGroupId);
		}

		public ActionResult<TaskRunGroupHistory> CompleteGroupTask(int TaskId)
		{
			TaskRunGroupHistory taskGroup = new TaskRunGroupHistoryAccessor ().Find (TaskId);

			taskGroup.TimeRunCompleted = DateTime.Now;

			return new TaskRunGroupHistoryAccessor ().Save (taskGroup);


		}

		public ActionResult<TaskRunGroupHistory> Save(TaskRunGroupHistory saveTask)
		{
			return new TaskRunGroupHistoryAccessor().Save(saveTask);
		}
	}
}

