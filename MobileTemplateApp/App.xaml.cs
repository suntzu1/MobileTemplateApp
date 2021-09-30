using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileTemplateApp.Views;

namespace MobileTemplateApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new LoginPage();
            MainPage = new NavigationPage(new LoginPage());
            // MainPage = new MainPage();
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
