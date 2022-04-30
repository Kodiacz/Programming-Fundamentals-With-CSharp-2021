using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Test 1:
            3
            Arnoldii<->4
            Woodii<->7
            Welwitschia<->2
            Rate: Woodii - 10
            Rate: Welwitschia - 7
            Rate: Arnoldii - 3
            Rate: Woodii - 5
            Update: Woodii - 5
            Reset: Arnoldii
            Exhibition

            Test 2:
            2
            Candelabra<->10
            Oahu<->10
            Rate: Oahu - 7
            Rate: Candelabra - 6
            Exhibition

            */

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double[]> plants = new Dictionary<string, double[]>();

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split("<->");

                if (!plants.ContainsKey(information[0]))
                {
                    plants.Add(information[0], new double[] { Convert.ToDouble(information[1]), 0, 0 });
                }
                else
                {
                    plants[information[0]][0] = Convert.ToDouble(information[1]);
                }
            }

            string[] commands = Console.ReadLine().Split(": ");

            while (commands[0] != "Exhibition")
            {
                string[] plantAndRating = commands[1].Split(" - ");

                switch (commands[0])
                {
                    case "Rate":
                        if (!plants.ContainsKey(plantAndRating[0]))
                        {
                            Console.WriteLine("error");
                            commands = Console.ReadLine().Split(": ");
                            continue;
                        }

                        plants[plantAndRating[0]][1] += Convert.ToDouble(plantAndRating[1]);
                        plants[plantAndRating[0]][2]++;
                        break;
                    case "Update":
                        if (!plants.ContainsKey(plantAndRating[0]))
                        {
                            Console.WriteLine("error");
                            commands = Console.ReadLine().Split(": ");
                            continue;
                        }

                        plants[plantAndRating[0]][0] = Convert.ToDouble(plantAndRating[1]);
                        break;
                    case "Reset":
                        if (!plants.ContainsKey(plantAndRating[0]))
                        {
                            Console.WriteLine("error");
                            commands = Console.ReadLine().Split(": ");
                            continue;
                        }

                        plants[plantAndRating[0]][1] = 0;
                        plants[plantAndRating[0]][2] = 0;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                commands = Console.ReadLine().Split(": ");
            }

            plants = plants.OrderByDescending(pair => pair.Value[0])
                           .ThenByDescending(pair => pair.Value[1])
                           .ToDictionary(pair => pair.Key, pair => pair.Value);
            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plants)
            {
                if (plant.Value[2] == 0)
                {
                    plant.Value[2] = 1;
                }

                plant.Value[1] /= plant.Value[2];
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:F2}");
            }
        }
    }
}
