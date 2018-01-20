using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        /*James Carroll 10/18/16
         * This program gives the user 3 options to enter
         */
        static void Main(string[] args)
        {
            int choice = 1;

            Console.WriteLine("Select an option 1, 2, or 3. 3 will close the loop.");

            while (choice != 3)
            {
                Console.WriteLine("Option 1:\t 1");
                Console.WriteLine("Option 2:\t 2");
                Console.WriteLine("Option 3:\t 3");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You have chosen option one.");
                        break;
                    case 2:
                        Console.WriteLine("You have chosen option two.");
                        break;
                    case 3:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }//end switch

            }//end of while loop
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();

        }//end of Main
    }//end of Program
}//end of namespace