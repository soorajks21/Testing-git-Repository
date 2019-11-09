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

namespace _300871455_Betan__ASS_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          

        InitializeComponent();


            List<course> courses = new List<course>()
                {
                   new course{ Sem=1,Course1="COMP171", Course2="COMP213",Course3="COMP120",Course4="COMP125", Course5="COMP253"},
                   new course{ Sem=2,Course1="COMP100", Course2="COMP213",Course3="COMP120",Course4="COMP125", Course5="COMP253"},
                    new course{ Sem=3,Course1="COMP100", Course2="COMP213",Course3="COMP120",Course4="COMP125", Course5="COMP253"},
                    new course{ Sem=4,Course1="COMP100", Course2="COMP213",Course3="COMP120",Course4="COMP125", Course5="COMP253"},
                      new course{ Sem=5,Course1="COMP100", Course2="COMP213",Course3="COMP120",Course4="COMP125", Course5="COMP253"},
                };
            combo_sem.ItemsSource = courses;
            combo_sem.DisplayMemberPath = "Sem";







        }


        private void Combo_sem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            course cs = combo_sem.SelectedItem as course;
            course_txt.Text = cs.Course1 + "\r\n" + cs.Course2 + " \r\n" + cs.Course3 + "\r\n"+ cs.Course4 + "\r\n"+ cs.Course5 ;
        }

        
    }
}
