using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFDemo
{
    public class CustomButton : Button
    {
        public static readonly DependencyProperty dependencyProperty = 
            DependencyProperty.Register("SetBackground", 
                typeof(bool), 
                typeof(CustomButton), 
                new PropertyMetadata(false, new PropertyChangedCallback(ChangeBackGround)));

        public bool SetBackGroundRed
        {
            get => (bool)GetValue(dependencyProperty);
            set => SetValue(dependencyProperty, value);
        }

        private static void ChangeBackGround(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue) (d as CustomButton).Background = Brushes.Red;
        }
    }
}
