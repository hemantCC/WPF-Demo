using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Interfaces
{
    public interface IWindow
    {
        void CreateWindowInstance(Type type);
        void ShowWindow(Type type);
    }
}
