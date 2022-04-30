using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            //// \b(?<date>\d{2})(.)(?<month>[A-z]{3})\2(?<year>\d{4})\b
            //// [0-9]{2}(?<separator>.)[A-Z][a-z]{2}\k<separator>[0-9]{4}
            //// string text = "13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016";
            //string input = Console.ReadLine();
            //Regex datePattern = new Regex(@"(?<date>[0-9]{2})(?<separator>.)(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})");
            //MatchCollection validDates = datePattern.Matches(input);

            //foreach (Match date in validDates)
            //{
            //    var day = date.Groups["date"].Value;
            //    var month = date.Groups["month"].Value;
            //    var year = date.Groups["year"].Value;

            //    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            //}

            string pattern = @"\b(?<date>\d{2})(.)(?<month>[A-z]{3})\2(?<year>\d{4})\b";
            string input = @"13/Jul/1928
                             10-Nov-1934
                             25.Dec.1937
                             01/Jan-1951
                             23/sept/1973
                             1/Feb/2016";
            MatchCollection validDates = Regex.Matches(input, pattern);

            foreach (Match date in validDates)
            {
                Console.WriteLine($"Day: {date.Groups["date"].Value}, Month: {date.Groups["month"].Value}, Year {date.Groups["year"].Value}");
            }

        }
    }
}
