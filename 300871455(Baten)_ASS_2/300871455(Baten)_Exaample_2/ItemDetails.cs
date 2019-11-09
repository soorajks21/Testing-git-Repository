using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300871455_Baten__Exaample_2
{
  public  class ItemDetails: INotifyPropertyChanged
    {
        private string itemName;
        private int quantity;
        private double itemTotal;
        private double itemPrice;

        public ItemDetails()
        {
            quantity = 1;
        }
        
        public double ItemTotal { get => itemPrice* quantity;
            set { itemTotal = itemPrice * quantity;
                onPropertyChanged("itemTotal");
            } }
        public int Quantity { get => quantity;
            set { quantity = value;
                onPropertyChanged("quantity");
                onPropertyChanged("itemTotal");
            } }
       

        public double ItemPrice { get => itemPrice ;
            set { itemPrice = value;
                onPropertyChanged("ItemPrice");
                onPropertyChanged("itemTotal");
            } }

        public string ItemName { get => itemName;
            set {
                itemName = value;
                onPropertyChanged("itemName");
                onPropertyChanged("itemTotal");
            } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
