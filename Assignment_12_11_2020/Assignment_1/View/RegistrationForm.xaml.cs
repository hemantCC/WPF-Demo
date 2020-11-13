using Assignment_1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Assignment_1.View
{
    /// <summary>
    /// Interaction logic for RegistrationForm.xaml
    /// </summary>
    public partial class RegistrationForm : Window
    {
        private readonly Employee _selectedEmployee;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public RegistrationForm(Employee _selectedEmployee)
        {
            InitializeComponent();
            this._selectedEmployee = new Employee();
            this._selectedEmployee = _selectedEmployee;
            InitiazeForm();
        }

        private void InitiazeForm()
        {
            if (_selectedEmployee != null)
            {
                textBoxId.Text = _selectedEmployee.Id.ToString();
                textBoxContact.Text = _selectedEmployee.Contact;
                textBoxEmail.Text = _selectedEmployee.Email;
                textBoxName.Text = _selectedEmployee.Name;
            }
        }

        private void Clear_Button_Clicked(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBoxContact.Text = textBoxEmail.Text = textBoxName.Text = "";
        }

        private void Cancel_Button_Clicked(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Hide();
            main.Show();
        }
    }
}
