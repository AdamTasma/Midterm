using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    //main

    /*
     TODO:  -comments
            -add line total after choosing qty
            -input validation /try catch if needed
            -****go over each piece so everyone knows everything //can use comments to help with program flow
            -presentation stuff
            -            -add file output for extended challenge??

            
            

     */
    class Program
    {
        static void Main(string[] args)
        {

            Factory.ReadInventory();
            MainMenu menu = new MainMenu();

            menu.showMenu();
            Console.WriteLine("David is the best");
        }
    }
}
