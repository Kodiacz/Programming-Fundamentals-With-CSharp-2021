using System;

namespace CalculateRectangleArea
{
    class CalculateRectangleArea
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine());

            int result = RectangleArea(a, b);
            Console.WriteLine(result);
        }

        static int RectangleArea(int a, int b)
        {
            int result = a * b;
            return result;
        }
    }
}
