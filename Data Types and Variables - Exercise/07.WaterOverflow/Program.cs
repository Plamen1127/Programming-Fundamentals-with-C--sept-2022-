using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyInput = int.Parse(Console.ReadLine());
            int totalLiter = 0;
            int counterSum = 0;

            for (int i = 1; i <= qtyInput; i++)
            {
                
                int amountOfWater = int.Parse(Console.ReadLine());
                counterSum += amountOfWater;
                if (amountOfWater < 255 && counterSum <= 255)
                {
                    totalLiter += amountOfWater;
                }
                else
                {
                    counterSum -= amountOfWater;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(totalLiter);
        }
    }
}
