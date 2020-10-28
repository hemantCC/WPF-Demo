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
    /// Interaction logic for Checkbox.xaml
    /// </summary>
    public partial class Checkbox : Window
    {
        public Checkbox()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Hide();
            main.Show();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(AllCheck.IsChecked == true)
            {
                Jalapeno.IsChecked = Olives.IsChecked = Cucumber.IsChecked = Pickel.IsChecked = true;
            }
            if (AllCheck.IsChecked == false)
            {
                Jalapeno.IsChecked = Olives.IsChecked = Cucumber.IsChecked = Pickel.IsChecked = false;
            }
        }

        private void Jalapeno_Checked(object sender, RoutedEventArgs e)
        {
            if (Jalapeno.IsChecked == true && Olives.IsChecked == true && Cucumber.IsChecked == true && Pickel.IsChecked == true)
            {
                AllCheck.IsChecked = true;
            }
            if (Jalapeno.IsChecked == false && Olives.IsChecked == false && Cucumber.IsChecked == false && Pickel.IsChecked == false)
            {
                AllCheck.IsChecked = false;
            }
            
        }
    }
}
