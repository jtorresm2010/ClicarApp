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
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }


        //Placeholder action

        private void LoginCommand(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new ConfigView());

        }


    }
}