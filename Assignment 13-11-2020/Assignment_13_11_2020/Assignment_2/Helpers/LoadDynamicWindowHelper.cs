using Assignment_2.DependencyProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Assignment_2.Helpers
{
    public class LoadDynamicWindowHelper 
    {

        #region Public Dictionary

        /// <summary>
        /// Stores instances of all Windows having type of DynamicWindow as Interface Instance
        /// </summary>
        public static Dictionary<Type, DynamicWindow> DynamicWindowInstances { get; private set; }

        #endregion

        #region Private Variable

        /// <summary>
        /// Stores information of current executing assembly
        /// </summary>
        private static Assembly _assembly;

        #endregion

        #region Constructor

        static LoadDynamicWindowHelper()
        {
            _assembly = Assembly.GetExecutingAssembly();
            DynamicWindowInstances = new Dictionary<Type, DynamicWindow>();
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

        public DynamicWindow ReturnInstance(Type type)
        {
            return Activator.CreateInstance(type) as DynamicWindow;
        }
        
        #endregion
    }
}
