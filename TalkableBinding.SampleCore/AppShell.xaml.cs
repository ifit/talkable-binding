using System;
using System.Collections.Generic;
using TalkableBinding.SampleCore.ViewModels;
using TalkableBinding.SampleCore.Views;
using Xamarin.Forms;

namespace TalkableBinding.SampleCore
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
