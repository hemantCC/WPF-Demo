using Assignment_1.DependencyProperties;
using Assignment_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;

namespace Assignment_1.FactoryProducts
{
    /// <summary>
    /// Concrete Factory Product for Dynamic Window Factory
    /// </summary>
    /// <seealso cref="Assignment_1.Interfaces.IWindow" />
    /// <seealso cref="Assignment_1.Interfaces.IWindowInstance{Assignment_1.DependencyProperties.DynamicWindow}" />
    public class DynamicWindowFactoryProduct : IWindow, IWindowInstance<DynamicWindow>
    {
        #region private Variables

        /// <summary>
        /// Stores information of current executing assembly
        /// </summary>
        private Assembly _assembly;

        #endregion

        #region public Dictionaries

        /// <summary>
        /// Stores Instances of All Windows Having Type of DynamicWindow
        /// </summary>        
        public static Dictionary<Type, IWindowInstance<DynamicWindow>> DynamicWindowInstances { get; set; }

        #endregion

        #region Constructor

        public DynamicWindowFactoryProduct()
        {
            _assembly = Assembly.GetExecutingAssembly();
            DynamicWindowInstances = new Dictionary<Type, IWindowInstance<DynamicWindow>>();
        }

        #endregion

        #region Public Methods


        /// <summary>
        /// Creates Instances of Dynamic Widows
        /// </summary>
        /// <param name="type">DynamicWindow</param>
        public void CreateWindowInstance(Type type)
        {
            IEnumerable<Type> dynamicWindows = _assembly.GetTypes().Where(x => x.BaseType == typeof(DynamicWindow));
            foreach (Type dw in dynamicWindows)
            {
                DynamicWindowInstances[dw] = ReturnInstance(dw);
            }
            
        }

        /// <summary>
        /// Shows the window.
        /// </summary>
        /// <param name="type">The type.</param>
        public void ShowWindow(Type type)
        {
            var window = ReturnInstance(type) as DynamicWindow;
            window.Show();
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
