using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConstructors
{
    public class Order
    {
        //alocam maxim 100 pozitii
        private OrderItem[] items = new OrderItem[100];
        private int lastOrderItemIndex = -1;

        public decimal Tota { get; private set; }
        public void AddProduct(string name, int quantity, decimal price)
        {
            if (lastOrderItemIndex < 100)
            {

                OrderItem newItem = new OrderItem
                {
                    ProductName = name,
                    Quantity = quantity,
                    Price = price
                };

                lastOrderItemIndex++;
                items[lastOrderItemIndex] = newItem;
            }


        }

        public void Print()
        {
            Console.WriteLine(new string('=', 59));
            Console.WriteLine($"{"Produs",-20} | {"Quantity",10} | {"Unit price",10} | {"Total",10}");
            Console.WriteLine(new string('=', 59));
            for (int i = 0; i <= lastOrderItemIndex; i++)
            {

                Console.WriteLine($"{items[i].ProductName,-20} | {items[i].Quantity,10} | {items[i].Price,10} | {items[i].ItemTotal,10}");
            }
            Console.WriteLine(new string('=', 59));
        }

        private class OrderItem
        {
            public string ProductName { get; set; }

            public int Quantity { get; set; }

            public decimal Price { get; set; }

            public decimal ItemTotal
            {
                get
                {
                    return Quantity * Price;
                }
            }


        }
    }
}
