using System;
using System.Reflection;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Storage;

public class MauiHelper
{
    private CancellationTokenSource _cancelTokenSource;
    private bool _isCheckingLocation;

    public Location GetCurrentLocation()
    {
        try
        {
            _isCheckingLocation = true;

            GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));

            _cancelTokenSource = new CancellationTokenSource();

            Location location = Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token).Result;

            if (location != null)
                Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");


            return location;
        }
        // Catch one of the following exceptions:
        //   FeatureNotSupportedException
        //   FeatureNotEnabledException
        //   PermissionException
        catch (Exception ex)
        {
            // Unable to get location
            // TODO : log
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            _isCheckingLocation = false;
        }
        return null;
    }

    public void CancelRequest()
    {
        if (_isCheckingLocation && _cancelTokenSource != null && _cancelTokenSource.IsCancellationRequested == false)
            _cancelTokenSource.Cancel();
    }
}
