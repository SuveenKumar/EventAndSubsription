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

        public bool CanExecute(object parameter) => true;

        public Store store;

        public Command(Store curstore)
        {
            store = curstore;
        }

        public void Execute(object parameter)
        {
            if (store.Txt != "Ramesh")
            {
                store.Txt = "Ramesh";
            }
            else
            {
                store.Txt = "Suresh";
            }
        }

        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
