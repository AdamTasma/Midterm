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

        public static bool AddProduct(string name, string category, string description, double price)
        {
            try
            {
                Product p = new Product(name, category, description, price);
                Singleton.Inventory.Add(p);
                StreamWriter w = File.AppendText(Singleton.filepath);// new StreamWriter(Singleton.filepath, true);

                w.WriteLine(p.GetName() + ";" + p.GetCategory() + ";" + p.GetDescription() + ";" + p.GetPrice());
                w.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong");
                return false;
            }
        }

        public static void ReadInventory()
        {
            {
                string line;

                try
                {
                    if (File.Exists(Singleton.filepath))
                    {
                        StreamReader file = new System.IO.StreamReader(Singleton.filepath);
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
