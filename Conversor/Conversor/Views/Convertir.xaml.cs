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
            lblResultado.Text = m.ToString() + " m";
        }

        private void Validar()
        {
            if (!string.IsNullOrEmpty(txtcm.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error","Ingrese una cantidad.", "ok");
                lblResultado.Text = "0.0 m";
            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}