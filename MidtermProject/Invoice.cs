using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    //Cart class, holds items that are selected by customer, and displays them back
    //then the customer will have the option to continue shopping or check out and pay.
    class Invoice
    {
        double SaleTax = 0.06;
        double SubTotal;
        double GrandTotal;
        double TotalTax;
        public bool Payed;

        public static List<Product> Cart = new List<Product>();

        public double GetGrandTotal()
        {
            return GrandTotal;
        }

        public void Calculate()
        {
            double sum = 0;
            foreach (Product p in Invoice.Cart)
            {
                sum += p.GetPrice() * p.GetQty();
            }
            this.SubTotal = sum;
            
            this.TotalTax = SubTotal * SaleTax;

            this.GrandTotal = SubTotal + TotalTax;
        }
        
        public void ShowCart()
        {
            Console.WriteLine("List of items");
            foreach ( Product p in Cart)
            {
                Console.Write("\nName: {0,-10} / Qty: {1,-5} / Price per: {2,-5:C2} / Line Total: {3,-5:C2}",p.GetName(),p.GetQty(), p.GetPrice(), p.GetPrice()*p.GetQty());
            }
            Console.WriteLine("\nSubtotal: {0:C2} \nTax: {1:C2} \nGrand Total: {2:C2}",SubTotal, TotalTax, GrandTotal);
        }

        public void printReceipt(string payType, double tendered, double change)
        {
            Console.WriteLine("*** STEAMY MIST*** \n");
            ShowCart();         
            Console.WriteLine("Tendered with: " + payType); 
            Console.WriteLine("Amount tendered: {0:C2}", tendered);
            Console.WriteLine("Change: " + "{0:C2}", change); 
            Console.WriteLine();
            Console.WriteLine("Thank you for shopping with STEAMY MIST");

        }

    }
}
