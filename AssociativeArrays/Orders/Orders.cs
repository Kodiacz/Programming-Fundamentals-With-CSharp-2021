using System;
using System.Collections.Generic;

namespace Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            // Beer 2.20 100
            // IceTea 1.50 50
            // NukaCola 3.30 80
            // Water 1.00 500
            // buy

            string[] order = Console.ReadLine().Split();
            string name = order[0];
            double price = Convert.ToDouble(order[1]);
            int quantity = Convert.ToInt32(order[2]);

            Dictionary<string, List<double>> totalPrice = new Dictionary<string, List<double>>();

            while (name != "buy")
            {
                if (!totalPrice.ContainsKey(name))
                {
                    totalPrice.Add(name, new List<double>() { 0, 0 });
                }

                if (totalPrice[name][0] != price)
                {
                    totalPrice[name][0] = price;
                    totalPrice[name][1] += quantity;
                }
                else
                {
                    totalPrice[name][1] += quantity;
                }

                order = Console.ReadLine().Split();
                name = order[0];

                if (order.Length > 1)
                {
                    price = Convert.ToDouble(order[1]);
                    quantity = Convert.ToInt32(order[2]);
                }
            }

            foreach (var item in totalPrice)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):F2}");
            }
        }
    }
}
