using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class GaussTrick
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> split = text.Split(' ').ToList();
            List<int> numbers = new List<int>();
            List<int> GaussNumbers = new List<int>();
            int rotations = split.Count / 2;

            for (int i = 0; i < split.Count; i++)
            {
                numbers.Add(int.Parse(split[i]));
            }

            for (int i = 0; i < rotations; i++)
            {
                GaussNumbers.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }

            if (numbers.Count % 2 != 0)
            {
                GaussNumbers.Add(numbers[rotations]);
            }

            Console.WriteLine(String.Join(" ", GaussNumbers));
        }
    }
}
