using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //NavigationPage = new NavigationPage ( new Custom());
           
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
