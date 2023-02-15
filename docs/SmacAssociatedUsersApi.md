# Org.OpenAPITools.Api.SmacAssociatedUsersApi

All URIs are relative to *https://smac-poc.mcs-group.com.my/*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SmacAssociatedUsersIdGet**](SmacAssociatedUsersApi.md#smacassociatedusersidget) | **GET** /SmacAssociatedUsers/{id} |  |

<a name="smacassociatedusersidget"></a>
# **SmacAssociatedUsersIdGet**
> void SmacAssociatedUsersIdGet (Guid id, string returnUrl = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SmacAssociatedUsersIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            var apiInstance = new SmacAssociatedUsersApi(config);
            var id = "id_example";  // Guid | 
            var returnUrl = "returnUrl_example";  // string |  (optional) 

            try
            {
                apiInstance.SmacAssociatedUsersIdGet(id, returnUrl);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SmacAssociatedUsersApi.SmacAssociatedUsersIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmacAssociatedUsersIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SmacAssociatedUsersIdGetWithHttpInfo(id, returnUrl);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SmacAssociatedUsersApi.SmacAssociatedUsersIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **returnUrl** | **string** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

