using System;

namespace RepeatString
{
    class RepeatString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            string output = MultiplyInput(input, multiplier);

            Console.WriteLine(output);
        }

        static string MultiplyInput(string input, int multiplier)
        {
            string output = "";
            for (int i = 0; i < multiplier; i++)
            {
                output += input;
            }

            return output;
        }
    }
}
