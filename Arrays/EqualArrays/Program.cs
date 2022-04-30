using System;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string[] firstSplit = firstInput.Split(' ');
            string[] secondSplit = secondInput.Split(' ');

            int[] firstNumbers = new int[firstSplit.Length];
            int[] secondNumbers = new int[secondSplit.Length];

            int sum = 0;
            int index = -1;

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                firstNumbers[i] = Convert.ToInt32(firstSplit[i]);
                secondNumbers[i] = Convert.ToInt32(secondSplit[i]);

                if (firstNumbers[i] == secondNumbers[i])
                {
                    sum += firstNumbers[i];
                }
                else
                {
                    index = i;
                    break;
                }
            } 

            if (index >= 0)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
