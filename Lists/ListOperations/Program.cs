using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(command[1]);
                        break;
                    case "Insert":
                        if (int.Parse(command[2]) > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(int.Parse(command[2]), command[1]);
                        }
                        break;
                    case "Remove":
                        if (int.Parse(command[1]) > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                        }
                        break;
                    case "Shift":
                        if (command[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                string temp = numbers[0];

                                for (int k = 0; k < numbers.Count - 1; k++)
                                {

                                    numbers[k] = numbers[k + 1];

                                    if (k == numbers.Count - 2)
                                    {
                                        numbers[numbers.Count - 1] = temp;
                                    }
                                }
                            }
                        }
                        else if (command[1] == "right")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                string temp = numbers[numbers.Count - 1];

                                for (int k = numbers.Count - 1; k > 0; k--)
                                {
                                    numbers[k] = numbers[k - 1];

                                    if (k == 1)
                                    {
                                        numbers[0] = temp;
                                    }
                                }
                            }
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
