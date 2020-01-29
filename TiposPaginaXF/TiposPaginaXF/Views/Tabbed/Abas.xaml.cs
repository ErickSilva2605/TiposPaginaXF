
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TiposPaginaXF.Views.Navigation;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace TiposPaginaXF.Views.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            Children.Add(new NavigationPage(new Page1()) { Title = "Item 3"});
        }
    }
}