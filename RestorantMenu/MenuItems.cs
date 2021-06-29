using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantMenu
{
    public class MenuItems
    {
        public string ItemName;
        public string Description;
        public double Price;
        //public string Name;

        public void MenuItem(string itemName, string description, double price)
        {
            this.ItemName = itemName;
            this.Description = description;
            this.Price = price;

            //return 
        }

        
        



        //public List<string> ItemName = new List<string>
        //{
        //    "Burger",
        //    "Sandvich",
        //    "Taco"
        //};
        //public List<string> Description = new List<string>
        //{
        //    "Beef",
        //    "Turkey and Cheese",
        //    "Rice and beef"
        //};
        //public List<double> Price = new List<double>
        //{
        //    6.30,
        //    3.40,
        //    4.80
        //};
        //public List<string> NewItem = new List<string>();

        //public MenuItems ()
        //{

        //}

        //string ItemName, string Description, double Price, string NewItem
    }
}
