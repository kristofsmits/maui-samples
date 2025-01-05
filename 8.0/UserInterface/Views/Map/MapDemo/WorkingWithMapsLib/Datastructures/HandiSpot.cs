using GeoCoordinatePortable;
using System.Globalization;
using BlueSpot.Utilities;

namespace WorkingWithMapsLib.Datastructures
{
    public class HandiSpot
    {
        private static string no_image_url = "https://firebasestorage.googleapis.com/v0/b/handi-431506.appspot.com/o/HandiSpots%2Fno_image_available.png?alt=media&token=4cb1aecc-b481-4ef8-84bc-c8451e0c4341";

        public string Id { get; private set; }
        public string Name { get; private set; }
        public DateTime CreationDate { get; private set; }
        public GeoCoordinate GeoCoordinate { get; private set; }
        public int Number { get; private set; }
        public Paiement Paiement { get; private set; }
        public bool Confirmed { get; private set; }
        public bool Ignore { get; private set; }
        public string Source { get; private set; }
        public string ImageUrl { get; private set; }

        public HandiSpot(string id, string name, DateTime creationDate, GeoCoordinate geoCoordinate, int number, Paiement paiement, bool confirmed, bool ignore, string source, string imageUrl)
        {
            Id = id;
            Name = name;
            CreationDate = creationDate;
            GeoCoordinate = geoCoordinate;
            Number = number;
            Paiement = paiement;
            Confirmed = confirmed;
            Ignore = ignore;
            Source = source;
            ImageUrl = imageUrl;
        }

        public List<object> ToGoogleSheetEntry()
        {
            // NumberFormatInfo nfi = new NumberFormatInfo();
            // nfi.NumberDecimalSeparator = ".";

            List<object> list = new List<object>();
            list.Add(Id);
            list.Add(Name);
            list.Add(CreationDate.ToUniversalTime().ToString("u")); // https://stackoverflow.com/questions/49087359/how-can-i-print-datetime-in-utc-format
            list.Add(GeoCoordinate.Latitude);
            list.Add(GeoCoordinate.Longitude);
            list.Add(Number);
            list.Add(Paiement.ToString());
            list.Add(Confirmed);
            list.Add(Ignore);
            list.Add(Source);
            list.Add(ImageUrl);
            return list;
        }

        public static HandiSpot FromGoogleSheetEntry(List<string> googleSheetRow)
        {
            try
            {
                string id = googleSheetRow[0];
                string name = googleSheetRow[1];
                DateTime creationDate = parseToDateTime(googleSheetRow[2]);
                double latitude = ConversionHelper.parseToDouble(googleSheetRow[3]);
                double longitude = ConversionHelper.parseToDouble(googleSheetRow[4]);
                int number = Convert.ToInt32(googleSheetRow[5]);
                Enum.TryParse(googleSheetRow[6], out Paiement paiement);
                bool confirmed = Convert.ToBoolean(googleSheetRow[7]);
                bool ignore = Convert.ToBoolean(googleSheetRow[8]);
                string source = googleSheetRow[9];
                string imageUrl = no_image_url;
                // support for entries without image, in that case, the row is one size shorter
                if (googleSheetRow.Count == 11)
                {
                    imageUrl = googleSheetRow[10];
                }

                return new HandiSpot(id, name, creationDate, new GeoCoordinate(latitude, longitude), number, paiement, confirmed, ignore, source, imageUrl);
            }
            catch (Exception ex)
            {
                // TODO : log
                Console.Out.WriteLine(ex.Message);
                return null;
            }

        }

        // see https://stackoverflow.com/a/60205610
        public static DateTime parseToDateTime(string text)
        {
            return DateTime.Parse(text, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
        }



    }
}
