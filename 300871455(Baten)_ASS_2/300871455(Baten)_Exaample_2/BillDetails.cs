using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300871455_Baten__Exaample_2
{
  public class BillDetails: INotifyPropertyChanged
    {
        private double sub_total;
        private double _total;
        private double itemtax;

      public  BillDetails()
        {
            sub_total = 0;
            _total = 0;
            itemtax = 0;
        }
        public double Sub_total { get => sub_total;
            set {
                sub_total = value;
                onPropertyChanged("Sub_total");
                onPropertyChanged("Total");
            }
        }
        public double Total { get => _total; set {
                _total = value;
                onPropertyChanged("Total");
             
            } }
        public double Itemtax { get => itemtax;
            set { itemtax = value;
                onPropertyChanged("Itemtax");
                onPropertyChanged("Total");
            } }



        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        public void getBill(ObservableCollection<ItemDetails> itemval)
        {
            foreach(var val in itemval)
            {
                Sub_total = Sub_total + val.ItemTotal;
            }
            Itemtax = Sub_total * .13;
            Total = Itemtax + Sub_total;
        }
            
    }
}
