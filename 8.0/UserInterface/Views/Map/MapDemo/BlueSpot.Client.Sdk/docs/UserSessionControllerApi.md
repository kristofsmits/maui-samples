# BlueSpot.Client.Sdk.Api.UserSessionControllerApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SetSessionLocale**](UserSessionControllerApi.md#setsessionlocale) | **PUT** /rest/user-session/locale |  |

<a id="setsessionlocale"></a>
# **SetSessionLocale**
> void SetSessionLocale ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class SetSessionLocaleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new UserSessionControllerApi(config);

            try
            {
                apiInstance.SetSessionLocale();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSessionControllerApi.SetSessionLocale: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetSessionLocaleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetSessionLocaleWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSessionControllerApi.SetSessionLocaleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

