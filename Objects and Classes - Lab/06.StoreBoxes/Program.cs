using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split(" ");
                Box box = new Box
                {
                    SerialNumber = tokens[0],
                    Item = new Item
                    {
                        Name = tokens[1],
                        Price = decimal.Parse(tokens[3])
                    },

                    ItemQuantity = int.Parse(tokens[2])
                };

                boxes.Add(box);
            }
            List<Box> orderBoxes = boxes.OrderByDescending(box => box.PriceOfBox).ToList();
            foreach (Box box in orderBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceOfBox:F2}");
            }

        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceOfBox
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
        }
    }
}
