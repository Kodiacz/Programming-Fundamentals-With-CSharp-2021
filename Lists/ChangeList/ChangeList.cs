using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split(' ');
            
            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "Delete":
                        numbers.RemoveAll(item => item == int.Parse(input[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        break;
                }

                input = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
