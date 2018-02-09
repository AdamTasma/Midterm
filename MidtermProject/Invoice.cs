using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Invoice
    {
        double SaleTax = 0.06;
        List<ProductOrdered> Products;
        double SubTotal;
        double GrandTotal;
        double TotalTax;
        public bool Payed;

        public Invoice()
        {
            Products = new List<ProductOrdered>();
            Payed = false;
        }

        public bool GetStatus()
        {
            return Payed;
        }

        public void Calculate()
        {
            double sum = 0;
            foreach (ProductOrdered p in Products)
            {
                sum += p.GetPrice() * p.GetQuantity();
            }
            SubTotal = sum;

            TotalTax = SubTotal * SaleTax;

            GrandTotal = SubTotal + TotalTax;
        }
        
        public void ShowInvoice()
        {
            Console.WriteLine("List of items");
            foreach ( ProductOrdered p in Products)
            {
                Console.Write("{0}{1}{2}{3}",p.GetName(),p.GetQuantity(), p.GetPrice(), p.GetPrice()*p.GetQuantity());
            }
            Console.WriteLine("Subtotal:{0:C2} Tax:{1} Total:{2}",SubTotal, TotalTax, GrandTotal);
            Console.WriteLine(GrandTotal);
        }
    }
}
