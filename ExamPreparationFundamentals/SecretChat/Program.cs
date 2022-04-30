using System;
using System.Linq;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string[] commands = Console.ReadLine().Split(":|:");

            while (commands[0] != "Reveal")
            {
                switch (commands[0])
                {
                    case "InsertSpace":
                        message = message.Insert(Convert.ToInt32(commands[1]), " ");
                        Console.WriteLine(message);
                        break;
                    case "Reverse":

                        if (message.Contains(commands[1]))
                        {
                            int index = message.IndexOf(commands[1]);
                            string reversed = message.Substring(index);
                            message = message.Remove(index);
                            char[] temp = reversed.ToCharArray();
                            Array.Reverse(temp);
                            reversed = new string(temp);
                            message += reversed;
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        message = message.Replace(commands[1], commands[2]);
                        Console.WriteLine(message);
                        break;
                } // Switch Case

                commands = Console.ReadLine().Split(":|:");
            }// While Loop

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
