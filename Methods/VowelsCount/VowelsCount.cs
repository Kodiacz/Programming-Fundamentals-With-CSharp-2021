using System;

namespace VowelsCount
{
    class VowelsCount
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            CountVowels(input);
        }

        private static void CountVowels(string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (Convert.ToString(text[i]).ToLower() == "a" || Convert.ToString(text[i]).ToLower() == "e" || Convert.ToString(text[i]).ToLower() == "i" || Convert.ToString(text[i]).ToLower() == "o" || Convert.ToString(text[i]).ToLower() == "u")
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
