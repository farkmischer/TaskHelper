using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlLiteTest.HelloWorld;
using Managers;

namespace SqlLiteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicCrud.Run();

			new TestManager().RunEntityExample();

			Console.WriteLine("Successful Run");

			Console.ReadKey();
        }
    }
}
