using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Introduccion_MVVM.ViewModel;
using Xamarin.Forms;

namespace Introduccion_MVVM.Vistas
{
    public partial class ConfirmacionesBorja : ContentPage
    {
        public ConfirmacionesBorja()
        {
            InitializeComponent();
            BindingContext = new ConfirmacionesBorjaViewModel();
        }
    }
}
