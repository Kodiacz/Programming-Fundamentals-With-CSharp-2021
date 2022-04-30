using System;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = "";
            string chars = "";
            string signs = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    digits += input[i];
                }
                else if ((input[i] >= 65 && input[i] <= 90) || (input[i] >= 97 && input[i] <= 122))
                {
                    chars += input[i];
                }
                else 
                {
                    signs += input[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(chars);
            Console.WriteLine(signs);
        }
    }
}
