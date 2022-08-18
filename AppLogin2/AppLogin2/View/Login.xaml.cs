﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppLogin2.View;
using AppLogin2.Model;

namespace AppLogin2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        App PropriedadesApp;

        public Login()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            frm_login.BackgroundColor = Color.FromRgba(1, 1, 1, 0.15);

            txt_email.PlaceholderColor = Color.FromRgba(1, 1, 1, 0.3);
            txt_senha.PlaceholderColor = Color.FromRgba(1, 1, 1, 0.3);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string email = txt_email.Text;
                string senha = txt_senha.Text;

                if (PropriedadesApp.List_usuario.Any(i => (i.Email == email && i.Senha == senha)))
                {
                    App.Current.Properties.Add("usuario_logado", email);
                    App.Current.MainPage = new Protegida();
                }
                else
                    throw new Exception("Dados incorretos, tente novamente.");

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}