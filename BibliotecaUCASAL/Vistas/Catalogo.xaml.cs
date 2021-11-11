using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BibliotecaUCASAL.Clases;

namespace BibliotecaUCASAL.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Catalogo : ContentPage
    {
        public IList<Libro> Libros { get; private set; }    //region
        public Catalogo()
        {
            InitializeComponent();
            #region MyRegion
            Libros = new List<Libro>();
            Libros.Add(new Libro
            {
                nombre = "Alderson",
                afiliacion = "Buenos",
                url = "https://pbs.twimg.com/profile_images/1072928657402806272/0KMzkg16_400x400.jpg"
            });
            Libros.Add(new Libro
            {
                nombre = "Tyrell Wellick",
                afiliacion = "Buenos",
                url = "https://static.wikia.nocookie.net/villains/images/9/9d/Tyrell_Wellick_S4.jpg/revision/latest?cb=20191029131501"
            });
            Libros.Add(new Libro
            {
                nombre = "Angela Moss",
                afiliacion = "Buenos",
                url = "https://static.wikia.nocookie.net/mrrobot/images/4/4a/Tumblr_8a25712b9121eb8069ff575b842b9fc9_990d4100_1280.jpg/revision/latest?cb=20190928214750"
            });

            BindingContext = this;


            #endregion         //region p/ cargar grilla
        }

        private void LVCatalogo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Libro selectedItem = e.SelectedItem as Libro;
        }

        private void LVCatalogo_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Libro tappedItem = e.Item as Libro;
        }
    }
}