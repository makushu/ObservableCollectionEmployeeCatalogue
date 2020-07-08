using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using TheCatalogueEmployee.ICommands;
using TheCatalogueEmployee.Model;
using static TheCatalogueEmployee.Model.EmployeeModel;

namespace TheCatalogueEmployee.ViewModel
{
    class EmployeeViewModel : INotifyPropertyChanged
    {
        public ICommandsClass AddCommand { get; set; }
        public ICommandsClass EditCommand { get; set; }
        public ICommandsClass ViewCommand { get; set; }
        public ICommandsClass SaveEditCommand { get; set; }
        public EmployeeViewModel()
        {
            AddCommand = new ICommandsClass(OnAdd);
            EditCommand = new ICommandsClass(OnEdit);
            ViewCommand = new ICommandsClass(OnView);
            SaveEditCommand = new ICommandsClass(OnSaveEdit);
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
                Id = "1",
                Name = "Monday",
                Surname = "Morning",
                DateOfBirth = "1/1/1980",
                Gender = "Female",
                HomeAddress = "123 Streeting Street"
            });
            employees.Add(new Employee
            {
                Id ="2",
                Name = "Tuesday",
                Surname = "Afternoon",
                DateOfBirth = "2/2/1955",
                Gender = "Male",
                HomeAddress = "456 Roading Road"
            });
            employees.Add(new Employee
            {
                Id = "3",
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

            Name = selectedEmployee.Name;
            Surname = selectedEmployee.Surname;
            Gender = selectedEmployee.Gender;
            DateOfBirth = selectedEmployee.DateOfBirth;
            HomeAddress = selectedEmployee.HomeAddress;
        }


        private void OnAdd()
        {
            employees.Add(new Employee { Name = newName, Surname = newSurname, Gender=newGender, DateOfBirth=newDateOfBirth, HomeAddress=newHomeAddress});


        }

        private void OnSaveEdit()
        {
            var item = employees.FirstOrDefault(a => a.Name == selectedEmployee.Name);
            if (item != null)
            {
                item.Name = Name;
                item.Surname = Surname;
                item.DateOfBirth = DateOfBirth.ToString();
                item.Gender = Gender;
                item.HomeAddress = HomeAddress;
               
            }

            

        }
        private void OnEdit()
        {
                            
              Name = selectedEmployee.Name;
              Surname = selectedEmployee.Surname;
              Gender = selectedEmployee.Gender;
              DateOfBirth = selectedEmployee.DateOfBirth;
              HomeAddress = selectedEmployee.HomeAddress;

        }

        private string newName;
        private string newSurname;
        private string newGender;
        private string newDateOfBirth;
        private string newHomeAddress;
        private string newId;

      
        public string Id
        {
            get { return newId; }
            set
            {
                newId = value;
                RaisePropertyChanged("Id");
            }
        }

        public string Name
        {
            get { return newName; }
            set
            {
                newName = value;
                RaisePropertyChanged("Name");
            }
        }

        public string Surname
        {
            get { return newSurname; }
            set
            {
                newSurname = value;
                RaisePropertyChanged("Surname");
            }
        }

        public string DateOfBirth
        {
            get { return newDateOfBirth; }
            set
            {
                newDateOfBirth = value;
                RaisePropertyChanged("DateOfBirth");
            }
        }

        public string Gender
        {
            get { return newGender; }
            set
            {
                newGender = value;
                RaisePropertyChanged("Gender");
            }
        }

        public string HomeAddress
        {
            get { return newHomeAddress; }
            set
            {
                newHomeAddress = value;
                RaisePropertyChanged("HomeAddress");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
