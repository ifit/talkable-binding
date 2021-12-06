using System.ComponentModel;
using Xamarin.Forms;
using TalkableBinding.SampleCore.ViewModels;

namespace TalkableBinding.SampleCore.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
