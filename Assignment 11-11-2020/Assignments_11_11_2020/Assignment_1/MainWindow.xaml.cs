using Assignment_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            listBoxCars.ItemsSource = GetCarData();
            listBoxEmployees.ItemsSource = GetEmployeeData();
        }

        #region Private Methods

        /// <summary>
        /// Gets the car data.
        /// </summary>
        /// <returns></returns>
        private List<Car> GetCarData()
        {
            List<Car> cars = new List<Car>()
            {
                new Car{ Id =1, Brand ="BMW",Model ="M5 Coupe",Fuel = 60,SpecialFeature="Initial Tourque" },
                new Car{ Id =2, Brand ="Audi",Model ="Q7",Fuel = 90,SpecialFeature="Safety" },
                new Car{ Id =3, Brand ="Maserati",Model ="Grand Turismo",Fuel = 20 ,SpecialFeature="Top Speed"},
                new Car{ Id =4, Brand ="Lamborghini",Model ="Huracan",Fuel = 75 ,SpecialFeature="Performance"}
            };
            return cars;
        }

        /// <summary>
        /// Gets the employee data.
        /// </summary>
        /// <returns></returns>
        private List<Employee> GetEmployeeData()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ Id =1,EmployeeName ="Hemant Mohapatra", Designation="Software Engineer", Experience="1 year" },
                new Employee{ Id =2,EmployeeName ="Kaushik Iyer", Designation="Sr. Software Engineer", Experience="3 year" },
                new Employee{ Id =3,EmployeeName ="Satyam Dudhagra", Designation="Project Manager", Experience="12 year" },
                new Employee{ Id =4,EmployeeName ="Dilip maillapali", Designation="Tech Lead", Experience="10 year" },
            };
            return employees;
        }
        
        #endregion
    }
}
