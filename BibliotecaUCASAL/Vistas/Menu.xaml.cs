using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaUCASAL.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void btnCatalogo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Catalogo());
        }

        private async void btnInst_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Institucional());
            
        }

        private async void btnPerfil_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MiPerfil());
        }

        private async void btnPrestamos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MisPrestamos());
        }

        private async void btnSalir_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}