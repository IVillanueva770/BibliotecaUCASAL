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
    public partial class IniciarSesion : ContentPage
    {
        public IniciarSesion()
        {
            InitializeComponent();

        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            //{validar usuario, contraseña,}
            //await DisplayAlert("Inicio de sesión exitoso", "Mensaje enviado", "Aceptar");
            //await DisplayAlert("Error en el inicio de sesión", "Las credenciales de inicio de sesión son inválidas.", "Aceptar");
            App.Current.MainPage = new NavigationPage(new Menu());
        }
    }
}