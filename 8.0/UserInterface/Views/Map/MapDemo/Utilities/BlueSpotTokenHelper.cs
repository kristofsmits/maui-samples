// Copyright 2020 Hysopt NV. All Rights Reserved.

using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace BlueSpot.Utilities
{
    public class BlueSpotTokenHelper
    {
        private readonly string iamBasePath;

        public BlueSpotTokenHelper(string iamBasePath)
        {
            this.iamBasePath = iamBasePath;
        }

        private static dynamic DeserialiseJsonStringToDynamicObject(string json)
        {
            dynamic data = JObject.Parse(json);
            return data;
        }

        public string GetToken(string username, string password)
        {
            try
            {
                string clientId = "myapp";
                string clientSecret = "mysecret";
                string grantType = "password";


                // create request
                string url = iamBasePath + "/oauth2/token";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                // Add Basic Auth header
                string authHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));
                request.Headers["Authorization"] = $"Basic {authHeader}";

                // Form data
                string postData = $"grant_type={grantType}&username={username}&password={password}";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                using (Stream newStream = request.GetRequestStream())
                {
                    newStream.Write(byteArray, 0, byteArray.Length);

                    // read the response stream
                    // inspired by https://stackoverflow.com/questions/137285/what-is-the-best-way-to-read-getresponsestream
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        Stream responseStream = response.GetResponseStream();
                        if (responseStream == null)
                        {
                            // Log.Error("Failed to obtain response stream from the IAM response...");
                            return null;
                        }
                        using (StreamReader streamReader = new StreamReader(responseStream, true))
                        {
                            string responseBody = streamReader.ReadToEnd();
                            // responseBody looks like "{\"accessToken\":\"eyJraWQiOiJUSnZOOEpPM2N4XC9ZZW1BaE56WTZ1VlBzRnc4dWY1VlV2NUYzWndpU3pubz0iLCJhbGciOiJSUzI1NiJ9.eyJzdWIiOiIzMGMyMmQ5ZS04NGE2LTRkNTktOGU0Ni0zZDcyNGI2OTE0ZTciLCJpc3MiOiJodHRwczpcL1wvY29nbml0by1pZHAuZXUtd2VzdC0xLmFtYXpvbmF3cy5jb21cL2V1LXdlc3QtMV9xWUE4VnlOMUMiLCJjbGllbnRfaWQiOiI2dTA1Zmp1aW1uMXZwb3BvOG9hZWk0NXY4ZCIsIm9yaWdpbl9qdGkiOiI2ZTVjZmJlYS05Yjc0LTQwOTgtYTc4OC05ZjBmNDYyNGE1MDEiLCJldmVudF9pZCI6Ijk3NGFkNzFmLWE2NDctNDQ3MC1iZWIzLTMxMjUwOGRmN2FiYiIsInRva2VuX3VzZSI6ImFjY2VzcyIsInNjb3BlIjoiYXdzLmNvZ25pdG8uc2lnbmluLnVzZXIuYWRtaW4iLCJhdXRoX3RpbWUiOjE2NTY3NTIwMDgsImV4cCI6MTY1Njc1NTYwOCwiaWF0IjoxNjU2NzUyMDA4LCJqdGkiOiI0YjdhODk1NC0wMDI2LTRlMTYtODk1Ni00YmRiZTcxZTU4MTIiLCJ1c2VybmFtZSI6ImtyaXN0b2ZAaHlzb3B0LmNvbSJ9.jk7mzVpYMDV0E1bF-AdcSvhX01wijyNbCVk3Qdokgnprm1u4zCAAlYxLarZmOiuJ-OCmnWOVFEaE11isjnpQKN53K1EzuUxfWn3kluIec99WX5rp8IP2xgisHuZk_IuvvXTqL-1G-k1YFdAOC1oN-8mcjROfqko7Xu916AsLkWELXd6RDFdkyLZ6R8B9aS2KfLmvXprpLe89ye1Tqz-epbG06dO8T-5gKPcHzpeYqOldZMwILgo8iwAYBTgNb-VN6G1z6xyOiM4KW2BBPIujMxAg4RqPf7aDeOToyoPh70bFvvGt3WDtVAqWp0hHUyRTdfxQAKDSvKbgJYOJmaoVag\",\"accessTokenExpirationPeriod\":3600,\"message\":\"Authentication successful\",\"additionalAction\":null,\"mfaSession\":null}"
                            dynamic data = DeserialiseJsonStringToDynamicObject(responseBody);
                            return data.access_token;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log.Error("Failed to authenticate username {Username} : {Ex}", username, ex.Message);
                return null;
            }
        }
    }
}
