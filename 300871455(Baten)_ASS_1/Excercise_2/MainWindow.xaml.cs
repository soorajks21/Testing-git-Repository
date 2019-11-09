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

namespace Excercise_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void RedBtn_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void BlueBtn_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void GreenBtn_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Color = Colors.Green;
          
        }

        private void BlkBtn_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void InkCanvas_Gesture(object sender, InkCanvasGestureEventArgs e)
        {

        }

        private void SmallBtn_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Height = 5;
            this.inkCanvas1.DefaultDrawingAttributes.Width = 5;
        }

        private void MedBtn_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Height = 10;
            this.inkCanvas1.DefaultDrawingAttributes.Width = 10;
        }

        private void LrgBtn_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.DefaultDrawingAttributes.Height = 15;
            this.inkCanvas1.DefaultDrawingAttributes.Width = 15;
        }
    }
}
