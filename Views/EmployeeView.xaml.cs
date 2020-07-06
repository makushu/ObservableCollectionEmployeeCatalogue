using System;
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
using static TheCatalogueEmployee.Model.EmployeeModel;
using static TheCatalogueEmployee.ViewModel.EmployeeViewModel;

namespace TheCatalogueEmployee.Views
{
    /// <summary>
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {

        public EmployeeView()
        {
           InitializeComponent();

        }

        private void btnShowAdd_Click(object sender, RoutedEventArgs e)
        {
            PopAdd.IsOpen = true;
        }

        private void btnShowEdit_Click(object sender, RoutedEventArgs e)
        {
            PopEdit.IsOpen = true;
        }

        private void btnCloseAdd_Click(object sender, RoutedEventArgs e)
        {
            PopAdd.IsOpen = false;
        }

        private void btnCloseEdit_Click(object sender, RoutedEventArgs e)
        {
            PopEdit.IsOpen = false;
        }

        private void ctmEdit(object sender, RoutedEventArgs e)
        {
            PopEdit.IsOpen = true;
        }
    }

}
