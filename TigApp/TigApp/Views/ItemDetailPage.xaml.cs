using System.ComponentModel;
using Xamarin.Forms;
using TigApp.ViewModels;

namespace TigApp.Views
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