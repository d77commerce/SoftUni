using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int maxOrder = orders.Max();
            int count = orders.Count();
            for (int i = 0; i < count; i++)
            {
                if (foodQuantity - orders.Peek() >= 0)
                {
                    foodQuantity -= orders.Dequeue();
                }
                else
                {
                    break;
                }
              
            }
            Console.WriteLine(maxOrder);
            Console.WriteLine(orders.Count <= 0 ? "Orders complete" :$"Orders left: {string.Join(" ", orders)}");
        }
    }
}
