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
    /// Interaction logic for SUM.xaml
    /// </summary>
    public partial class SUM : Window
    {
        public sum sumObj { get; set; }
        public SUM()
        {
            InitializeComponent();
            sumObj = new sum { Num1 = "1", Num2 = "2" };
            this.DataContext = sumObj;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
    }
}
