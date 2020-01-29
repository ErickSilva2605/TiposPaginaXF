using System;
using TiposPaginaXF.Views.Tabbed;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPaginaXF.Views.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carousel3 : ContentPage
    {
        public Carousel3()
        {
            InitializeComponent();
        }

        private void MudarPagina(Object sender, EventArgs args)
        {
            // Não Permite volta a pagina anterior, nao empilha a pagina.
            // App.Current.MainPage = new Navigation.Page1();

            //Para permitir que as paginas sejam empilhadas.
            //App.Current.MainPage = new NavigationPage(new Navigation.Page1()) { BackgroundColor = Color.LightBlue};

            App.Current.MainPage = new Abas();
        }
    }
}