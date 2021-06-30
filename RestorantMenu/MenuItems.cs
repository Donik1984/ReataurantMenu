using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Menu_Update
{
    class MenuItem
    {
        //--Create list for details of menu items (name and description)
        //--Create print details method
        //Create way to add, modify, remove details
        //Show if new item

        public List<string> details = new List<string>();

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        public void PrintAll()
        {
            Console.WriteLine($" {this.Name} --- {this.Price}\n {this.Description}");
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}