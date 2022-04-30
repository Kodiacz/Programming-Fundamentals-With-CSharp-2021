using System;

namespace AddAndSubtract
{
    class AddAndSubtract
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = Summing(firstNumber, secondNumber);
            int substractedSum = Substract(sum, thirdNumber);

            Console.WriteLine(substractedSum);
        }

        private static int Substract(int sum, int number)
        {
            int substraction = sum - number;
            return substraction;
        }

        private static int Summing(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}
