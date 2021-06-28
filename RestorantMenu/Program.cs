using System;

namespace RestorantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu DateTest = new Menu();
            MenuItems menuItems = new MenuItems();
            Console.WriteLine(DateTest.currentDateTime);
            //Console.WriteLine($"{menuItems.ItemName[0]} + {menuItems.Description[0]} + {menuItems.Price[0]}");
            //Console.WriteLine("Please change the name for the item: ");
            //menuItems.ItemName[0] = Console.ReadLine();
            //Console.WriteLine($"{menuItems.ItemName[0]} + {menuItems.Description[0]} + {menuItems.Price[0]}");
            Console.WriteLine("Please add the new item name, description and price: ");

            menuItems.ItemName.Add(Console.ReadLine());
            menuItems.Description.Add(Console.ReadLine());
            double newPrice = Double.Parse(Console.ReadLine());
            menuItems.Price.Add(newPrice);

            Console.WriteLine($"New Item(s): {menuItems.ItemName[menuItems.ItemName.Count - 1]}" +
                $" {menuItems.Description[menuItems.Description.Count - 1]}  ${menuItems.Price[menuItems.Price.Count - 1]}");
            //Console.WriteLine(menuItems.ItemName.Count);



        }
    }
}
