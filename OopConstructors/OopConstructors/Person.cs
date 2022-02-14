using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConstructors
{
    public class Person
    {
        public Person()
            :this(string.Empty, string.Empty, new DateTime(1950, 1, 1))
        { 
        }

            /// <summary>
            /// Initializez etc..
            /// </summary>
            /// <param name="firstName"></param>
            /// <param name="lastName"></param>
            /// <param name="dateOfBirth"></param>
            public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void Print()
        {
            Console.WriteLine($"{this.FirstName}||{this.LastName}||{this.DateOfBirth}");
        }
    }
}
