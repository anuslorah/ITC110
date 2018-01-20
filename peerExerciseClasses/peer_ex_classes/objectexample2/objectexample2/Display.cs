using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectexample2
{
    public class Display
    {
        //get items from console
        //diplay list of items
        //get the total

        //declaring an instance at class level because 
        //I need it in each method, redeclaring would zero it out again
        ShoppingCart cart; 

        //constructor
        public Display()
        {
            cart = new ShoppingCart();
            GetiItems();
            ShowItems();
            ShowTotal();
            Pause();
        }
        
        private void GetiItems()
        {
            Console.WriteLine("enter how many items you are buying");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i<number; i++)
            {
                Item item = new Item();
                Console.WriteLine("enter item name");
                item.ItemName = Console.ReadLine();
                Console.WriteLine("enter item price");
                item.ItemPrice = double.Parse(Console.ReadLine());
                cart.AddItem(item);
            }
        }

        private void ShowItems()
        {
            List<Item> stuff = cart.GetItems();
            Console.Clear(); //clears the console
            foreach(Item i in stuff)
            {
                Console.WriteLine("{0} costs {1}", i.ItemName, i.ItemPrice);
            }
        }

        private void ShowTotal()
        {
            Console.WriteLine("the total is {0}", cart.GetTotal());
        }

        private void Pause()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
