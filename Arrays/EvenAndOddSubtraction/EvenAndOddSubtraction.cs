using System;

namespace EvenAndOddSubtraction
{
    class EvenAndOddSubtraction
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splittedINput = input.Split(' ');
            int[] numbers = new int[splittedINput.Length];
            int counterOdd = 0;
            int counterEven = 0;
            int sumEven = 0;
            int sumOdd = 0;
            int totalSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(splittedINput[i]);

                if (numbers[i] % 2 == 0)
                {
                    counterEven++;
                    sumEven += numbers[i];
                }
                else
                {
                    counterOdd++;
                    sumOdd += numbers[i];
                }
            }

            int[] evenNumbers = new int[counterEven];
            int[] oddNumbers = new int[counterOdd];
            counterEven = 0;
            counterOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[counterEven] += numbers[i];
                    counterEven++;
                }
                else
                {
                    oddNumbers[counterOdd] += numbers[i];
                    counterOdd++;
                }
            }

            totalSum = sumEven - sumOdd;
            //Console.WriteLine($"Even: {String.Join(" + ", evenNumbers)} = {sumEven}");
            //Console.WriteLine($"Odd: {String.Join(" + ", oddNumbers)} = {sumOdd}");
            //Console.WriteLine($"Result: {sumEven} - {sumOdd} = {totalSum}");

            Console.WriteLine(totalSum);
        }
    }
}
