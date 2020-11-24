using EMS.Entities.DataEntities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EMS.Entities.BusinessEntities;

namespace EMS.Client
{
    /// <summary>
    /// Interaction logic for EmployeeForm.xaml
    /// </summary>
    public partial class EmployeeForm : Window
    {
        MainWindow main = new MainWindow();
        EmployeeViewModel employeeEdit;
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(EmployeeViewModel employee)
        {
            InitializeComponent();
            this.employeeEdit = new EmployeeViewModel();
            this.employeeEdit = employee;
            PopulateData();
            if (this.employeeEdit != null)
            {
                MasterLabel.Content = "Edit Employee";
                sbtButton.Content = "UPDATE";
            }
        }

        /// <summary>
        /// Populates the data.
        /// </summary>
        private void PopulateData()
        {
            textBoxName.Text = employeeEdit.Name;
            textBoxContact.Text = employeeEdit.Contact;
            textBoxAddress.Text = employeeEdit.Address;
            textBoxEmail.Text = employeeEdit.Email;
            datePickerDOB.Text = employeeEdit.Dob.ToString();
        }


        /// <summary>
        /// Handles the Click event of the Ad or Edit Functionality control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                EmployeeViewModel employee = new EmployeeViewModel()
                {
                    Id = employeeEdit == null ? 0 : employeeEdit.Id,
                    Name = textBoxName.Text.Trim(),
                    Contact = textBoxContact.Text.Trim(),
                    Address = textBoxAddress.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    Dob = datePickerDOB.SelectedDate
                };

                //Add Employee
                if (employee.Id == 0)
                {

                    var response = GlobalVariable.WebApiClient.PostAsJsonAsync("PostEmployee", employee).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Employee Added");
                        this.Hide();
                        main = new MainWindow();
                        main.Show();
                    }
                    else
                        MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                }

                //Update Employee
                else
                {
                    var response = GlobalVariable.WebApiClient.PutAsJsonAsync("UpdateEmployee", employee).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Employee Updated");
                        this.Hide();
                        main = new MainWindow();
                        main.Show();
                    }
                    else
                        MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Invalid Form Detail(s)!");
            }

        }
        
        /// <summary>
        /// Validates the form.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            if (textBoxName.Text == "" || textBoxContact.Text == "" || textBoxAddress.Text == "" || textBoxEmail.Text == "" || datePickerDOB.Text == "")
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Clears the form.
        /// </summary>
        private void Clear()
        {
            textBoxName.Text = textBoxContact.Text = textBoxAddress.Text = textBoxEmail.Text = "";
            datePickerDOB.SelectedDate = null;
        }

        /// <summary>
        /// Handles the event of the Cancel Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }


        /// <summary>
        /// Handles the event of the Clear Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Clear();
        }
    }
}
