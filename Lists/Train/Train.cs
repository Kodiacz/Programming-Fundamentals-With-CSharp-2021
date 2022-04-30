using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());
            int newPassengers = 0;
            string[] input = Console.ReadLine().Split(' ');
            bool isNumber = int.TryParse(input[0], out newPassengers);

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else if (isNumber)
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= capacity)
                        {
                            wagons[i] += newPassengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine().Split(' ');
                isNumber = int.TryParse(input[0], out newPassengers);
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
