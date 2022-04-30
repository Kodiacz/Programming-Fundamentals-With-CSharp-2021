using System;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int[] numbers = new int[split.Length];
            int[] condensed = new int[numbers.Length - 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(split[i]);
            }

            if (input.Length > 2)
            {
                while (true)
                {
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        condensed[i] = numbers[i] + numbers[i + 1];
                    }

                    numbers = condensed;

                    if (condensed.Length == 1)
                    {
                        break;
                    }
                    else if (condensed[0] == 1)
                    {
                        break;
                    }

                    condensed = new int[condensed.Length - 1];
                }

                Console.WriteLine(condensed[0]);
            }
            else
            {
                Console.WriteLine(input);

            }
        }
    }
}
