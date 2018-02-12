using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
        public static void ReadInventory()
        {
            {
                string line;
                //string filepath = @"C:\Users\adamt\source\repos\midtermFileIO\midtermFileIO\InventoryList.txt";
                string filepath = @"C:\Users\aManHasNoName\Desktop\inventory.txt";

                if (File.Exists(filepath))
                {
                    StreamReader file = new System.IO.StreamReader(filepath);
                    while ((line = file.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        string[] game = line.Split(';');
                        //Console.WriteLine(game[0]);
                        Product v = new Product(game[0], game[1], game[2], double.Parse(game[3]));

                        Singleton.Inventory.Add(v);
                    }
                    file.Close();

                }
                else
                {
                    Console.WriteLine("there is no file");
                }


            }
        }
        }
}
