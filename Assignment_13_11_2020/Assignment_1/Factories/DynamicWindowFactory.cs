using Assignment_1.FactoryProducts;
using Assignment_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Factories
{
    /// <summary>
    /// Concrete Creator for Dyanamic Window Factory Product
    /// </summary>
    /// <seealso cref="Assignment_1.Interfaces.IWindowFactory" />
    public class DynamicWindowFactory : IWindowFactory
    {
        /// <summary>
        /// Gets the window factory.
        /// </summary>
        /// <returns></returns>
        public IWindow GetWindowFactory()
        {
            return new DynamicWindowFactoryProduct();
        }
    }
}
