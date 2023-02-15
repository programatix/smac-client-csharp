# Org.OpenAPITools.Model.EmailRule
An email rule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedEmails** | **string** | A comma or semicolon separated string defining the allowed emails (The allowed email take precedents if its domain is black-listed.) | [optional] 
**BlockedEmails** | **string** | A comma or semicolon separated string defining the blocked emails (The blocked email take precedents if its domain is white-listed.) | [optional] 
**DomainWhiteList** | **string** | A comma or semicolon separated string defining the white-listed domains (The blocked email take precedents if its domain is white-listed.) | [optional] 
**DomainBlackList** | **string** | A comma or semicolon separated string defining the black-listed domains (The allowed email take precedents if its domain is black-listed.) | [optional] 
**Type** | **string** | Defines the type of the rule | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

