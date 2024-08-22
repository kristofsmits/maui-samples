using System.Reflection;
using WorkingWithMapsLib.Datastructures;
using WorkingWithMapsLib.Repository;
using WorkingWithMapsLib.Utilities;
using GeoCoordinatePortable;
using Xunit;

namespace WorkingWithMapsTest.Repository
{
    public class HandiSpotRepositoryTests
    {
        private HandiSpot createDummyHandiSpot(string uniqueId)
        {
            return new HandiSpot(uniqueId, "HandiSpotRepositoryTest", DateTime.Now, new GeoCoordinate(25.25, 50.50), 1000, Paiement.UNKOWN, false, true, "unittest", "https://upload.wikimedia.org/wikipedia/commons/8/85/Logo-Test.png");
        }

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

        [Fact]
        public void AddAndDeleteHandiSpotTest()
        {
            string relativeCredentialsPath = "Credentials/handi-credentials.json";
            HandiSpotRepository repository = new HandiSpotRepository(relativeCredentialsPath);         
            string uniqueId = Guid.NewGuid().ToString();

            HandiSpot spotBeforeAddition = repository.get(uniqueId);
            Assert.Null(spotBeforeAddition);

            HandiSpot handiSpot = createDummyHandiSpot(uniqueId);

            bool succesfulAdd = repository.add(handiSpot).GetAwaiter().GetResult();
            Assert.True(succesfulAdd);

            HandiSpot spotAfterAddition = repository.get(uniqueId);
            Assert.NotNull(spotAfterAddition);

            bool succesfulDelete = repository.delete(uniqueId);
            Assert.True(succesfulDelete);

            System.Threading.Thread.Sleep(10000);

            HandiSpot spotAfterDeletion = repository.get(uniqueId);
            Assert.Null(spotAfterDeletion);
        }
    }
}
