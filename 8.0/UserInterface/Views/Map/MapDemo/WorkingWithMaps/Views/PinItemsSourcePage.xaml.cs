using WorkingWithMaps.ViewModels;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System.Globalization;
using static System.Net.WebRequestMethods;
using System.ComponentModel;

namespace WorkingWithMaps.Views;

public partial class PinItemsSourcePage : ContentPage
{
    private PinItemsSourcePageViewModel viewModel = new PinItemsSourcePageViewModel();
    private MauiHelper mauiHelper = new MauiHelper();
    private static Pin latestPinClicked = null;
    private static DateTime latestMarkerClicked = DateTime.Now;

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
        makeButtonsInvisible();
    }


    void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        // https://github.com/dotnet/maui/issues/16556
        if (e.PropertyName == nameof(Microsoft.Maui.Controls.Maps.Map.VisibleRegion))
        {
            makeButtonsInvisible();
        }
    }

    void OnTrafficCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        map.IsTrafficEnabled = !map.IsTrafficEnabled;
    }

    private void makeButtonsInvisible() {
        // due to interference with OnPropertyChanged when marker is clicked
        if (DateTime.Now - latestMarkerClicked > TimeSpan.FromMilliseconds(500))
        {
            streetview.IsVisible = false;
        }
    }

    private void makeButtonsVisible()
    {
        streetview.IsVisible = true;
    }

    void OnMarkerClickedAsync(object sender, PinClickedEventArgs e)
    {
        latestMarkerClicked = DateTime.Now;
        latestPinClicked = (Pin)sender;
        makeButtonsVisible();
    }

    async void StreetviewButtonCLickedAsync(object sender, EventArgs e)
    {
        // string url = "https://maps.google.com/maps?q=&layer=c&cbll=31.335198,-89.287204&cbp=11,0,0,0,0";
        // e.HideInfoWindow = true;
       
        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberDecimalSeparator = ".";
        string lo = latestPinClicked.Location.Longitude.ToString(nfi);
        string la = latestPinClicked.Location.Latitude.ToString(nfi);

        // await DisplayAlert("InfoWindow Clicked", $"{pinName} was clicked.", "Ok");

        string url = "https://maps.google.com/maps?q=&layer=c&cbll="
                           + la + "," + lo + "&cbp=";

        Page page = new StreetView(url);
        await Navigation.PushAsync(page);
    }

    async void InfoWindowClickedAsync(object sender, PinClickedEventArgs e)
    {
        // string url = "https://maps.google.com/maps?q=&layer=c&cbll=31.335198,-89.287204&cbp=11,0,0,0,0";
        // e.HideInfoWindow = true;
        Pin pin = ((Pin)sender);
        NumberFormatInfo nfi = new NumberFormatInfo();
        nfi.NumberDecimalSeparator = ".";
        string lo = pin.Location.Longitude.ToString(nfi);
        string la = pin.Location.Latitude.ToString(nfi);
        string pinName = ((Pin)sender).Label;
        // await DisplayAlert("InfoWindow Clicked", $"{pinName} was clicked.", "Ok");

        //string url = "https://www.google.com/maps/embed/v1/streetview"
        //    + "?key=AIzaSyC5ML20M5U7M70_xCNTNBnUsElCYNefnS0"
        //    + "&location=" + lo + "," + la
        //    + "&heading=210"
        //    + "&pitch=10"
        //    + "&fov=35";

        string url = "https://maps.google.com/maps?q=&layer=c&cbll="
                           + la + "," + lo + "&cbp=";

        Page page = new StreetView(url);
        await Navigation.PushAsync(page);
    }
}
