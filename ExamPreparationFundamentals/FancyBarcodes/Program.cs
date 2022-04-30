using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string productNumber = "";
            bool isMatch;
            bool isDigit;

            Regex barcodePattern = new Regex(@"^(@#+)[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1}\1$");
            Regex digits = new Regex(@"(\d+)");

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                isMatch = barcodePattern.IsMatch(text);
                isDigit = digits.IsMatch(text);

                if (isMatch)
                {
                    if (isDigit)
                    {
                        MatchCollection matches = digits.Matches(text);

                        for (int k = 0; k < matches.Count; k++)
                        {
                            productNumber += Convert.ToString(matches[k]);
                        }

                        Console.WriteLine($"Product group: {productNumber}");
                    }
                    else
                    {
                        productNumber = "00";
                        Console.WriteLine($"Product group: {productNumber}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

                productNumber = "";
            }
        }
    }
}
