using System;
using TiposPaginaXF.Views.Master;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPaginaXF.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void MudarPagina(Object sender, EventArgs args)
        {
            // Permite voltar a pagina anterior se a anterior estiver dentro de uma NavigationPage.
            Navigation.PushAsync(new Page2());
        }

        private void ChamarModal(Object sender, EventArgs args)
        {
            // Modal é uma pagina que nao interrompe o fluxo do NavigationPAge
            Navigation.PushModalAsync(new Modal());
        }

        private void ChamarMaster(Object sender, EventArgs args)
        {
            // Paginas como MasterDetailPage, TabbedPage e CarouselPage devem ser chamados atravez de Currento.MainPage
            App.Current.MainPage = new Master.Master();
        }
    }
}