using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string check = Console.ReadLine();
            int firstNumber = 0;
            int secondNumber = 0;
            char firstLetter = ' ';
            char secondLetter = ' ';
            string firstText = "";
            string secondText = "";

            if (check == "int")
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                GreaterValue(firstNumber, secondNumber);
            }
            else if (check == "char")
            {
                firstLetter = char.Parse(Console.ReadLine());
                secondLetter = char.Parse(Console.ReadLine());
                GreaterValue(firstLetter, secondLetter);
            }
            else if (check == "string")
            {
                firstText = Console.ReadLine();
                secondText = Console.ReadLine();
                GreaterValue(firstText, secondText);
            }

        }

        private static void GreaterValue(int firstNumber, int secondNumber)
        {
            int result = 0;

            if (firstNumber >= secondNumber)
            {
                result = firstNumber;
            }
            else
            {
                result = secondNumber;
            }

            Console.WriteLine(result);
        }
        private static void GreaterValue(char firstLetter, char secondLetter)
        {
            char result = ' ';

            if (firstLetter >= secondLetter)
            {
                result = firstLetter;
            }
            else
            {
                result = secondLetter;
            }
            Console.WriteLine(result);
        }
        private static void GreaterValue(string firstText, string secondText)
        {
            string result = "";
            int firstSum = GetSumOfASCII(firstText); 
            int secondSum = GetSumOfASCII(secondText);

            if (firstSum >= secondSum)
            {
                result = firstText;
            }
            else
            {
                result = secondText;
            }

            Console.WriteLine(result);
        }

        private static int GetSumOfASCII(string text)
        {
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                sum += text[i];
            }

            return sum;
        }
    }
}
