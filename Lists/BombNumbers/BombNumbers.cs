
using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            // 1 2 2 4 2 2 2 9
            // 1 2 2 2 4 2 2 2 2 9

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb[0])
                {
                    int left = i - bomb[1];
                    int right = i;
                    int leftIteration = bomb[1];
                    int rightIteration = bomb[1];

                    if (left < 0)
                    {
                        left = 0;
                        leftIteration = i - bomb[1];
                    }

                    for (int k = 0; k < leftIteration; k++)
                    {
                        numbers.RemoveAt(left);
                    }

                    if (right > numbers.Count - 1)
                    {
                        right = numbers.Count - 1;
                        rightIteration = i - bomb[1];
                    }

                    for (int k = 0; k < rightIteration; k++)
                    {
                        numbers.RemoveAt(right);
                        right--;
                    }

                    numbers.Remove(bomb[0]);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
