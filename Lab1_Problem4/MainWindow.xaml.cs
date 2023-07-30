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

namespace Lab1_Problem4
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Problem_1.IsChecked == true) 
            {
                new Lab1_Problem1.MainWindow().Show();
                this.Close();
            }
            if (Problem_2.IsChecked == true)
            { 
                new Lab1_Problem2.MainWindow().Show();
                this.Close();
            }
            if (Problem_3.IsChecked == true) 
            {   
                new Lab1_Problem3.MainWindow().Show();
                this.Close();
            }
            
        }
    }
}
