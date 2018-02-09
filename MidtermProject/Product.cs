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
        double Price { get; set; }
        public double GetPrice()
        {
            return Price;
        }
        public string GetName()
        {
            return Name;
        }

        public Product(string name, string category, string description, double price)
        {
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Price = price;
        }
    }
}
