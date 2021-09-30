using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Examen.Respositories.Rspositoryrealm;

namespace Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        RepositoryRealm repo;

        public Inicio()
        {
            InitializeComponent();
            this.repo = new RepositoryRealm();
            this.botondetalles.Clicked += Botondetalles_Clicked;
            this.botoneliminar.Clicked += Botoneliminar_Clicked;
            this.botoninsertar.Clicked += Botoninsertar_Clicked;
            this.botonmodificar.Clicked += Botonmodificar_Clicked;
            this.botonmostrarregistros.Clicked += Botonmostrarregistros_Clicked;
        }

        private async void Botoninsertar_Clicked(object sender, EventArgs e)
        {
            I insertview = new InsertarPersonaje();
            await Navigation.PushModalAsync(insertview);
        }
    }
}