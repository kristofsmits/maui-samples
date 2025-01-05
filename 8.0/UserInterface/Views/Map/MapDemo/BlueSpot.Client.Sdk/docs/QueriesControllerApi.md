# BlueSpot.Client.Sdk.Api.QueriesControllerApi

All URIs are relative to *http://localhost:8080*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExecuteQueryGet**](QueriesControllerApi.md#executequeryget) | **GET** /rest/queries/{entityName}/{queryName} |  |
| [**ExecuteQueryPost**](QueriesControllerApi.md#executequerypost) | **POST** /rest/queries/{entityName}/{queryName} |  |
| [**GetCountGetText1**](QueriesControllerApi.md#getcountgettext1) | **GET** /rest/queries/{entityName}/{queryName}/count |  |
| [**GetCountPostText1**](QueriesControllerApi.md#getcountposttext1) | **POST** /rest/queries/{entityName}/{queryName}/count |  |
| [**LoadQueriesList**](QueriesControllerApi.md#loadquerieslist) | **GET** /rest/queries/{entityName} |  |

<a id="executequeryget"></a>
# **ExecuteQueryGet**
> string ExecuteQueryGet (string entityName, string queryName, Dictionary<string, string> _params, int? limit = null, int? offset = null, string view = null, string fetchPlan = null, bool? returnNulls = null, bool? dynamicAttributes = null, bool? returnCount = null, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class ExecuteQueryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new QueriesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var queryName = "queryName_example";  // string | 
            var _params = new Dictionary<string, string>(); // Dictionary<string, string> | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var view = "view_example";  // string |  (optional) 
            var fetchPlan = "fetchPlan_example";  // string |  (optional) 
            var returnNulls = true;  // bool? |  (optional) 
            var dynamicAttributes = true;  // bool? |  (optional) 
            var returnCount = true;  // bool? |  (optional) 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.ExecuteQueryGet(entityName, queryName, _params, limit, offset, view, fetchPlan, returnNulls, dynamicAttributes, returnCount, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueriesControllerApi.ExecuteQueryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExecuteQueryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.ExecuteQueryGetWithHttpInfo(entityName, queryName, _params, limit, offset, view, fetchPlan, returnNulls, dynamicAttributes, returnCount, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueriesControllerApi.ExecuteQueryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **queryName** | **string** |  |  |
| **_params** | [**Dictionary&lt;string, string&gt;**](string.md) |  |  |
| **limit** | **int?** |  | [optional]  |
| **offset** | **int?** |  | [optional]  |
| **view** | **string** |  | [optional]  |
| **fetchPlan** | **string** |  | [optional]  |
| **returnNulls** | **bool?** |  | [optional]  |
| **dynamicAttributes** | **bool?** |  | [optional]  |
| **returnCount** | **bool?** |  | [optional]  |
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

<a id="executequerypost"></a>
# **ExecuteQueryPost**
> string ExecuteQueryPost (string entityName, string queryName, string body, int? limit = null, int? offset = null, string view = null, string fetchPlan = null, bool? returnNulls = null, bool? dynamicAttributes = null, bool? returnCount = null, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class ExecuteQueryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new QueriesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var queryName = "queryName_example";  // string | 
            var body = "body_example";  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var view = "view_example";  // string |  (optional) 
            var fetchPlan = "fetchPlan_example";  // string |  (optional) 
            var returnNulls = true;  // bool? |  (optional) 
            var dynamicAttributes = true;  // bool? |  (optional) 
            var returnCount = true;  // bool? |  (optional) 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.ExecuteQueryPost(entityName, queryName, body, limit, offset, view, fetchPlan, returnNulls, dynamicAttributes, returnCount, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueriesControllerApi.ExecuteQueryPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExecuteQueryPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.ExecuteQueryPostWithHttpInfo(entityName, queryName, body, limit, offset, view, fetchPlan, returnNulls, dynamicAttributes, returnCount, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueriesControllerApi.ExecuteQueryPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **queryName** | **string** |  |  |
| **body** | **string** |  |  |
| **limit** | **int?** |  | [optional]  |
| **offset** | **int?** |  | [optional]  |
| **view** | **string** |  | [optional]  |
| **fetchPlan** | **string** |  | [optional]  |
| **returnNulls** | **bool?** |  | [optional]  |
| **dynamicAttributes** | **bool?** |  | [optional]  |
| **returnCount** | **bool?** |  | [optional]  |
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

<a id="getcountgettext1"></a>
# **GetCountGetText1**
> string GetCountGetText1 (string entityName, string queryName, Dictionary<string, string> _params, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetCountGetText1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new QueriesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var queryName = "queryName_example";  // string | 
            var _params = new Dictionary<string, string>(); // Dictionary<string, string> | 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.GetCountGetText1(entityName, queryName, _params, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueriesControllerApi.GetCountGetText1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCountGetText1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.GetCountGetText1WithHttpInfo(entityName, queryName, _params, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueriesControllerApi.GetCountGetText1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **queryName** | **string** |  |  |
| **_params** | [**Dictionary&lt;string, string&gt;**](string.md) |  |  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain;charset=UTF-8, application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcountposttext1"></a>
# **GetCountPostText1**
> string GetCountPostText1 (string entityName, string queryName, string body, string modelVersion = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class GetCountPostText1Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new QueriesControllerApi(config);
            var entityName = "entityName_example";  // string | 
            var queryName = "queryName_example";  // string | 
            var body = "body_example";  // string | 
            var modelVersion = "modelVersion_example";  // string |  (optional) 

            try
            {
                string result = apiInstance.GetCountPostText1(entityName, queryName, body, modelVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueriesControllerApi.GetCountPostText1: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCountPostText1WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.GetCountPostText1WithHttpInfo(entityName, queryName, body, modelVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueriesControllerApi.GetCountPostText1WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |
| **queryName** | **string** |  |  |
| **body** | **string** |  |  |
| **modelVersion** | **string** |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain;charset=UTF-8, application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="loadquerieslist"></a>
# **LoadQueriesList**
> List&lt;QueryInfo&gt; LoadQueriesList (string entityName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BlueSpot.Client.Sdk.Api;
using BlueSpot.Client.Sdk.Client;
using BlueSpot.Client.Sdk.Model;

namespace Example
{
    public class LoadQueriesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080";
            var apiInstance = new QueriesControllerApi(config);
            var entityName = "entityName_example";  // string | 

            try
            {
                List<QueryInfo> result = apiInstance.LoadQueriesList(entityName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueriesControllerApi.LoadQueriesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoadQueriesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<QueryInfo>> response = apiInstance.LoadQueriesListWithHttpInfo(entityName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueriesControllerApi.LoadQueriesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityName** | **string** |  |  |

### Return type

[**List&lt;QueryInfo&gt;**](QueryInfo.md)

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

