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

namespace proverka_vetok
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
            MessageBox.Show("egw");
        }

        private void CLick_ChekTextBox(object sender, RoutedEventArgs e)
        {
            var TName = Name.Text;
            if (TName == "Павел")
            {
                MessageBox.Show("Congratulations!");
            }
        }
    }
}
