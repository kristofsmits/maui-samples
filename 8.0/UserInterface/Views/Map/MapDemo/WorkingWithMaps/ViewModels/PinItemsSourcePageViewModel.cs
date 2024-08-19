using Microsoft.Maui.Storage;
using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows.Input;
using WorkingWithMaps.Models;
using WorkingWithMapsLib.Datastructures;
using WorkingWithMapsLib.Utilities;

namespace WorkingWithMaps.ViewModels;

public class PinItemsSourcePageViewModel
{
    int _pinCreatedCount = 0;
    readonly ObservableCollection<Position> _positions;

    public IEnumerable Positions => _positions;

    public ICommand AddLocationCommand { get; }
    public ICommand RemoveLocationCommand { get; }
    public ICommand ClearLocationsCommand { get; }
    public ICommand UpdateLocationsCommand { get; }
    public ICommand ReplaceLocationCommand { get; }

    public PinItemsSourcePageViewModel()
    {
        string _spreadsheetId = "12SQY5ElDVm5uRaFJ6o5YcEV-fjyWB8BQQFn9xSh7A5I";
        string _range = "A2:Z100";
        string relativeCredentialsPath = "Credentials/handi-credentials.json";

        string currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string fullCredentialsPath = Path.Combine(currentDir, relativeCredentialsPath);

        GSheetsHelper g = new GSheetsHelper(relativeCredentialsPath, _spreadsheetId, _range);
        List<HandiSpot> handiSpots = g.GetItems().ConvertAll(l => HandiSpot.CreateFrom(l));

        _positions = new ObservableCollection<Position>();
        foreach (HandiSpot handiSpot in handiSpots) 
        {
            Position pos = new Position(handiSpot.Id, handiSpot.Name + " - " + handiSpot.Number, new Location(handiSpot.GeoCoordinate.Latitude, handiSpot.GeoCoordinate.Longitude));
            _positions.Add(pos);
        };

        AddLocationCommand = new Command(AddLocation);
        RemoveLocationCommand = new Command(RemoveLocation);
        ClearLocationsCommand = new Command(() => _positions.Clear());
        UpdateLocationsCommand = new Command(UpdateLocations);
        ReplaceLocationCommand = new Command(ReplaceLocation);
    }

    void AddLocation()
    {

        _positions.Add(NewPosition());
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
