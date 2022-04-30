using System;
using System.Text.RegularExpressions;

namespace HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"<b>Regular Expressions</b> are cool!
                             <p>I am a paragraph</p> … some text after
                             Hello, <div>I am a<code>DIV</code></div>!
                             <span>Hello, I am Span</span>
                             <a href=""https://softuni.bg/"">SoftUni</a>";

            Regex htmlPattern = new Regex(@"<(.*)>(.*)<\/\1>");
            var matches = htmlPattern.Matches(input);

            Console.WriteLine("This is the regular expression (pattern) -> <(.*)>(.*)<\\/\\1>\n");
            Console.WriteLine("First foreach loop will print the hole matches:\n");

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }

            Console.WriteLine();
            Console.WriteLine("The second foreach loop will print the second group, which is in the middle >(.*)<:\n");
            
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2]);
            }


        }
    }
}
