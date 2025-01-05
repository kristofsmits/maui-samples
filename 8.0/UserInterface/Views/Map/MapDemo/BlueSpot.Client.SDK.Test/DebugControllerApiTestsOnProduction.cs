using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;
using BlueSpot.Utilities;

namespace BlueSpot.Client.SDK.Test
{
    public class DebugControllerApiTestsOnProduction
    {

        [Fact]
        public void GetTokenForExistingUserTest()
        {
            BlueSpotTokenHelper blueSpotTokenHelper = new BlueSpotTokenHelper("https://bluespotserver.nw.r.appspot.com");
            string test = blueSpotTokenHelper.GetToken("admin","admin");
            Assert.NotNull(test);
            Assert.True(test.Length > 0);
        }

        [Fact]
        public void GetTokenForNonExistingUserTest()
        {
            BlueSpotTokenHelper blueSpotTokenHelper = new BlueSpotTokenHelper("https://bluespotserver.nw.r.appspot.com");
            string test = blueSpotTokenHelper.GetToken("nonexistinguser", "nonexistinguser_password");
            Assert.Null(test);
        }

        [Fact]
        public void PublicHashTest()
        {
            DebugControllerApi api = new DebugControllerApi("https://bluespotserver.nw.r.appspot.com");
            ApiResponse<DebugResponse> publicHashResponse = api.HashWithHttpInfo("1234");
            Assert.Equal(true, publicHashResponse.Data.Success);
            Assert.Equal("\u0003�gB\u0016��\\v\u001E��U�g�6#ȳ��E�\u0013�x��F�", publicHashResponse.Data.Response);
        }

        [Fact]
        public void PrivateHashTest()
        {
            BlueSpotTokenHelper blueSpotTokenHelper = new BlueSpotTokenHelper("https://bluespotserver.nw.r.appspot.com");
            string token = blueSpotTokenHelper.GetToken("admin", "admin");
            Configuration configuration = new Configuration();
            configuration.BasePath = "https://bluespotserver.nw.r.appspot.com";
            configuration.AccessToken = token;
            DebugControllerApi api = new DebugControllerApi(configuration);
            ApiResponse<DebugResponse> publicHashResponse = api.HashWithHttpInfo("1234");
            Assert.Equal(true, publicHashResponse.Data.Success);
            Assert.Equal("\u0003�gB\u0016��\\v\u001E��U�g�6#ȳ��E�\u0013�x��F�", publicHashResponse.Data.Response);
        }
    }
}