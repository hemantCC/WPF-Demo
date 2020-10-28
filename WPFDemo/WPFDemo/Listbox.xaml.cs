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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for Listbox.xaml
    /// </summary>
    public partial class Listbox : Window
    {
        public Listbox()
        {
            InitializeComponent();
            List<Car> cars = new List<Car>()
            {
                new Car{ Id =1, Brand ="BMW",Model ="M5 Coupe",Fuel = 60,SpecialFeature="Initial Tourque" },
                new Car{ Id =2, Brand ="Audi",Model ="Q7",Fuel = 90,SpecialFeature="Safety" },
                new Car{ Id =3, Brand ="Maserati",Model ="Grand Turismo",Fuel = 20 ,SpecialFeature="Top Speed"},
                new Car{ Id =4, Brand ="Lamborghini",Model ="Huracan",Fuel = 75 ,SpecialFeature="Performance"}
            };
            Cars.ItemsSource = cars;
        }

        class Car
        {
            public int Id { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string SpecialFeature { get; set; }
            public int Fuel { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Hide();
            main.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(Cars.SelectedItem != null)
            {
                MessageBox.Show("The Special Feature of Selected Car: " + (Cars.SelectedItem as Car).SpecialFeature);
            }
            else
            {
                MessageBox.Show("Please Select a Car!");
            }
        }
    }
}
