using StudentForLogistic.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StudentForLogistic.Views
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