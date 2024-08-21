using System;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Storage;
using WorkingWithMapsLib.Datastructures;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

public class MauiHelper
{
    private CancellationTokenSource _cancelTokenSource;
    private bool _isCheckingLocation;

    public MauiHelper()
    {
    }

    public Location GetCurrentLocation()
    {
        Location latestLocation = null;

        try
        {
            _isCheckingLocation = true;

            latestLocation = Geolocation.GetLastKnownLocationAsync().GetAwaiter().GetResult();
            if (latestLocation == null)
            {
                latestLocation = Geolocation.GetLocationAsync(new GeolocationRequest()
                {
                    DesiredAccuracy = GeolocationAccuracy.High,
                    Timeout = TimeSpan.FromSeconds(30)
                }).GetAwaiter().GetResult();
            }

        if (latestLocation != null)
                Console.WriteLine($"Latitude: {latestLocation.Latitude}, Longitude: {latestLocation.Longitude}, Altitude: {latestLocation.Altitude}");
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

        return latestLocation;
    }

    private void CancelGetCurrentLocationRequest()
    {
        if (_isCheckingLocation && _cancelTokenSource != null && _cancelTokenSource.IsCancellationRequested == false)
            _cancelTokenSource.Cancel();
    }

    public static void ShowToaster(string message) {
        CancellationToken _cancelTokenSource = new CancellationToken();
        var toast = Toast.Make(message, ToastDuration.Short, 11);
        toast.Show(_cancelTokenSource);
    }
}
