using System;
using System.Collections.Generic;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Inventory> inventories = new List<Inventory>()
            {
               new Inventory(){Name="Mixer", Cost= 25.00, Quantity=4 },
               new Inventory(){Name="Mobile", Cost= 600.50, Quantity=7 },
               new Inventory(){Name="watch", Cost= 121.00, Quantity=21 },
               new Inventory(){Name="Laptop", Cost= 600, Quantity=14 },
               new Inventory(){Name="Tablet", Cost= 400, Quantity=25 },
               new Inventory(){Name="Speaker", Cost= 6.75, Quantity=5 }



            };

            Console.WriteLine("Before Sort");
            foreach (var item in inventories)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            inventories.Sort();

            Console.WriteLine();
            Console.WriteLine("Sort by name");
            foreach(var item in inventories)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
