using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WorkingWithMapsLib.Datastructures;
using WorkingWithMapsLib.Utilities;

namespace WorkingWithMapsLib.Repository
{
    public class HandiSpotRepository
    {
        private GSheetsHelper gSheetsHelper;

        public HandiSpotRepository(string relativeCredentialsPath) {
            string _spreadsheetId = "12SQY5ElDVm5uRaFJ6o5YcEV-fjyWB8BQQFn9xSh7A5I";
            string _range = "A2:Z100";
            gSheetsHelper = new GSheetsHelper(relativeCredentialsPath, _spreadsheetId, _range);
        }

        public List<HandiSpot> getAll() {
            List<HandiSpot> handiSpots = gSheetsHelper.GetItems().ConvertAll(l => HandiSpot.FromGoogleSheetEntry(l));
            return handiSpots;
        }

        public HandiSpot get(string id)
        {
            List<HandiSpot> handiSpots = gSheetsHelper.GetItems().ConvertAll(l => HandiSpot.FromGoogleSheetEntry(l));
            return handiSpots.FirstOrDefault(x => x.Id.Equals(id), null);
        }

        public List<HandiSpot> getAllWithinDistance(GeoCoordinate center, double distanceInMeter)
        {
            List<HandiSpot> handiSpots = gSheetsHelper.GetItems().ConvertAll(l => HandiSpot.FromGoogleSheetEntry(l));
            handiSpots.Where(x => center.GetDistanceTo(x.GeoCoordinate) <= distanceInMeter).ToList();
            return handiSpots;
        }

        public async Task<bool> add(HandiSpot handiSpot)
        {
            try
            {
                List<object> googleSheetEntry = handiSpot.ToGoogleSheetEntry();
                await gSheetsHelper.AddItem(googleSheetEntry);
                return true;
            }
            catch (Exception ex)
            {
                // TODO : log
                return false;
            }
        }

        public bool delete(string id)
        {
            try
            {
                gSheetsHelper.RemoveItem(id).GetAwaiter().GetResult();
                return true;
            }
            catch (Exception ex)
            {
                // TODO : log
                return false;
            }
        }
    }
}
