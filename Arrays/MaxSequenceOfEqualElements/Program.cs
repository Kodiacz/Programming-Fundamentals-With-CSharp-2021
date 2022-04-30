using System;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 1 1 2 3 3 2 2 2 1
            // 1 1 1 2 3 1 3 3
            // 0 1 1 5 2 2 6 3 3

            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int counter = 1;
            int counterCopy = 1;
            string output = string.Empty;

            for (int i = 0; i < split.Length - 1; i++)
            {
                if (split[i] == split[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counterCopy < counter)
                {
                    counterCopy = counter;
                    output = split[i];
                }
            }

            if (counterCopy > split.Length)
            {
                counterCopy -= 1;
            }

            for (int i = 0; i < counterCopy; i++)
            {
                if (i == counterCopy - 1)
                {
                    Console.WriteLine(output);
                    break;
                }

                Console.Write($"{output} ");
            }
        }
    }
}
