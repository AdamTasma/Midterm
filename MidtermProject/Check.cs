using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Check : IPayment
    {
        string checkNumber;
        public bool MakePayment(double grandTotal)
        {
            return true;

        }
    }
}
