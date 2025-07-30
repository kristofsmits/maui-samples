# BlueSpot.Client.Sdk.Api.FileUploadControllerApi

All URIs are relative to *https://bluespotserver.onrender.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UploadFile1**](FileUploadControllerApi.md#uploadfile1) | **POST** /rest/files |  |

<a id="uploadfile1"></a>
# **UploadFile1**
> FileInfoResponse UploadFile1 (System.IO.Stream file, string name = null, string storageName = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class UploadFile1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new FileUploadControllerApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 
            var name = "name_example";  // string |  (optional) 
            var storageName = "storageName_example";  // string |  (optional) 

            try
            {
                FileInfoResponse result = apiInstance.UploadFile1(file, name, storageName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileUploadControllerApi.UploadFile1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadFile1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileInfoResponse> response = apiInstance.UploadFile1WithHttpInfo(file, name, storageName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileUploadControllerApi.UploadFile1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |
| **name** | **string** |  | [optional]  |
| **storageName** | **string** |  | [optional]  |

### Return type

[**FileInfoResponse**](FileInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

