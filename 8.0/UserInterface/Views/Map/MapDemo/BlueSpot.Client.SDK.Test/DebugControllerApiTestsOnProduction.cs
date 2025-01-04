using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using System;

namespace BlueSpot.Client.SDK.Test
{
    public class DebugControllerApiTestsOnProduction
    {
        [Fact]
        public void PublicHash()
        {
            DebugControllerApi api = new DebugControllerApi("https://bluespotserver.nw.r.appspot.com");
            ApiResponse<string> publicHashResponse = api.HashWithHttpInfo("1234");
            Assert.Equal("\u0003�gB\u0016��\\v\u001E��U�g�6#ȳ��E�\u0013�x��F�", publicHashResponse.Data);
        }

        [Fact]
        public void PrivateHash()
        {
            Configuration configuration = new Configuration();
            configuration.BasePath = "https://bluespotserver.nw.r.appspot.com";
            configuration.Username = "admin";
            configuration.Password = "admin";
            DebugControllerApi api = new DebugControllerApi(configuration);
            ApiResponse<string> publicHashResponse = api.Hash2WithHttpInfo("1234");
            Assert.Equal("\u0003�gB\u0016��\\v\u001E��U�g�6#ȳ��E�\u0013�x��F�", publicHashResponse.Data);
        }
    }
}