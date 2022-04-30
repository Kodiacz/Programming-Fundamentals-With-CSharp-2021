using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]); // add the the winning card at the end
                    firstPlayer.Add(secondPlayer[0]); // add the losing card at the end

                    firstPlayer.Remove(firstPlayer[0]); // remove the first card of firstPlayer hand
                    secondPlayer.Remove(secondPlayer[0]); // remove the losing hand first card
                }
                else if (secondPlayer[0] > firstPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);

                    secondPlayer.Remove(secondPlayer[0]);
                    firstPlayer.Remove(firstPlayer[0]);
                }
                else if (firstPlayer[0] == secondPlayer[0])
                {
                    firstPlayer.Remove(firstPlayer[0]);
                    secondPlayer.Remove(secondPlayer[0]);
                }
            }

            if (firstPlayer.Count > 0)
            {
                sum = SummingLists(firstPlayer, sum);
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (secondPlayer.Count > 0)
            {
                sum = SummingLists(secondPlayer, sum);
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }

        }

        private static int SummingLists(List<int> list, int sum)
        {
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }
    }
}
