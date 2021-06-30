using System;

namespace Restaurant_Menu_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu appetizersMenu = new Menu("Appetizers");
            Menu entreesMenu = new Menu("Entrees");
            Menu dessertsMenu = new Menu("Desserts");
            Menu drinksMenu = new Menu("Drinks");

            MenuItem item1 = new MenuItem("Fried Pickles", "Deep fried dill pickles with a side of house made ranch", 8.99);
            MenuItem item2 = new MenuItem("Bone-In Wings", "Choice of Naked, Buffalo, Sweet Chili, BBQ with house made ranch", 9.99);
            MenuItem item3 = new MenuItem("Mozzerella Sticks", "Served with marinara", 6.99);

            MenuItem item4 = new MenuItem("Cheese Burger", "Angus beef patty with chedder cheese, lettuce, pickles, and onions", 10.99);
            MenuItem item5 = new MenuItem("Tacos", "Choice of beef or chicken", 12.99);
            MenuItem item6 = new MenuItem("Chicken Sandwich", "Crispy fried chicken breast, plain or buffalo", 11.99);

            MenuItem item7 = new MenuItem("NY cheesecake", "Creamy NY style cheescake", 6.99);
            MenuItem item8 = new MenuItem("Triple Chocolate Cake", "Three layers of chocolate fudge cake", 5.99);
            MenuItem item9 = new MenuItem("Ice Cream", "Choice of Vanilla, Chocolate, Strawberry", 3.99);

            MenuItem item10 = new MenuItem("");
            MenuItem item11 = new MenuItem("");
            MenuItem item12 = new MenuItem("");

            appetizersMenu.AddItem(item1);
            appetizersMenu.AddItem(item2);
            appetizersMenu.AddItem(item3);

            entreesMenu.AddItem(item4);
            entreesMenu.AddItem(item5);
            entreesMenu.AddItem(item6);

            dessertsMenu.AddItem(item7);
            dessertsMenu.AddItem(item8);
            dessertsMenu.AddItem(item9);

            drinksMenu.AddItem(item10);
            drinksMenu.AddItem(item11);
            drinksMenu.AddItem(item12);




            appetizersMenu.PrintMenu();
        }
    }
}