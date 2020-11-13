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

namespace WPFDemo.Validation_Modules
{
    /// <summary>
    /// Interaction logic for ValidationHome.xaml
    /// </summary>
    public partial class ValidationHome : Window
    {
        public ValidationHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ValidationRules vr = new ValidationRules();
            vr.Show();
            this.Hide();
        }
    }
}
