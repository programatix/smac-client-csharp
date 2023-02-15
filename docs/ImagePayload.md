# Org.OpenAPITools.Model.ImagePayload
A payload containing an image

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Payload** | **byte[]** | The image binary | 
**ContentType** | **string** | A string representing the media type of the resource (A check is performed to validate the correctness of the provided  content type against the actual image. If the check failed, a bad  request error will be returned.)    The value can be:  - image/jpeg  - image/png  - image/gif  - image/svg | [optional] 
**IsUseExternalBrowser** | **bool** | A flag indicating whether to display the image in an external browser | [optional] 
**Type** | **string** | Defines the type of the payload | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

