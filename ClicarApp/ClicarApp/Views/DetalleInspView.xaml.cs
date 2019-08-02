using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClicarApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleInspView : ContentPage
    {
        public DetalleInspView()
        {
            InitializeComponent();
            //NavigationPage.SetTitleIconImageSource(this, "clicar_bajada_toolbar.png");
        }

        private async void RechazarCommand(object sender, EventArgs e)
        {
            // Navigation.PopAsync();
            var popup = PopupNavigation.Instance;
            await popup.PushAsync(new DetallePopupView());
            //await PopupNavigation.PushAsync(new DetallePopupView());
        }

        private async void InspeccionarCommand(object sender, EventArgs e)
        {
            var popup = PopupNavigation.Instance;
            await popup.PushAsync(new DetallePopupView());
        }
    }
}