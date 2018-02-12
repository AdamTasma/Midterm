using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    //main

    /*
     TODO:  -view / customer screen
                -> menu for user to choose from 
            -controller class that handles the interpreting from customer view to the data.
            -model class needs to read a txt file and create object from it and store them in a List<Product>
            -model class needs to write out new products that are available. (extended)
            -need a receipt that prints to the screen once an order is paid for. to include
                               -> name of store
                 -item -> price -> quantity -> line total
                                            -> subtotal
                                            -> tax
                                            ****************
                                            -> grand total
                                            -> tender type
                                            -> amount tendered
                                            -> change given
                               -> thank you message
            -input validation on info entered by customer
            

     */
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu.showMenu();
            Console.WriteLine("Adam is the best");
        }
    }
}
