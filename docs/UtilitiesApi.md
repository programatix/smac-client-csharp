# Org.OpenAPITools.Api.UtilitiesApi

All URIs are relative to *https://smac-poc.mcs-group.com.my/*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiUtilitiesPingGet**](UtilitiesApi.md#apiutilitiespingget) | **GET** /api/Utilities/ping | Checks if the service is alive. |
| [**ApiUtilitiesVersionGet**](UtilitiesApi.md#apiutilitiesversionget) | **GET** /api/Utilities/version | Retrieve the service version. |

<a name="apiutilitiespingget"></a>
# **ApiUtilitiesPingGet**
> PingResponse ApiUtilitiesPingGet ()

Checks if the service is alive.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUtilitiesPingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");

            var apiInstance = new UtilitiesApi(config);

            try
            {
                // Checks if the service is alive.
                PingResponse result = apiInstance.ApiUtilitiesPingGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilitiesApi.ApiUtilitiesPingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUtilitiesPingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks if the service is alive.
    ApiResponse<PingResponse> response = apiInstance.ApiUtilitiesPingGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UtilitiesApi.ApiUtilitiesPingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PingResponse**](PingResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiutilitiesversionget"></a>
# **ApiUtilitiesVersionGet**
> VersionResponse ApiUtilitiesVersionGet ()

Retrieve the service version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUtilitiesVersionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");

            var apiInstance = new UtilitiesApi(config);

            try
            {
                // Retrieve the service version.
                VersionResponse result = apiInstance.ApiUtilitiesVersionGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilitiesApi.ApiUtilitiesVersionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUtilitiesVersionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve the service version.
    ApiResponse<VersionResponse> response = apiInstance.ApiUtilitiesVersionGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UtilitiesApi.ApiUtilitiesVersionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**VersionResponse**](VersionResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

