# Org.OpenAPITools.Model.DateTimeRule
A date time rule. The date and time are in UTC.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BegDate** | **DateTime?** | The begin date in UTC | [optional] 
**BegTime** | **string** | The begin time in UTC | [optional] 
**EndDate** | **DateTime?** | The end date in UTC | [optional] 
**EndTime** | **string** | The end time in UTC | [optional] 
**IsIgnoreTimeZone** | **bool?** | A flag indicating whether to ignore time zone. (If the flag is set, time zone is ignored for Scan API. For example, if the BegTime is set to 9am to 5pm, this rule is valid from 9am to 5pm no matter where it is scanned from.) | [optional] 
**Type** | **string** | Defines the type of the rule | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

