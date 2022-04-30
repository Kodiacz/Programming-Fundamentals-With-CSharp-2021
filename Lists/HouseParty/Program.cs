using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input.Length == 3)
                {
                    if (guests.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(input[0]);
                    }
                }
                else
                {
                    if (!guests.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(input[0]);
                    }
                }
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
