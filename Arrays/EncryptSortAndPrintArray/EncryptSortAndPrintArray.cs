using System;

namespace EncryptSortAndPrintArray
{
    class EncryptSortAndPrintArray
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            string text = "";

            for (int i = 0; i < length; i++)
            {
                text = Console.ReadLine();
                int sumVowel = 0;
                int sumConsonant = 0;

                for (int k = 0; k < text.Length; k++)
                {
                    if (char.ToLower(text[k]) == 'a' || char.ToLower(text[k]) == 'e' || char.ToLower(text[k]) == 'i' || char.ToLower(text[k]) == 'o' || char.ToLower(text[k]) == 'u')
                    {
                        sumVowel += text[k] * text.Length;
                    }
                    else
                    {
                        sumConsonant += text[k] / text.Length;
                    }
                }

                int totalSum = sumVowel + sumConsonant;
                numbers[i] = totalSum;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] > numbers[k])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[k];
                        numbers[k] = temp;
                    }
                }
            }

            //Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
