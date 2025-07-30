# BlueSpot.Client.Sdk.Api.ServicesControllerApi

All URIs are relative to *https://bluespotserver.onrender.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetServiceInfo**](ServicesControllerApi.md#getserviceinfo) | **GET** /rest/services/{serviceName} |  |
| [**GetServiceInfos**](ServicesControllerApi.md#getserviceinfos) | **GET** /rest/services |  |
| [**InvokeServiceMethodGet**](ServicesControllerApi.md#invokeservicemethodget) | **GET** /rest/services/{serviceName}/{methodName} |  |
| [**InvokeServiceMethodPost**](ServicesControllerApi.md#invokeservicemethodpost) | **POST** /rest/services/{serviceName}/{methodName} |  |

<a id="getserviceinfo"></a>
# **GetServiceInfo**
> RestServiceInfo GetServiceInfo (string serviceName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetServiceInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new ServicesControllerApi(config);
            var serviceName = "serviceName_example";  // string | 

            try
            {
                RestServiceInfo result = apiInstance.GetServiceInfo(serviceName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesControllerApi.GetServiceInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServiceInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RestServiceInfo> response = apiInstance.GetServiceInfoWithHttpInfo(serviceName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesControllerApi.GetServiceInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceName** | **string** |  |  |

### Return type

[**RestServiceInfo**](RestServiceInfo.md)

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

<a id="getserviceinfos"></a>
# **GetServiceInfos**
> List&lt;RestServiceInfo&gt; GetServiceInfos ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetServiceInfosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new ServicesControllerApi(config);

            try
            {
                List<RestServiceInfo> result = apiInstance.GetServiceInfos();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesControllerApi.GetServiceInfos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServiceInfosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<RestServiceInfo>> response = apiInstance.GetServiceInfosWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesControllerApi.GetServiceInfosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;RestServiceInfo&gt;**](RestServiceInfo.md)

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

<a id="invokeservicemethodget"></a>
# **InvokeServiceMethodGet**
> string InvokeServiceMethodGet (string serviceName, string methodName, Dictionary<string, string> paramsMap, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class InvokeServiceMethodGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new ServicesControllerApi(config);
            var serviceName = "serviceName_example";  // string | 
            var methodName = "methodName_example";  // string | 
            var paramsMap = new Dictionary<string, string>(); // Dictionary<string, string> | 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.InvokeServiceMethodGet(serviceName, methodName, paramsMap, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesControllerApi.InvokeServiceMethodGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvokeServiceMethodGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.InvokeServiceMethodGetWithHttpInfo(serviceName, methodName, paramsMap, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesControllerApi.InvokeServiceMethodGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceName** | **string** |  |  |
| **methodName** | **string** |  |  |
| **paramsMap** | [**Dictionary&lt;string, string&gt;**](string.md) |  |  |
| **modelVersion** | **string** |  | [optional]  |

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

<a id="invokeservicemethodpost"></a>
# **InvokeServiceMethodPost**
> string InvokeServiceMethodPost (string serviceName, string methodName, string modelVersion = null, string body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class InvokeServiceMethodPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new ServicesControllerApi(config);
            var serviceName = "serviceName_example";  // string | 
            var methodName = "methodName_example";  // string | 
            var modelVersion = "modelVersion_example";  // string |  (optional) 
            var body = "body_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.InvokeServiceMethodPost(serviceName, methodName, modelVersion, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicesControllerApi.InvokeServiceMethodPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvokeServiceMethodPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.InvokeServiceMethodPostWithHttpInfo(serviceName, methodName, modelVersion, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicesControllerApi.InvokeServiceMethodPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceName** | **string** |  |  |
| **methodName** | **string** |  |  |
| **modelVersion** | **string** |  | [optional]  |
| **body** | **string** |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

