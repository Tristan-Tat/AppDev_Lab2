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

namespace Lab1_Problem3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int startingPop = int.Parse(TextBoxPop.Text);
            double avgDailyGrowth = double.Parse(TextBoxGrowth.Text) / 100;
            int days = int.Parse(TextBoxDays.Text);

            bool isInvalidInput = startingPop < 2 || avgDailyGrowth < 0 || days < 1; 
            if (isInvalidInput) { MessageBox.Show("Error: Invalid input"); }
            else
            {
                
                int[] dailyPop = new Population(startingPop, avgDailyGrowth, days).calcDailyPop();
                String message = $"Day 0 pop. = {startingPop}\n";
                for (int i = 0; i < dailyPop.Length; i++)
                {
                    message += $"Day {i+1} pop. = {dailyPop[i]}\n";
                }
                MessageBox.Show(message);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new Lab1_Problem4.MainWindow().Show();
        }
    }
}
