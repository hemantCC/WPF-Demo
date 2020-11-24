using Assignment_1.Constants;
using Assignment_1.DependencyProperties;
using Assignment_1.Enums;
using Assignment_1.Factories;
using Assignment_1.FactoryProducts;
using Assignment_1.Helpers;
using Assignment_1.Implementations;
using Assignment_1.Interfaces;
using Assignment_1.Windows;
using System;
using System.Collections.Generic;
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

namespace Assignment_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IWindowInstance<Window>
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateControls();
        }

        #region Private Methods

        /// <summary>
        /// Populates the controls.
        /// </summary>
        private void PopulateControls()
        {
            ComboBoxTheme.ItemsSource = Enum.GetValues(typeof(ThemeMode)).Cast<ThemeMode>();
        }
        #endregion


        #region Unimplemented Methods

        /// <summary>
        /// Returns the instance.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IWindowInstance<Window> ReturnInstance(Type type)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Events

        /// <summary>
        /// Handles the SelectionChanged event of the Theme control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void Theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ThemeMode theme = (ThemeMode)ComboBoxTheme.SelectedItem;
            new ThemeHelper().ChangeApplicationTheme(theme);
        }


        /// <summary>
        /// Handles the Clicked event of the LoadDynamicWindowButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void LoadDynamicWindowButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (Flags.IsSingletonEnabled)
            {
                new DynamicWindowHelper().LoadWindow(typeof(MyDynamicWindow));
            }
            else
            {
                IWindowFactory dynamicWindowFactory = new DynamicWindowFactory();
                dynamicWindowFactory.GetWindowFactory().ShowWindow(typeof(MyDynamicWindow));
            }
        }

        /// <summary>
        /// Handles the Changed event of the RadioButtonSingleton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void RadioButtonSingleton_Changed(object sender, RoutedEventArgs e)
        {
            if ((bool)RadioButtonSingleton.IsChecked)
                Flags.IsSingletonEnabled = true;
            else
                Flags.IsSingletonEnabled = false;
        }

        #endregion
    }
}
