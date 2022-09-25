using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtyPeople = int.Parse(Console.ReadLine());
            string typeOffGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (typeOffGroup == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if ( day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

            }
            if (typeOffGroup == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.6;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            if (typeOffGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.5;
                }
            }

            double allPrice = qtyPeople * price;


            if ( typeOffGroup == "Students" && qtyPeople >= 30)
            {
                allPrice *= 0.85;
            }
            else if (typeOffGroup == "Business" && qtyPeople >= 100)
            {
                allPrice -= 10 * price;
            }
            else if (typeOffGroup == "Regular" && qtyPeople >= 10 && qtyPeople<=20)
            {
                allPrice *= 0.95;
            }


            Console.WriteLine($"Total price: {allPrice:F2}");
        }
    }
}
