using System;
using System.Collections.Generic;

namespace _03exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string names = string.Empty;
            Dictionary<string, List<string>> nameMeal = new Dictionary<string, List<string>>();
            int unLikeMeal = 0;
            while (input != "Stop")
            {
                string[] inputArray = input.Split("-");
                if (inputArray[0] == "Like")
                {
                    if (!nameMeal.ContainsKey(inputArray[1]))
                    {
                        nameMeal.Add(inputArray[1], new List<string>() { inputArray[2] });
                    }
                    else
                    {
                        if (!nameMeal[inputArray[1]].Contains(inputArray[2]))
                        {
                            nameMeal[inputArray[1]].Add(inputArray[2]);
                        }
                    }

                }
                else
                {
                    if (!nameMeal.ContainsKey(inputArray[1]))
                    {
                        Console.WriteLine($"{inputArray[1]} is not at the party.");
                        input = Console.ReadLine();
                        continue;
                    }
                    if (nameMeal[inputArray[1]].Contains(inputArray[2]))
                    {
                        nameMeal[inputArray[1]].Remove(inputArray[2]);
                        Console.WriteLine($"{inputArray[1]} doesn't like the {inputArray[2]}.");
                        input = Console.ReadLine();
                        continue;
                    }
                    if (!nameMeal[inputArray[1]].Contains(inputArray[2]))
                    {
                        nameMeal[inputArray[1]].Remove(inputArray[2]);
                        Console.WriteLine($"{ inputArray[1]} doesn't have the {inputArray[2]} in his/her collection.");
                        input = Console.ReadLine();
                        continue;
                    }


                }

                input = Console.ReadLine();
            }

            foreach (var item in nameMeal)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
