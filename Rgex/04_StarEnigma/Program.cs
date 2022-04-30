using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
/*
1st Test:

2
STCDoghudd4=63333$D$0A53333
EHfsytsnhf?8555&I&2C9555SR

2nd Test:

3
tt(''DGsvywgerx>6444444444%H%1B9444
GQhrr|A977777(H(TTTT
EHfsytsnhf?8555&I&2C9555SR
*/

            int lines = int.Parse(Console.ReadLine());

            Regex planetNamePattern = new Regex(@"@(?<name>[a-zA-Z]+)");
            Regex planetPopulationPattern = new Regex(@":(?<population>\d+)");
            Regex attackTypePattern = new Regex(@"!(?<attackType>[AD]{1})!");
            Regex soldierCountPattern = new Regex(@"->(?<soldierCount>\d+)");
            Regex starPattern = new Regex(@"[starSTAR]");

            Dictionary<string, List<string>> planets = new Dictionary<string, List<string>>()
            {
                { "Attacked", new List<string>() },
                { "Destroyed", new List<string>() }
            };

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string text = "";
                MatchCollection starMatches = starPattern.Matches(input);
                int count = Convert.ToInt32(starMatches.Count);

                for (int k = 0; k < input.Length; k++)
                {
                    text += Convert.ToChar(input[k] - count);
                }

                bool isName = planetNamePattern.IsMatch(text);
                bool isPopulation = planetPopulationPattern.IsMatch(text);
                bool isattackType = attackTypePattern.IsMatch(text);
                bool isSoldierCount = soldierCountPattern.IsMatch(text);

                if (isName && isPopulation && isattackType && isSoldierCount)
                {
                    Match matchName = planetNamePattern.Match(text);
                    Match matchAttackType = attackTypePattern.Match(text);

                    string name = matchName.Groups["name"].Value;

                    if (matchAttackType.Groups["attackType"].Value == "A")
                    {

                        planets["Attacked"].Add(name);
                    }
                    else
                    {
                        planets["Destroyed"].Add(name);
                    }
                }
            }

            foreach (var planet in planets)
            {
                planet.Value.Sort();
                Console.WriteLine($"{planet.Key} planets: {planet.Value.Count}");

                if (planet.Value.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"-> {string.Join("\n-> ", planet.Value)}");
            }
        }
    }
}
