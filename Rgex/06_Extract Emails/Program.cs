using System;
using System.Text.RegularExpressions;

namespace _06_Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex emailRegex = new Regex(@"[a-zA-Z0-9]+[\.\-_]?[a-zA-Z0-9]+@[a-zA-Z0-9\-]+\.[a-zA-Z0-9\-\.]+[^\W]");
            MatchCollection emails = emailRegex.Matches(text);

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
