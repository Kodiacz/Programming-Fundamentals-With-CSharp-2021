using System;

namespace RepeatStrings
{
    class RepeatStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = 0; k < input[i].Length; k++)
                {
                    output += input[i];
                }
            }

            Console.WriteLine(output);


        }
    }
}
