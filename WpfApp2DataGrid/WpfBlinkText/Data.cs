using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBlinkText
{
    public class Data : BindableBase
    {
        private int _state;
        public int State
        {
            get
            {
                return _state;
            }
            set
            {
                SetProperty(ref _state, value);
            }
        }

    }
}
