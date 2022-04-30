using System;

namespace PasswordValidator
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            CheckPassowrd(password);
        }

        private static void CheckPassowrd(string text)
        {
            int countDigits = 0;
            int countLength = 0;
            bool checkForSymbols = false;

            bool digit = false;
            bool length = false;
            bool symbol = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    countDigits++;
                }

                countLength++;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) == false && char.IsLetter(text[i]) == false)
                {
                    checkForSymbols = true;
                    break;
                }
            }

            if (countLength < 6 || countLength > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else
            {
                length = true;
            }

            if (checkForSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            else
            {
                symbol = true;
            }

            if (countDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                digit = true;
            }

            if (digit && length && symbol)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
