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

namespace DigitalX
{
    /// <summary>
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {
        public Orders()
        {
            InitializeComponent();

            /*
                dgdOrders.ItemsSource = (from orderVariable in dborders
                                           select new
                                           {
                                               orderVariable.orderID,
                                               orderVariable.FirstName,
                                               orderVariable.LastName,
                                               orderVariable.UserName
                                           }
                                          );
            */
        }
        public void backfunction()
        {
            NavigationWindow nw = (NavigationWindow)Window.GetWindow(this);
            nw.Close();
        }
    }
}
