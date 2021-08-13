using System;
using System.Collections.Generic;
using System.Linq;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inPut = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArray = command.Split(" - ");
                string action = commandArray[0];
                string phone = commandArray[1];
                if (action == "Add")
                {
                    if (!inPut.Contains(phone))
                    {
                        inPut.Add(phone);
                    }

                }
                if (action == "Remove")
                {
                    if (inPut.Contains(phone))
                    {
                        inPut.Remove(phone);
                    }
                }
                if (action == "Bonus phone")
                {
                    string[] bonusPhone = commandArray[1].Split(":");
                    string oldPhone = bonusPhone[0];
                    string newPhone = bonusPhone[1];
                    if (inPut.Contains(oldPhone))
                    {
                        int indexOldPhone = inPut.IndexOf(oldPhone);
                        inPut.Insert(indexOldPhone + 1, newPhone);
                    }

                }
                if (action == "Last")
                {
                    if (inPut.Contains(phone))
                    {
                        inPut.Remove(phone);
                        inPut.Add(phone);
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",inPut));
        }
    }
}
