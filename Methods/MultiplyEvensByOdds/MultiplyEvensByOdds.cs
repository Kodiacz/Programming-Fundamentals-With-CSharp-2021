using System;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = new int[input.Length];
            int evenSum = 0;
            int oddSum = 0;
            int multiplySum = 0;
            string even = "";
            string odd = "";

            ConvertNumbers(input, numbers);
           // PrintEven(numbers, even);
            //PrintOdd(numbers, odd);
            GetSumOfDigits(numbers, ref evenSum, ref oddSum, ref multiplySum);

        }

        private static void PrintOdd(int[] numbers, string text)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1 && numbers[i] != 0)
                {
                    text += Convert.ToString(numbers[i]) + " ";
                }
            }

            Console.WriteLine($"Odds: {text}");
        }

        private static void PrintEven(int[] numbers, string text)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && numbers[i] != 0)
                {
                    text += Convert.ToString(numbers[i]) + " ";
                }
            }

            Console.WriteLine($"Evens: {text}");
        }

        private static void GetSumOfDigits(int[] numbers, ref int evenSum, ref int oddSum, ref int multiplySum)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] < 0)
                    {
                        evenSum += Math.Abs(numbers[i]);
                    }
                    else
                    {
                        evenSum += numbers[i];
                    }
                }
                else
                {
                    if (numbers[i] < 0)
                    {
                        oddSum += Math.Abs(numbers[i]);
                    }
                    else
                    {
                        oddSum += numbers[i];
                    }
                }
            }

            multiplySum = oddSum * evenSum;

            Console.WriteLine(multiplySum);
        }

        private static void ConvertNumbers(string input, int[] numbers)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers[i] = Convert.ToInt32(Convert.ToString(input[i]));
                }
            }
        }
    }
}
