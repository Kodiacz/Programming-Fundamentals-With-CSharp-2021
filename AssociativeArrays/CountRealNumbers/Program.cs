using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            double[] numbersAsArray = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbersAsArray.Length; i++)
            {
                if (!numbers.ContainsKey(numbersAsArray[i]))
                {
                    numbers.Add(numbersAsArray[i], 0);
                }

                numbers[numbersAsArray[i]]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
