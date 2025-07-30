# BlueSpot.Client.Sdk.Api.MessagesControllerApi

All URIs are relative to *https://bluespotserver.onrender.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLocalizationForAllEntities**](MessagesControllerApi.md#getlocalizationforallentities) | **GET** /rest/messages/entities |  |
| [**GetLocalizationForAllEnums**](MessagesControllerApi.md#getlocalizationforallenums) | **GET** /rest/messages/enums |  |
| [**GetLocalizationForEntity**](MessagesControllerApi.md#getlocalizationforentity) | **GET** /rest/messages/entities/{entityName} |  |
| [**GetLocalizationForEnum**](MessagesControllerApi.md#getlocalizationforenum) | **GET** /rest/messages/enums/{enumClassName} |  |

<a id="getlocalizationforallentities"></a>
# **GetLocalizationForAllEntities**
> Dictionary&lt;string, string&gt; GetLocalizationForAllEntities ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetLocalizationForAllEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new MessagesControllerApi(config);

            try
            {
                Dictionary<string, string> result = apiInstance.GetLocalizationForAllEntities();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesControllerApi.GetLocalizationForAllEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLocalizationForAllEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, string>> response = apiInstance.GetLocalizationForAllEntitiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesControllerApi.GetLocalizationForAllEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlocalizationforallenums"></a>
# **GetLocalizationForAllEnums**
> Dictionary&lt;string, string&gt; GetLocalizationForAllEnums ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetLocalizationForAllEnumsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new MessagesControllerApi(config);

            try
            {
                Dictionary<string, string> result = apiInstance.GetLocalizationForAllEnums();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesControllerApi.GetLocalizationForAllEnums: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLocalizationForAllEnumsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, string>> response = apiInstance.GetLocalizationForAllEnumsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesControllerApi.GetLocalizationForAllEnumsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlocalizationforentity"></a>
# **GetLocalizationForEntity**
> Dictionary&lt;string, string&gt; GetLocalizationForEntity (string entityName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetLocalizationForEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new MessagesControllerApi(config);
            var entityName = "entityName_example";  // string | 

            try
            {
                Dictionary<string, string> result = apiInstance.GetLocalizationForEntity(entityName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesControllerApi.GetLocalizationForEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLocalizationForEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, string>> response = apiInstance.GetLocalizationForEntityWithHttpInfo(entityName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesControllerApi.GetLocalizationForEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlocalizationforenum"></a>
# **GetLocalizationForEnum**
> Dictionary&lt;string, string&gt; GetLocalizationForEnum (string enumClassName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetLocalizationForEnumExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://bluespotserver.onrender.com";
            var apiInstance = new MessagesControllerApi(config);
            var enumClassName = "enumClassName_example";  // string | 

            try
            {
                Dictionary<string, string> result = apiInstance.GetLocalizationForEnum(enumClassName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesControllerApi.GetLocalizationForEnum: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLocalizationForEnumWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, string>> response = apiInstance.GetLocalizationForEnumWithHttpInfo(enumClassName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesControllerApi.GetLocalizationForEnumWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enumClassName** | **string** |  |  |

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

