# BlueSpot.Client.Sdk.Api.VersionControllerApi

All URIs are relative to *https://bluespotserver.onrender.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetApiVersion**](VersionControllerApi.md#getapiversion) | **GET** /rest/version |  |

<a id="getapiversion"></a>
# **GetApiVersion**
> string GetApiVersion ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetApiVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new VersionControllerApi(config);

            try
            {
                string result = apiInstance.GetApiVersion();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VersionControllerApi.GetApiVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApiVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.GetApiVersionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VersionControllerApi.GetApiVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

