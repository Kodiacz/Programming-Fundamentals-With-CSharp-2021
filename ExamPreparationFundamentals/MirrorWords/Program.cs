using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> mirroredWords = new List<string>();
            Regex mirroredPattern = new Regex(@"([@#])(?<original>[a-zA-Z]{3,})\1\1(?<mirrored>[a-zA-Z]{3,})\1");
            MatchCollection matchFormirroredWords = mirroredPattern.Matches(input);

            foreach (Match match in matchFormirroredWords)
            {
                char[] temp = match.Groups["mirrored"].Value.ToArray();
                Array.Reverse(temp);
                string mirrored = new string(temp);
                string original = match.Groups["original"].Value;

                if (mirrored == original)
                {
                    Array.Reverse(temp);
                    mirrored = new string(temp);
                    mirroredWords.Add(original + " <=> " + mirrored);
                }
            }

            if (matchFormirroredWords.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else 
            {
                Console.WriteLine($"{matchFormirroredWords.Count} word pairs found!");

                if (mirroredWords.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(String.Join(", ", mirroredWords));
                }
            }
        }
    }
}
