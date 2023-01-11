using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment.Commands
{
    public class RegisterButton : ICommand
    {
        Action<object> _execute;
        Func<object,bool> _canExecute;

        public RegisterButton(Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        

        public bool CanExecute(object parameter)
        {
            
            if(_canExecute==null)
            {
                return true;
                
            }
            else
            {
                return _canExecute(parameter);
            }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
            }
    }
}
