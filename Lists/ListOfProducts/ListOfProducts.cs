using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class ListOfProducts
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();
            int sorting = 0;
            foreach (string product in products)
            {
                sorting += 1;
                Console.WriteLine($"{sorting}.{product}");
            }
        }
    }
}
