using System;

namespace _01extractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string name = "";
            string age = "";
            bool simbol = false;
            bool digit = false;
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                foreach (char item in input)
                {
                    if (item == '@')
                    {
                        simbol = true;
                        continue;
                    }
                    if (simbol == true && item != '|')
                    {
                        name += item;
                    }
                    if (item == '|')
                    {
                        simbol = false;
                    }
                    if (item == '#')
                    {
                        digit = true;
                        continue;
                    }
                    if (digit == true && item != '*')
                    {
                        age += item;
                    }
                    if (item == '*')
                    {
                        digit = false;
                    }
                }
                Console.WriteLine($"{name} is {age} years old.");
                name = "";
                age = "";

            }
        }
    }
}
