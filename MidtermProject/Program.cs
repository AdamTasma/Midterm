using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    //main

    /*
     TODO:  
     input validation
     add comments
     extended challenge
     */
    class Program
    {
        static void Main(string[] args)
        {

            Factory.ReadInventory();
            MainMenu menu = new MainMenu();

            menu.showMenu();
            Console.WriteLine("burritos are the best");
        }
    }
}
