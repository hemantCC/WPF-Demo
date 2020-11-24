using Assignment_2.DependencyProperties;
using Assignment_2.Helpers;
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

namespace Assignment_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the ButtonLoadWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void ButtonLoadWindow_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxWindowId.Text) && string.IsNullOrWhiteSpace(textBoxWindowId.Text))
            {
                MessageBox.Show("Textbox can't be empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                handleWindowLoad();
            }
        }

        /// <summary>
        /// Handles the window load.
        /// </summary>
        private void handleWindowLoad()
        {
            bool status = false;
            foreach (var window in DynamicWindowHelper.DynamicWindowInstances)
            {
                status = CheckWindowId(window);
                if (status == true)
                {
                    break;
                }
            }
            textBoxWindowId.Clear();
            if (status == false)
            {
                frameRenderWindow.Content = null;
                MessageBox.Show("Enter a valid key", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Checks the window identifier.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <returns></returns>
        private bool CheckWindowId(KeyValuePair<Type, DynamicWindow> window)
        {
            bool status = false;
            DynamicWindow dynamicWindow = null;
            dynamicWindow = (DynamicWindow)window.Value;
            if (dynamicWindow.WindowId == textBoxWindowId.Text)
            {
                frameRenderWindow.Content = dynamicWindow.Content;
                status = true;
            }
            return status;
        }
    }
}
