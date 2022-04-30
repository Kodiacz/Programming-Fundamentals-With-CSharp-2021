using System;

namespace CharactersInRange
{
    class CharactersInRange
    {
        static void Main(string[] args)
        {
            char firstSign = char.Parse(Console.ReadLine());
            char secondSign = char.Parse(Console.ReadLine());

            if (firstSign > secondSign)
            {
                PrintFromFirstToSecond(secondSign, firstSign);

            }
            else
            {
                PrintFromFirstToSecond(firstSign, secondSign);
            }
        }

        private static void PrintFromFirstToSecond(char first, char second)
        {
            for (int i = first + 1; i < second; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
        }
    }
}
