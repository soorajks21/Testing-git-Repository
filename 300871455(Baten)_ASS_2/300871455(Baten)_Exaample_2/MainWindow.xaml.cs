using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _300871455_Baten__Exaample_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ItemDetails> Electronics = new List<ItemDetails>();
        public List<ItemDetails> Books = new List<ItemDetails>();
        public List<ItemDetails> Toys = new List<ItemDetails>();
        public List<ItemDetails> Jewellery = new List<ItemDetails>();
        public ObservableCollection<ItemDetails> tableMenu = new ObservableCollection<ItemDetails>();

        BillDetails invoice = new BillDetails();
        public MainWindow()
        {
            InitializeComponent();
            Electronics.Add(new ItemDetails { ItemName = "switch", ItemPrice = 1.95 });
            Electronics.Add(new ItemDetails { ItemName = "Mobile", ItemPrice = 124.50 });
            Electronics.Add(new ItemDetails { ItemName = "TV", ItemPrice = 100.25 });



            Books.Add(new ItemDetails { ItemName = "Kaipoo che", ItemPrice = 5.95 });
            Books.Add(new ItemDetails { ItemName = "Fingers", ItemPrice = 6.95 });
            Books.Add(new ItemDetails { ItemName = "Latest", ItemPrice = 8.95 });


            Toys.Add(new ItemDetails { ItemName = "Pumpkin", ItemPrice = 15.95 });
            Toys.Add(new ItemDetails { ItemName = "Tom", ItemPrice = 13.95 });
            Toys.Add(new ItemDetails { ItemName = "Super Man", ItemPrice = 13.95 });


            Jewellery.Add(new ItemDetails { ItemName = "Necklace", ItemPrice = 5.95 });
            Jewellery.Add(new ItemDetails { ItemName = "ring", ItemPrice = 3.95 });
            Jewellery.Add(new ItemDetails { ItemName = "Bangles", ItemPrice = 5.95 });


            BCombo.ItemsSource = Electronics;
            AppCombo.ItemsSource = Books;
            MainCombo.ItemsSource = Toys;
            DessCombo.ItemsSource = Jewellery;

            BillDetails.ItemsSource = tableMenu;

            Total_Price.DataContext = invoice;
            Sub_Total.DataContext = invoice;
            Tax.DataContext = invoice;



        }


        private void clearBill_Click(object sender, RoutedEventArgs e)
        {
            tableMenu.Clear();
            invoice.Sub_total = 0;
            invoice.Total = 0;
            invoice.Itemtax = 0;

        }





        private void Beverage_DropDownClosed(object sender, EventArgs e)
        {
            ItemDetails newItem = (ItemDetails)BCombo.SelectedItem;

            if (checkdetails(newItem.ItemName) == true)
            {

                newItem.Quantity++;

            }
            else
            {
                tableMenu.Add(newItem);
            }
            invoice.getBill(tableMenu);
        }

        private void Appetizer_DropDownClosed(object sender, EventArgs e)
        {

            ItemDetails newItem = (ItemDetails)AppCombo.SelectedItem;

            if (checkdetails(newItem.ItemName) == true)
            {

                newItem.Quantity++;

            }
            else
            {
                tableMenu.Add(newItem);
            }
            invoice.getBill(tableMenu);
        }

        private void Mains_DropDownClosed(object sender, EventArgs e)
        {
            ItemDetails newItem = (ItemDetails)MainCombo.SelectedItem;

            if (checkdetails(newItem.ItemName) == true)
            {

                newItem.Quantity++;

            }
            else
            {
                tableMenu.Add(newItem);
            }
            invoice.getBill(tableMenu);
        }

        private void Desserts_DropDownClosed(object sender, EventArgs e)
        {

            ItemDetails newItem = (ItemDetails)DessCombo.SelectedItem;

            if (checkdetails(newItem.ItemName) == true)
            {

                newItem.Quantity++;

            }
            else
            {
                tableMenu.Add(newItem);
            }
            invoice.getBill(tableMenu);
        }

        private Boolean checkdetails(String name)
        {

            foreach (var item in tableMenu)
            {
                if (item.ItemName == name)
                    return true;
            }
            return false;
        }

        private void Gen_Bill_Click(object sender, RoutedEventArgs e)
        {

            String finalBill = "";
            foreach (var item in tableMenu)
            {
                finalBill = finalBill + item.ItemName + "  " + item.ItemTotal + "\n";
            }
            MessageBox.Show(finalBill + "\nSubtotal : " + invoice.Sub_total + "\nTax : " + invoice.Itemtax + "\nTotal Bill Total_Price is " + invoice.Total);
        }


    }
}


