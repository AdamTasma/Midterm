using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class Credit : IPayment
    {
        string CardNumber;
        string CardExpiration;
        string CVV;
       // double Amount;

        public Credit(string cardNumber, string cardExpiration, string cVV)
        {
            this.CardNumber = cardNumber;
            this.CardExpiration = cardExpiration;
            this.CVV = cVV;
        }

        public bool MakePayment(double grandTotal)
        {
            return true;
        }
    }
}
