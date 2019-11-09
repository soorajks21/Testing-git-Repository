using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300871455_Baten__ASS_2
{
   public class BookLibrary
    {
        private string title;
        private string author;
        private int price;
        private string typeOfCover;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int Price { get => price; set => price = value; }
        public string TypeOfCover { get => typeOfCover; set => typeOfCover = value; }

        public override string ToString()
        {
        return "title: " + Title + "   Author: " + Author + "Price:" + Price + "Type" + TypeOfCover ;
         }
}
}
