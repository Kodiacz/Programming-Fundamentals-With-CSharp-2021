using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class ListManipulationAdvanced
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> copyOfNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            List<int> comparisonList = new List<int>();

            string[] command = Console.ReadLine().Split(' ');

            bool isDifferent = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                copyOfNumbers.Add(numbers[i]);
            }

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":

                        if (int.Parse(command[2]) >= numbers.Count)
                        {
                            command[2] = Convert.ToString(numbers.Count - 1);
                        }

                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenNumbers.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", evenNumbers));
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                oddNumbers.Add(numbers[i]);
                            }
                        }

                        Console.WriteLine(String.Join(" ", oddNumbers));
                        break;
                    case "GetSum":
                        int sum = 0;

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }

                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        if (command[1] == "<=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= int.Parse(command[2]))
                                {
                                    comparisonList.Add(numbers[i]);
                                }
                            }

                            Console.WriteLine(String.Join(" ", comparisonList));
                        }
                        else if (command[1] == ">=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= int.Parse(command[2]))
                                {
                                    comparisonList.Add(numbers[i]);
                                }
                            }

                            Console.WriteLine(String.Join(" ", comparisonList));
                        }
                        else if (command[1] == "<")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < int.Parse(command[2]))
                                {
                                    comparisonList.Add(numbers[i]);
                                }
                            }

                            Console.WriteLine(String.Join(" ", comparisonList));
                        }
                        else if (command[1] == ">")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > int.Parse(command[2]))
                                {
                                    comparisonList.Add(numbers[i]);
                                }
                            }

                            Console.WriteLine(String.Join(" ", comparisonList));
                        }
                        break;
                }

                comparisonList = new List<int>();
                evenNumbers = new List<int>();
                oddNumbers = new List<int>();
                command = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != copyOfNumbers[i])
                {
                    isDifferent = true;
                    break;
                }
            }

            if (isDifferent) 
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
