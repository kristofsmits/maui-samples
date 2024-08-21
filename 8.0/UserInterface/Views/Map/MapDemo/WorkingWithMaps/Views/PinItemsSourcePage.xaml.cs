using WorkingWithMaps.ViewModels;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace WorkingWithMaps.Views;

public partial class PinItemsSourcePage : ContentPage
{
    private PinItemsSourcePageViewModel viewModel = new PinItemsSourcePageViewModel();
    private MauiHelper mauiHelper = new MauiHelper();

    public PinItemsSourcePage()
    {
        InitializeComponent();
        BindingContext = viewModel;
        Location currentLocation = mauiHelper.GetCurrentLocation();
        map.MoveToRegion(MapSpan.FromCenterAndRadius(currentLocation, Distance.FromKilometers(10)));
    }

    void OnMapClicked(object sender, MapClickedEventArgs e)
    {
        System.Diagnostics.Debug.WriteLine($"MapClick: {e.Location.Latitude}, {e.Location.Longitude}");
    }
}
