using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ");

            Dictionary<string, int> namesAndPoints = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                namesAndPoints.Add(text[i], 0);
            }

            Regex namePattern = new Regex(@"[a-zA-Z]");
            Regex pointsPattern = new Regex(@"[0-9]");

            string code = Console.ReadLine();

            while (code != "end of race")
            {
                string tempName = "";
                int tempPoints = 0;

                MatchCollection collectionOfNames = namePattern.Matches(code);
                MatchCollection collectionOfPoints = pointsPattern.Matches(code);

                foreach (Match name in collectionOfNames)
                {
                    tempName += Convert.ToString(name.Value);
                }

                foreach (Match points in collectionOfPoints)
                {
                    tempPoints += Convert.ToInt32(points.Value);
                }

                if (namesAndPoints.ContainsKey(tempName))
                {
                    namesAndPoints[tempName] += tempPoints;
                }

                code = Console.ReadLine();
            }

            namesAndPoints = namesAndPoints.OrderByDescending(pair => pair.Value)
                                           .ToDictionary(pair => pair.Key, pair => pair.Value);
            int arrangement = 0;
            string suffix = "";

            foreach (var person in namesAndPoints)
            {

                arrangement++;

                if (arrangement == 1)
                {
                    suffix = "st";
                }
                else if (arrangement == 2)
                {
                    suffix = "nd";
                }
                else if (arrangement == 3)
                {
                    suffix = "rd";
                }
                else
                {
                    break;
                }

                Console.WriteLine($"{arrangement}{suffix} place: {person.Key}");
            }
        }
    }
}

