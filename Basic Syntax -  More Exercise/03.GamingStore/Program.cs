using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double totalSpend = 0;
            
            string nameOfGame;
            while( (nameOfGame= Console.ReadLine()) != "Game Time")
            {
                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }



                else if (nameOfGame == "OutFall 4")
                {
                    if (budget >= 39.99)
                    {
                        Console.WriteLine($"Bought {nameOfGame}");
                        budget -= 39.99;
                        totalSpend += 39.99;
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    
                }




                else if (nameOfGame == "CS: OG")
                {
                    if (budget >= 15.99)
                    {
                        Console.WriteLine($"Bought {nameOfGame}");
                        budget -= 15.99;
                        totalSpend += 15.99;
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                   
                }


                else if (nameOfGame == "Zplinter Zell")
                {
                    if (budget >= 19.99)
                    {
                        Console.WriteLine($"Bought {nameOfGame}");
                        budget -= 19.99;
                        totalSpend += 19.99;
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }


                else if (nameOfGame == "Honored 2")
                {
                    if (budget >= 59.99)
                    {
                        Console.WriteLine($"Bought {nameOfGame}");
                        budget -= 59.99;
                        totalSpend += 59.99;
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    
                }


                else if (nameOfGame == "RoverWatch")
                {
                    if (budget >= 29.99)
                    {
                        Console.WriteLine($"Bought {nameOfGame}");
                        budget -= 29.99;
                        totalSpend += 29.99;
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    
                }


                else if (nameOfGame == "RoverWatch Origins Edition")
                {
                    if (budget >= 39.99)
                    {
                        Console.WriteLine($"Bought {nameOfGame}");
                        budget -= 39.99;
                        totalSpend += 39.99;
                    }

                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    
                }

              

                else
                {
                    Console.WriteLine("Not Found");
                    
                }

                
            }

            if (budget == 0)
            {
                Console.WriteLine("Out of money!");
               
            }
            else 
            {
                Console.WriteLine($"Total spent: ${totalSpend:F2}. Remaining: ${budget:F2}");
            }

            

        }
    }
}
