using CommunityToolkit.Maui.Alerts;
using Firebase.Storage;
using GeoCoordinatePortable;
using Microsoft.Maui.Storage;
using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Threading;
using System.Windows.Input;
using WorkingWithMaps.Models;
using WorkingWithMapsLib.Datastructures;
using WorkingWithMapsLib.Repository;
using WorkingWithMapsLib.Utilities;

namespace WorkingWithMaps.ViewModels;

public class PinItemsSourcePageViewModel
{
    int _pinCreatedCount = 0;
    ObservableCollection<Position> _positions = new ObservableCollection<Position>();
    private HandiSpotRepository handiSpotRepository = new HandiSpotRepository("Credentials/handi-credentials.json");

    public IEnumerable Positions => _positions;

    public ICommand AddLocationCommand { get; }
    public ICommand RemoveLocationCommand { get; }
    public ICommand ClearLocationsCommand { get; }
    public ICommand UpdateLocationsCommand { get; }
    public ICommand ReplaceLocationCommand { get; }

    public void rebind() {
        _positions.Clear();
        List<HandiSpot> handiSpots = handiSpotRepository.getAll();
        foreach (HandiSpot handiSpot in handiSpots)
        {
            Position pos = new Position(handiSpot.Name, toDescription(handiSpot.Number, handiSpot.Paiement), new Location(handiSpot.GeoCoordinate.Latitude, handiSpot.GeoCoordinate.Longitude));
            _positions.Add(pos);
        };
    }

    private string toDescription(int number, Paiement paiement) {
        string description = "";
        if (number == 0)
        {
            description = "? spots";
        }
        else if (number == 1)
        {
            description = "1 spot";
        }
        else
        {
            description = number + " spots";
        }

        if (paiement == Paiement.FREE)
        {
            description += " (free)";
        }
        else {
            description += " (money)";
        }

        return description;

    }

    public PinItemsSourcePageViewModel()
    {
        AddLocationCommand = new Command(AddLocation);
        RemoveLocationCommand = new Command(RemoveLocation);
        ClearLocationsCommand = new Command(() => _positions.Clear());
        UpdateLocationsCommand = new Command(UpdateLocations);
        ReplaceLocationCommand = new Command(ReplaceLocation);

        rebind();
    }

    static private FileResult photo = null;
    private static void MyFunction()
    {

        if (MediaPicker.Default.IsCaptureSupported)
        {
            photo = MediaPicker.Default.CapturePhotoAsync().GetAwaiter().GetResult();
        }
    }

    private async void AddLocation()
    {
        MauiHelper mauiHelper = new MauiHelper();
        Location currentLocation = mauiHelper.GetCurrentLocation();
        if (currentLocation == null)
        {
            // TODO : log
            MauiHelper.ShowToaster("Unable to get current location");
            return;
        }

        MauiHelper.ShowToaster("Current location " + currentLocation.Longitude + " - " + currentLocation.Latitude);

        // take photo
        if (MediaPicker.Default.IsCaptureSupported)
        {
            photo = await MediaPicker.Default.CapturePhotoAsync();
        }

        // save the file into local storage
        // string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);
        using Stream sourceStream = photo.OpenReadAsync().GetAwaiter().GetResult();
        // using FileStream localFileStream = File.OpenWrite(localFilePath);
        // sourceStream.CopyToAsync(localFileStream).GetAwaiter().GetResult();

        // FileResult fileResult = FilePicker.PickAsync().Result;
        // Stream fileToUpload = fileResult.OpenReadAsync().Result;

        // upload
        MauiHelper.ShowToaster("Start upload");
        FirebaseStorage firebaseStorage = new FirebaseStorage("handi-431506.appspot.com");
        string url = await firebaseStorage.Child(photo.FileName).PutAsync(sourceStream);

        MauiHelper.ShowToaster("url : " + url);
        HandiSpot hs = new HandiSpot(Guid.NewGuid().ToString(), "name", DateTime.Now, new GeoCoordinate(currentLocation.Latitude, currentLocation.Longitude), 1, Paiement.FREE, false, false, "User", url);

        MauiHelper.ShowToaster("adding to Google Sheet");
        bool success = await handiSpotRepository.add(hs);

        if (success)
        {
            MauiHelper.ShowToaster("succes");
        }
        else {
            MauiHelper.ShowToaster("failed");
        }

        photo = null;
        rebind();
    }

    void RemoveLocation()
    {
        if (_positions.Any())
        {
            _positions.Remove(_positions.First());
        }
    }

    void UpdateLocations()
    {
        if (!_positions.Any())
        {
            return;
        }

        double lastLatitude = _positions.Last().Location.Latitude;
        foreach (Position position in Positions)
        {
            position.Location = new Location(lastLatitude, position.Location.Longitude);
        }
    }

    void ReplaceLocation()
    {
        if (!_positions.Any())
        {
            return;
        }

        _positions[_positions.Count - 1] = NewPosition();
    }

    Position NewPosition()
    {
        _pinCreatedCount++;
        return new Position(
            $"Pin {_pinCreatedCount}",
            $"Desc {_pinCreatedCount}",
            RandomPosition.Next(new Location(39.8283459, -98.5794797), 8, 19));
    }
}
