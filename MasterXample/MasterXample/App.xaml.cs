using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MasterXample.Views;

namespace MasterXample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContentPage1());
            //MainPage = new MasterDetailPage1();
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
