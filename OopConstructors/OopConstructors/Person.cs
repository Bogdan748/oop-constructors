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
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = new DateTime(1950, 1, 1);
        }




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
