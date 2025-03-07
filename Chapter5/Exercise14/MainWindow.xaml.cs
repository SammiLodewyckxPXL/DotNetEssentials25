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

namespace Exercise14
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
       
        public String ConvertNumberToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            binaryLabel.Content = ConvertNumberToBinary(Convert.ToInt16(numberTextBox.Text));
        }
    }
}
