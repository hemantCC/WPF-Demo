using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Assignment_1.CustomCommands
{
    public class ValidateInputCommand : ICommand
    {

        /// <summary>
        /// Delegate For Execute Method of Custom Commands
        /// </summary>
        Action<object> _executeMethod;

        /// <summary>
        /// Delegate For CanExecute Method of Custom Commands
        /// </summary>
        Func<object, bool> _canExecuteMethod;

        public ValidateInputCommand(Action<object> _executeMethod, Func<object, bool> _canExecuteMethod)
        {
            this._executeMethod = _executeMethod;
            this._canExecuteMethod = _canExecuteMethod;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecuteMethod != null)
            {
                return _canExecuteMethod(parameter);
            }
            return false;
        }

        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }
    }
}
