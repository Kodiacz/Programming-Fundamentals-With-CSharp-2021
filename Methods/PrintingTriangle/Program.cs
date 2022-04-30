using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTriangle(input);
        }

        static void PrintTriangle(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();
            }

            for (int i = input - 1; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
