using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(n => n.Length % 2 == 0).ToArray();
            Console.WriteLine(String.Join("\n", words));
        }
    }
}
