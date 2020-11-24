using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Assignment_2.DependencyProperties
{
    public class DynamicWindow : Window
    {
        #region Dependency Properties

        /// <summary>
        /// The window identifier property
        /// </summary>
        public static readonly DependencyProperty WindowIdProperty =
            DependencyProperty.Register("WindowId", typeof(string), typeof(DynamicWindow), new PropertyMetadata(null));

        #endregion

        /// <summary>
        /// Gets or sets the window identifier.
        /// </summary>
        /// <value>
        /// The window identifier.
        /// </value>
        public string WindowId
        {
            get { return (string)GetValue(WindowIdProperty); }
            set { SetValue(WindowIdProperty, value); }
        }

    }
}
