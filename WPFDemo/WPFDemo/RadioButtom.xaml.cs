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
    /// Interaction logic for RadioButtom.xaml
    /// </summary>
    public partial class RadioButtom : Window
    {
        public RadioButtom()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Hide();
            main.Show();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thats Great!");
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please learn! Its very helpful.");
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please learn! Its very helpful.");
        }
    }
}
