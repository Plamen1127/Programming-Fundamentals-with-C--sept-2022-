using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
           string inputCoints = Console.ReadLine();
            double nuts = 2;
            double wather = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1;
            
                double allCoints = 0;
            while (inputCoints != "Start")
            {
                double coint = Double.Parse(inputCoints);
                if (inputCoints == "0.1" || inputCoints == "0.2" || inputCoints == "0.5" || inputCoints == "1" || inputCoints == "2")
                { 
                    
                    allCoints += coint;
                    
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputCoints} ");
                }

                inputCoints = Console.ReadLine();
            }
            string product = Console.ReadLine();



            while(product != "End")
            {
                if( product == "Nuts")
                {
                    if (allCoints < nuts)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased nuts");
                        allCoints -= nuts;
                    }
                    
                }
                else if (product == "Water")
                {
                    if (allCoints < wather)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased water");
                        allCoints -= wather;
                    }
                
                }
                else if (product == "Crisps")
                {
                    if (allCoints < crisps)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased crisps");
                        allCoints -= crisps;
                    }
                 
                }
               
                else if (product == "Soda")
                {
                    if (allCoints < soda)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased soda");
                        allCoints -= soda;
                    }
                    
                }
                else if (product == "Coke")
                {
                    if (allCoints < coke)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine("Purchased coke");
                        allCoints -= coke;
                    }
                   
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {allCoints:F2}");
            
        }
    }
}
