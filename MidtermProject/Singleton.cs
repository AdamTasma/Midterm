﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    //things that never change
    static class Singleton
    {
        public static string filepath = @"C:\Users\adamt\source\repos\MidtermProject\Inventory.txt";

        public static double salesTax = 0.06;

        public static List<Product> Inventory = new List<Product>();
    }
}
