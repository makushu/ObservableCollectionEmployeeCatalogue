using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TheCatalogueEmployee.ICommands;
using TheCatalogueEmployee.Model;
using static TheCatalogueEmployee.Model.EmployeeModel;

namespace TheCatalogueEmployee.ViewModel
{
    class EmployeeViewModel
    {
        public ICommandsClass AddCommand { get; set; }
        public ICommandsClass EditCommand { get; set; }
        public ICommandsClass ViewCommand { get; set; }
        public EmployeeViewModel()
        {
            AddCommand = new ICommandsClass(OnAdd);
            EditCommand = new ICommandsClass(OnEdit);
            ViewCommand = new ICommandsClass(OnView);
        }

        public ObservableCollection<Employee> Employees
        {
            get;
            set;
        }

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public void ShowEmployees()
        {

            employees.Add(new Employee
            {
                Name = "Monday",
                Surname = "Morning",
                DateOfBirth = "1/1/1980",
                Gender = "Female",
                HomeAddress = "123 Streeting Street"
            });
            employees.Add(new Employee
            {
                Name = "Tuesday",
                Surname = "Afternoon",
                DateOfBirth = "2/2/1955",
                Gender = "Male",
                HomeAddress = "456 Roading Road"
            });
            employees.Add(new Employee
            {
                Name = "Wednesday",
                Surname = "Night",
                DateOfBirth = "3/3/2000",
                Gender = "Female",
                HomeAddress = "789 Driving Drive"
            });

            Employees = employees;
        }
      
        
        private Employee selectedEmployee;

        public Employee SelectedEmployee
        {
            get
            {
                return selectedEmployee;
            }

            set
            {
                selectedEmployee = value;
                EditCommand.RaiseCanExecuteChanged();
            }
        }




        private void OnView()
        {
                MessageBox.Show("Name : " + selectedEmployee.Name + "\n" + "Surname : " + selectedEmployee.Surname + "\n" + "Date Of Birth : " +
                   selectedEmployee.DateOfBirth + "\n" + "Gender : " + selectedEmployee.Gender + "\n" + "Home Address : " + selectedEmployee.HomeAddress, selectedEmployee.Name.ToUpper() + "'s DETAILS");
        }


        private void OnAdd()
        {
            
            employees.Add(new Employee { Name = newName, Surname = newSurname, Gender=newGender, DateOfBirth=newDateOfBirth, HomeAddress=newHomeAddress});
        }

        private void OnEdit()
        {
            employees.Add(new Employee
            {

                Name = selectedEmployee.Name,
                Surname = selectedEmployee.Surname,
                Gender = selectedEmployee.Gender,
                DateOfBirth = selectedEmployee.DateOfBirth,
                HomeAddress = selectedEmployee.HomeAddress



            });
        }

        

        public string newName { get; set; }
        public string newSurname { get; set; }
        public string newGender { get; set; }
        public string newDateOfBirth { get; set; }
        public string newHomeAddress { get; set; }

    }
}
