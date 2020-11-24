using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Assignment_1.Interfaces
{
    public interface IWindowInstance<T> where T : Window
    {
        IWindowInstance<T> ReturnInstance(Type type);
    }
}
