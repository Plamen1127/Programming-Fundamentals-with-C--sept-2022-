

namespace _08.BeerKegs
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volume = 0;
            string nameType = "";
            for (int i = 1; i <=n ; i++)
            {
                double curentVolume = 0;
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                curentVolume +=  Math.PI * radius * radius * height;
               

                if (curentVolume > volume)
                {
                    volume = curentVolume;
                    nameType = model;
                }
            }

            Console.WriteLine(nameType);
        }
    }
}
