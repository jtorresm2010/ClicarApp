using ClicarApp.Models;
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
    public partial class AgendaView : ContentPage
    {
        public AgendaView()
        {
            InitializeComponent();
            LoadUserList();
            //NavigationPage.SetTitleIconImageSource(this, "clicar_bajada_toolbar.png");
            //NavigationPage.SetTitleView();
        }


        void LoadUserList()/* Carga la lista de vehiculos en el ListView */
        {

            var listaVehiculos = new List<Vehiculo>();

            listaVehiculos.AddRange(new[] {
                new Vehiculo
                {
                    Modelo = "GSK342 SPARK", Marca = "MAZDA", Color = "NEGRO", HoraInicio = "17:00 pm", IDVehiculo = "W-20190703-1297", Finalizado = true, Pendiente = false
                },
                new Vehiculo
                {
                    Modelo = "GDST40 CX-5", Marca = "CHEVROLET", Color = "PLATEADO", HoraInicio = "13:00 pm", IDVehiculo = "W-20190703-1298", Finalizado = false, Pendiente = true
                },
                new Vehiculo
                {
                    Modelo = "JRGK85 TUCSON", Marca = "PEUGEOT", Color = "BLANCO", HoraInicio = "10:00 pm", IDVehiculo = "W-20190703-1297", Finalizado = true, Pendiente = false
                },
                new Vehiculo
                {
                    Modelo = "JRGK85 TUCSON", Marca = "PEUGEOT", Color = "AZUL", HoraInicio = "10:00 pm", IDVehiculo = "W-20190703-1297", Finalizado = true, Pendiente = false
                },
                new Vehiculo
                {
                    Modelo = "JRGK85 TUCSON", Marca = "PEUGEOT", Color = "VERDE PALTA", HoraInicio = "10:00 pm", IDVehiculo = "W-20190703-1297", Finalizado = true, Pendiente = false
                },
                new Vehiculo
                {
                    Modelo = "JRGK85 TUCSON", Marca = "PEUGEOT", Color = "AMARILLO", HoraInicio = "10:00 pm", IDVehiculo = "W-20190703-1297", Finalizado = true, Pendiente = false
                },
                new Vehiculo
                {
                    Modelo = "JRGK85 UNO", Marca = "KIA", Color = "AMARILLO", HoraInicio = "10:00 pm", IDVehiculo = "W-20190703-1297", Finalizado = true, Pendiente = false
                },
                new Vehiculo
                {
                    Modelo = "JRGK85 NOVA", Marca = "CHEVY", Color = "AMARILLO", HoraInicio = "10:00 pm", IDVehiculo = "W-20190703-1297", Finalizado = true, Pendiente = false
                },
                new Vehiculo
                {
                    Modelo = "JRGK85 LANCER", Marca = "MITSUBISHI", Color = "AMARILLO", HoraInicio = "10:00 pm", IDVehiculo = "W-20190703-1297", Finalizado = true, Pendiente = false
                },
                new Vehiculo
                {
                    Modelo = "GSK342 SPARK", Marca = "MAZDA", Color = "NEGRO", HoraInicio = "17:00 pm", IDVehiculo = "W-20190703-1297", Finalizado = true, Pendiente = false
                },
                
                
            });

            AgendaListView.ItemsSource = listaVehiculos;

        }

        private async void AgendaItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tapped = (Vehiculo)e.Item;
            Console.WriteLine("Item tapped: "+tapped.Marca);
            await Navigation.PushAsync(new DetalleInspView());
        }

    }
}