using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContracts;

namespace Accessors
{
    public class TaskAccessor
    {
		public List<DataContracts.Task> FindAll()
        {
            using (var context = new ChinookContext())
            {
				return context.Tasks.ToList ();
            }

            // ### Add a db record
            //using (var context = new ChinookContext())
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
			using (var context = new ChinookContext())
			{
				return context.Tasks
					.Where(w => w.TaskGroupId == TaskGroupId)
					.ToList ();
			}
		}
    }
}
