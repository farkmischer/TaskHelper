using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using DataContracts;
using System.Data.Entity.Infrastructure;

namespace Accessors
{
    public class TaskRunGroupHistoryAccessor
    {
		public List<TaskRunGroupHistory> FindAll()
        {
            using (var context = new TaskDatabaseContext())
            {
				return context.TaskRunGroupHistories.ToList ();
            }

        }

		public List<TaskRunGroupHistory> FindByTaskGroup(int TaskGroupId)
		{
			using (var context = new TaskDatabaseContext())
			{
				return context.TaskRunGroupHistories
					.Where(w => w.TaskGroupId == TaskGroupId)
					.ToList ();
			}
		}

		public TaskRunGroupHistory Find(int TaskId)
		{
			using (var context = new TaskDatabaseContext())
			{
				return context.TaskRunGroupHistories.Find(TaskId);
			}
		}

		public ActionResult<TaskRunGroupHistory> Save(TaskRunGroupHistory saveTask)
		{
			using (var context = new TaskDatabaseContext ()) 
			{
				//var test1 = context.Tasks.Attach (saveTask);
				//context.Context.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);  
				//context.ChangeTracker.DetectChanges (); 
				DbEntityEntry<TaskRunGroupHistory> entry = context.Entry (saveTask);
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

				return new ActionResult<TaskRunGroupHistory> () {
					ReturnObject = saveTask,
				};


			}
		}

    }
}
