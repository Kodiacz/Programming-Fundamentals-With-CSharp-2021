using System;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int[] numbers = new int[split.Length];
            int[] sumLeft = new int[numbers.Length];
            int[] sumRight = new int[numbers.Length];
            int index = 0;
            bool isEqual = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(split[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int right = 0; right < i; right++)
                {
                    sumRight[i] += numbers[right];
                }

                for (int left = numbers.Length - 1; left > i; left--)
                {
                    sumLeft[i] += numbers[left];
                }

                if (sumLeft[i] == sumRight[i])
                {
                    isEqual = true;
                    index = i;
                    break;
                }
                else
                {
                    isEqual = false;
                }
            }

            if (isEqual)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
