using System;

namespace MagicSum
{
    class MagicSum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string[] split = input.Split();
            int[] numbers = new int[split.Length];
            string temp = "";
            string output = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(split[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i; k < numbers.Length; k++)
                {
                    if (numbers[i] + numbers[k] == number)
                    {
                        temp = Convert.ToString(numbers[i]) + " " + Convert.ToString(numbers[k]);
                        Console.WriteLine(temp);
                    }
                    else
                    {
                        temp = "";
                    }
                }

                temp = "";
            }

        }
    }
}
