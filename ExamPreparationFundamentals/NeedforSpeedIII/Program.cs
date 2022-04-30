using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedforSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Test 1:
            3
            Audi A6|38000|62
            Mercedes CLS|11000|35
            Volkswagen Passat CC|45678|5
            Drive : Audi A6 : 543 : 47
            Drive : Mercedes CLS : 94 : 11
            Drive : Volkswagen Passat CC : 69 : 8
            Refuel : Audi A6 : 50
            Revert : Mercedes CLS : 500
            Revert : Audi A6 : 30000
            Stop

            Test 2:
            4
            Lamborghini Veneno|11111|74
            Bugatti Veyron|12345|67
            Koenigsegg CCXR|67890|12
            Aston Martin Valkryie|99900|50
            Drive : Koenigsegg CCXR : 382 : 82
            Drive : Aston Martin Valkryie : 99 : 23
            Drive : Aston Martin Valkryie : 2 : 1
            Refuel : Lamborghini Veneno : 40
            Revert : Bugatti Veyron : 2000
            Stop

            */

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                cars.Add(input[0], new int[] { Convert.ToInt32(input[1]), Convert.ToInt32(input[2]) });
            }

            string[] commands = Console.ReadLine().Split(" : ");

            while (commands[0] != "Stop")
            {
                // key = car
                // mileage = 0
                // fuel = 1
                switch (commands[0])
                {
                    // Drive : {car} : {distance} : {fuel}
                    case "Drive":
                        if (Convert.ToInt32(commands[3]) > cars[commands[1]][1])
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[commands[1]][0] += Convert.ToInt32(commands[2]);
                            cars[commands[1]][1] -= Convert.ToInt32(commands[3]);
                            Console.WriteLine($"{commands[1]} driven for {commands[2]} kilometers. {commands[3]} liters of fuel consumed.");
                        }

                        if (cars[commands[1]][0] >= 100000)
                        {
                            cars.Remove(commands[1]);
                            Console.WriteLine($"Time to sell the {commands[1]}!");
                        }
                        break;
                    // Refuel : {car} : {fuel}
                    case "Refuel":
                        int fuel = Convert.ToInt32(commands[2]);

                        if (cars[commands[1]][1] + Convert.ToInt32(commands[2]) > 75)
                        {
                            fuel = Math.Abs(75 - cars[commands[1]][1]);
                            cars[commands[1]][1] += fuel;
                        }
                        else
                        {
                            cars[commands[1]][1] += fuel;
                        }

                        Console.WriteLine($"{commands[1]} refueled with {fuel} liters");
                        break;
                    // Revert : {car} : {kilometers}
                    case "Revert":
                        if (cars[commands[1]][0] - Convert.ToInt32(commands[2]) < 10000)
                        {
                            cars[commands[1]][0] = 10000;
                        }
                        else
                        {
                            cars[commands[1]][0] -= Convert.ToInt32(commands[2]);
                            Console.WriteLine($"{commands[1]} mileage decreased by {commands[2]} kilometers");
                        }
                        break;

                }// Switch Case

                commands = Console.ReadLine().Split(" : ");
            }// While Loop

            cars = cars.OrderByDescending(pair => pair.Value[0])
                       .ThenBy(pair => pair.Key)
                       .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
