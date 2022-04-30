using System;

namespace FactorialDivision
{
    class FactorialDivision
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int division = CalculateFactorialDivision(firstNumber, secondNumber);

            Console.WriteLine($"{division:F2}");
        }

        private static int CalculateFactorialDivision(int firstNumber, int secondNumber)
        {
            int firstNumberFactorial = CalcFactorial(firstNumber);;
            int secondNumberFactorial = CalcFactorial(secondNumber);

            int result = firstNumberFactorial / secondNumberFactorial;

            return result;
        }

        private static int CalcFactorial(int number)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
