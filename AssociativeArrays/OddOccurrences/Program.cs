using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Select(w => w.ToLower()).ToArray();
            Dictionary<string, List<string>> oddOccurrence = new Dictionary<string, List<string>>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!oddOccurrence.ContainsKey(words[i]))
                {
                    oddOccurrence.Add(words[i], new List<string>());
                }

                oddOccurrence[words[i]].Add(words[i]);
            }

            foreach (var item in oddOccurrence)
            {
                if (item.Value.Count % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
