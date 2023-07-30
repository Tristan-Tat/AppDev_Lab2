﻿using System;
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

namespace Lab1_Problem1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBoxAccount_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BankCharges account = new BankCharges();

            decimal currentBalance = decimal.Parse(TextBoxAccount.Text);

            account.SetAccountBalance(currentBalance);
            account.SetNumberOfChecks(int.Parse(TextBoxChecks.Text));

            decimal newBalance = currentBalance - account.CalcCharges();
            TextBoxAccount.Text = newBalance.ToString();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new Lab1_Problem4.MainWindow().Show();
        }
    }
}