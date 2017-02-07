using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Introduccion_MVVM.Vistas.CS
{
    public class EjemploTwoBinding:ContentPage
    {
        public EjemploTwoBinding()
        {
            var iptEscritura = new Entry()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var lblEscritura = new Label()
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            iptEscritura.TextChanged += (sender, args) =>
            {                
                lblEscritura.Text = iptEscritura.Text;
            };

            Content = new StackLayout()
            {
                Children = { iptEscritura, lblEscritura}
            };
        }
    }
}
