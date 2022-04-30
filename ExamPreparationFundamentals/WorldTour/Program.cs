using System;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commands = Console.ReadLine().Split(':');

            while (commands[0] != "Travel")
            {
                switch (commands[0])
                {
                    // Add Stop:{index}:{string}
                    case "Add Stop":
                        if (Convert.ToInt32(commands[1]) >= 0 && Convert.ToInt32(commands[1]) < input.Length)
                        {
                            input = input.Insert(Convert.ToInt32(commands[1]), commands[2]);
                        }

                        Console.WriteLine(input);
                        break;
                    // Remove Stop:{start_index}:{end_index}
                    case "Remove Stop":
                        if ((Convert.ToInt32(commands[1]) >= 0 && Convert.ToInt32(commands[1]) < input.Length) && (Convert.ToInt32(commands[2]) >= 0 && Convert.ToInt32(commands[2]) < input.Length))
                        {
                            int length = Convert.ToInt32(commands[2]) - Convert.ToInt32(commands[1]) + 1;
                            input = input.Remove(Convert.ToInt32(commands[1]), length);
                        }

                        Console.WriteLine(input);
                        break;
                    // Switch:{old_string}:{new_string}
                    case "Switch":
                        if (input.Contains(commands[1]))
                        {
                            input = input.Replace(commands[1], commands[2]);
                        }

                        Console.WriteLine(input);
                        break;
                }// Switch Case

                commands = Console.ReadLine().Split(':');
            }// While Loop

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
