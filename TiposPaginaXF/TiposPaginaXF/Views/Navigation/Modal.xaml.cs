using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPaginaXF.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modal : ContentPage
    {
        public Modal()
        {
            InitializeComponent();
        }

        private void FecharModal(Object sender, EventArgs args)
        {
            // PAra voltar para tela anterior de uma pagina de modal.
            Navigation.PopModalAsync();
        }
    }
}