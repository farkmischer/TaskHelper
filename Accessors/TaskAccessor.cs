using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContracts;
using System.Data.Entity.Infrastructure;

namespace Accessors
{
    public class TaskAccessor
    {
		public List<DataContracts.Task> FindAll()
        {
            using (var context = new TaskDatabaseContext())
            {
				return context.Tasks.ToList ();
            }

            // ### Add a db record
            //using (var context = new chinookContext())
            //{
            //    context.Artists.Add(
            //        new Artist
            //        {
            //            Name = "Anberlin",
            //            Albums =
            //            {
            //                new Album { Title = "Cities" },
            //                new Album { Title = "New Surrender" }
            //            }
            //        });
            //    context.SaveChanges();
            //}

//            Console.ReadKey();
        }

		public List<DataContracts.Task> FindByTaskGroup(int TaskGroupId)
		{
			using (var context = new TaskDatabaseContext())
			{
				return context.Tasks
					.Where(w => w.TaskGroupId == TaskGroupId)
					.ToList ();
			}
		}

		public DataContracts.Task Find(int TaskId)
		{
			using (var context = new TaskDatabaseContext())
			{
				return context.Tasks.Find(TaskId);
			}
		}

		public void Save(DataContracts.Task saveTask)
		{
			using (var context = new TaskDatabaseContext ()) 
			{
				//var test1 = context.Tasks.Attach (saveTask);
				//context.Context.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);  
				//context.ChangeTracker.DetectChanges (); 
				DbEntityEntry<DataContracts.Task> entry = context.Entry (saveTask);
				//entry.GetDatabaseValues ();
				entry.State = System.Data.Entity.EntityState.Modified;

				//bool test = context.ChangeTracker.HasChanges();

				//bool test2 = context.Configuration.AutoDetectChangesEnabled;

				//var test4 = context.GetValidationErrors ();

				foreach (var propertyName in entry.CurrentValues.PropertyNames )
				{
					Console.WriteLine("Property Name: {0}", propertyName);

					//get original value
					var orgVal = entry.OriginalValues[propertyName];
					Console.WriteLine("     Original Value: {0}", orgVal);

					//get current values
					var curVal = entry.CurrentValues[propertyName];
					Console.WriteLine("     Current Value: {0}", curVal);
				}

				int i = context.SaveChanges ();
			}
		}

    }
}
