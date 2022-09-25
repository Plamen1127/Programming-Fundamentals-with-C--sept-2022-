using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int qtySudent = int.Parse(Console.ReadLine());
            double priceForSabel = double.Parse(Console.ReadLine());
            double priceForRobe = double.Parse(Console.ReadLine());
            double priceForBelt = double.Parse(Console.ReadLine());

            double moneySabel = Math.Ceiling(qtySudent * 1.1) * priceForSabel;
            double moneyRobe = qtySudent * priceForRobe;
            double moneyBelt = (qtySudent * priceForBelt) - (qtySudent / 6) * priceForBelt;



            double totalMoney = moneySabel + moneyRobe + moneyBelt;

            if (budget >= totalMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");

            }
            else
            {
                Console.WriteLine($"John will need {totalMoney-budget:f2}lv more.");
            }
        }
    }
}
