using System;
using System.Collections.Generic;
using System.Linq;

namespace herosOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Test 1:
             2
            Solmyr 85 120
            Kyrre 99 50
            Heal - Solmyr - 10
            Recharge - Solmyr - 50
            TakeDamage - Kyrre - 66 - Orc
            CastSpell - Kyrre - 15 - ViewEarth
            End
             */

            /* Test 2:
             4
            Adela 90 150
            SirMullich 70 40
            Ivor 1 111
            Tyris 94 61 
            Heal - SirMullich - 50
            Recharge - Adela - 100
            CastSpell - Tyris - 1000 - Fireball
            TakeDamage - Tyris - 99 - Fireball
            TakeDamage - Ivor - 3 - Mosquito
            End
            */

            int heroesCount = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> hero = new Dictionary<string, int[]>();

            // Adding heros and their abilities
            for (int i = 0; i < heroesCount; i++)
            {
                string[] values = Console.ReadLine().Split();
                hero.Add(values[0], new int[2] { Convert.ToInt32(values[1]), Convert.ToInt32(values[2]) });
            }

            string[] actions = Console.ReadLine().Split(" - ");

            while (actions[0] != "End")
            {
                int amount;
                string heroName;
                string attacker;
                string spellName;

                switch (actions[0])
                {
                    case "CastSpell":
                        heroName = actions[1];
                        spellName = actions[3];

                        if (hero[actions[1]][1] - Convert.ToInt32(actions[2]) >= 0)
                        {
                            hero[actions[1]][1] -= Convert.ToInt32(actions[2]);
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {hero[actions[1]][1]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        heroName = actions[1];
                        attacker = actions[3];
                        hero[actions[1]][0] -= Convert.ToInt32(actions[2]); ;

                        if (hero[actions[1]][0] > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {actions[2]} HP by {attacker} and now has {hero[actions[1]][0]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                            hero.Remove(actions[1]);
                        }
                        break;
                    case "Recharge":
                        // max 200
                        amount = Convert.ToInt32(actions[2]);
                        heroName = actions[1];

                        if (hero[actions[1]][1] + amount > 200)
                        {
                            amount = Math.Abs(200 - hero[actions[1]][1]);
                            hero[actions[1]][1] += amount;
                        }
                        else
                        {
                            hero[actions[1]][1] += amount;
                        }

                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        break;
                    case "Heal":
                        // max 100
                        amount = Convert.ToInt32(actions[2]);
                        heroName = actions[1];

                        if (hero[actions[1]][0] + amount > 100)
                        {
                            amount = Math.Abs(100 - hero[actions[1]][0]);
                            hero[actions[1]][0] += amount;
                        }
                        else
                        {
                            hero[actions[1]][0] += amount;
                        }

                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        break;
                }// Switch Case

                actions = Console.ReadLine().Split(" - ");
            }// While

            hero = hero.OrderByDescending(pair => pair.Value[0])
                       .ThenBy(pair => pair.Key)
                       .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var item in hero)
            {
                Console.WriteLine($"{item.Key}\n  HP: {item.Value[0]}\n  MP: {item.Value[1]}");
            }
        }// Main
    }
}
