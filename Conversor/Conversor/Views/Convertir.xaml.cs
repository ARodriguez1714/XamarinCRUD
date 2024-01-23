using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm, m;
        public Convertir()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            cm = Convert.ToDouble(txtcm.Text);
            m = cm / 100;
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}