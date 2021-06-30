using System;

namespace Restaurant_Menu_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu Appetizers = new Menu("Appetizers");
            Menu Entrees = new Menu("Entrees");
            Menu Desserts = new Menu("Desserts");
            Menu Drinks = new Menu("Drinks");

            MenuItem item1 = new MenuItem("Fried Pickles", "Deep fried dill pickles with a side of house made ranch", 8.99);
            MenuItem item2 = new MenuItem("Bone-In Wings", "Choice of Naked, Buffalo, Sweet Chili, BBQ with house made ranch", 9.99);
            MenuItem item3 = new MenuItem("Mozzerella Sticks", "Served with marinara", 6.99);

            MenuItem item4 = new MenuItem("Cheese Burger", "Angus beef patty with chedder cheese, lettuce, pickles, and onions", 10.99);
            MenuItem item5 = new MenuItem("Tacos", "Choice of beef or chicken", 12.99);
            MenuItem item6 = new MenuItem("Chicken Sandwich", "Crispy fried chicken breast, plain or buffalo", 11.99);

            MenuItem item7 = new MenuItem("NY cheesecake", "Creamy NY style cheescake", 6.99);
            MenuItem item8 = new MenuItem("Triple Chocolate Cake", "Three layers of chocolate fudge cake", 5.99);
            MenuItem item9 = new MenuItem("Ice Cream", "Choice of Vanilla, Chocolate, Strawberry", 3.99);

            Appetizers.AddItem(item1);
            Appetizers.AddItem(item2);
            Appetizers.AddItem(item3);

            Entrees.AddItem(item4);
            Entrees.AddItem(item5);
            Entrees.AddItem(item6);

            Desserts.AddItem(item7);
            Desserts.AddItem(item8);
            Desserts.AddItem(item9);
                                  
           
            Appetizers.PrintMenu();
            Entrees.PrintMenu();
            Desserts.PrintMenu();

            
        }
    }
}