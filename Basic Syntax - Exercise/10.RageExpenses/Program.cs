using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            int qtyHeadset = lostGame / 2;
            int qtyMouse = lostGame / 3;
            int qtyKeyboard = lostGame / 6;
            int qtyDisplay = lostGame / 12;

            double moneyHeadset = qtyHeadset * priceHeadset;
            double moneyMouse = qtyMouse * priceMouse;
            double moneyKeyboard = qtyKeyboard * priceKeyboard;
            double moneyDisplay = qtyDisplay * priceDisplay;

            double allMoney = moneyHeadset + moneyMouse + moneyKeyboard + moneyDisplay;

            Console.WriteLine($"Rage expenses: {allMoney:F2} lv.");
        }
    }
}
