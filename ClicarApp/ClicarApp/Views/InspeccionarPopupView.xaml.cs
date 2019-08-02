using Rg.Plugins.Popup.Pages;
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
    public partial class InspeccionarPopupView : PopupPage
    {
        public InspeccionarPopupView()
        {
            InitializeComponent();
        }

        private async void CancelarCommand(object sender, EventArgs e)
        {
            var popup = PopupNavigation.Instance;
            await popup.PopAsync();


            //await PopupNavigation.PushAsync(new DetallePopupView());
        }

        private async void ContinuarCommand(object sender, EventArgs e)
        {
            var popup = PopupNavigation.Instance;
            //await popup.PushAsync(new RechazarView());
            await Navigation.PushAsync(new RechazarView());
            await popup.PopAsync();
        }


    }
}