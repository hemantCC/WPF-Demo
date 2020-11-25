using Assignment_2.CustomCommands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Assignment_2
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        #region Private Members

        private int _Id;
        private string _Name;
        private string _Email;
        private string _Contact;
        private string _Address;

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Constructor

        /// <summary>
        ///  Create new Instance of Class EmployeeViewmodel
        /// </summary>
        public EmployeeViewModel()
        {
            ValidateInputCommand = new ValidateInputCommand(_executeMethod, _canExecuteMethod);
        }

        #endregion

        #region Private Methods

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)    
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private bool _canExecuteMethod(object parameter)
        {
            if (ValidateMembers())
               return true;
            else
                return false;
        }


        /// <summary>
        /// Does all validaitions 
        /// </summary>
        /// <returns></returns>
        private bool ValidateMembers()
        {
            bool IsValid = false;
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrWhiteSpace(Name))
            {
                if (!string.IsNullOrEmpty(Email) && !string.IsNullOrWhiteSpace(Email) && ValidateEmail())
                {
                    if (!string.IsNullOrEmpty(Contact) && !string.IsNullOrWhiteSpace(Contact) && Contact.Length == 10)
                    {
                        if (!string.IsNullOrEmpty(Address) && !string.IsNullOrWhiteSpace(Address))
                        {
                            IsValid = true;
                        }
                    }
                }
            }
            return IsValid;

        }

        /// <summary>
        /// Validates Email
        /// </summary>
        /// <returns></returns>
        private bool ValidateEmail()
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);
            if (match.Success)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Custom Execution 
        /// </summary>
        /// <param name="paramater"></param>
        private void _executeMethod(object paramater)
        {
            var saveThisToFile = "Employee Name = "+ Name + "    Email = "+Email+"    Contact = "+Contact+"     Address = "+Address; 

            using (StreamWriter sw = new StreamWriter("D:\\Employees.txt",true) )
            {
                sw.WriteLine(saveThisToFile);
            }
            Name = Email = Contact = Address = "";
            MessageBox.Show("Registered Successfully!");
        }

        #endregion

        #region Public Members

        public int Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Contact
        {
            get { return _Contact; }
            set
            {
                _Contact = value;
                OnPropertyChanged("Contact");
            }
        }
        public string Address
        {
            get { return _Address; }
            set
            {
                _Address = value;
                OnPropertyChanged("Address");
            }
        }
        public ICommand ValidateInputCommand 
        { 
            get; 
            set; 
        }

        #endregion
    }
}
