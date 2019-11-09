using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300871455_Baten__Example3
{
  public  class Customer
    {
        public Customer(string cName, string name, string title, string adress, string city, string country)
        {
           
            CName = cName;
            Name = name;
            Title = title;
            Adress = adress;
            City = city;
            Country = country;
        }


        public string CName { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }



    }
}
