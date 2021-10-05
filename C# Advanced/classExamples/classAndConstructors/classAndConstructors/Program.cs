using System;
using System.Collections.Generic;

namespace classAndConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Person(4,"Ivo");
            var order = new Order();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            customer.Orders = new List<Order>();
            
            Console.WriteLine();
        }
    }
}
