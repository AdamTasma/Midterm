using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
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
