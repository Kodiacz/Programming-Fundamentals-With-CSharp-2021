using System;

namespace MathOperations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            double sum = 0;

            Operation(firstNumber, sign, secondNumber, sum);
        }

        private static void Operation(double firstNumber, string operators, double secondNumber, double sum)
        {
            if (operators == "/")
            {
                sum = firstNumber / secondNumber;
            }
            else if (operators == "*")
            {
                sum = firstNumber * secondNumber;
            }
            else if (operators == "-")
            {
                sum = firstNumber - secondNumber;
            }
            else if (operators == "+")
            {
                sum = firstNumber + secondNumber;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
