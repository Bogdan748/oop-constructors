using System;

namespace OopConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John","Doe",new DateTime(1980,2,14));

            Person d = new Person();

            d.Print();
        }
    }
}
