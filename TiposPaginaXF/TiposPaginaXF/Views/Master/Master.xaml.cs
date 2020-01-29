using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposPaginaXF.Views.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPaginaXF.Views.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void MudarPagina1(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Page1());
        }

        private void MudarPagina2(Object sender, EventArgs args)
        {
            Detail = new Page2();
        }

        private void MudarPagina3(Object sender, EventArgs args)
        {
            Detail = new Conteudo();
        }
    }
}