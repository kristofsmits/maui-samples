# BlueSpot.Client.Sdk.Api.FileDownloadControllerApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DownloadFile**](FileDownloadControllerApi.md#downloadfile) | **GET** /rest/files |  |

<a id="downloadfile"></a>
# **DownloadFile**
> void DownloadFile (string fileRef, bool? attachment = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class DownloadFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new FileDownloadControllerApi(config);
            var fileRef = "fileRef_example";  // string | 
            var attachment = true;  // bool? |  (optional) 

            try
            {
                apiInstance.DownloadFile(fileRef, attachment);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileDownloadControllerApi.DownloadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DownloadFileWithHttpInfo(fileRef, attachment);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileDownloadControllerApi.DownloadFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileRef** | **string** |  |  |
| **attachment** | **bool?** |  | [optional]  |

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

