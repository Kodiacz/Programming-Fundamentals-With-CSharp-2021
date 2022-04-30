using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            int bestDnaSum = 0;
            int count = 0;
            int bestDnacount = 0;
            int index = 0;
            int BestDnaIndex = 0;
            int bestSequenceIndex = 0;
            int bestSequenceindexCount = 0;
            int[] numbers = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bestDna = new int[numbers.Length];

            while (input != "Clone them!")
            {
                count = 0;
                index = 0;
                sum = 0;
                bestDnacount = 0;
                BestDnaIndex = 0;
                bestDnaSum = 0;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1] && numbers[i] == 1 && numbers[i + 1] == 1)  // the count of "one's" sequence and the index of first "one"
                    {
                        count++;
                        index = i;
                    }

                    if (bestDna[i] == bestDna[i + 1] && bestDna[i] == 1 && bestDna[i + 1] == 1)
                    {
                        bestDnacount++;
                        BestDnaIndex = i;
                    }


                    sum += numbers[i];                      // get the sum
                    bestDnaSum += bestDna[i];

                    if (i == numbers.Length - 2)            //
                    {
                        sum += numbers[numbers.Length - 1]; //
                    }

                    if (i == bestDna.Length - 2)
                    {
                        bestDnaSum += bestDna[bestDna.Length - 1];
                    }
                }

                bestSequenceindexCount++;

                if (count > bestDnacount)
                {
                    bestDna = numbers;
                    bestSequenceIndex = bestSequenceindexCount;
                }
                else if (count == bestDnacount)
                {
                    if (index < BestDnaIndex)
                    {
                        bestDna = numbers;
                        bestSequenceIndex = bestSequenceindexCount;
                    }
                }
                else if (count == bestDnacount && index == BestDnaIndex)
                {
                    if (sum > bestDnaSum)
                    {
                        bestDna = numbers;
                        bestSequenceIndex = bestSequenceindexCount;
                    }
                }

                input = Console.ReadLine();

                if (input != "Clone them!")
                {
                    numbers = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                }
            }

            bestDnaSum = 0;

            for (int i = 0; i < bestDna.Length; i++)
            {
                bestDnaSum += bestDna[i];
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestDnaSum}.");
            Console.WriteLine(String.Join(" ", bestDna));
        }
    }
}
