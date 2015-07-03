using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContracts;

namespace Accessors
{
    public class TaskGroupAccessor
    {
		public List<TaskGroup> FindAll()
        {
            using (var context = new ChinookContext())
            {
				return context.TaskGroups.ToList ();
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
    }
}
