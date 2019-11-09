using System;
using System.Collections.Generic;
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

namespace Excercise_3_converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int fahrenheit, celisus = 0;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            exce_lbl.Content = " ";
            fahrenheit = Convert.ToInt32(fahrenheit_txt.Text);
            celisus = Convert.ToInt32(0.55 * (fahrenheit - 32));
            result.Content = celisus.ToString();
            } 
            catch(Exception ex)
            {
               exce_lbl.Content = "Must enter a value in Numeric";
            }
         

        }
    }
}
