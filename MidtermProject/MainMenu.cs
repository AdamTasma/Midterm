using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class MainMenu
    {
        Invoice invoice = new Invoice();
        Payment payment = new Payment();

        //show the main menu.
        public void showMenu()
        {
            Console.WriteLine("Welcome to SteamyMist");
            Console.WriteLine("*********************");
            Console.WriteLine("1: Order products");
            Console.WriteLine("2: View Cart");
            Console.WriteLine("3: Checkout");
            Console.WriteLine("9: Exit Store");

            Console.Write("\nWhat would you like to do: ");
            int resp =   GetInput();
            switch (resp)
            {
                case 1:
                    order();
                    break;
                case 2:
                    showCart();
                    break;
                case 3:
                    checkout();
                    break;
                case 9:
                    Console.WriteLine("Thank you for shopping with us. Goodbye.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    showMenu();
                    break;

            }
        }

        //prompt the user for input, then pass the input to validate to make sure its a valid integer choice.
        //then pass to an if statement or switch statement to handle the choice accordingly.
        public int GetInput()
        {
            string input = Console.ReadLine();
            int valid = Validate(input);
            return valid;
        }

        //move validate to another class? logic doesn't really belong in view...
        public int Validate(string input)
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

        public void order()
        {
            int productNumber = 0;
            foreach (Product p  in Singleton.Inventory) //inventory list from txt
            {
                Console.WriteLine( productNumber + ": " + p.ToString() );
                productNumber++;
            }

            Console.Write("\nWhich product would you like to order: ");
            int input = GetInput();
            Console.Write("Enter the quantity you want to order: ");

            int qty = GetInput();
            Product product = Singleton.Inventory [input];
            product.SetQty(qty);
            //waldo//
            Console.WriteLine("your line total is {0:c2}", (product.GetPrice() * product.GetQty()));

            Invoice.Cart.Add(product);

            Console.WriteLine("\n1: Continue shopping \n2: Back to main menu \n3: checkout");
            int response = GetInput();
            if (response == 1)
            {
                order();
            }
            else if(response == 3)
            {
                checkout();
            }
            else 
            {
                showMenu();
            }
            

        }

        public void showCart()
        {

            Console.WriteLine("Shopping Cart: \n");

            foreach (Product p in Invoice.Cart)
            {
                Console.WriteLine( p.showCartProducts() );
            }

            Console.WriteLine("\n1: Checkout \n2: Main Menu");
            int response = GetInput();
            if (response == 1)
            {
                checkout();
            }
            else
            {
                showMenu();
            }

        }

        public void checkout()
        {

            Console.WriteLine("\n*** CHECKOUT ***\n");
            invoice.Calculate();            
            invoice.ShowCart();
            Console.WriteLine("\n1: Pay with Cash \n2: Pay with Credit Card \n3: Pay with Check");
            int response = GetInput();

            pay(response);

        }

        public void pay(int response)
        {
            if (response == 1)
            {
                //give a total, cash tendered, get back the change , and then display receipt.
                Console.Write("Enter amount of Cash tendered: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double tendered) != false && tendered >= invoice.GetGrandTotal())
                {
                    double change = payment.PayWithCash(invoice.GetGrandTotal(), tendered);
                    Console.WriteLine( "Your change is: " + change);
                    invoice.printReceipt("Cash", tendered, change);
                    Invoice.Cart.Clear();
                    Console.ReadLine();

                    showMenu();
                }
                else
                {
                    Console.WriteLine("Invalid amount entered, try again.");
                    pay(response);
                }
                Console.WriteLine();
                //show receipt
                //after they pay, clear the cart and show main menu

            }
            else if (response == 2)
            {
                //receipt contains last 4 credit info...
                string lastFour = payment.PayWithCard();
                invoice.printReceipt(("Credit Card " +lastFour), invoice.GetGrandTotal(), 0.0);
                Console.ReadLine();
                Invoice.Cart.Clear();

                showMenu();
            }
            else if (response == 3)
            {
                //receipt contains check number 
                double checkNumber = payment.PayWithCheck();
                invoice.printReceipt(("Check #: " + checkNumber), invoice.GetGrandTotal(), 0.0 );
                Console.ReadLine();
                Invoice.Cart.Clear();

                showMenu();
            }
            else
            {
                Console.WriteLine("Invalid entry, please select a method of payment.");
                checkout();
            }


        }


        //switch statement to handle user choice from the main menu, probably belongs in a different class.


    }
}
