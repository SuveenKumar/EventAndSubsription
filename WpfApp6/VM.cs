using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp6
{
    public class VM:INotifyPropertyChanged
    {
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public ICommand command { get; set; }
        public VM()
        {
            Name = "Ramesh";
            command = new Command(executeMethod, canExecuteMethod) ;
        }

        public bool canExecuteMethod(object parameter)
        {
            return true;
        }

        
        public void executeMethod(object parameter)
        {
            if (Name != "Ramesh")
            {
                Name = "Ramesh";
            }
            else
            {
                Name = "Suresh";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

       

    }
}
