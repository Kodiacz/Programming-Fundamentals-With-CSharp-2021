using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" | ");
            Dictionary<string, List<string>> wordsAndDefinitions = new Dictionary<string, List<string>>();

            for (int i = 0; i < words.Length; i++)
            {
                string[] temp = words[i].Split(": ");

                if (!wordsAndDefinitions.ContainsKey(temp[0]))
                {
                    wordsAndDefinitions.Add(temp[0], new List<string> { temp[1] });
                }
                else
                {
                    wordsAndDefinitions[temp[0]].Add(temp[1]);
                }
            }

            words = Console.ReadLine().Split(" | ");
            string command = Console.ReadLine();

            if (command == "Hand Over")
            {
                wordsAndDefinitions = wordsAndDefinitions.Keys.OrderBy(x => x).ToDictionary(x => x, x => wordsAndDefinitions[x]);

                Console.WriteLine(String.Join(" ", wordsAndDefinitions.Keys));
            }
            else if (command == "Test")
            {
                //wordsAndDefinitions = wordsAndDefinitions.OrderByDescending(pair => pair.Value.Reverse()).ToDictionary(pair => pair.Key, pair => pair.Value);
                 
                foreach (var element in wordsAndDefinitions.Values)
                {
                    element.Reverse();
                }

                foreach (var word in words)
                {
                    if (wordsAndDefinitions.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");

                        for (int i = 0; i < wordsAndDefinitions[word].Count; i++)
                        {
                            Console.WriteLine($" -{wordsAndDefinitions[word][i]}");
                        }
                    }
                }
            }
        }
    }
}
