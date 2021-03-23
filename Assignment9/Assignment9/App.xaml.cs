using Assignment9.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment9
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Assignment9Page();
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
