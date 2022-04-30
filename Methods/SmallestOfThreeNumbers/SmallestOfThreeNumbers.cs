using System;

namespace SmallestOfThreeNumbers
{
    class SmallestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            GetTheSmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        private static void GetTheSmallestNumber(int first, int second, int third)
        {
            int smallest = 0;

            if (first <= second && first <= third)
            {
                smallest = first;
            }
            else if (second <= first && second <= third)
            {
                smallest = second;
            }
            else if (third <= first && third <= second)
            {
                smallest = third;
            }

            Console.WriteLine(smallest);
        }
    }
}
