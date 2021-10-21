using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
            string[] action = new string[2];
            while (songs.Count > 0)
            {
               action = Console.ReadLine().Split(" ");
                if (action[0] == "Add")
                {
                    if (songs.Contains(action[1]))
                    {

                        Console.WriteLine($"{action[1]} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(action[1]);
                    }
                }
                else if (action[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
                else if (action[0] == "Play")
                {
                    songs.Dequeue();
                }

            }
            Console.WriteLine("No more songs!");

        }
    }
}
