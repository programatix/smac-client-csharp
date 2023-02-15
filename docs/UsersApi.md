# Org.OpenAPITools.Api.UsersApi

All URIs are relative to *https://smac-poc.mcs-group.com.my/*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiUsersAssociatedSmacsGet**](UsersApi.md#apiusersassociatedsmacsget) | **GET** /api/Users/associated-smacs | Gets the SMACs associated with the user. |
| [**ApiUsersAuthenticatePost**](UsersApi.md#apiusersauthenticatepost) | **POST** /api/Users/authenticate | Performs user authentication. |
| [**ApiUsersForgotPasswordPost**](UsersApi.md#apiusersforgotpasswordpost) | **POST** /api/Users/forgot-password | Initiates password reset procedure. |
| [**ApiUsersRefreshTokenPost**](UsersApi.md#apiusersrefreshtokenpost) | **POST** /api/Users/refresh-token | Retrieves new access token. |
| [**ApiUsersRegisterPost**](UsersApi.md#apiusersregisterpost) | **POST** /api/Users/register | Register an account. |
| [**ApiUsersResendEmailConfirmationPost**](UsersApi.md#apiusersresendemailconfirmationpost) | **POST** /api/Users/resend-email-confirmation | Resend email confirmation. |
| [**ApiUsersRevokeTokenPost**](UsersApi.md#apiusersrevoketokenpost) | **POST** /api/Users/revoke-token | Revokes a refresh token. |
| [**ApiUsersRolesPost**](UsersApi.md#apiusersrolespost) | **POST** /api/Users/roles | Gets the authenticated user&#39;s roles. |
| [**ApiUsersUploadProfilePhotoPost**](UsersApi.md#apiusersuploadprofilephotopost) | **POST** /api/Users/upload-profile-photo | Uploads current user profile photo. |
| [**ApiUsersUserProfilePost**](UsersApi.md#apiusersuserprofilepost) | **POST** /api/Users/user-profile | Gets the current user profile. |

<a name="apiusersassociatedsmacsget"></a>
# **ApiUsersAssociatedSmacsGet**
> AssociatedSmacsResponse ApiUsersAssociatedSmacsGet ()

Gets the SMACs associated with the user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersAssociatedSmacsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UsersApi(config);

            try
            {
                // Gets the SMACs associated with the user.
                AssociatedSmacsResponse result = apiInstance.ApiUsersAssociatedSmacsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersAssociatedSmacsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersAssociatedSmacsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the SMACs associated with the user.
    ApiResponse<AssociatedSmacsResponse> response = apiInstance.ApiUsersAssociatedSmacsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersAssociatedSmacsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AssociatedSmacsResponse**](AssociatedSmacsResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersauthenticatepost"></a>
# **ApiUsersAuthenticatePost**
> AuthenticateResponse ApiUsersAuthenticatePost (AuthenticateRequest authenticateRequest = null)

Performs user authentication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersAuthenticatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            var apiInstance = new UsersApi(config);
            var authenticateRequest = new AuthenticateRequest(); // AuthenticateRequest |  (optional) 

            try
            {
                // Performs user authentication.
                AuthenticateResponse result = apiInstance.ApiUsersAuthenticatePost(authenticateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersAuthenticatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersAuthenticatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Performs user authentication.
    ApiResponse<AuthenticateResponse> response = apiInstance.ApiUsersAuthenticatePostWithHttpInfo(authenticateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersAuthenticatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authenticateRequest** | [**AuthenticateRequest**](AuthenticateRequest.md) |  | [optional]  |

### Return type

[**AuthenticateResponse**](AuthenticateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Authenticated |  -  |
| **400** | Incorrect credential provided |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersforgotpasswordpost"></a>
# **ApiUsersForgotPasswordPost**
> string ApiUsersForgotPasswordPost (EmailRequest emailRequest = null)

Initiates password reset procedure.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersForgotPasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            var apiInstance = new UsersApi(config);
            var emailRequest = new EmailRequest(); // EmailRequest |  (optional) 

            try
            {
                // Initiates password reset procedure.
                string result = apiInstance.ApiUsersForgotPasswordPost(emailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersForgotPasswordPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersForgotPasswordPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Initiates password reset procedure.
    ApiResponse<string> response = apiInstance.ApiUsersForgotPasswordPostWithHttpInfo(emailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersForgotPasswordPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailRequest** | [**EmailRequest**](EmailRequest.md) |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersrefreshtokenpost"></a>
# **ApiUsersRefreshTokenPost**
> AuthenticateResponse ApiUsersRefreshTokenPost (RefreshTokenRequest refreshTokenRequest = null)

Retrieves new access token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersRefreshTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            var apiInstance = new UsersApi(config);
            var refreshTokenRequest = new RefreshTokenRequest(); // RefreshTokenRequest |  (optional) 

            try
            {
                // Retrieves new access token.
                AuthenticateResponse result = apiInstance.ApiUsersRefreshTokenPost(refreshTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersRefreshTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersRefreshTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves new access token.
    ApiResponse<AuthenticateResponse> response = apiInstance.ApiUsersRefreshTokenPostWithHttpInfo(refreshTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersRefreshTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refreshTokenRequest** | [**RefreshTokenRequest**](RefreshTokenRequest.md) |  | [optional]  |

### Return type

[**AuthenticateResponse**](AuthenticateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Refresh token expired |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersregisterpost"></a>
# **ApiUsersRegisterPost**
> string ApiUsersRegisterPost (RegisterRequest registerRequest = null)

Register an account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersRegisterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            var apiInstance = new UsersApi(config);
            var registerRequest = new RegisterRequest(); // RegisterRequest |  (optional) 

            try
            {
                // Register an account.
                string result = apiInstance.ApiUsersRegisterPost(registerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersRegisterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersRegisterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register an account.
    ApiResponse<string> response = apiInstance.ApiUsersRegisterPostWithHttpInfo(registerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersRegisterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registerRequest** | [**RegisterRequest**](RegisterRequest.md) |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersresendemailconfirmationpost"></a>
# **ApiUsersResendEmailConfirmationPost**
> string ApiUsersResendEmailConfirmationPost (EmailRequest emailRequest = null)

Resend email confirmation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersResendEmailConfirmationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            var apiInstance = new UsersApi(config);
            var emailRequest = new EmailRequest(); // EmailRequest |  (optional) 

            try
            {
                // Resend email confirmation.
                string result = apiInstance.ApiUsersResendEmailConfirmationPost(emailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersResendEmailConfirmationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersResendEmailConfirmationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resend email confirmation.
    ApiResponse<string> response = apiInstance.ApiUsersResendEmailConfirmationPostWithHttpInfo(emailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersResendEmailConfirmationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailRequest** | [**EmailRequest**](EmailRequest.md) |  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersrevoketokenpost"></a>
# **ApiUsersRevokeTokenPost**
> string ApiUsersRevokeTokenPost (RevokeTokenRequest revokeTokenRequest = null)

Revokes a refresh token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersRevokeTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UsersApi(config);
            var revokeTokenRequest = new RevokeTokenRequest(); // RevokeTokenRequest |  (optional) 

            try
            {
                // Revokes a refresh token.
                string result = apiInstance.ApiUsersRevokeTokenPost(revokeTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersRevokeTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersRevokeTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Revokes a refresh token.
    ApiResponse<string> response = apiInstance.ApiUsersRevokeTokenPostWithHttpInfo(revokeTokenRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersRevokeTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **revokeTokenRequest** | [**RevokeTokenRequest**](RevokeTokenRequest.md) |  | [optional]  |

### Return type

**string**

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersrolespost"></a>
# **ApiUsersRolesPost**
> List&lt;string&gt; ApiUsersRolesPost ()

Gets the authenticated user's roles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersRolesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UsersApi(config);

            try
            {
                // Gets the authenticated user's roles.
                List<string> result = apiInstance.ApiUsersRolesPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersRolesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersRolesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the authenticated user's roles.
    ApiResponse<List<string>> response = apiInstance.ApiUsersRolesPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersRolesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersuploadprofilephotopost"></a>
# **ApiUsersUploadProfilePhotoPost**
> UploadPhotoResponse ApiUsersUploadProfilePhotoPost (UploadPhotoRequest uploadPhotoRequest = null)

Uploads current user profile photo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersUploadProfilePhotoPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UsersApi(config);
            var uploadPhotoRequest = new UploadPhotoRequest(); // UploadPhotoRequest | The request parameters (optional) 

            try
            {
                // Uploads current user profile photo.
                UploadPhotoResponse result = apiInstance.ApiUsersUploadProfilePhotoPost(uploadPhotoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersUploadProfilePhotoPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUploadProfilePhotoPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Uploads current user profile photo.
    ApiResponse<UploadPhotoResponse> response = apiInstance.ApiUsersUploadProfilePhotoPostWithHttpInfo(uploadPhotoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersUploadProfilePhotoPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadPhotoRequest** | [**UploadPhotoRequest**](UploadPhotoRequest.md) | The request parameters | [optional]  |

### Return type

[**UploadPhotoResponse**](UploadPhotoResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiusersuserprofilepost"></a>
# **ApiUsersUserProfilePost**
> UserProfileResponse ApiUsersUserProfilePost ()

Gets the current user profile.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUsersUserProfilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://smac-poc.mcs-group.com.my/";
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UsersApi(config);

            try
            {
                // Gets the current user profile.
                UserProfileResponse result = apiInstance.ApiUsersUserProfilePost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ApiUsersUserProfilePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersUserProfilePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the current user profile.
    ApiResponse<UserProfileResponse> response = apiInstance.ApiUsersUserProfilePostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ApiUsersUserProfilePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserProfileResponse**](UserProfileResponse.md)

### Authorization

[bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

