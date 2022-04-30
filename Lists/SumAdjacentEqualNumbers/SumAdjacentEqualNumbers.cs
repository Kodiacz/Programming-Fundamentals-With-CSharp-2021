using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> splitting = text.Split(' ').ToList();
            List<decimal> numbers = new List<decimal>();

            for (int i = 0; i < splitting.Count; i++)
            {
                numbers.Add(Convert.ToDecimal(splitting[i]));
            }

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    numbers[i - 1] += numbers[i];
                    numbers.RemoveAt(i);
                    i = 0;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
