using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input;
            string output;
            char firstChar;
            char secondChar;
            char thirdChar;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                Regex codePattern = new Regex(@"^([$%])(?<name>[A-Z]{1}[a-z]{2,})\1: \[(?<first>[0-9]+)\]\|\[(?<second>[0-9]+)\]\|\[(?<third>[0-9]+)\]\|$");
                Match match = codePattern.Match(input);

                if (codePattern.IsMatch(input))
                {
                    int temp1 = Convert.ToInt32(match.Groups["first"].Value);
                    firstChar = Convert.ToChar(temp1);
                    int temp2 = Convert.ToInt32(match.Groups["second"].Value);
                    secondChar = (char)temp2;
                    int temp3 = Convert.ToInt32(match.Groups["third"].Value);
                    thirdChar = (char)temp3;

                    output = Convert.ToString(firstChar) + Convert.ToString(secondChar) + Convert.ToString(thirdChar);
                    Console.WriteLine($"{match.Groups["name"]}: {output}");
                }
                else
                {
                    output = "Valid message not found!";
                    Console.WriteLine(output);
                }
            }
        }
    }
}
