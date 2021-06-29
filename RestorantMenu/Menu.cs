using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestorantMenu
{
    class Menu
    {
        
        private DateTime _currentDateTime = DateTime.Now;
        public string[] Category = new string[] {"Appetizer", "Entrees", "Dessert", "Drinks" };

        public Menu ()
        {
        
        }
        //public void SetDateTime (DateTime setCurrentDateTime)
        //{
        //    _currentDateTime = setCurrentDateTime;
        //}

        public DateTime GetDateTime()
        {
            return _currentDateTime;
        }


        //public datetime currentdate
        //{
        //    get { return currentdatetime; }
        //    set { currentdatetime = value; }
        //}

    }
}
