using Assignment_1.Constants;
using Assignment_1.Factories;
using Assignment_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Helpers
{
    /// <summary>
    /// Helper Class for Normal and Dynamic Instances 
    /// for Singleton Pattern and Factory Pattern 
    /// </summary>
    static class WindowInstanceHelper
    {

        #region Public Static Methods

        /// <summary>
        /// Creates Instance of Normal Window
        /// </summary>
        /// <param name="type">MainWindow</param>
        public static void CreateNormalWindowIntanceBasedOnPattern(Type type)
        {
            if (Flags.IsSingletonEnabled)
            {
                new NormalWindowHelper().LoadWindow(type);
            }
            else 
            {
                IWindowFactory windowFactory = new NormalWindowFactory();
                windowFactory.GetWindowFactory().CreateWindowInstance(type);
            }
        }

        /// <summary>
        /// Creates Instance of DynamicWindows on a single go
        /// </summary>
        /// <param name="type">DynamicWindow</param>
        public static void CreateDynamicWindowIntanceBasedOnPattern(Type type)
        {
            if (Flags.IsSingletonEnabled)
            {
                new DynamicWindowHelper().LoadWindows();
            }
            else 
            {
                IWindowFactory dynamicWindowFactory = new DynamicWindowFactory();
                dynamicWindowFactory.GetWindowFactory().CreateWindowInstance(type);
            }
        }

        #endregion
    }
}
