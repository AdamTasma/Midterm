using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    static class MainMenu
    {
        //show the main menu.
        public static void showMenu()
        {
            Console.WriteLine("Welcome to SteamyMist");
            Console.WriteLine("*********************");
            Console.WriteLine("1: Order products");
            Console.WriteLine("2: View Cart");
            Console.WriteLine("3: Checkout");
            Console.WriteLine("4: Exit Store");
            GetInput();

        }

        //prompt the user for input, then pass the input to validate to make sure its a valid integer choice.
        //then pass to an if statement or switch statement to handle the choice accordingly.
        public static void GetInput()
        {
            Console.Write("\nWhat would you like to do: ");
            string input = Console.ReadLine();
            int valid = Validate(input);

        }

        //move validate to another class? logic doesn't really belong in view...
        public static int Validate(string input)
        {
            if (int.TryParse(input, out int valid) != false)
            {
                return valid;
            }
            else
            {
                Console.WriteLine("ERROR: Invalid input. Please try again.");
                showMenu();
                return 0;
            }


        }

        //switch statement to handle user choice from the main menu, probably belongs in a different class.


    }
}
