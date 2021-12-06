using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TalkableBinding.SampleCore.Services;
using TalkableBinding.SampleCore.Views;

namespace TalkableBinding.SampleCore
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
