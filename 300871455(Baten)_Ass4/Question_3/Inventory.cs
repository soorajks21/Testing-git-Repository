using System;
using System.Collections.Generic;
using System.Text;

namespace Question_3
{
  public  class Inventory : IComparable<Inventory>
    {

        private string name;
        private double cost;
        private int quantity;

        public string Name { get => name; set => name = value; }
        public double Cost { get => cost; set => cost = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public int CompareTo(Inventory other)
        {

            return this.Name.CompareTo(other.Name);
        }


        public override string ToString()
        {

            return "Name: " + this.Name + " Cost: " + this.Cost + " Quantity: " + this.Quantity;

        }
    }
}
