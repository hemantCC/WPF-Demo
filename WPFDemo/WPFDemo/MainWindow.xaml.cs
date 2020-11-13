using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WPFDemo.Validation_Modules;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Grid grid = new Grid();
            //WrapPanel wrapPanel = new WrapPanel();
            //Button btn = new Button();
            //btn.Content = "Primary";
            //btn.Height = 30;
            //btn.Width = 80;
            //btn.Background = Brushes.Black;
            //btn.Foreground = Brushes.White;

            //grid.Children.Add(wrapPanel);
            //wrapPanel.Children.Add(btn);
            //this.Content = grid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SUM sum = new SUM();
            sum.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Listbox listbox = new Listbox();
            listbox.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ComboBox combp = new ComboBox();
            this.Hide();
            combp.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Checkbox check = new Checkbox();
            this.Hide();
            check.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            RadioButtom rb = new RadioButtom();
            this.Hide();
            rb.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Triggers trigger = new Triggers();
            this.Hide();
            trigger.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            CRUD crud = new CRUD();
            this.Hide();
            crud.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            this.Hide();
            binding.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            DependencyPropertyWindow dp = new DependencyPropertyWindow();
            this.Hide();
            dp.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ValidationHome vd = new ValidationHome();
            vd.Show();
            this.Hide();
        }
    }
}
