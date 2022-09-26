

namespace _01.IntegerOperations
{
    using System;
    using System.Numerics;
   

    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            long firstResult = (long)n1 + n2;
            BigInteger secundResult = (BigInteger)firstResult / n3;
            BigInteger thirdRsult = secundResult * n4;

            Console.WriteLine(thirdRsult);


        }
    }
}
