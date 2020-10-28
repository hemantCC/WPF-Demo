using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ComboBox.xaml
    /// </summary>
    public partial class ComboBox : Window
    {
        //public combo comboObj { get; set; }
        public ComboBox()
        {
            InitializeComponent();
            MyCombobox.ItemsSource = typeof(Colors).GetProperties();
            //comboObj = new combo() { Selected = "DarkGray" };
            //this.DataContext = comboObj;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Hide();
            main.Show();
        }
    }

    //public class combo : INotifyPropertyChanged
    //{
    //    private string selected;
    //    public string Selected
    //    {
    //        get
    //        {
    //            return selected;
    //        }
    //        set
    //        {
    //            selected = value;
    //            OnPropertyChanged("Selected");
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    private void OnPropertyChanged(string property)
    //    {
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(property));
    //        }
    //    }
    //}
}
