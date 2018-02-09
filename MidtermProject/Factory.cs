using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    //class for making objects that are needed
    class Factory
    {
        public Invoice CreateInvoice()
        {
            return new Invoice();
        }
    }
}
