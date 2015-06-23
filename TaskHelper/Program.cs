using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlLiteTest.HelloWorld;
using Managers;
using DataContracts;

namespace SqlLiteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicCrud.Run();

			List<TaskGroup> results = new TaskGroupManager().FindAll();

			Console.WriteLine("Successful Run");

			Console.ReadKey();
        }
    }
}
