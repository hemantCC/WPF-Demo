using Assignment_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Assignment_1.FactoryProducts
{
    /// <summary>
    /// Concrete Factory Product For Normal Window
    /// </summary>
    /// <seealso cref="Assignment_1.Interfaces.IWindow" />
    /// <seealso cref="Assignment_1.Interfaces.IWindowInstance{System.Windows.Window}" />
    public class NormalWindowFactoryProduct : IWindow, IWindowInstance<Window>
    {
        #region Public Methods

        /// <summary>
        /// Creates Instance of Specified Window Type
        /// </summary>
        /// <param name="type">HomeWindow</param>
        public void CreateWindowInstance(Type type)
        {
            if (IsWindowType(type))
            {
                CreateInstance(type);
            }
            else
            {
                throw new Exception("Requested object must be of type Window only");
            }
        }

        /// <summary>
        /// Returns the instance.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public IWindowInstance<Window> ReturnInstance(Type type)
        {
            return Activator.CreateInstance(type) as IWindowInstance<Window>;
        }

        #endregion

        #region Unimplemented Methods

        public void ShowWindow(Type type)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods


        /// <summary>
        /// Checks Whether Requested Type Is Of Window Or Not
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool IsWindowType(Type type)
        {
            bool status = false;
            if (type.BaseType == typeof(Window))
            {
                status = true;
            }
            else
            {
                throw new Exception("Requested object not of type Window.");
            }
            return status;
        }

        /// <summary>
        /// Creates New Instance of Window Type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="model"></param>
        private void CreateInstance(Type type)
        {
            var window = ReturnInstance(type) as Window;
            window.Show();
        }

        #endregion
    }
}
