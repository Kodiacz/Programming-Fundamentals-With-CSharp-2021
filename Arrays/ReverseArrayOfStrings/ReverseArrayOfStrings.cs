using System;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split(' ');
            string[] reversedText = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                reversedText[text.Length - 1 - i] = text[i];
            }

            Console.WriteLine(String.Join(" ", reversedText));
        }
    }
}
