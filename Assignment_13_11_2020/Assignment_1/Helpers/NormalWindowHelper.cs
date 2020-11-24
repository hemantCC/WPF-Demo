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
    public class NormalWindowHelper : IWindowInstance<Window>
    {
        #region Public Static Members

        /// <summary>
        /// Stores instances of all Windows having type of DynamicWindow
        /// </summary>
        public static Dictionary<Type, IWindowInstance<Window>> WindowInstances { get; private set; }

        #endregion

        static NormalWindowHelper()
        {
            WindowInstances = new Dictionary<Type, IWindowInstance<Window>>();
        }


        /// <summary>
        /// Stores Dynamic Windows and their Instances as Key,Value Pairs
        /// </summary>
        public void LoadWindow(Type type)
        {
            if (type.BaseType == typeof(Window))
            {
                if (WindowInstances.ContainsKey(type))
                {
                    (WindowInstances[type] as Window).Activate();
                }
                else
                {
                    WindowInstances[type] = ReturnInstance(type);
                    (WindowInstances[type] as Window).Show();
                }
            }
        }

        public IWindowInstance<Window> ReturnInstance(Type type)
        {
            return Activator.CreateInstance(type) as IWindowInstance<Window>;
        }

    }
}
