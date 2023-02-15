# Org.OpenAPITools.Api.SmacsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiSmacsGet**](SmacsApi.md#apismacsget) | **GET** /api/Smacs | Gets the SMAC for the current user. |
| [**ApiSmacsIdDelete**](SmacsApi.md#apismacsiddelete) | **DELETE** /api/Smacs/{id} | Deletes the specified SMAC for the current user. |
| [**ApiSmacsIdGeneratePost**](SmacsApi.md#apismacsidgeneratepost) | **POST** /api/Smacs/{id}/generate | Generates the SMAC QR Code. |
| [**ApiSmacsIdGet**](SmacsApi.md#apismacsidget) | **GET** /api/Smacs/{id} | Gets the specific SMAC for the current user. |
| [**ApiSmacsIdPngGet**](SmacsApi.md#apismacsidpngget) | **GET** /api/Smacs/{id}/png | Downloads the SMAC QR Code as PNG. |
| [**ApiSmacsIdPut**](SmacsApi.md#apismacsidput) | **PUT** /api/Smacs/{id} | Updates the specified SMAC for the current user. |
| [**ApiSmacsIdSvgGet**](SmacsApi.md#apismacsidsvgget) | **GET** /api/Smacs/{id}/svg | Downloads the SMAC QR Code as SVG. |
| [**ApiSmacsPost**](SmacsApi.md#apismacspost) | **POST** /api/Smacs | Creates a new SMAC for the current user. |

<a name="apismacsget"></a>
# **ApiSmacsGet**
> SmacResponsePaginatedResponse ApiSmacsGet (int? pageNumber = null, int? pageSize = null, string sortOrder = null, string searchText = null, string filter = null)

Gets the SMAC for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSmacsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SmacsApi(config);
            var pageNumber = 1;  // int? | Page number to retrieve (optional)  (default to 1)
            var pageSize = 10;  // int? | Maximum number of items per page (optional)  (default to 10)
            var sortOrder = "sortOrder_example";  // string | Comma separated sort order (\"name\", \"description\", \"createddate\", \"updateddate\"). Append with \"_desc\" to sort descending. (optional) 
            var searchText = "searchText_example";  // string | Search string to search in \"name\" and \"description\" (optional) 
            var filter = "filter_example";  // string | Filter the query in JSON format. eg: {\"name\":\"john\"} (optional) 

            try
            {
                // Gets the SMAC for the current user.
                SmacResponsePaginatedResponse result = apiInstance.ApiSmacsGet(pageNumber, pageSize, sortOrder, searchText, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmacsApi.ApiSmacsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSmacsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the SMAC for the current user.
    ApiResponse<SmacResponsePaginatedResponse> response = apiInstance.ApiSmacsGetWithHttpInfo(pageNumber, pageSize, sortOrder, searchText, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmacsApi.ApiSmacsGetWithHttpInfo: " + e.Message);
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

[**SmacResponsePaginatedResponse**](SmacResponsePaginatedResponse.md)

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

<a name="apismacsiddelete"></a>
# **ApiSmacsIdDelete**
> void ApiSmacsIdDelete (Guid id)

Deletes the specified SMAC for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSmacsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SmacsApi(config);
            var id = "id_example";  // Guid | The SMAC ID to delete

            try
            {
                // Deletes the specified SMAC for the current user.
                apiInstance.ApiSmacsIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmacsApi.ApiSmacsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSmacsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes the specified SMAC for the current user.
    apiInstance.ApiSmacsIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmacsApi.ApiSmacsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The SMAC ID to delete |  |

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
| **404** | SMAC not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apismacsidgeneratepost"></a>
# **ApiSmacsIdGeneratePost**
> System.IO.Stream ApiSmacsIdGeneratePost (Guid id, SmacGenerateRequest smacGenerateRequest = null)

Generates the SMAC QR Code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSmacsIdGeneratePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SmacsApi(config);
            var id = "id_example";  // Guid | The SMAC unique identifier
            var smacGenerateRequest = new SmacGenerateRequest(); // SmacGenerateRequest | The request parameters (optional) 

            try
            {
                // Generates the SMAC QR Code.
                System.IO.Stream result = apiInstance.ApiSmacsIdGeneratePost(id, smacGenerateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmacsApi.ApiSmacsIdGeneratePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSmacsIdGeneratePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generates the SMAC QR Code.
    ApiResponse<System.IO.Stream> response = apiInstance.ApiSmacsIdGeneratePostWithHttpInfo(id, smacGenerateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmacsApi.ApiSmacsIdGeneratePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The SMAC unique identifier |  |
| **smacGenerateRequest** | [**SmacGenerateRequest**](SmacGenerateRequest.md) | The request parameters | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apismacsidget"></a>
# **ApiSmacsIdGet**
> SmacResponse ApiSmacsIdGet (Guid id)

Gets the specific SMAC for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSmacsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SmacsApi(config);
            var id = "id_example";  // Guid | The SMAC ID to retrieve

            try
            {
                // Gets the specific SMAC for the current user.
                SmacResponse result = apiInstance.ApiSmacsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmacsApi.ApiSmacsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSmacsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the specific SMAC for the current user.
    ApiResponse<SmacResponse> response = apiInstance.ApiSmacsIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmacsApi.ApiSmacsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The SMAC ID to retrieve |  |

### Return type

[**SmacResponse**](SmacResponse.md)

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

<a name="apismacsidpngget"></a>
# **ApiSmacsIdPngGet**
> System.IO.Stream ApiSmacsIdPngGet (Guid id, int? size = null)

Downloads the SMAC QR Code as PNG.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSmacsIdPngGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SmacsApi(config);
            var id = "id_example";  // Guid | The SMAC unique identifier
            var size = 1024;  // int? | The image dimension in pixel (optional)  (default to 1024)

            try
            {
                // Downloads the SMAC QR Code as PNG.
                System.IO.Stream result = apiInstance.ApiSmacsIdPngGet(id, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmacsApi.ApiSmacsIdPngGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSmacsIdPngGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Downloads the SMAC QR Code as PNG.
    ApiResponse<System.IO.Stream> response = apiInstance.ApiSmacsIdPngGetWithHttpInfo(id, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmacsApi.ApiSmacsIdPngGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The SMAC unique identifier |  |
| **size** | **int?** | The image dimension in pixel | [optional] [default to 1024] |

### Return type

**System.IO.Stream**

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apismacsidput"></a>
# **ApiSmacsIdPut**
> void ApiSmacsIdPut (Guid id, ApiSmacsIdDeleteRequest apiSmacsIdDeleteRequest = null)

Updates the specified SMAC for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSmacsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SmacsApi(config);
            var id = "id_example";  // Guid | The SMAC ID to update
            var apiSmacsIdDeleteRequest = new ApiSmacsIdDeleteRequest(); // ApiSmacsIdDeleteRequest |  (optional) 

            try
            {
                // Updates the specified SMAC for the current user.
                apiInstance.ApiSmacsIdPut(id, apiSmacsIdDeleteRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmacsApi.ApiSmacsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSmacsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the specified SMAC for the current user.
    apiInstance.ApiSmacsIdPutWithHttpInfo(id, apiSmacsIdDeleteRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmacsApi.ApiSmacsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The SMAC ID to update |  |
| **apiSmacsIdDeleteRequest** | [**ApiSmacsIdDeleteRequest**](ApiSmacsIdDeleteRequest.md) |  | [optional]  |

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
| **404** | SMAC not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apismacsidsvgget"></a>
# **ApiSmacsIdSvgGet**
> System.IO.Stream ApiSmacsIdSvgGet (Guid id)

Downloads the SMAC QR Code as SVG.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSmacsIdSvgGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SmacsApi(config);
            var id = "id_example";  // Guid | The SMAC unique identifier

            try
            {
                // Downloads the SMAC QR Code as SVG.
                System.IO.Stream result = apiInstance.ApiSmacsIdSvgGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmacsApi.ApiSmacsIdSvgGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSmacsIdSvgGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Downloads the SMAC QR Code as SVG.
    ApiResponse<System.IO.Stream> response = apiInstance.ApiSmacsIdSvgGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmacsApi.ApiSmacsIdSvgGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The SMAC unique identifier |  |

### Return type

**System.IO.Stream**

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apismacspost"></a>
# **ApiSmacsPost**
> SmacResponse ApiSmacsPost (SmacPostRequest smacPostRequest = null)

Creates a new SMAC for the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiSmacsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SmacsApi(config);
            var smacPostRequest = new SmacPostRequest(); // SmacPostRequest |  (optional) 

            try
            {
                // Creates a new SMAC for the current user.
                SmacResponse result = apiInstance.ApiSmacsPost(smacPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmacsApi.ApiSmacsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiSmacsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new SMAC for the current user.
    ApiResponse<SmacResponse> response = apiInstance.ApiSmacsPostWithHttpInfo(smacPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmacsApi.ApiSmacsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smacPostRequest** | [**SmacPostRequest**](SmacPostRequest.md) |  | [optional]  |

### Return type

[**SmacResponse**](SmacResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly created SMAC |  -  |
| **400** | Invalid parameter |  -  |
| **401** | Unauthorized access |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

