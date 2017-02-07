using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Introduccion_MVVM.Comandos;
using Introduccion_MVVM.ViewModel.Base;
using Introduccion_MVVM.Vistas;

namespace Introduccion_MVVM.ViewModel
{
    public class ConfirmacionesBorjaViewModel:ViewModelBase
    {
        private int _conteo;
        private DelegateCommand _onfire;

        public ConfirmacionesBorjaViewModel()
        {
            _conteo = 0;
        }

        public String Sumando
        {
            get { return string.Format("Ya lo ha dicho {0} veces!!!", _conteo); }
        }

        private void conteoCommandExecute()
        {
            _conteo++;
            RaisePropertyChanged("Sumando");
        }

        public ICommand Onfire
        {
            get { return _onfire = _onfire ?? new DelegateCommand(conteoCommandExecute); }
        }


    }
}
