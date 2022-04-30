using System;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            string[] arrayOfAsterisks = new string[input.Length];

            string text = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = 0; k < input[i].Length; k++)
                {
                    arrayOfAsterisks[i] += '*';
                }

                text = text.Replace(input[i], arrayOfAsterisks[i]);
            }

            Console.WriteLine(text);
        }
    }
}
