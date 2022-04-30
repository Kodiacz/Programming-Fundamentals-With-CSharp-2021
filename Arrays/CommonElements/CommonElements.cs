using System;

namespace CommonElements
{
    class CommonElements
    {
        static void Main(string[] args)
        {
            //Hey hello 2 4
            //10 hey 4 hello

            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string[] firstSplit = firstInput.Split(' ');
            string[] secondSplit = secondInput.Split(' ');
            string output = "";

            if (firstSplit.Length >= secondSplit.Length)
            {
                for (int first = 0; first < firstSplit.Length; first++)
                {
                    for (int second = 0; second < secondSplit.Length; second++)
                    {
                        if (secondSplit[second] == firstSplit[first])
                        {
                            output += $"{secondSplit[second]} ";
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                
            }
            else
            {
                for (int second = 0; second < secondSplit.Length; second++)
                {
                    for (int first = 0; first < firstSplit.Length; first++)
                    {
                        if (firstSplit[first] == secondSplit[second])
                        {
                            output += $"{firstSplit[first]} ";
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}
