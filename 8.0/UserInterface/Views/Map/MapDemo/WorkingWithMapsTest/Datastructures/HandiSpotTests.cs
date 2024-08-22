using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WorkingWithMapsLib.Datastructures;
using WorkingWithMapsLib.Utilities;
using Xunit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WorkingWithMapsTest.Datastructures
{

    public class HandiSpotTests {

        private HandiSpot createDummyHandiSpot() {
            DateTime date = HandiSpot.parseToDateTime("2018-02-18 11:10:13Z");
            return new HandiSpot("id", "name", date, new GeoCoordinate(25.25, 50.50), 1000, Paiement.FREE, false, true, "unittest", "https://upload.wikimedia.org/wikipedia/commons/8/85/Logo-Test.png");
        }

        private List<string> createDummyGoogleSheetEntry()
        {
            return new List<string>(new string[] { "id2", "name2", "2018-02-18 11:10:13Z", "75.75", "100.100", "2000", "FREE", "TRUE", "TRUE", "unittest", "https://upload.wikimedia.org/wikipedia/commons/8/85/Logo-Test.png" });
        }

        [Fact]
        public void HandiSpotToGSheetTest()
        {
            HandiSpot dummy = createDummyHandiSpot();
            List<object> googleSheetEntry = dummy.ToGoogleSheetEntry();
            Assert.Equal(11, googleSheetEntry.Count);
            Assert.Equal("id", googleSheetEntry[0]);
            Assert.Equal("name", googleSheetEntry[1]);
            Assert.Equal("2018-02-18 11:10:13Z", googleSheetEntry[2]);
            Assert.Equal(25.25, googleSheetEntry[3]);
            Assert.Equal(50.5, googleSheetEntry[4]);
            Assert.Equal(1000, googleSheetEntry[5]);
            Assert.Equal("FREE", googleSheetEntry[6]);
            Assert.Equal(false, googleSheetEntry[7]);
            Assert.Equal(true, googleSheetEntry[8]);
            Assert.Equal("unittest", googleSheetEntry[9]);
            Assert.Equal("https://upload.wikimedia.org/wikipedia/commons/8/85/Logo-Test.png", googleSheetEntry[10]);
        }

        [Fact]
        public void GSheetToHandiSpotTest()
        {
            List<string> googleSheetEntry = createDummyGoogleSheetEntry();
            Assert.Equal(11, googleSheetEntry.Count);
            HandiSpot handiSpot = HandiSpot.FromGoogleSheetEntry(googleSheetEntry);

            Assert.Equal("id2", handiSpot.Id);
            Assert.Equal("name2", handiSpot.Name);
            Assert.Equal(2018, handiSpot.CreationDate.Year);
            Assert.Equal(75.75, handiSpot.GeoCoordinate.Latitude);
            Assert.Equal(100.1, handiSpot.GeoCoordinate.Longitude);
            Assert.Equal(2000, handiSpot.Number);
            Assert.Equal(Paiement.FREE, handiSpot.Paiement);
            Assert.True(handiSpot.Confirmed);
            Assert.True(handiSpot.Ignore);
            Assert.Equal("unittest", handiSpot.Source);
            Assert.Equal("https://upload.wikimedia.org/wikipedia/commons/8/85/Logo-Test.png", handiSpot.ImageUrl);
        }
    }
}
