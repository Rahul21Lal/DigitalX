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
    /// Interaction logic for Employees.xaml
    /// </summary>
    public partial class Employees : Page
    {
        public Employees()
        {
            InitializeComponent();

            /*
                dgdEmployees.ItemsSource = (from employeeVariable in dbemployees
                                           select new
                                           {
                                               employeeVariable.employeeID,
                                               employeeVariable.FirstName,
                                               employeeVariable.LastName,
                                               employeeVariable.UserName
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
