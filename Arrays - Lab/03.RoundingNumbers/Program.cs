using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // за въвеждане от конзолата на един ред числа от типа  0.9 1.5 2.4 2.5 3.14
            // за да може масива да си ги сложи по индексите
                                //за число                              а за стринг без Select(double.Parse)
            //              double[] numbers = Console.ReadLine()
            //               .Split()  
            //              .Select(double.Parse)
            //              .ToArray();

            double[] numbers = Console.ReadLine()
                .Split()  // На Split в скобите се слага с какво да се отделят числата или стринга, в момента е спейс
                .Select(double.Parse) //тук парсване към число
                .ToArray(); 

            for (int i = 0; i < numbers.Length; i++)
            {
             
                Console.WriteLine($" {numbers[i]} => {(int)Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
            }                                        // това закръгля числото  {(int)Math.Round(numbers[i],MidpointRounding.AwayFromZero)}
        }
    }
}
