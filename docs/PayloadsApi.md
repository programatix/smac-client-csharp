# Org.OpenAPITools.Api.PayloadsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiPayloadsGet**](PayloadsApi.md#apipayloadsget) | **GET** /api/Payloads | Gets the payloads for the current user. |
| [**ApiPayloadsIdDelete**](PayloadsApi.md#apipayloadsiddelete) | **DELETE** /api/Payloads/{id} | Deletes the specified payload for the current user. |
| [**ApiPayloadsIdGet**](PayloadsApi.md#apipayloadsidget) | **GET** /api/Payloads/{id} | Gets the specific payload for the current user. |
| [**ApiPayloadsIdPut**](PayloadsApi.md#apipayloadsidput) | **PUT** /api/Payloads/{id} | Updates the specified payload for the current user. |
| [**ApiPayloadsPost**](PayloadsApi.md#apipayloadspost) | **POST** /api/Payloads | Creates a new payload for the current user. |

<a name="apipayloadsget"></a>
# **ApiPayloadsGet**
> PayloadResponsePaginatedResponse ApiPayloadsGet (int? pageNumber = null, int? pageSize = null, string sortOrder = null, string searchText = null, string filter = null)

Gets the payloads for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPayloadsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayloadsApi(config);
            var pageNumber = 1;  // int? | Page number to retrieve (optional)  (default to 1)
            var pageSize = 10;  // int? | Maximum number of items per page (optional)  (default to 10)
            var sortOrder = "sortOrder_example";  // string | Comma separated sort order (\"name\", \"description\", \"createddate\", \"updateddate\"). Append with \"_desc\" to sort descending. (optional) 
            var searchText = "searchText_example";  // string | Search string to search in \"name\" and \"description\" (optional) 
            var filter = "filter_example";  // string | Filter the query in JSON format. eg: {\"name\":\"john\"} (optional) 

            try
            {
                // Gets the payloads for the current user.
                PayloadResponsePaginatedResponse result = apiInstance.ApiPayloadsGet(pageNumber, pageSize, sortOrder, searchText, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayloadsApi.ApiPayloadsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPayloadsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the payloads for the current user.
    ApiResponse<PayloadResponsePaginatedResponse> response = apiInstance.ApiPayloadsGetWithHttpInfo(pageNumber, pageSize, sortOrder, searchText, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayloadsApi.ApiPayloadsGetWithHttpInfo: " + e.Message);
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

[**PayloadResponsePaginatedResponse**](PayloadResponsePaginatedResponse.md)

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

<a name="apipayloadsiddelete"></a>
# **ApiPayloadsIdDelete**
> void ApiPayloadsIdDelete (Guid id)

Deletes the specified payload for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPayloadsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayloadsApi(config);
            var id = "id_example";  // Guid | The payload ID to delete

            try
            {
                // Deletes the specified payload for the current user.
                apiInstance.ApiPayloadsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayloadsApi.ApiPayloadsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPayloadsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified payload for the current user.
    apiInstance.ApiPayloadsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayloadsApi.ApiPayloadsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The payload ID to delete |  |

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
| **404** | Payload not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipayloadsidget"></a>
# **ApiPayloadsIdGet**
> PayloadResponse ApiPayloadsIdGet (Guid id)

Gets the specific payload for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPayloadsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayloadsApi(config);
            var id = "id_example";  // Guid | The payload ID to retrieve

            try
            {
                // Gets the specific payload for the current user.
                PayloadResponse result = apiInstance.ApiPayloadsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayloadsApi.ApiPayloadsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPayloadsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific payload for the current user.
    ApiResponse<PayloadResponse> response = apiInstance.ApiPayloadsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayloadsApi.ApiPayloadsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The payload ID to retrieve |  |

### Return type

[**PayloadResponse**](PayloadResponse.md)

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

<a name="apipayloadsidput"></a>
# **ApiPayloadsIdPut**
> void ApiPayloadsIdPut (Guid id, ApiPayloadsIdDeleteRequest apiPayloadsIdDeleteRequest = null)

Updates the specified payload for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPayloadsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayloadsApi(config);
            var id = "id_example";  // Guid | The payload ID to update
            var apiPayloadsIdDeleteRequest = new ApiPayloadsIdDeleteRequest(); // ApiPayloadsIdDeleteRequest |  (optional) 

            try
            {
                // Updates the specified payload for the current user.
                apiInstance.ApiPayloadsIdPut(id, apiPayloadsIdDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayloadsApi.ApiPayloadsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPayloadsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the specified payload for the current user.
    apiInstance.ApiPayloadsIdPutWithHttpInfo(id, apiPayloadsIdDeleteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayloadsApi.ApiPayloadsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The payload ID to update |  |
| **apiPayloadsIdDeleteRequest** | [**ApiPayloadsIdDeleteRequest**](ApiPayloadsIdDeleteRequest.md) |  | [optional]  |

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
| **404** | Payload not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipayloadspost"></a>
# **ApiPayloadsPost**
> PayloadResponse ApiPayloadsPost (PayloadPostRequest payloadPostRequest = null)

Creates a new payload for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPayloadsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PayloadsApi(config);
            var payloadPostRequest = new PayloadPostRequest(); // PayloadPostRequest |  (optional) 

            try
            {
                // Creates a new payload for the current user.
                PayloadResponse result = apiInstance.ApiPayloadsPost(payloadPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayloadsApi.ApiPayloadsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPayloadsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new payload for the current user.
    ApiResponse<PayloadResponse> response = apiInstance.ApiPayloadsPostWithHttpInfo(payloadPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PayloadsApi.ApiPayloadsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payloadPostRequest** | [**PayloadPostRequest**](PayloadPostRequest.md) |  | [optional]  |

### Return type

[**PayloadResponse**](PayloadResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly created payload |  -  |
| **400** | Invalid parameter |  -  |
| **401** | Unauthorized access |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

