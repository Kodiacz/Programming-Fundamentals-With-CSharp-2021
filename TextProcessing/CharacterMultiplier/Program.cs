using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstString = input[0];
            string secondString = input[1];
            int totalSum = 0;

            if (firstString.Length >= secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (i > secondString.Length - 1)
                    {
                        totalSum += firstString[i];
                    }
                    else
                    {
                        totalSum += firstString[i] * secondString[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    if (i > firstString.Length - 1)
                    {
                        totalSum += secondString[i];
                    }
                    else
                    {
                        totalSum += firstString[i] * secondString[i];
                    }
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
