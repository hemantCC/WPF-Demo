using Assignment_1.Models;
using Assignment_1.View;
using System;
using System.Collections.Generic;
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

namespace Assignment_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the Edit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeDG.SelectedIndex != -1)
            {
                Employee SelectedEmployee = (Employee)EmployeeDG.SelectedItems[0];
                RegistrationForm form = new RegistrationForm(SelectedEmployee);
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("please select a record!");
        }
    }
}
