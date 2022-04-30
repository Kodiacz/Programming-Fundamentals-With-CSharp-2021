using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05_Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Regex healthTemplate = new Regex(@"[a-zA-Z]");
            Regex damageTemplate = new Regex(@"-?[0-9]+\.?[0-9]*");
            Regex symbolsTemplate = new Regex(@"[*\/]");

            int health = 0;
            double damage = 0;

            Dictionary<string, string[]> demons = new Dictionary<string, string[]>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains(","))
                {
                    input[i] = input[i].Replace(",", "");
                }

                if (input[i].Contains(" "))
                {
                    input[i] = input[i].Replace(" ", "");
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                MatchCollection letters = healthTemplate.Matches(input[i]);
                MatchCollection numbers = damageTemplate.Matches(input[i]);
                MatchCollection symbols = symbolsTemplate.Matches(input[i]);

                foreach (Match letter in letters)
                {
                    health += Convert.ToChar(letter.Value);
                }

                foreach (Match number in numbers)
                {
                    damage += Convert.ToDouble(number.Value);
                }

                foreach (Match symbol in symbols)
                {
                    if (symbol.Value == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                demons.Add(input[i], new string[] { $"{Convert.ToString(health)} health", $"{Convert.ToString($"{damage:F2}")} damage" });
                health = 0;
                damage = 0;
            }

            demons = demons.OrderBy(x => x.Key).ToDictionary(item => item.Key, item => item.Value);

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {string.Join(", ", demon.Value)}");
            }
        }
    }
}
