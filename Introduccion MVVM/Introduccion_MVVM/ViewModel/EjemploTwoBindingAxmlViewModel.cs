using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Introduccion_MVVM.ViewModel.Base;

namespace Introduccion_MVVM.ViewModel
{
    public class EjemploTwoBindingAxmlViewModel:ViewModelBase
    {
        private String _escribirMensaje;

        public EjemploTwoBindingAxmlViewModel()
        {            
        }

        public String EscribirMensaje
        {
            get { return _escribirMensaje; }
            set
            {
                _escribirMensaje = value;
                RaisePropertyChanged();
            }
        }
    }
}
