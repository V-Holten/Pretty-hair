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

namespace Pretty_hair
{
    /// <summary>
    /// Interaction logic for New_Order.xaml
    /// </summary>
    public partial class New_Order : Page
    {
        Controller controller;
        public New_Order(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        public New_Order()
        {
            InitializeComponent();
        }

        private void Textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Text = "";
        }
    }
}
