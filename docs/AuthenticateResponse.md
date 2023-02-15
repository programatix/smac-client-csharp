# Org.OpenAPITools.Model.AuthenticateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **Guid** | The user identifier | [optional] 
**Email** | **string** | The user email address | [optional] 
**Roles** | **List&lt;string&gt;** | The user roles | [optional] 
**Token** | **string** | The access token to be used when calling APIs | 
**TokenType** | **string** | The access token type | [optional] 
**Expires** | **int** |  | [optional] 
**ValidUntil** | **DateTime** | The expiry date-time in notation as defined by RFC 3339, section 5.6, for example, &lt;em&gt;2017-07-21T17:32:28Z&lt;/em&gt; | [optional] 
**RefreshToken** | **string** | The refresh token (It is used to retrieve new access token via &lt;a href&#x3D;\&quot;#operations-Users-post_api_Users_refresh_token\&quot;&gt;/api/Users/refresh-token&lt;/a&gt;.) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

