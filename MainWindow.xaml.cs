﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TheCatalogueEmployee.ViewModel;
using TheCatalogueEmployee.Views;
using static TheCatalogueEmployee.Model.EmployeeModel;

namespace TheCatalogueEmployee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private ObservableCollection<Employee> employee;

        public MainWindow()
        {
            InitializeComponent();
            employee = new ObservableCollection<Employee>();

        }


        private void EmployeeViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.ShowEmployees();
            EmployeeViewControl.DataContext = employeeViewModel;
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            
          //  Main.Content = new AddEmployee();
        }

        private void btnEditEmployee_Click(object sender, RoutedEventArgs e)
        {
         //   Main.Content = new EditEmployee();
        }

     
    }

}
