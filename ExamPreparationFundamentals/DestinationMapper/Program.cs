using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int travelPoints = 0;
            Regex validDestinationPattern = new Regex(@"([=\/])(?<destinations>[A-Z]{1}[a-zA-Z]{2,})\1");
            MatchCollection collectionOfMatches = validDestinationPattern.Matches(input);
            List<string> validDestinations = new List<string>();

            foreach (Match destination in collectionOfMatches)
            {
                travelPoints += destination.Groups["destinations"].Value.Length;
                validDestinations.Add(destination.Groups["destinations"].Value);
            }

            Console.WriteLine($"Destinations: {String.Join(", ", validDestinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
