using System;

namespace _01_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "Done")
            {
                switch (commands[0])
                {
                    //Change {char} {replacement}
                    case "Change":
                        if (input.Contains(commands[1]))
                        {
                            input = input.Replace(commands[1], commands[2]);
                        }

                        Console.WriteLine(input);
                        break;
                    //Includes {otherString}
                    case "Includes":
                        Console.WriteLine(input.Contains(commands[1]));
                        break;
                    //End {otherString}
                    case "End":
                        int length = Convert.ToInt32(commands[1].Length);
                        int firstCharOfLastWord = (input.Length - 1) - length;
                        string lastString = input.Substring(firstCharOfLastWord);

                        if (lastString == commands[1])
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    //Uppercase
                    case "Uppercase":
                        input = input.ToUpper();
                        Console.WriteLine(input);
                        break;
                    //FindIndex {char}
                    case "FindIndex":
                        int indexOfChar = input.IndexOf(commands[1]);
                        Console.WriteLine(indexOfChar);
                        break;
                    //Cut {startIndex} {length}
                    case "Cut":
                        int lastIndexOfUncutString = Convert.ToInt32(commands[1]) + Convert.ToInt32(commands[2]) - 1;
                        int countForTheEnd = (input.Length - 1) - lastIndexOfUncutString;
                        int startIndex = Convert.ToInt32(commands[1]) - Convert.ToInt32(commands[1]);
                        int countForTheStart = Convert.ToInt32(commands[1]);

                        if (countForTheStart < 0)
                        {
                            countForTheStart = 0;
                        }

                        input = input.Remove(lastIndexOfUncutString + 1, countForTheEnd);
                        input = input.Remove(startIndex, countForTheStart);
                        Console.WriteLine(input);
                        break;
                }// Switch Case

                commands = Console.ReadLine().Split();
            }// While Loop
        }
    }
}
