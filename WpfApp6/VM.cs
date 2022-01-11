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
        public Store store { get; set; }

        public string label => store.Txt;
        public ICommand command { get; set; }
        public VM()
        {
            store = new Store() { Txt="Ramesh"};
            store.TxtChanged += OnTextChanged;
            command = new Command(store);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void OnTextChanged()
        {
            OnPropertyChanged(nameof(label));
        }

    }
}
