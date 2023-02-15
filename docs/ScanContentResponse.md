# Org.OpenAPITools.Model.ScanContentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The dataset name | [optional] 
**CodeId** | **Guid** | The SMAC identifier | [optional] 
**PayloadType** | **string** | The payload type    The value can be:  - Image  - Url  - Contact | [optional] 
**PayloadName** | **string** | The payload name | [optional] 
**Payload** | **string** | The payload content | [optional] 
**Token** | **string** | The access token containing the information on the scan (The access token is used to identify the scanner and the payload.  It should be transmitted to the recipient if traffic need to be  redirected. This is especially true for URL Payload.  The recipient should call &lt;a href&#x3D;\&quot;#operations-OAuth-post_api_OAuth_verify_token\&quot;&gt;/api/OAuth/verify-token&lt;/a&gt;  to validate the token before consuming it.) | [optional] 
**IsUseExternalBrowser** | **bool** | A flag indicating whether an external browser should be used | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

