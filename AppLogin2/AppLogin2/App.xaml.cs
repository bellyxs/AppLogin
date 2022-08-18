using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using AppLogin2.View;
using AppLogin2.Model;

namespace AppLogin2
{
    public partial class App : Application
    {
        private List<DadosUsuario> list_usuario = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "bella@gmail.com",
                Nome = "Bella",
                Senha = "202"
            },
            new DadosUsuario()
            {
                Email = "gatinhosfofos@gmail.com",
                Nome = "Fã de gatos",
                Senha = "456"
            }
        };

        internal List<DadosUsuario> List_usuario { get => list_usuario; set => list_usuario = value; }

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Protegida();
            else
                MainPage = new Login();
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