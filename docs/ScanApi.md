# Org.OpenAPITools.Api.ScanApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiScanContentListPost**](ScanApi.md#apiscancontentlistpost) | **POST** /api/Scan/content-list | Retrieves the SMAC content list. |
| [**ApiScanContentPost**](ScanApi.md#apiscancontentpost) | **POST** /api/Scan/content | Retrieves the SMAC content. |

<a name="apiscancontentlistpost"></a>
# **ApiScanContentListPost**
> ScanContentListResponse ApiScanContentListPost (ScanContentListRequest scanContentListRequest = null)

Retrieves the SMAC content list.

This API should be followed up by <a href=\"#operations-Scan-post_api_Scan_content\">/api/Scan/content</a>.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiScanContentListPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ScanApi(config);
            var scanContentListRequest = new ScanContentListRequest(); // ScanContentListRequest |  (optional) 

            try
            {
                // Retrieves the SMAC content list.
                ScanContentListResponse result = apiInstance.ApiScanContentListPost(scanContentListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ApiScanContentListPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiScanContentListPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the SMAC content list.
    ApiResponse<ScanContentListResponse> response = apiInstance.ApiScanContentListPostWithHttpInfo(scanContentListRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanApi.ApiScanContentListPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scanContentListRequest** | [**ScanContentListRequest**](ScanContentListRequest.md) |  | [optional]  |

### Return type

[**ScanContentListResponse**](ScanContentListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |
| **400** | Invalid request |  -  |
| **403** | Forbidden or spoofing detected |  -  |
| **404** | The id provided is not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiscancontentpost"></a>
# **ApiScanContentPost**
> ScanContentResponse ApiScanContentPost (ScanContentRequest scanContentRequest = null)

Retrieves the SMAC content.

Before calling this API, <a href=\"#operations-Scan-post_api_Scan_content_list\">/api/Scan/content-list</a> must be called first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiScanContentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ScanApi(config);
            var scanContentRequest = new ScanContentRequest(); // ScanContentRequest |  (optional) 

            try
            {
                // Retrieves the SMAC content.
                ScanContentResponse result = apiInstance.ApiScanContentPost(scanContentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ApiScanContentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiScanContentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the SMAC content.
    ApiResponse<ScanContentResponse> response = apiInstance.ApiScanContentPostWithHttpInfo(scanContentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScanApi.ApiScanContentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scanContentRequest** | [**ScanContentRequest**](ScanContentRequest.md) |  | [optional]  |

### Return type

[**ScanContentResponse**](ScanContentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List retrieved |  -  |
| **400** | Invalid request |  -  |
| **403** | Forbidden |  -  |
| **404** | The id provided is not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

