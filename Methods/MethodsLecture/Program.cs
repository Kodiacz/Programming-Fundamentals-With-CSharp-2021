using System;

namespace MethodsLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Multiply(x, n);

            Multiply(1, 5);

           // Multiply();
        }

        private static void Multiply(int r, int s)
        {
            int sum = r * s;
            int sum1 = s * s;
            int sum2 = r * r;
            Console.WriteLine(sum);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}
