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
using System.Windows.Shapes;

namespace Kvalitet
{
    /// <summary>
    /// Interaction logic for CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : Window
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btnorderback_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btnfinishorder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Txtantalpro_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
