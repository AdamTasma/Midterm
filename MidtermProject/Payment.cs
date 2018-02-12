using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Payment
    {

        //if user is paying with cash

        public double PayWithCash(double GrandTotal, double CashTendered)

        {

            double change = CashTendered - GrandTotal;

            return change;

        }        //if user is paying with card

        public string PayWithCard()

        {

            Console.WriteLine("Please input your card number.");

            string cardNumber = Console.ReadLine();

            Console.WriteLine("please input your expiration date.");

            string cardExpiration = Console.ReadLine();

            Console.WriteLine("Please input your CVV.");

            string cVV = Console.ReadLine();

            string lastFour = cardNumber.Substring((cardNumber.Length - 4), 4);

            return lastFour;

        }        //if user is paying with check

        public string PayWithCheck()

        {

            Console.WriteLine("Please input your check number.");

            string checkNumber = Console.ReadLine();

            return checkNumber;

        }

    }

}

