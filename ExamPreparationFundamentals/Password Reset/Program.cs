using System;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string Password = Console.ReadLine();
            string coppy = "";
            string[] commands = Console.ReadLine().Split();
            string takeOdd = "";
            string cut = "";
            string cuttingString = "";
            string substitute = "";

            while (commands[0] != "Done")
            {
                switch (commands[0])
                {
                    case "TakeOdd":
                        for (int i = 0; i < Password.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                coppy += Password[i];
                            }
                        }

                        Password = coppy;
                        Console.WriteLine(Password);
                        break;
                    case "Cut":
                        int cuttingIndex = Convert.ToInt32(commands[1]);
                        int cuttingLength = Convert.ToInt32(commands[2]);
                        Password = Password.Remove(cuttingIndex, cuttingLength);
                        Console.WriteLine(Password);
                        break;
                    case "Substitute":
                        if (Password.Contains(commands[1]))
                        {
                            Password = Password.Replace(commands[1], commands[2]);
                            Console.WriteLine(Password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine($"Your password is: {Password}");
        }
    }
}
