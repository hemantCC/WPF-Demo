using Assignment_1.CustomCommands;
using Assignment_1.Data;
using Assignment_1.Models;
using Assignment_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Input;

namespace Assignment_1.ViewModels
{
    public class EmployeeViewModel
    {
        #region Private Variables

        private List<Employee> _employees;
        private int _id;
        private string _name;
        private string _email;
        private string _contact;

        #endregion

        #region Constructor

        public EmployeeViewModel()
        {
            _employees = new List<Employee>();
            LoadData();
        }

        #endregion

        #region Public Properties

        public List<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }


        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }


        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }

        public string Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
            }
        }

        private ICommand _validateInputCommand;

        public ICommand ValidateInputCommand
        {
            get
            {
                if (_validateInputCommand == null)
                    _validateInputCommand = new ValidateInputCommand(_executeMethod, _canExecuteMethod);
                return _validateInputCommand;
            }
            set { _validateInputCommand = value; }
        }

        #endregion

        #region Private Methods


        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadData()
        {
            using (var _context =  new DbEmployeeContext())
            {
                var Employees = _context.TblEmployees.ToList();
                foreach (var employee in Employees)
                {
                    Employee Employee = new Employee()
                    {
                        Id = employee.Id,
                        Name = employee.Name,
                        Contact = employee.Contact,
                        Email = employee.Email
                    };
                    _employees.Add(Employee);
                }
            }
        }


        /// <summary>
        /// Determines whether this instance [can execute method] the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns>
        ///   <c>true</c> if this instance [can execute method] the specified parameter; otherwise, <c>false</c>.
        /// </returns>
        private bool _canExecuteMethod(object parameter)
        {
            if (ValidateMembers())
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
            using (var _context = new DbEmployeeContext())
            {
                TblEmployee employee = new TblEmployee()
                {
                    Id = Id,
                    Name = Name,
                    Contact = Contact,
                    Email = Email,
                    Dob = new DateTime(),
                    Address = "Ahmedabad"
                };
                _context.TblEmployees.Update(employee);
                _context.SaveChanges();
            }
           
            var window = Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive);
            window.Close();
            MainWindow main = new MainWindow();
            main.DataContext = new EmployeeViewModel();
            main.Show();
            MessageBox.Show("Updated Successfully.");
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
                if (!string.IsNullOrEmpty(Email) && !string.IsNullOrWhiteSpace(Email) && ValidateEmail(Email))
                {
                    if (!string.IsNullOrEmpty(Contact) && !string.IsNullOrWhiteSpace(Contact) && Contact.Length == 10)
                    {
                        IsValid = true;
                    }
                }
            }
            return IsValid;
        }


        /// <summary>
        /// Validates Email
        /// </summary>
        /// <returns></returns>
        private bool ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        #endregion

    }
}
