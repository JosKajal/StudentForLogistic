using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentForLogistic.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mapa : ContentPage
    {
        //VERSION DE RECUPERACION 
        public Mapa()
        {
            InitializeComponent();
            MapView.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(37, -122), Distance.FromMiles(1)));
        }
        private void Street_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Street;
        }


        private void Hybrid_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Hybrid;
        }

        private void Satellite_OnClicked(object sender, EventArgs e)
        {
            MapView.MapType = MapType.Satellite;
        }
    }
}