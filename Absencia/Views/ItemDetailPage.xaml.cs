using Absencia.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Absencia.Views
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