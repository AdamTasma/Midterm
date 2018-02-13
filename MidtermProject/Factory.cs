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

                try
                {
                    string filepath = @"C:\Users\adamt\source\repos\MidtermProject\Inventory.txt";

                    if (File.Exists(filepath))
                    {
                        StreamReader file = new System.IO.StreamReader(filepath);
                        while ((line = file.ReadLine()) != null)
                        {
                            string[] info = line.Split(';');
                            Product v = new Product(info[0], info[1], info[2], double.Parse(info[3]));

                            Singleton.Inventory.Add(v);
                        }
                        file.Close();
                    }
                    else
                    {
                        Console.WriteLine("there is no file foo");
                    }
                }
                catch(FileLoadException e)
                {
                    Console.WriteLine("unable to read the file");
                }

                catch (Exception e)
                {
                    Console.WriteLine("unable to read the file");
                }
            }
        }
    }
}
