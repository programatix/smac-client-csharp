# Org.OpenAPITools.Api.OAuthApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiOAuthVerifyTokenPost**](OAuthApi.md#apioauthverifytokenpost) | **POST** /api/OAuth/verify-token | Verifies token issued by SMAC for OAuth purposes. |

<a name="apioauthverifytokenpost"></a>
# **ApiOAuthVerifyTokenPost**
> VerifyTokenResponse ApiOAuthVerifyTokenPost (VerifyTokenRequest verifyTokenRequest = null)

Verifies token issued by SMAC for OAuth purposes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiOAuthVerifyTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");

            var apiInstance = new OAuthApi(config);
            var verifyTokenRequest = new VerifyTokenRequest(); // VerifyTokenRequest |  (optional) 

            try
            {
                // Verifies token issued by SMAC for OAuth purposes.
                VerifyTokenResponse result = apiInstance.ApiOAuthVerifyTokenPost(verifyTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.ApiOAuthVerifyTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiOAuthVerifyTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verifies token issued by SMAC for OAuth purposes.
    ApiResponse<VerifyTokenResponse> response = apiInstance.ApiOAuthVerifyTokenPostWithHttpInfo(verifyTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuthApi.ApiOAuthVerifyTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verifyTokenRequest** | [**VerifyTokenRequest**](VerifyTokenRequest.md) |  | [optional]  |

### Return type

[**VerifyTokenResponse**](VerifyTokenResponse.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Verification performed. See &lt;em&gt;status&lt;/em&gt; of &lt;a href&#x3D;\&quot;#model-VerifyTokenResponse\&quot;&gt;VerifyTokenResponse&lt;/a&gt; for result. |  -  |
| **400** |  |  -  |
| **401** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

