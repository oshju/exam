using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Models;
using Examen.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Examen.Respositories.Rspositoryrealm;

namespace Examen
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        public List<Apuesta> listaapuestas { get; set; }
        RepositoryRealm repo;

        public MainPage()
        {
            InitializeComponent();
            this.repo = new RepositoryRealm();
            this.listaapuestas = new List<Apuesta>();
            this.botonrealizar.Clicked += Botoninsertar_Clicked;

        }
        private void Botonprimerapagina_Clicked(object sender, EventArgs e)
        {
            NavigationPage primera = new NavigationPage(new MyPage());
            primera.Title = "Primera Página";
            Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(primera));
        }


        private async void Botoninsertar_Clicked(object sender, EventArgs e)
        {
            MyPage insertview = new MyPage();
            await Navigation.PushModalAsync(insertview);
        }

    }
}