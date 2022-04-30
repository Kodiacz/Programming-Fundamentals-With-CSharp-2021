using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] allLetters = input.ToCharArray();
            
            for (int i = 0; i < input.Length; i++)
            {
                allLetters[i] += (char)3;
            }

            input = new string(allLetters);

            Console.WriteLine(input);

        }
    }
}
