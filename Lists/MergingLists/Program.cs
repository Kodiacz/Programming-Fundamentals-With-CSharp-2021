using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();

            List<string> firstNumbers = firstText.Split(' ').ToList();
            List<string> secondNumbers = secondText.Split(' ').ToList();
            List<string> mergedNumbers = new List<string>();

            int rotation = 0;

            if (firstNumbers.Count >= secondNumbers.Count)
            {
                rotation = firstNumbers.Count;
            }
            else
            {
                rotation = secondNumbers.Count;
            }

            for (int i = 0; i < rotation; i++)
            {
                if (i < firstNumbers.Count)
                {
                    mergedNumbers.Add(firstNumbers[i]);
                }

                if (i < secondNumbers.Count)
                {
                    mergedNumbers.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", mergedNumbers));
        }
    }
}
