using System;
using System.Collections.Generic;


namespace supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string custumer = Console.ReadLine();
            while (custumer != "End")
            {
                if (custumer == "Paid")
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                    queue.Clear();
                    custumer = Console.ReadLine();
                    continue;
                }
                queue.Enqueue(custumer);
                custumer = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
