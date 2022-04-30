using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex patternForPhoneNumbers = new Regex(@"\+359( |-)\d{1}\1\d{3}\1\d{4}\b");
            MatchCollection matches = patternForPhoneNumbers.Matches(input);
            string[] validPhoneNUmbers = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(String.Join(", ", validPhoneNUmbers));
        }
    }
}
