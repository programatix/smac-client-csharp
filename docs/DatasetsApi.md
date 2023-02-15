# Org.OpenAPITools.Api.DatasetsApi

All URIs are relative to *https://smac-poc.mcs-group.com.my/*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiDatasetsGet**](DatasetsApi.md#apidatasetsget) | **GET** /api/Datasets | Gets the datasets for the current user. |
| [**ApiDatasetsIdDelete**](DatasetsApi.md#apidatasetsiddelete) | **DELETE** /api/Datasets/{id} | Deletes the specified dataset for the current user. |
| [**ApiDatasetsIdGet**](DatasetsApi.md#apidatasetsidget) | **GET** /api/Datasets/{id} | Gets the specific dataset for the current user. |
| [**ApiDatasetsIdPut**](DatasetsApi.md#apidatasetsidput) | **PUT** /api/Datasets/{id} | Updates the specified dataset for the current user. |
| [**ApiDatasetsPost**](DatasetsApi.md#apidatasetspost) | **POST** /api/Datasets | Creates a new dataset for the current user. |

<a name="apidatasetsget"></a>
# **ApiDatasetsGet**
> DatasetResponsePaginatedResponse ApiDatasetsGet (int? pageNumber = null, int? pageSize = null, string sortOrder = null, string searchText = null, string filter = null)

Gets the datasets for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiDatasetsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DatasetsApi(config);
            var pageNumber = 1;  // int? | Page number to retrieve (optional)  (default to 1)
            var pageSize = 10;  // int? | Maximum number of items per page (optional)  (default to 10)
            var sortOrder = "sortOrder_example";  // string | Comma separated sort order (\"name\", \"description\", \"createddate\", \"updateddate\"). Append with \"_desc\" to sort descending. (optional) 
            var searchText = "searchText_example";  // string | Search string to search in \"name\" and \"description\" (optional) 
            var filter = "filter_example";  // string | Filter the query in JSON format. eg: {\"name\":\"john\"} (optional) 

            try
            {
                // Gets the datasets for the current user.
                DatasetResponsePaginatedResponse result = apiInstance.ApiDatasetsGet(pageNumber, pageSize, sortOrder, searchText, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.ApiDatasetsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDatasetsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the datasets for the current user.
    ApiResponse<DatasetResponsePaginatedResponse> response = apiInstance.ApiDatasetsGetWithHttpInfo(pageNumber, pageSize, sortOrder, searchText, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.ApiDatasetsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageNumber** | **int?** | Page number to retrieve | [optional] [default to 1] |
| **pageSize** | **int?** | Maximum number of items per page | [optional] [default to 10] |
| **sortOrder** | **string** | Comma separated sort order (\&quot;name\&quot;, \&quot;description\&quot;, \&quot;createddate\&quot;, \&quot;updateddate\&quot;). Append with \&quot;_desc\&quot; to sort descending. | [optional]  |
| **searchText** | **string** | Search string to search in \&quot;name\&quot; and \&quot;description\&quot; | [optional]  |
| **filter** | **string** | Filter the query in JSON format. eg: {\&quot;name\&quot;:\&quot;john\&quot;} | [optional]  |

### Return type

[**DatasetResponsePaginatedResponse**](DatasetResponsePaginatedResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apidatasetsiddelete"></a>
# **ApiDatasetsIdDelete**
> void ApiDatasetsIdDelete (Guid id)

Deletes the specified dataset for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiDatasetsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DatasetsApi(config);
            var id = "id_example";  // Guid | The dataset ID to delete

            try
            {
                // Deletes the specified dataset for the current user.
                apiInstance.ApiDatasetsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.ApiDatasetsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDatasetsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified dataset for the current user.
    apiInstance.ApiDatasetsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.ApiDatasetsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The dataset ID to delete |  |

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **400** | Invalid parameter |  -  |
| **401** | Unauthorized access |  -  |
| **404** | Dataset not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apidatasetsidget"></a>
# **ApiDatasetsIdGet**
> DatasetResponse ApiDatasetsIdGet (Guid id)

Gets the specific dataset for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiDatasetsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DatasetsApi(config);
            var id = "id_example";  // Guid | The dataset ID to retrieve

            try
            {
                // Gets the specific dataset for the current user.
                DatasetResponse result = apiInstance.ApiDatasetsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.ApiDatasetsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDatasetsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific dataset for the current user.
    ApiResponse<DatasetResponse> response = apiInstance.ApiDatasetsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.ApiDatasetsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The dataset ID to retrieve |  |

### Return type

[**DatasetResponse**](DatasetResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apidatasetsidput"></a>
# **ApiDatasetsIdPut**
> void ApiDatasetsIdPut (Guid id, ApiDatasetsIdDeleteRequest apiDatasetsIdDeleteRequest = null)

Updates the specified dataset for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiDatasetsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DatasetsApi(config);
            var id = "id_example";  // Guid | The dataset ID to update
            var apiDatasetsIdDeleteRequest = new ApiDatasetsIdDeleteRequest(); // ApiDatasetsIdDeleteRequest |  (optional) 

            try
            {
                // Updates the specified dataset for the current user.
                apiInstance.ApiDatasetsIdPut(id, apiDatasetsIdDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.ApiDatasetsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDatasetsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the specified dataset for the current user.
    apiInstance.ApiDatasetsIdPutWithHttpInfo(id, apiDatasetsIdDeleteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.ApiDatasetsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The dataset ID to update |  |
| **apiDatasetsIdDeleteRequest** | [**ApiDatasetsIdDeleteRequest**](ApiDatasetsIdDeleteRequest.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **400** | Invalid parameter |  -  |
| **401** | Unauthorized access |  -  |
| **404** | Dataset not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apidatasetspost"></a>
# **ApiDatasetsPost**
> DatasetResponse ApiDatasetsPost (DatasetPostRequest datasetPostRequest = null)

Creates a new dataset for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiDatasetsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DatasetsApi(config);
            var datasetPostRequest = new DatasetPostRequest(); // DatasetPostRequest |  (optional) 

            try
            {
                // Creates a new dataset for the current user.
                DatasetResponse result = apiInstance.ApiDatasetsPost(datasetPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetsApi.ApiDatasetsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDatasetsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new dataset for the current user.
    ApiResponse<DatasetResponse> response = apiInstance.ApiDatasetsPostWithHttpInfo(datasetPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetsApi.ApiDatasetsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **datasetPostRequest** | [**DatasetPostRequest**](DatasetPostRequest.md) |  | [optional]  |

### Return type

[**DatasetResponse**](DatasetResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly created dataset |  -  |
| **400** | Invalid parameter |  -  |
| **401** | Unauthorized access |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

