using System;

namespace ZigZagArrays
{
    class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] firstOutput = new int[lines];
            int[] secondOutput = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string[] split = input.Split(' ');

                if (i % 2 == 0)
                {
                    firstOutput[i] = Convert.ToInt32(split[0]);
                    secondOutput[i] = Convert.ToInt32(split[1]);
                }
                else
                {
                    firstOutput[i] = Convert.ToInt32(split[1]);
                    secondOutput[i] = Convert.ToInt32(split[0]);
                }
            }

            Console.WriteLine(String.Join(" ", firstOutput));
            Console.WriteLine(String.Join(" ", secondOutput));
        }
    }
}
