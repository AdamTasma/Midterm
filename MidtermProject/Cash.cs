using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    //cash payment class, implements Ipayment
    //has amount tendered by customer, and a balance (change) due back to customer
    class Cash : IPayment
    {
        double CashTendered;
        double balance;


        public double GetBalance()
        {
            return balance;
        }

        public bool MakePayment(double grandTotal)
        {
            balance = CashTendered - grandTotal;            
            return true;
        }
    }
}
