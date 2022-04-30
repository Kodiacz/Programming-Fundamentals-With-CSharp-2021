using System;

namespace Train
{
    class Train
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            int sumOfAllPeople = 0;

            for (int i = 0; i < wagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sumOfAllPeople += people[i];
            }

            Console.WriteLine(String.Join(" ", people));
            Console.WriteLine(sumOfAllPeople);
        }
    }
}
