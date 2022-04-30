using System;
using System.Text.RegularExpressions;

namespace _03_SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex namePattern = new Regex(@"(%)(?<name>[A-Z]{1}[a-z]+)\1");
            Regex productPattern = new Regex(@"<(?<product>\w+)>");
            Regex countPattern = new Regex(@"(\|)(?<count>\d+)\1");
            Regex PricePattern = new Regex(@"(?<price>[\d\.]+)\$");

            double totalIncome = 0;

            while (input != "end of shift")
            {
                bool isName = namePattern.IsMatch(input);
                bool isProduct = productPattern.IsMatch(input);
                bool isCount = countPattern.IsMatch(input);
                bool isPrice = PricePattern.IsMatch(input);

                if (isName && isProduct && isCount && isPrice)
                {
                    Match matchName = namePattern.Match(input);
                    Match matchProduct = productPattern.Match(input);
                    Match matchCount = countPattern.Match(input);
                    Match matchPrice = PricePattern.Match(input);

                    string name = matchName.Groups["name"].Value;
                    string product = matchProduct.Groups["product"].Value;
                    int count = Convert.ToInt32(matchCount.Groups["count"].Value);
                    double price = Convert.ToDouble(matchPrice.Groups["price"].Value);
                    double totalPrice = count * price;

                    totalIncome += totalPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}"); 
        }
    }
}
