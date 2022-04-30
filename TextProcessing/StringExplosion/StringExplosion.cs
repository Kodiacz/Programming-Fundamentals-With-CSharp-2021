using System;
using System.Linq;

namespace StringExplosion
{
    class StringExplosion
    {
        static void Main(string[] args)
        {
            // abv>1>1>2>2asdasd
            // abv>1>1>2>4asd>asd
            // pesho>2sis>1a>2akarate>4hexmaster
            // v>9dr
            // s>2

            string input = Console.ReadLine();
            int strenght = 0;
            int additioanlStrenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    if (char.IsDigit(input[i + 1]))
                    {
                        strenght = Convert.ToInt32(Convert.ToString(input[i + 1]));
                    }

                    if (additioanlStrenght > 0)
                    {
                        strenght += additioanlStrenght;
                        additioanlStrenght = 0;
                    }
                }

                for (int k = 0; k < strenght; k++)
                {
                    if (k > input.Length - 1 || i > input.Length - 1)
                    {
                        break;
                    }
                    else if (input[input.Length - 1] == '>')
                    {
                        break;
                    }

                    if (input[i + 1] == '>')
                    {
                        additioanlStrenght++;
                        continue;
                    }

                    input = input.Remove(i + 1, 1);
                }

                strenght = 0;
            }

            Console.WriteLine(input);
        }
    }
}
