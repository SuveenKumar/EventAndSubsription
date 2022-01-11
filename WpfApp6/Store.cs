using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Store
    {
        public string txt;
        public string Txt
        {
            get
            {
                return txt;
            }
            set
            {
                txt = value;
                OnTxtChanged();
            }
        }
        public event Action TxtChanged;
        private void OnTxtChanged()
        {
            TxtChanged?.Invoke();
        }
    }
}
