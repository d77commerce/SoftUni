<<<<<<< HEAD
﻿
=======
﻿using System;
using System.Collections.Generic;

namespace _05matchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string inPut = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < inPut.Length; i++)

            {
                if (inPut[i]=='(')
                {

                    stack.Push(i);
                }
                else if (inPut[i] ==')')
                {
                    int start = stack.Pop();
                    int end = i;
                    Console.WriteLine(inPut.Substring(start, end-start+1));
                }
            }
        }
    }
}
>>>>>>> 632dd80a3184c34b04d16b52ae9b47109d977aa7
