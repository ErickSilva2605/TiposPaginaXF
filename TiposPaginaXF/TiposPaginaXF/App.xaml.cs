using System;
using TiposPaginaXF.Views.Carousel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPaginaXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Introducao();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
