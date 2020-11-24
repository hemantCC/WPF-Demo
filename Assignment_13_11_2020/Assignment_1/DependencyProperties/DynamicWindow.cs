using Assignment_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Assignment_1.DependencyProperties
{
    /// <summary>
    /// Custom extension for Window
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="Assignment_1.Interfaces.IWindowInstance{Assignment_1.DependencyProperties.DynamicWindow}" />
    public class DynamicWindow : Window, IWindowInstance<DynamicWindow>
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

        #region Unimplemented Methods

        public IWindowInstance<DynamicWindow> ReturnInstance(Type type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
