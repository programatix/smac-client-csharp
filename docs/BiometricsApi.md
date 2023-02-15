# Org.OpenAPITools.Api.BiometricsApi

All URIs are relative to *https://smac-poc.mcs-group.com.my/*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBiometricsFacePhotoPost**](BiometricsApi.md#apibiometricsfacephotopost) | **POST** /api/Biometrics/facePhoto | Retrieves the facial photo |
| [**ApiBiometricsUtilsCropFacePost**](BiometricsApi.md#apibiometricsutilscropfacepost) | **POST** /api/Biometrics/utils/cropFace | Crops the face from the given image. |
| [**ApiBiometricsUtilsExtractFacePost**](BiometricsApi.md#apibiometricsutilsextractfacepost) | **POST** /api/Biometrics/utils/extractFace | Extracts the biometric face template from the given image. |
| [**ApiBiometricsUtilsExtractFingerPost**](BiometricsApi.md#apibiometricsutilsextractfingerpost) | **POST** /api/Biometrics/utils/extractFinger | Extracts the biometric finger template from the given image. |
| [**ApiBiometricsUtilsExtractIrisPost**](BiometricsApi.md#apibiometricsutilsextractirispost) | **POST** /api/Biometrics/utils/extractIris | Extracts the biometric iris template from the given image. |
| [**ApiBiometricsUtilsVerifyFacePost**](BiometricsApi.md#apibiometricsutilsverifyfacepost) | **POST** /api/Biometrics/utils/verifyFace | Performs face verification. |
| [**ApiBiometricsUtilsVerifyFingerPost**](BiometricsApi.md#apibiometricsutilsverifyfingerpost) | **POST** /api/Biometrics/utils/verifyFinger | Performs finger verification. |
| [**ApiBiometricsUtilsVerifyIrisPost**](BiometricsApi.md#apibiometricsutilsverifyirispost) | **POST** /api/Biometrics/utils/verifyIris | Performs iris verification. |
| [**ApiBiometricsVerifyFacePost**](BiometricsApi.md#apibiometricsverifyfacepost) | **POST** /api/Biometrics/verifyFace | Performs face verification of the user provided in the request parameters. |
| [**ApiBiometricsVerifyFingerPost**](BiometricsApi.md#apibiometricsverifyfingerpost) | **POST** /api/Biometrics/verifyFinger | Performs finger verification of the user provided in the request parameters. |
| [**ApiBiometricsVerifyIrisPost**](BiometricsApi.md#apibiometricsverifyirispost) | **POST** /api/Biometrics/verifyIris | Performs iris verification of the user provided in the request parameters. |

<a name="apibiometricsfacephotopost"></a>
# **ApiBiometricsFacePhotoPost**
> FacePhotoResponse ApiBiometricsFacePhotoPost (FacePhotoRequest facePhotoRequest = null)

Retrieves the facial photo

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsFacePhotoPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var facePhotoRequest = new FacePhotoRequest(); // FacePhotoRequest |  (optional) 

            try
            {
                // Retrieves the facial photo
                FacePhotoResponse result = apiInstance.ApiBiometricsFacePhotoPost(facePhotoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsFacePhotoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsFacePhotoPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the facial photo
    ApiResponse<FacePhotoResponse> response = apiInstance.ApiBiometricsFacePhotoPostWithHttpInfo(facePhotoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsFacePhotoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **facePhotoRequest** | [**FacePhotoRequest**](FacePhotoRequest.md) |  | [optional]  |

### Return type

[**FacePhotoResponse**](FacePhotoResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsutilscropfacepost"></a>
# **ApiBiometricsUtilsCropFacePost**
> CropResponse ApiBiometricsUtilsCropFacePost (CropRequest cropRequest = null)

Crops the face from the given image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsUtilsCropFacePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var cropRequest = new CropRequest(); // CropRequest | The request parameters (optional) 

            try
            {
                // Crops the face from the given image.
                CropResponse result = apiInstance.ApiBiometricsUtilsCropFacePost(cropRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsCropFacePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsUtilsCropFacePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Crops the face from the given image.
    ApiResponse<CropResponse> response = apiInstance.ApiBiometricsUtilsCropFacePostWithHttpInfo(cropRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsCropFacePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cropRequest** | [**CropRequest**](CropRequest.md) | The request parameters | [optional]  |

### Return type

[**CropResponse**](CropResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsutilsextractfacepost"></a>
# **ApiBiometricsUtilsExtractFacePost**
> ExtractResponse ApiBiometricsUtilsExtractFacePost (ExtractRequest extractRequest = null)

Extracts the biometric face template from the given image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsUtilsExtractFacePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var extractRequest = new ExtractRequest(); // ExtractRequest | The request parameters (optional) 

            try
            {
                // Extracts the biometric face template from the given image.
                ExtractResponse result = apiInstance.ApiBiometricsUtilsExtractFacePost(extractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsExtractFacePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsUtilsExtractFacePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extracts the biometric face template from the given image.
    ApiResponse<ExtractResponse> response = apiInstance.ApiBiometricsUtilsExtractFacePostWithHttpInfo(extractRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsExtractFacePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **extractRequest** | [**ExtractRequest**](ExtractRequest.md) | The request parameters | [optional]  |

### Return type

[**ExtractResponse**](ExtractResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsutilsextractfingerpost"></a>
# **ApiBiometricsUtilsExtractFingerPost**
> ExtractResponse ApiBiometricsUtilsExtractFingerPost (ExtractRequest extractRequest = null)

Extracts the biometric finger template from the given image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsUtilsExtractFingerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var extractRequest = new ExtractRequest(); // ExtractRequest | The request parameters (optional) 

            try
            {
                // Extracts the biometric finger template from the given image.
                ExtractResponse result = apiInstance.ApiBiometricsUtilsExtractFingerPost(extractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsExtractFingerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsUtilsExtractFingerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extracts the biometric finger template from the given image.
    ApiResponse<ExtractResponse> response = apiInstance.ApiBiometricsUtilsExtractFingerPostWithHttpInfo(extractRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsExtractFingerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **extractRequest** | [**ExtractRequest**](ExtractRequest.md) | The request parameters | [optional]  |

### Return type

[**ExtractResponse**](ExtractResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsutilsextractirispost"></a>
# **ApiBiometricsUtilsExtractIrisPost**
> ExtractResponse ApiBiometricsUtilsExtractIrisPost (ExtractRequest extractRequest = null)

Extracts the biometric iris template from the given image.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsUtilsExtractIrisPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var extractRequest = new ExtractRequest(); // ExtractRequest | The request parameters (optional) 

            try
            {
                // Extracts the biometric iris template from the given image.
                ExtractResponse result = apiInstance.ApiBiometricsUtilsExtractIrisPost(extractRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsExtractIrisPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsUtilsExtractIrisPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extracts the biometric iris template from the given image.
    ApiResponse<ExtractResponse> response = apiInstance.ApiBiometricsUtilsExtractIrisPostWithHttpInfo(extractRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsExtractIrisPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **extractRequest** | [**ExtractRequest**](ExtractRequest.md) | The request parameters | [optional]  |

### Return type

[**ExtractResponse**](ExtractResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsutilsverifyfacepost"></a>
# **ApiBiometricsUtilsVerifyFacePost**
> VerifyResponse ApiBiometricsUtilsVerifyFacePost (VerifyRequest verifyRequest = null)

Performs face verification.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsUtilsVerifyFacePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var verifyRequest = new VerifyRequest(); // VerifyRequest | The request parameters (optional) 

            try
            {
                // Performs face verification.
                VerifyResponse result = apiInstance.ApiBiometricsUtilsVerifyFacePost(verifyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsVerifyFacePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsUtilsVerifyFacePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs face verification.
    ApiResponse<VerifyResponse> response = apiInstance.ApiBiometricsUtilsVerifyFacePostWithHttpInfo(verifyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsVerifyFacePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verifyRequest** | [**VerifyRequest**](VerifyRequest.md) | The request parameters | [optional]  |

### Return type

[**VerifyResponse**](VerifyResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsutilsverifyfingerpost"></a>
# **ApiBiometricsUtilsVerifyFingerPost**
> VerifyResponse ApiBiometricsUtilsVerifyFingerPost (VerifyRequest verifyRequest = null)

Performs finger verification.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsUtilsVerifyFingerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var verifyRequest = new VerifyRequest(); // VerifyRequest | The request parameters (optional) 

            try
            {
                // Performs finger verification.
                VerifyResponse result = apiInstance.ApiBiometricsUtilsVerifyFingerPost(verifyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsVerifyFingerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsUtilsVerifyFingerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs finger verification.
    ApiResponse<VerifyResponse> response = apiInstance.ApiBiometricsUtilsVerifyFingerPostWithHttpInfo(verifyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsVerifyFingerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verifyRequest** | [**VerifyRequest**](VerifyRequest.md) | The request parameters | [optional]  |

### Return type

[**VerifyResponse**](VerifyResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsutilsverifyirispost"></a>
# **ApiBiometricsUtilsVerifyIrisPost**
> VerifyResponse ApiBiometricsUtilsVerifyIrisPost (VerifyRequest verifyRequest = null)

Performs iris verification.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsUtilsVerifyIrisPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var verifyRequest = new VerifyRequest(); // VerifyRequest | The request parameters (optional) 

            try
            {
                // Performs iris verification.
                VerifyResponse result = apiInstance.ApiBiometricsUtilsVerifyIrisPost(verifyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsVerifyIrisPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsUtilsVerifyIrisPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs iris verification.
    ApiResponse<VerifyResponse> response = apiInstance.ApiBiometricsUtilsVerifyIrisPostWithHttpInfo(verifyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsUtilsVerifyIrisPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verifyRequest** | [**VerifyRequest**](VerifyRequest.md) | The request parameters | [optional]  |

### Return type

[**VerifyResponse**](VerifyResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsverifyfacepost"></a>
# **ApiBiometricsVerifyFacePost**
> List&lt;VerifyResponse&gt; ApiBiometricsVerifyFacePost (Guid userId, List<FaceTypesVerifyContent> contents)

Performs face verification of the user provided in the request parameters.

This method is meant to be used in a HTML form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsVerifyFacePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var userId = "userId_example";  // Guid | The user identifier to verify against
            var contents = new List<FaceTypesVerifyContent>(); // List<FaceTypesVerifyContent> | The probe images to verify with

            try
            {
                // Performs face verification of the user provided in the request parameters.
                List<VerifyResponse> result = apiInstance.ApiBiometricsVerifyFacePost(userId, contents);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsVerifyFacePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsVerifyFacePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs face verification of the user provided in the request parameters.
    ApiResponse<List<VerifyResponse>> response = apiInstance.ApiBiometricsVerifyFacePostWithHttpInfo(userId, contents);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsVerifyFacePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | The user identifier to verify against |  |
| **contents** | [**List&lt;FaceTypesVerifyContent&gt;**](FaceTypesVerifyContent.md) | The probe images to verify with |  |

### Return type

[**List&lt;VerifyResponse&gt;**](VerifyResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsverifyfingerpost"></a>
# **ApiBiometricsVerifyFingerPost**
> List&lt;VerifyResponse&gt; ApiBiometricsVerifyFingerPost (Guid userId, List<FingerTypesVerifyContent> contents)

Performs finger verification of the user provided in the request parameters.

This method is meant to be used in a HTML form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsVerifyFingerPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var userId = "userId_example";  // Guid | The user identifier to verify against
            var contents = new List<FingerTypesVerifyContent>(); // List<FingerTypesVerifyContent> | The probe images to verify with

            try
            {
                // Performs finger verification of the user provided in the request parameters.
                List<VerifyResponse> result = apiInstance.ApiBiometricsVerifyFingerPost(userId, contents);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsVerifyFingerPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsVerifyFingerPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs finger verification of the user provided in the request parameters.
    ApiResponse<List<VerifyResponse>> response = apiInstance.ApiBiometricsVerifyFingerPostWithHttpInfo(userId, contents);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsVerifyFingerPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | The user identifier to verify against |  |
| **contents** | [**List&lt;FingerTypesVerifyContent&gt;**](FingerTypesVerifyContent.md) | The probe images to verify with |  |

### Return type

[**List&lt;VerifyResponse&gt;**](VerifyResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apibiometricsverifyirispost"></a>
# **ApiBiometricsVerifyIrisPost**
> List&lt;VerifyResponse&gt; ApiBiometricsVerifyIrisPost (Guid userId, List<IrisTypesVerifyContent> contents)

Performs iris verification of the user provided in the request parameters.

This method is meant to be used in a HTML form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiBiometricsVerifyIrisPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure API key authorization: apiKey
            config.AddApiKey("X-SMAC-PLATFORM-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-SMAC-PLATFORM-API-KEY", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BiometricsApi(config);
            var userId = "userId_example";  // Guid | The user identifier to verify against
            var contents = new List<IrisTypesVerifyContent>(); // List<IrisTypesVerifyContent> | The probe images to verify with

            try
            {
                // Performs iris verification of the user provided in the request parameters.
                List<VerifyResponse> result = apiInstance.ApiBiometricsVerifyIrisPost(userId, contents);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BiometricsApi.ApiBiometricsVerifyIrisPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBiometricsVerifyIrisPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs iris verification of the user provided in the request parameters.
    ApiResponse<List<VerifyResponse>> response = apiInstance.ApiBiometricsVerifyIrisPostWithHttpInfo(userId, contents);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BiometricsApi.ApiBiometricsVerifyIrisPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | The user identifier to verify against |  |
| **contents** | [**List&lt;IrisTypesVerifyContent&gt;**](IrisTypesVerifyContent.md) | The probe images to verify with |  |

### Return type

[**List&lt;VerifyResponse&gt;**](VerifyResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

