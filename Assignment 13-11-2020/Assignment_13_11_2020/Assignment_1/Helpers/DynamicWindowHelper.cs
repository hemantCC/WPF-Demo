using Assignment_1.Interfaces;
using Assignment_1.DependencyProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace Assignment_1.Helpers
{
    public class DynamicWindowHelper : IWindowInstance<DynamicWindow>
    {
        #region Private Static Members

        /// <summary>
        /// Stores information of current executing assembly
        /// </summary>
        private static Assembly _assembly;

        #endregion

        #region public Static Member

        /// <summary>
        /// Stores instances of all Windows having type of DynamicWindow
        /// </summary>
        public static Dictionary<Type, IWindowInstance<DynamicWindow>> DynamicWindowInstances { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes the <see cref="DynamicWindowHelper"/> class.
        /// </summary>
        static DynamicWindowHelper()
        {
            _assembly = Assembly.GetExecutingAssembly();
            DynamicWindowInstances = new Dictionary<Type, IWindowInstance<DynamicWindow>>();
        }

        #endregion

        #region Public Methods


        /// <summary>
        /// Stores Dynamic windows and their instances as Key,Value pairs
        /// </summary>
        public void LoadWindows()
        {
            IEnumerable<Type> dynamicWindows = _assembly.GetTypes().Where(x => x.BaseType == typeof(DynamicWindow));
            foreach (Type dw in dynamicWindows)
            {
                DynamicWindowInstances[dw] = ReturnInstance(dw);
            }
        }

        /// <summary>
        /// Removes The Instance from the Dictionary OnClosed Event
        /// </summary>
        /// <param name="type"></param>
        public static void HandleWindowClosed(Type type)
        {
            if (DynamicWindowInstances.ContainsKey(type))
            {
                DynamicWindowInstances.Remove(type);
            }
        }

        /// <summary>
        /// Loads the window.
        /// </summary>
        /// <param name="type">The type.</param>
        public void LoadWindow(Type type)
        {
            if (type.BaseType == typeof(DynamicWindow))
            {
                if (DynamicWindowInstances.ContainsKey(type))
                {
                    (DynamicWindowInstances[type] as DynamicWindow).Activate();
                    (DynamicWindowInstances[type] as DynamicWindow).Show();
                }
                else
                {
                    DynamicWindowInstances[type] = ReturnInstance(type) as DynamicWindow;
                    (DynamicWindowInstances[type] as DynamicWindow).Show();
                }
            }
        }

        /// <summary>
        /// Returns the instance of Dynamic Window.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public IWindowInstance<DynamicWindow> ReturnInstance(Type type)
        {
            return Activator.CreateInstance(type) as IWindowInstance<DynamicWindow>;
        }

        #endregion
      
    }
}
