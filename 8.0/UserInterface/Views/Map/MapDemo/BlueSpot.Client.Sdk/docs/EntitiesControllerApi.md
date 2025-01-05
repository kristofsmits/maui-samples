# BlueSpot.Client.Sdk.Api.EntitiesControllerApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CountSearchEntitiesListGet**](EntitiesControllerApi.md#countsearchentitieslistget) | **GET** /rest/entities/{entityName}/search/count |  |
| [**CountSearchEntitiesListPost**](EntitiesControllerApi.md#countsearchentitieslistpost) | **POST** /rest/entities/{entityName}/search/count |  |
| [**CreateEntity**](EntitiesControllerApi.md#createentity) | **POST** /rest/entities/{entityName} |  |
| [**DeleteEntities**](EntitiesControllerApi.md#deleteentities) | **DELETE** /rest/entities/{entityName} |  |
| [**DeleteEntity**](EntitiesControllerApi.md#deleteentity) | **DELETE** /rest/entities/{entityName}/{entityId} |  |
| [**LoadEntitiesList**](EntitiesControllerApi.md#loadentitieslist) | **GET** /rest/entities/{entityName} |  |
| [**LoadEntity**](EntitiesControllerApi.md#loadentity) | **GET** /rest/entities/{entityName}/{entityId} |  |
| [**SearchEntitiesListGet**](EntitiesControllerApi.md#searchentitieslistget) | **GET** /rest/entities/{entityName}/search |  |
| [**SearchEntitiesListPost**](EntitiesControllerApi.md#searchentitieslistpost) | **POST** /rest/entities/{entityName}/search |  |
| [**UpdateEntities**](EntitiesControllerApi.md#updateentities) | **PUT** /rest/entities/{entityName} |  |
| [**UpdateEntity**](EntitiesControllerApi.md#updateentity) | **PUT** /rest/entities/{entityName}/{entityId} |  |

<a id="countsearchentitieslistget"></a>
# **CountSearchEntitiesListGet**
> string CountSearchEntitiesListGet (string entityName, string filter, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class CountSearchEntitiesListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var filter = "filter_example";  // string | 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.CountSearchEntitiesListGet(entityName, filter, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.CountSearchEntitiesListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CountSearchEntitiesListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.CountSearchEntitiesListGetWithHttpInfo(entityName, filter, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.CountSearchEntitiesListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **filter** | **string** |  |  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**string**

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

<a id="countsearchentitieslistpost"></a>
# **CountSearchEntitiesListPost**
> string CountSearchEntitiesListPost (string entityName, string body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class CountSearchEntitiesListPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var body = "body_example";  // string | 

            try
            {
                string result = apiInstance.CountSearchEntitiesListPost(entityName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.CountSearchEntitiesListPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CountSearchEntitiesListPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.CountSearchEntitiesListPostWithHttpInfo(entityName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.CountSearchEntitiesListPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **body** | **string** |  |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createentity"></a>
# **CreateEntity**
> string CreateEntity (string entityName, string body, string responseView = null, string responseFetchPlan = null, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class CreateEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var body = "body_example";  // string | 
            var responseView = "responseView_example";  // string |  (optional) 
            var responseFetchPlan = "responseFetchPlan_example";  // string |  (optional) 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.CreateEntity(entityName, body, responseView, responseFetchPlan, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.CreateEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.CreateEntityWithHttpInfo(entityName, body, responseView, responseFetchPlan, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.CreateEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **body** | **string** |  |  |
| **responseView** | **string** |  | [optional]  |
| **responseFetchPlan** | **string** |  | [optional]  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteentities"></a>
# **DeleteEntities**
> Object DeleteEntities (string entityName, string body, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class DeleteEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var body = "body_example";  // string | 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                Object result = apiInstance.DeleteEntities(entityName, body, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.DeleteEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.DeleteEntitiesWithHttpInfo(entityName, body, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.DeleteEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **body** | **string** |  |  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteentity"></a>
# **DeleteEntity**
> Object DeleteEntity (string entityName, string entityId, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class DeleteEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var entityId = "entityId_example";  // string | 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                Object result = apiInstance.DeleteEntity(entityName, entityId, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.DeleteEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.DeleteEntityWithHttpInfo(entityName, entityId, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.DeleteEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **entityId** | **string** |  |  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**Object**

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

<a id="loadentitieslist"></a>
# **LoadEntitiesList**
> string LoadEntitiesList (string entityName, string fetchPlan = null, int? limit = null, int? offset = null, string sort = null, bool? returnNulls = null, bool? returnCount = null, bool? dynamicAttributes = null, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class LoadEntitiesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var fetchPlan = "fetchPlan_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var returnNulls = true;  // bool? |  (optional) 
            var returnCount = true;  // bool? |  (optional) 
            var dynamicAttributes = true;  // bool? |  (optional) 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.LoadEntitiesList(entityName, fetchPlan, limit, offset, sort, returnNulls, returnCount, dynamicAttributes, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.LoadEntitiesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadEntitiesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.LoadEntitiesListWithHttpInfo(entityName, fetchPlan, limit, offset, sort, returnNulls, returnCount, dynamicAttributes, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.LoadEntitiesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **fetchPlan** | **string** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |
| **offset** | **int?** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **returnNulls** | **bool?** |  | [optional]  |
| **returnCount** | **bool?** |  | [optional]  |
| **dynamicAttributes** | **bool?** |  | [optional]  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**string**

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

<a id="loadentity"></a>
# **LoadEntity**
> string LoadEntity (string entityName, string entityId, string fetchPlan = null, bool? returnNulls = null, bool? dynamicAttributes = null, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class LoadEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var entityId = "entityId_example";  // string | 
            var fetchPlan = "fetchPlan_example";  // string |  (optional) 
            var returnNulls = true;  // bool? |  (optional) 
            var dynamicAttributes = true;  // bool? |  (optional) 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.LoadEntity(entityName, entityId, fetchPlan, returnNulls, dynamicAttributes, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.LoadEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.LoadEntityWithHttpInfo(entityName, entityId, fetchPlan, returnNulls, dynamicAttributes, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.LoadEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **entityId** | **string** |  |  |
| **fetchPlan** | **string** |  | [optional]  |
| **returnNulls** | **bool?** |  | [optional]  |
| **dynamicAttributes** | **bool?** |  | [optional]  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**string**

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

<a id="searchentitieslistget"></a>
# **SearchEntitiesListGet**
> string SearchEntitiesListGet (string entityName, string filter, string fetchPlan = null, int? limit = null, int? offset = null, string sort = null, bool? returnNulls = null, bool? returnCount = null, bool? dynamicAttributes = null, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class SearchEntitiesListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var filter = "filter_example";  // string | 
            var fetchPlan = "fetchPlan_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var sort = "sort_example";  // string |  (optional) 
            var returnNulls = true;  // bool? |  (optional) 
            var returnCount = true;  // bool? |  (optional) 
            var dynamicAttributes = true;  // bool? |  (optional) 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.SearchEntitiesListGet(entityName, filter, fetchPlan, limit, offset, sort, returnNulls, returnCount, dynamicAttributes, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.SearchEntitiesListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchEntitiesListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.SearchEntitiesListGetWithHttpInfo(entityName, filter, fetchPlan, limit, offset, sort, returnNulls, returnCount, dynamicAttributes, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.SearchEntitiesListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **filter** | **string** |  |  |
| **fetchPlan** | **string** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |
| **offset** | **int?** |  | [optional]  |
| **sort** | **string** |  | [optional]  |
| **returnNulls** | **bool?** |  | [optional]  |
| **returnCount** | **bool?** |  | [optional]  |
| **dynamicAttributes** | **bool?** |  | [optional]  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**string**

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

<a id="searchentitieslistpost"></a>
# **SearchEntitiesListPost**
> string SearchEntitiesListPost (string entityName, string body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class SearchEntitiesListPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var body = "body_example";  // string | 

            try
            {
                string result = apiInstance.SearchEntitiesListPost(entityName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.SearchEntitiesListPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchEntitiesListPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.SearchEntitiesListPostWithHttpInfo(entityName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.SearchEntitiesListPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **body** | **string** |  |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateentities"></a>
# **UpdateEntities**
> string UpdateEntities (string entityName, string body, string responseView = null, string responseFetchPlan = null, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class UpdateEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var body = "body_example";  // string | 
            var responseView = "responseView_example";  // string |  (optional) 
            var responseFetchPlan = "responseFetchPlan_example";  // string |  (optional) 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.UpdateEntities(entityName, body, responseView, responseFetchPlan, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.UpdateEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.UpdateEntitiesWithHttpInfo(entityName, body, responseView, responseFetchPlan, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.UpdateEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **body** | **string** |  |  |
| **responseView** | **string** |  | [optional]  |
| **responseFetchPlan** | **string** |  | [optional]  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateentity"></a>
# **UpdateEntity**
> string UpdateEntity (string entityName, string entityId, string body, string responseView = null, string responseFetchPlan = null, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class UpdateEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new EntitiesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var entityId = "entityId_example";  // string | 
            var body = "body_example";  // string | 
            var responseView = "responseView_example";  // string |  (optional) 
            var responseFetchPlan = "responseFetchPlan_example";  // string |  (optional) 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.UpdateEntity(entityName, entityId, body, responseView, responseFetchPlan, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EntitiesControllerApi.UpdateEntity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.UpdateEntityWithHttpInfo(entityName, entityId, body, responseView, responseFetchPlan, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EntitiesControllerApi.UpdateEntityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **entityId** | **string** |  |  |
| **body** | **string** |  |  |
| **responseView** | **string** |  | [optional]  |
| **responseFetchPlan** | **string** |  | [optional]  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

