using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class SoftUniParking
    {
        static void Main(string[] args)
        {
            // 5
            // register John CS1234JS
            // register George JAVA123S
            // register Andy AB4142CD
            // register Jesica VR1223EE
            // unregister Andy

            int n = int.Parse(Console.ReadLine());
            string name = "";
            string plateNumber = "";
            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command.Length > 1)
                {
                    name = command[1];
                }

                if (command.Length > 2)
                {
                    plateNumber = command[2];
                }

                switch (command[0])
                {
                    case "register":
                        if (!users.ContainsKey(name))
                        {
                            users.Add(name, plateNumber);
                            Console.WriteLine($"{name} registered {plateNumber} successfully");
                        }
                        else if (users.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (users.ContainsKey(name))
                        {
                            users.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        else if (!users.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        break;
                }
            }

            foreach (var person in users)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }
        }
    }
}

