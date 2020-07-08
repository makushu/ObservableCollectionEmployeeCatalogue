using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCatalogueEmployee.Model
{
    class EmployeeModel
    {
  
            public class Employee : INotifyPropertyChanged
            {
                private string id;
                private string name;
                private string surname;
                private string dateOfBirth;
                private string gender;
                private string homeAddress;

                public string Id
                {
                    get { return id; }
                    set
                    {
                        id = value;
                        RaisePropertyChanged("Id");
                    }
                }
                public string Name
                {
                    get { return name; }
                    set
                    {
                        name = value;
                        RaisePropertyChanged("Name");
                    }
                }

                public string Surname
                {
                    get { return surname; }
                    set
                    {
                        surname = value;
                        RaisePropertyChanged("Surname");
                    }
                }

                public string DateOfBirth
                {
                    get { return dateOfBirth; }
                    set
                    {
                        dateOfBirth = value;
                        RaisePropertyChanged("DateOfBirth");
                    }
                }

                public string Gender
                {
                    get { return gender; }
                    set
                    {
                        gender = value;
                        RaisePropertyChanged("Gender");
                    }
                }

                public string HomeAddress
                {
                    get { return homeAddress; }
                    set
                    {
                        homeAddress = value;
                        RaisePropertyChanged("HomeAddress");
                    }
                }
                public event PropertyChangedEventHandler PropertyChanged;

                public void RaisePropertyChanged(string propertyName)
                {
                    if (PropertyChanged != null)
                    {
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                    }
                }
            }
        }

    }