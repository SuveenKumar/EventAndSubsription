using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp6
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<object> executeMethod;
        Func<object, bool> canexecuteMethod;
        public bool CanExecute(object parameter) => true;
        public Command(Action<object> executeMethod,Func<object, bool> canexecuteMethod)
        {
            this.executeMethod = executeMethod;
            this.canexecuteMethod = canexecuteMethod;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }
    }
}
