using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Menu_Update
{
    class Menu
    {
        private DateTime _currentDateTime = DateTime.Now;

        public DateTime GetDateTime()
        {
            return _currentDateTime;
        }

        public List<MenuItem> listOfMenu = new List<MenuItem>();

        public string Category { get; set; }

        public Menu(string name)
        {
            this.Category = name;
        }

        public void AddItem(MenuItem item)
        {
            this.listOfMenu.Add(item);
        }
        
        public void RemoveItem(MenuItem item)
        {
            this.listOfMenu.Remove(item);
        }
        
        public void PrintMenu()
        {
            foreach (MenuItem item in listOfMenu)
            {
                item.PrintAll();
            }
        }

    }
}