using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");
            List<string> validUserNames = new List<string>();

            
            
            for (int i = 0; i < userNames.Length; i++)
            {
                if (userNames[i].Length >= 3 && 16 >= userNames[i].Length)
                {
                    if (userNames[i].Any(char.IsDigit))
                    
                }
            }

            foreach (string name in validUserNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
