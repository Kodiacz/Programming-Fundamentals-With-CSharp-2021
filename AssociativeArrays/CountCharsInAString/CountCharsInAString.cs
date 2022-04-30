using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    class CountCharsInAString
    {
        public static object Diction { get; private set; }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<char, int> countingChars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];

                for (int k = 0; k < word.Length; k++)
                {
                    if (!countingChars.ContainsKey(word[k]))
                    {
                        countingChars.Add(word[k], 0);
                    }

                    countingChars[word[k]]++;
                }
            }

            foreach (var item in countingChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
