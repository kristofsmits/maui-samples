# BlueSpot.Client.Sdk.Api.DocumentationControllerApi

All URIs are relative to *https://bluespotserver.onrender.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetOpenApiJson**](DocumentationControllerApi.md#getopenapijson) | **GET** /rest/docs/openapi.json |  |
| [**GetOpenApiYaml**](DocumentationControllerApi.md#getopenapiyaml) | **GET** /rest/docs/openapi.yaml |  |
| [**GetProjectOpenApiJson**](DocumentationControllerApi.md#getprojectopenapijson) | **GET** /rest/docs/openapiDetailed.json |  |
| [**GetProjectOpenApiYaml**](DocumentationControllerApi.md#getprojectopenapiyaml) | **GET** /rest/docs/openapiDetailed.yaml |  |

<a id="getopenapijson"></a>
# **GetOpenApiJson**
> string GetOpenApiJson ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetOpenApiJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new DocumentationControllerApi(config);

            try
            {
                string result = apiInstance.GetOpenApiJson();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentationControllerApi.GetOpenApiJson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOpenApiJsonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.GetOpenApiJsonWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentationControllerApi.GetOpenApiJsonWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getopenapiyaml"></a>
# **GetOpenApiYaml**
> string GetOpenApiYaml ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetOpenApiYamlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new DocumentationControllerApi(config);

            try
            {
                string result = apiInstance.GetOpenApiYaml();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentationControllerApi.GetOpenApiYaml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOpenApiYamlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.GetOpenApiYamlWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentationControllerApi.GetOpenApiYamlWithHttpInfo: " + e.Message);
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
 - **Accept**: application/yaml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprojectopenapijson"></a>
# **GetProjectOpenApiJson**
> string GetProjectOpenApiJson ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetProjectOpenApiJsonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new DocumentationControllerApi(config);

            try
            {
                string result = apiInstance.GetProjectOpenApiJson();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentationControllerApi.GetProjectOpenApiJson: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProjectOpenApiJsonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.GetProjectOpenApiJsonWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentationControllerApi.GetProjectOpenApiJsonWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprojectopenapiyaml"></a>
# **GetProjectOpenApiYaml**
> string GetProjectOpenApiYaml ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetProjectOpenApiYamlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new DocumentationControllerApi(config);

            try
            {
                string result = apiInstance.GetProjectOpenApiYaml();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentationControllerApi.GetProjectOpenApiYaml: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProjectOpenApiYamlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.GetProjectOpenApiYamlWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentationControllerApi.GetProjectOpenApiYamlWithHttpInfo: " + e.Message);
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
 - **Accept**: application/yaml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

