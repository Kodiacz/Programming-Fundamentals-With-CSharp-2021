using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            int index = secondInput.IndexOf(firstInput);

            while(index >= 0)
            {
                secondInput = secondInput.Remove(index, firstInput.Length);
                index = secondInput.IndexOf(firstInput);
            }

            Console.WriteLine(secondInput);
        }
    }
}
