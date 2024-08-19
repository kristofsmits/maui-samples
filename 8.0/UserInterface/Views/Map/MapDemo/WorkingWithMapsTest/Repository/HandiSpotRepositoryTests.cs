using System.Reflection;
using WorkingWithMapsLib.Datastructures;
using WorkingWithMapsLib.Repository;
using WorkingWithMapsLib.Utilities;
using Xunit;

namespace WorkingWithMapsTest.Repository
{
    public class HandiSpotRepositoryTests
    {
        [Fact]
        public void GetAllTest()
        {
            string relativeCredentialsPath = "Credentials/handi-credentials.json";

            HandiSpotRepository repository = new HandiSpotRepository(relativeCredentialsPath);
            List<HandiSpot> handiSpots = repository.getAll();

            Assert.True(handiSpots.Count >= 3);
            Assert.Equal(57.6904474, handiSpots[1].GeoCoordinate.Latitude);
            Assert.Equal(11.7884121, handiSpots[2].GeoCoordinate.Longitude);
        }
    }
}
