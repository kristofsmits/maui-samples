using GeoCoordinatePortable;
using System.Globalization;

namespace WorkingWithMapsLib.Datastructures
{
    public class HandiSpot
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public GeoCoordinate GeoCoordinate { get; private set; }
        public int Number { get; private set; }
        public bool Confirmed { get; private set; }

        public HandiSpot(string id, string name, GeoCoordinate geoCoordinate, int number, bool confirmed)
        {
            Id = id;
            Name = name;
            GeoCoordinate = geoCoordinate;
            Number = number;
            Confirmed = confirmed;
        }

        public static HandiSpot CreateFrom(List<string> googleSheetRow)
        {
            try
            {
                string id = googleSheetRow[0];
                string name = googleSheetRow[1];
                double latitude = parseToDouble(googleSheetRow[2]);
                double longitude = parseToDouble(googleSheetRow[3]);
                int number = Convert.ToInt32(googleSheetRow[4]);
                bool confirmed = Convert.ToBoolean(googleSheetRow[5]);

                return new HandiSpot(id, name, new GeoCoordinate(latitude, longitude), number, confirmed);
            }
            catch (Exception ex)
            {
                // TODO : log
                Console.Out.WriteLine(ex.Message);
                return null;
            }

        }

        // parse any double, whether comma or point is used as decimal separator
        // https://stackoverflow.com/questions/11560465/parse-strings-to-double-with-comma-and-point
        private static double parseToDouble(string text)
        {
            text = text.Replace(',', '.');
            return double.Parse(text, NumberStyles.Any, CultureInfo.InvariantCulture);
        }
    }
}
