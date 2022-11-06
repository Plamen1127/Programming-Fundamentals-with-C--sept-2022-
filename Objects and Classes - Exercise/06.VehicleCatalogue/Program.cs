using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Vehicle> vehicles = new List<Vehicle>();

            while (input != "End")
            {

                string[] data = input
                                .Split()
                                .ToArray();

                string type = data[0];
                string model = data[1];
                string color = data[2];
                int horsepower = int.Parse(data[3]);

                vehicles.Add(new Vehicle(type, model, color, horsepower));

                input = Console.ReadLine();
            }

            string brand = Console.ReadLine();

            double carHpSum = vehicles
                             .Where(x => x.Type == "car")
                             .Sum(x => x.Horsepower);

            double truckHpSum = vehicles
                               .Where(x => x.Type == "truck")
                               .Sum(x => x.Horsepower);

            int carCount = vehicles.Where(x => x.Type == "car").Count();
            int truckCount = vehicles.Where(x => x.Type == "truck").Count();

            while (brand != "Close the Catalogue")
            {

                foreach (var vehicle in vehicles.Where(x => x.Model == brand))
                {
                    if (vehicle.Type == "car")
                    {
                        Console.WriteLine($"Type: Car");
                    }
                    else
                    {
                        Console.WriteLine($"Type: Truck");
                    }
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                }

                brand = Console.ReadLine();

            }

            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(carHpSum / carCount):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (truckCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(truckHpSum / truckCount):f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
    }
}
