using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection fullName = regex.Matches(text);

            foreach (Match matche in fullName)
            {
                Console.Write(matche + " ");
            }
        }
    }
}
