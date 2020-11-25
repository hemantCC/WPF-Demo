using Assignment_1.Helpers;
using Assignment_1.DependencyProperties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment_1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// To-dos on Application Start up
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            //Initializes Main Window Instance
            WindowInstanceHelper.CreateNormalWindowIntanceBasedOnPattern(typeof(MainWindow));

            //Initializes All Dynamic Window Instances
            WindowInstanceHelper.CreateDynamicWindowIntanceBasedOnPattern(typeof(DynamicWindow));
        }
    }
}
