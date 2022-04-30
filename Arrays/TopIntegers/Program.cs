using System;

namespace TopIntegers
{
    class TopIntegers
    {
        static void Main(string[] args)
        {
            // 37 64 5 107 8 6 passed
            // 1 4 3 2 0

            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int[] numbers = new int[split.Length];
            int[] topIntegers = new int[split.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(split[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] > numbers[k])
                    {
                        topIntegers[i] = numbers[i];
                    }
                    else
                    {
                        topIntegers[i] = 0;
                        break;
                    }
                }
            }

            topIntegers[topIntegers.Length - 1] = numbers[numbers.Length - 1];

            for (int i = 0; i < topIntegers.Length; i++)
            {
                if (topIntegers[i] != 0 && i < topIntegers.Length - 1)
                {
                    Console.Write($"{topIntegers[i]} ");
                }
                else if (i == topIntegers.Length - 1)
                {
                    Console.Write(numbers[i]);
                }
            }
        }
    }
}
