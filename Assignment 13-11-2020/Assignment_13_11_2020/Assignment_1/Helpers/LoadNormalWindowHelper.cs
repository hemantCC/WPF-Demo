using Assignment_1.Interfaces;
using Assignment_1.DependencyProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;

namespace Assignment_1.Helpers
{
    public class LoadNormalWindowHelper : IWindowInstance<Window>
    {
        #region Private Static Members

        /// <summary>
        /// Stores information of current executing assembly
        /// </summary>
        private static Assembly _assembly;

        #endregion

        #region Public Static Members

        /// <summary>
        /// Stores instances of all Windows having type of DynamicWindow
        /// </summary>
        public static Dictionary<Type, Window> WindowInstances { get; private set; }

        #endregion

        #region Constructor

        static LoadNormalWindowHelper()
        {
            _assembly = Assembly.GetExecutingAssembly();
            WindowInstances = new Dictionary<Type, Window>();
        }

        #endregion

        #region Public Methods


        /// <summary>
        /// Stores Dynamic Windows and their Instances as Key,Value Pairs
        /// </summary>
        public void LoadWindow(Type type)
        {
            if (type.BaseType == typeof(Window))
            {
                if (WindowInstances.ContainsKey(type))
                {
                    WindowInstances[type].Activate();
                }
                else
                {
                    WindowInstances[type] = ReturnInstance(type) as Window;
                    WindowInstances[type].Show();
                }
            }
        }

        public IWindowInstance<Window> ReturnInstance(Type type)
        {
            return Activator.CreateInstance(type) as IWindowInstance<Window>;
        }

        #endregion
    }
}
