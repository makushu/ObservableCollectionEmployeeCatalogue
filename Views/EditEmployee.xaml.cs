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
using TheCatalogueEmployee.ViewModel;

namespace TheCatalogueEmployee.Views
{
    /// <summary>
    /// Interaction logic for EditEmployee.xaml
    /// </summary>
    public partial class EditEmployee : Page
    {
        EmployeeViewModel employeeViewModel;
        public EditEmployee()
        {
            InitializeComponent();
            // DataContext = new EmployeeViewModel;
         
                // This is a bit redundant I think, but I can't rememeber if this is how you set it up
             //   employeeViewModel = new EmployeeViewModel(selectedEmployee);
                DataContext = employeeViewModel;
            }

        private void btnEditEmployee_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnCloseEditPage_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
