using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConstructors
{
    public class ApplicationLog
    {

        private ApplicationLog() { }

        public static ApplicationLog Instance { get; } = new ApplicationLog();

        public void Write (string message)
        {
            Console.WriteLine($"Error log{message}");
        }
    }
}
