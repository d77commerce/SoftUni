<<<<<<< HEAD
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inPut = Console.ReadLine().Split();
            Stack<string> num = new Stack<string>(inPut.Reverse());
            int total = 0;
            while (num.Count > 0)
            {
                if (num.Peek() == "+")
                {
                    num.Pop();
                    total += int.Parse(num.Pop());
                }
                else if (num.Peek() == "-")
                {
                    num.Pop();
                    total -= int.Parse(num.Pop());
                }
                else
                {
                    total += int.Parse(num.Pop());
                }
            }
            Console.WriteLine(total);
        }
    }
}
=======
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inPut = Console.ReadLine().Split();
            Stack<string> num = new Stack<string>(inPut.Reverse());
            int total = 0;
            while (num.Count > 0)
            {
                if (num.Peek() == "+")
                {
                    num.Pop();
                    total += int.Parse(num.Pop());
                }
                else if (num.Peek() == "-")
                {
                    num.Pop();
                    total -= int.Parse(num.Pop());
                }
                else
                {
                    total += int.Parse(num.Pop());
                }
            }
            Console.WriteLine(total);
        }
    }
}
>>>>>>> 632dd80a3184c34b04d16b52ae9b47109d977aa7
