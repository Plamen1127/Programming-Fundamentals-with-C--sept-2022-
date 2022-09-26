using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyPeople = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());


            double course = Math.Ceiling((double)qtyPeople / capacityElevator);
            Console.WriteLine(course);
        }
    }
}
