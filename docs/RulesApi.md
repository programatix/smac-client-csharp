# Org.OpenAPITools.Api.RulesApi

All URIs are relative to *https://smac-poc.mcs-group.com.my/*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiRulesGet**](RulesApi.md#apirulesget) | **GET** /api/Rules | Gets the rules for the current user. |
| [**ApiRulesIdDelete**](RulesApi.md#apirulesiddelete) | **DELETE** /api/Rules/{id} | Deletes the specified rule for the current user. |
| [**ApiRulesIdGet**](RulesApi.md#apirulesidget) | **GET** /api/Rules/{id} | Gets the specific rule for the current user. |
| [**ApiRulesIdPut**](RulesApi.md#apirulesidput) | **PUT** /api/Rules/{id} | Updates the specified rule for the current user. |
| [**ApiRulesPost**](RulesApi.md#apirulespost) | **POST** /api/Rules | Creates a new rule for the current user. |

<a name="apirulesget"></a>
# **ApiRulesGet**
> RuleResponsePaginatedResponse ApiRulesGet (int? pageNumber = null, int? pageSize = null, string sortOrder = null, string searchText = null, string filter = null)

Gets the rules for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiRulesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RulesApi(config);
            var pageNumber = 1;  // int? | Page number to retrieve (optional)  (default to 1)
            var pageSize = 10;  // int? | Maximum number of items per page (optional)  (default to 10)
            var sortOrder = "sortOrder_example";  // string | Comma separated sort order (\"name\", \"description\", \"createddate\", \"updateddate\"). Append with \"_desc\" to sort descending. (optional) 
            var searchText = "searchText_example";  // string | Search string to search in \"name\" and \"description\" (optional) 
            var filter = "filter_example";  // string | Filter the query in JSON format. eg: {\"name\":\"john\"} (optional) 

            try
            {
                // Gets the rules for the current user.
                RuleResponsePaginatedResponse result = apiInstance.ApiRulesGet(pageNumber, pageSize, sortOrder, searchText, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.ApiRulesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRulesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the rules for the current user.
    ApiResponse<RuleResponsePaginatedResponse> response = apiInstance.ApiRulesGetWithHttpInfo(pageNumber, pageSize, sortOrder, searchText, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.ApiRulesGetWithHttpInfo: " + e.Message);
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

[**RuleResponsePaginatedResponse**](RuleResponsePaginatedResponse.md)

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

<a name="apirulesiddelete"></a>
# **ApiRulesIdDelete**
> void ApiRulesIdDelete (Guid id)

Deletes the specified rule for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiRulesIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RulesApi(config);
            var id = "id_example";  // Guid | The rule ID to delete

            try
            {
                // Deletes the specified rule for the current user.
                apiInstance.ApiRulesIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.ApiRulesIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRulesIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified rule for the current user.
    apiInstance.ApiRulesIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.ApiRulesIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The rule ID to delete |  |

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
| **404** | Rule not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apirulesidget"></a>
# **ApiRulesIdGet**
> RuleResponse ApiRulesIdGet (Guid id)

Gets the specific rule for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiRulesIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RulesApi(config);
            var id = "id_example";  // Guid | The rule ID to retrieve

            try
            {
                // Gets the specific rule for the current user.
                RuleResponse result = apiInstance.ApiRulesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.ApiRulesIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRulesIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific rule for the current user.
    ApiResponse<RuleResponse> response = apiInstance.ApiRulesIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.ApiRulesIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The rule ID to retrieve |  |

### Return type

[**RuleResponse**](RuleResponse.md)

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

<a name="apirulesidput"></a>
# **ApiRulesIdPut**
> void ApiRulesIdPut (Guid id, ApiRulesIdDeleteRequest apiRulesIdDeleteRequest = null)

Updates the specified rule for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiRulesIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RulesApi(config);
            var id = "id_example";  // Guid | The rule ID to update
            var apiRulesIdDeleteRequest = new ApiRulesIdDeleteRequest(); // ApiRulesIdDeleteRequest |  (optional) 

            try
            {
                // Updates the specified rule for the current user.
                apiInstance.ApiRulesIdPut(id, apiRulesIdDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.ApiRulesIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRulesIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the specified rule for the current user.
    apiInstance.ApiRulesIdPutWithHttpInfo(id, apiRulesIdDeleteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.ApiRulesIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The rule ID to update |  |
| **apiRulesIdDeleteRequest** | [**ApiRulesIdDeleteRequest**](ApiRulesIdDeleteRequest.md) |  | [optional]  |

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
| **404** | Rule not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apirulespost"></a>
# **ApiRulesPost**
> RuleResponse ApiRulesPost (RulePostRequest rulePostRequest = null)

Creates a new rule for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiRulesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RulesApi(config);
            var rulePostRequest = new RulePostRequest(); // RulePostRequest |  (optional) 

            try
            {
                // Creates a new rule for the current user.
                RuleResponse result = apiInstance.ApiRulesPost(rulePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.ApiRulesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRulesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new rule for the current user.
    ApiResponse<RuleResponse> response = apiInstance.ApiRulesPostWithHttpInfo(rulePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.ApiRulesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rulePostRequest** | [**RulePostRequest**](RulePostRequest.md) |  | [optional]  |

### Return type

[**RuleResponse**](RuleResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly created rule |  -  |
| **400** | Invalid parameter |  -  |
| **401** | Unauthorized access |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

