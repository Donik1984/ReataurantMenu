using System;

namespace RestorantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            
                       
            Menu CurrentDate = new Menu();
            MenuItems menuItems = new MenuItems();
            Console.WriteLine(CurrentDate.GetDateTime());

            Console.WriteLine("Menu Items: ");
            for (int i = 0; i < menuItems.ItemName.Count; i++)
            {
                Console.Write($"{i+1} - {menuItems.ItemName[i]}; ");
            }
            Console.WriteLine($"\nMenu Description: ");
            for (int i = 0; i < menuItems.Description.Count; i++)
            {
                Console.Write($"{i+1} - {menuItems.Description[i]}; ");
            }
            Console.WriteLine($"\nMenu Price: ");
            for (int i = 0; i < menuItems.Price.Count; i++)
            {
                Console.Write($"{i+1} - ${menuItems.Price[i]}; ");
            }

            Console.WriteLine("\nPlease add the new item name, description and price: ");

            menuItems.ItemName.Add(Console.ReadLine());
            menuItems.Description.Add(Console.ReadLine());
            double newPrice = Double.Parse(Console.ReadLine());
            menuItems.Price.Add(newPrice);

            Console.WriteLine($"New Item(s): {menuItems.ItemName[menuItems.ItemName.Count - 1]}" +
                $" {menuItems.Description[menuItems.Description.Count - 1]}  ${menuItems.Price[menuItems.Price.Count - 1]}");

        }
    }
}
