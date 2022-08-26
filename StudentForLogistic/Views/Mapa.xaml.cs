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
        public Mapa()
        {
            Pin pin;
            InitializeComponent();

            MapView.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(31.291890, -110.952625), Distance.FromMiles(0.2)));
            pin = new Pin { Label = "Vinculacion", Position = new Position(31.290899, -110.951311) };
            MapView.Pins.Add(pin);
            pin = new Pin { Label = "Edificio A", Position = new Position(31.292728, -110.955808) };
            MapView.Pins.Add(pin);
            pin = new Pin { Label = "Edificio B", Position = new Position(31.29255, -110.95612) };
            MapView.Pins.Add(pin);
            MapView.IsShowingUser = true;
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