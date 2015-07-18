using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DataContracts;
using System.Data.Entity.Infrastructure;

namespace Accessors
{
    public class TaskRunHistoryAccessor
    {
		public List<TaskRunHistory> FindAll()
        {
            using (var context = new TaskDatabaseContext())
            {
				return context.TaskRunHistories.ToList ();
            }

        }

		public List<TaskRunHistory> FindByTaskGroup(int TaskGroupId)
		{
			using (var context = new TaskDatabaseContext())
			{
				return context.TaskRunHistories
					.Where(w => w.TaskRunGroupHistoryId == TaskGroupId)
					.ToList ();
			}
		}

		public TaskRunHistory Find(int TaskId)
		{
			using (var context = new TaskDatabaseContext())
			{
				return context.TaskRunHistories.Find(TaskId);
			}
		}

		public ActionResult<TaskRunHistory> Save(TaskRunHistory saveTask)
		{
			using (var context = new TaskDatabaseContext ()) 
			{
				//var test1 = context.Tasks.Attach (saveTask);
				//context.Context.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);  
				//context.ChangeTracker.DetectChanges (); 
				DbEntityEntry<TaskRunHistory> entry = context.Entry (saveTask);
				//entry.GetDatabaseValues ();
				if (saveTask.Id == 0) {
					entry.State = System.Data.Entity.EntityState.Added;
				} else {
					entry.State = System.Data.Entity.EntityState.Modified;
				}
				//bool test = context.ChangeTracker.HasChanges();

				//bool test2 = context.Configuration.AutoDetectChangesEnabled;

				//var test4 = context.GetValidationErrors ();

//				foreach (var propertyName in entry.CurrentValues.PropertyNames )
//				{
//					Console.WriteLine("Property Name: {0}", propertyName);
//
//					//get original value
//					var orgVal = entry.OriginalValues[propertyName];
//					Console.WriteLine("     Original Value: {0}", orgVal);
//
//					//get current values
//					var curVal = entry.CurrentValues[propertyName];
//					Console.WriteLine("     Current Value: {0}", curVal);
//				}

				int i = context.SaveChanges ();

				return new ActionResult<TaskRunHistory> () {
					ReturnObject = saveTask,
				};


			}
		}

		public TaskRunHistory FindNextOpenTask(int TaskRunGroupHistoryId)
		{
			using (var context = new TaskDatabaseContext())
			{
				return context.TaskRunHistories.Where(w => (w.TaskRunGroupHistoryId == TaskRunGroupHistoryId) && (w.CompletedAt == null)).OrderBy(o => o.CalculatedCompletionTime).FirstOrDefault();
			}
		}

    }
}
