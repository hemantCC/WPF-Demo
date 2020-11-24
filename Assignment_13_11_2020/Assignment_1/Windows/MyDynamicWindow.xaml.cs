using Assignment_1.Constants;
using Assignment_1.DependencyProperties;
using Assignment_1.Helpers;
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

namespace Assignment_1.Windows
{
    /// <summary>
    /// Interaction logic for MyDynamicWindow.xaml
    /// </summary>
    public partial class MyDynamicWindow : DynamicWindow
    {
        public MyDynamicWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// To-dos on Window Closed Event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            DynamicWindowHelper.HandleWindowClosed(typeof(MyDynamicWindow));
        }
    }
}
