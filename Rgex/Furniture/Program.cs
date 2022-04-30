using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMatch = true;
            decimal totalSum = 0;
            List<string> products = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Regex pattern = new Regex(@">>(?<product>\w+)<<(?<price>\d+.\d+)!(?<quantity>\d+)");
                MatchCollection product = pattern.Matches(input);
                isMatch = pattern.IsMatch(input);

                foreach (Match match in product)
                {
                    if (isMatch)
                    {
                        products.Add(match.Groups["product"].Value);
                        totalSum += Convert.ToDecimal(match.Groups["price"].Value) * Convert.ToInt32(match.Groups["quantity"].Value);
                    }
                }
            }

            Console.WriteLine("Bought furniture:");
            Console.WriteLine(String.Join("\n", products));
            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
