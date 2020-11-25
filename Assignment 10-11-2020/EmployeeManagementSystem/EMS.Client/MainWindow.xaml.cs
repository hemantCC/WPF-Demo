using EMS.Entities.DataEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using EMS.Entities.BusinessEntities;

namespace EMS.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("GetEmployees").Result;
            var employees = response.Content.ReadAsAsync<IList<EmployeeViewModel>>().Result;
            EmployeeDG.ItemsSource = employees;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            this.Hide();
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmployeeViewModel employee = (EmployeeViewModel)EmployeeDG.SelectedItems[0];
            EmployeeForm EditForm = new EmployeeForm(employee);
            EditForm.Show();
            this.Hide();

        }

        //Delete Record
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                EmployeeViewModel employee = (EmployeeViewModel)EmployeeDG.SelectedItems[0];

                HttpResponseMessage response = GlobalVariable.WebApiClient.DeleteAsync("DeleteEmployee?Id=" + employee.Id).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Employee deleted");
                    LoadData();
                }
                else
                    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string searchText = Search.Text;
            if (searchText != "")
            {
                HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("GetEmployeeByName?EmployeeName=" + searchText).Result;
                var employees = response.Content.ReadAsAsync<IEnumerable<EmployeeViewModel>>().Result;
                EmployeeDG.ItemsSource = employees;
            }
            else
            {
                LoadData();
            }
        }
    }
}
