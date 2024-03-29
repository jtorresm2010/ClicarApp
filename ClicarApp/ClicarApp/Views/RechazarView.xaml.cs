﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClicarApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RechazarView : ContentPage
    {
        public RechazarView()
        {
            InitializeComponent();
        }


        private async void RechazarCommand(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void CancelarCommand(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


    }
}