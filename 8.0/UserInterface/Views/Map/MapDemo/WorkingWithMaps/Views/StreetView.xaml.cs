namespace WorkingWithMaps.Views;

public partial class StreetView : ContentPage
{
	public string Url = "https://www.google.be";


    public StreetView(string url)
	{
		InitializeComponent();
        Browser.Source = url;

    }
}