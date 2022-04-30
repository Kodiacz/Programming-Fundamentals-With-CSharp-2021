using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            string legendaryItem = "";

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "fragments", 0},
                { "motes", 0}
            };

            while (keyMaterials["shards"] < 250 && keyMaterials["fragments"] < 250 && keyMaterials["motes"] < 250)
            {
                string[] input = Console.ReadLine().Split().Select(i => i.ToLower()).ToArray();

                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (input[i] == "shards" || input[i] == "fragments" || input[i] == "motes")
                        {
                            keyMaterials[input[i]] += Convert.ToInt32(input[i - 1]);

                            if (keyMaterials["shards"] >= 250)
                            {
                                legendaryItem = "Shadowmourne";
                                break;
                            }
                            else if (keyMaterials["fragments"] >= 250)
                            {
                                legendaryItem = "Valanyr";
                                break;
                            }
                            else if (keyMaterials["motes"] >= 250)
                            {
                                legendaryItem = "Dragonwrath";
                                break;
                            }
                        }
                        else
                        {
                            if (!junkMaterials.ContainsKey(input[i]))
                            {
                                junkMaterials.Add(input[i], 0);
                            }

                            junkMaterials[input[i]] += Convert.ToInt32(input[i - 1]);
                        }
                    }
                }
            }

            if (legendaryItem == "Shadowmourne")
            {
                keyMaterials["shards"] -= 250;
            }
            else if (legendaryItem == "Valanyr")
            {
                keyMaterials["fragments"] -= 250;
            }
            else if (legendaryItem == "Dragonwrath")
            {
                keyMaterials["motes"] -= 250;
            }

            junkMaterials = junkMaterials.OrderBy(pairs => pairs.Key)
                                         .ToDictionary(pair => pair.Key, pair => pair.Value);
            keyMaterials = keyMaterials.OrderByDescending(pairs => pairs.Value)
                                       .ThenBy(pairs => pairs.Key)
                                       .ToDictionary(pairs => pairs.Key, pairs => pairs.Value);

            Console.WriteLine($"{legendaryItem} obtained!"); 

            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
