using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> split = input.Split(' ').ToList();
            List<int> numbers = new List<int>();

            for (int i = 0; i < split.Count; i++)
            {
                numbers.Add(int.Parse(split[i]));
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            int[] reversedOrder = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                reversedOrder[i] = numbers[numbers.Count - 1 - i];
            }

            if (reversedOrder.Length > 0)
            {
                Console.WriteLine(String.Join(" ", reversedOrder));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
