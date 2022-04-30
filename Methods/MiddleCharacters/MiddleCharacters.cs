using System;

namespace MiddleCharacters
{
    class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddle(input);
        }

        private static void PrintMiddle(string text)
        {
            int index = text.Length / 2;

            if (text.Length % 2 == 0 && text.Length > 2)
            {
                Console.WriteLine($"{text[index - 1]}{text[index]}");
            }
            else if (text.Length % 2 != 0 && text.Length > 2)
            {
                Console.WriteLine($"{text[index]}");
            }
            else if (text.Length == 1 || text.Length == 2)
            {
                Console.WriteLine(text);
            }
        }
    }
}
