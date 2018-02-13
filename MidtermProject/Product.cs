using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    //main product class. products that are available to purchase, which are imported from a txt file
    class Product
    {
        string Name;
        string Category;
        string Description;
        double Price;
        int qty;


        public int GetQty()
        {
            return qty;
        }

        public void SetQty(int qty) 
        {
            this.qty = qty;
        }
        public double GetPrice()
        {
            return Price;
        }

        public string GetFormattedPrice()
        {
            string formatPrice = "";
            String.Format("{0:C2}", Price);
            return formatPrice;
        }
        public string GetName()
        {
            return Name;
        }

        public string GetCategory()
        {
            return Category;
        }

        public string GetDescription()
        {
            return Description;
        }
        public Product(string name, string category, string description, double price)
        {
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Price = price;
        }

        public override string ToString()
        {
            string myString = String.Format("{0,-30} {1,-10:C2} {2,-15}{3,5}", Name, Price, Category, Description);
            return myString;
        }

        public string showCartProducts()
        {
            return this.ToString() + "\t" +  this.GetQty();            
        }
    }
}
