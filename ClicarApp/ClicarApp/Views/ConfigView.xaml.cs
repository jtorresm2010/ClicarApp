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
    public partial class ConfigView : ContentPage
    {
        public ConfigView()
        {
            InitializeComponent();
        }
        private void ContinueCommand(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new AgendaView());

        }
    }
}