using System;
using System.Collections.Generic;

namespace MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Dictionary<string, int> resourcesQantity = new Dictionary<string, int>();

            
            while (true)
            {
                if (!resourcesQantity.ContainsKey(resource))
                {
                    resourcesQantity.Add(resource, 0);
                }

                resourcesQantity[resource] += quantity;

                resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                quantity = int.Parse(Console.ReadLine());
            }

            foreach (var item in resourcesQantity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
