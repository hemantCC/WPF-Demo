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
        #region Variables

        private readonly Employee _selectedEmployee;

        #endregion

        #region Consutructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationForm"/> class.
        /// </summary>
        public RegistrationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationForm"/> class.
        /// </summary>
        /// <param name="_selectedEmployee">The selected employee.</param>
        public RegistrationForm(Employee _selectedEmployee)
        {
            InitializeComponent();
            this._selectedEmployee = new Employee();
            this._selectedEmployee = _selectedEmployee;
            InitiazeForm();
        }

        #endregion

        /// <summary>
        /// Initiazes the form.
        /// </summary>
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

        /// <summary>
        /// Handles the Clicked event of the Clear_Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Clear_Button_Clicked(object sender, RoutedEventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// Clears the form.
        /// </summary>
        private void ClearForm()
        {
            textBoxContact.Text = textBoxEmail.Text = textBoxName.Text = "";
        }

        /// <summary>
        /// Handles the Clicked event of the Cancel_Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Cancel_Button_Clicked(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Hide();
            main.Show();
        }
    }
}
