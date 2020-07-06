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

        public void ShowEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

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

            IEnumerable<Employee> employees = Employees.Where(a => a.Name == selectedEmployee.Name);

            foreach (var temp in employees)
            {
                MessageBox.Show("Name : " + temp.Name + "\n" + "Surname : " + temp.Surname + "\n" + "Date Of Birth : " +
                   temp.DateOfBirth + "\n" + "Gender : " + temp.Gender + "\n" + "Home Address : " + temp.HomeAddress, temp.Name.ToUpper() + "'s DETAILS");
            }
        }


        private void OnAdd()
        {
            Employees.Add(new Employee { Name = newName, Surname = newSurname, Gender=newGender, DateOfBirth=newDateOfBirth, HomeAddress=newHomeAddress});
        }

        private void OnEdit()
        {
          

        }

        

        public string newName { get; set; }
        public string newSurname { get; set; }
        public string newGender { get; set; }
        public string newDateOfBirth { get; set; }
        public string newHomeAddress { get; set; }

    }
}
