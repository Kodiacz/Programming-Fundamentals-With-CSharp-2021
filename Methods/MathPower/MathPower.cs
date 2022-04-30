using System;

namespace MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long power = long.Parse(Console.ReadLine());

            long result = Power(number, power);

            Console.WriteLine(result);
        }

        static long Power(long number, long power)
        {
            long oldNumber = number;

            for (int i = 1; i < power; i++)
            {
                number *= oldNumber;
            }

            return number;
        }
    }
}
