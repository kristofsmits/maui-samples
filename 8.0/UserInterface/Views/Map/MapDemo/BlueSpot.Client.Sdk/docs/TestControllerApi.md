# BlueSpot.Client.Sdk.Api.TestControllerApi

All URIs are relative to *http://bluespotserver.nw.r.appspot.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPart**](TestControllerApi.md#getpart) | **GET** /public/test/{uuid} | Returns a Hello World message |

<a id="getpart"></a>
# **GetPart**
> string GetPart (string uuid)

Returns a Hello World message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetPartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://bluespotserver.nw.r.appspot.com";
            var apiInstance = new TestControllerApi(config);
            var uuid = "uuid_example";  // string | 

            try
            {
                // Returns a Hello World message
                string result = apiInstance.GetPart(uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TestControllerApi.GetPart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a Hello World message
    ApiResponse<string> response = apiInstance.GetPartWithHttpInfo(uuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TestControllerApi.GetPartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uuid** | **string** |  |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

