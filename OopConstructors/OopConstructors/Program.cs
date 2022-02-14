using System;

namespace OopConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.AddProduct("paine", 1, 5);
            o.AddProduct("coca-ocola", 1, 2);
            o.Print();


            /*Person p = new Person("John","Doe",new DateTime(1980,2,14));

            Person d = new Person();

            d.Print();

            ApplicationLog log = ApplicationLog.Instance;

            log.Write("test error");

            MyApplication myApp = new MyApplication();
            myApp.DoWork();
            Console.WriteLine(MyApplication.StartDate);*/
        }
    }
}
