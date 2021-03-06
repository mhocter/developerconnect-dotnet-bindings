# Elli.Api.Contacts.Model.BorrowerFieldDefinitionContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FilterOnly** | **bool?** | This field is true when corresponding canonical field can be used only for filtering the contact. And is false, when corresponding canonical field can be used only for Selection and Sort | [optional] 
**Category** | **string** | Category of a field like Borrower Contact, Opportunity, Recent Events, Appointments, Loan, Trade, Milestone, Loan Folder, Pipeline, etc.  | [optional] 
**Description** | **string** | This is a detailed explanation what field represents | [optional] 
**CanonicalName** | **string** | Canonical name of field | [optional] 
**DataType** | **string** | Type of a field like Integer, String, YN(checkbox), Datetime, etc. | [optional] 
**DataSource** | **string** | Source of field Loan or BorrowerContact. | [optional] 
**MaxLength** | **int?** | If dataType is string,represents number of characters allowed | [optional] 
**Options** | **List&lt;string&gt;** | Represents possible options for field values | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

