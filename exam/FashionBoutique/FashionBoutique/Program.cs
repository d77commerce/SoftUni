using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> newGoods = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacityRack = int.Parse(Console.ReadLine());
            int racks = 1;
            int action = 0;
            int count = newGoods.Count;
            for (int i = 0; i < count; i++)
            {

                if (action + newGoods.Peek() <= capacityRack)
                {
                    action += newGoods.Pop();
                    if (action == capacityRack)
                    {
                        racks++;
                        action = 0;
                    }
                }
                else if (action + newGoods.Peek() > capacityRack)
                {
                    racks++;
                    action = 0;
                    count++;
                }

            }
            Console.WriteLine(racks); 
        }
    }
}
