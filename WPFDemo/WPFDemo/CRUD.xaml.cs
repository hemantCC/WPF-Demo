using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFDemo.Models;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for CRUD.xaml
    /// </summary>
    public partial class CRUD : Window
    {
        MainWindow main = new MainWindow();
        public CRUD()
        {
            InitializeComponent();
            LoadData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void LoadData()
        {
            using (DbCarContext _context = new DbCarContext())
            {
                var cars = _context.TblCar.ToList();
                CarDG.ItemsSource = cars;
            }
        }

        private void ResetForm()
        {
            Brand.Text = Model.Text = Price.Text = "";
        }
        private bool ValidateForm()
        {
            if (Brand.Text == "" || Model.Text == "" || Price.Text == "")
            {
                MessageBox.Show("Form Not Valid!");
                return false;
            }
            return true;
        }



        //Add
        private void OnAdd(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                using (DbCarContext _context = new DbCarContext())
                {
                    var car = _context.TblCar.Find((CarDG.SelectedItem as TblCar).Id);
                    bool carExists = (car != null) ? true : false;
                    if (!carExists)
                    {
                        TblCar tblCar = new TblCar()
                        {
                            Brand = Brand.Text,
                            Model = Model.Text,
                            Price = int.Parse(Price.Text)
                        };
                        _context.TblCar.Add(tblCar);
                    }
                    else
                    {
                        TblCar EditCar = _context.TblCar.Find((CarDG.SelectedItem as TblCar).Id);
                        EditCar.Brand = Brand.Text;
                        EditCar.Model = Model.Text;
                        EditCar.Price = int.Parse(Price.Text);
                        _context.TblCar.Update(EditCar);
                    }
                    _context.SaveChanges();
                }
                ResetForm();
                LoadData();
            }
        }

        //Delete button clicked
        private void OnDelete(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                int id = (CarDG.SelectedItem as TblCar).Id;
                using (DbCarContext _context = new DbCarContext())
                {
                    TblCar car = new TblCar() { Id = id };
                    _context.TblCar.Attach(car);
                    _context.TblCar.Remove(car);
                    _context.SaveChanges();
                }
                LoadData();
            }
        }

        //Edit button clicked
        private void OnEdit(object sender, RoutedEventArgs e)
        {
            int id = (CarDG.SelectedItem as TblCar).Id;
            using (DbCarContext _context = new DbCarContext())
            {
                TblCar car = _context.TblCar.Find(id);
                Brand.Text = car.Brand;
                Model.Text = car.Model;
                Price.Text = car.Price.ToString();
            }
        }
    }
}
