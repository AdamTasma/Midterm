using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    //interface for making payments via cash, card, or check
    interface IPayment
    {
         bool MakePayment(double grandTotal);
    }
}

