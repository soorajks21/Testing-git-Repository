using System;
using System.Collections.Generic;
using System.Data;
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

namespace _300871455_Baten__Example3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> items = new List<Customer>();
        int count = 6;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            
            items.Add(new Customer("UFT", "Sooraj", "Developer", "Grace st", "Toronto", "Canada"));
           
            //items.Add(new Customer("Centennial", "Midhun", "Developer", "Tuxedo" ,"Toronto", "Canada"));
            //items.Add(new Customer("Centennial", "Jayan", "Developer", "Grace st", "Toronto", "Canada"));
            //items.Add(new Customer("UFT", "Rohan", "Developer", "Grace st", "Toronto", "Canada"));
            //var grid = sender as DataGrid;
            //grid.ItemsSource = items;
            //// ... Scroll into view.
            //grid.ScrollIntoView(items[items.Count - 1]);
            gridview.Items.Add(items);
            items.Add(new Customer("Centennial", "Nithin", "Developer", "Jerald st", "Toronto", "Canada"));
            gridview.Items.Add(items);

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get SelectedItems from DataGrid.
            //var grid = sender as DataGrid;
            //var selected = grid.SelectedItems;
            //foreach (var item in selected)
            //{
            //    var val = item as Customer;
            //    Cname.Text = val.CName;
            //name.Text = val.Name;
            //title.Text = val.Title;
            //address.Text = val.Adress;
            //city.Text = val.City;
            //country.Text = val.Country;
            //}

            DataGrid gd = (DataGrid)sender;
            DataRowView row = gd.SelectedItem as DataRowView;
            Cname.Text = row["CName"].ToString();
            name.Text = row["Name"].ToString();
            title.Text = row["Title"].ToString();
            address.Text = row["Adress"].ToString();
            city.Text = row["City"].ToString();
            country.Text = row["Country"].ToString();

        }

        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var name = e.EditingElement as TextBox;
            var text = name.Text;
            Cname.Text = text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new Customer(Cname.Text, name.Text, title.Text, address.Text, city.Text, country.Text));

            gridview.Items.Add(items);
           
        }
    }
}
