using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    class ProductOrdered : Product
    {
        int Quantity;

        public int GetQuantity()
        {
            return Quantity;
        }

        public ProductOrdered(string name, string category, string description, double price, int quantity) : base(name, category, description, price)
        {
            this.Quantity = quantity;
        }
    
        
    }
}
