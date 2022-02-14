using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConstructors
{
    class MyApplication
    {
        static MyApplication()
        {
            Console.WriteLine("app is starting");
            StartDate = DateTime.Now;
        }

        public static DateTime StartDate { get; } = DateTime.Now;
        public void DoWork()
        {
            Console.WriteLine("App running");
        }
    }
}
