# PIStreamSummaries

## Properties
Name | Type | Notes
------------ | ------------- | -------------
**WebId** | **string**
**Name** | **string**
**Path** | **string**
**Items** | **[**PISummaryValue[]**](../Model/PISummaryValue.md)**
**Links** | **[**PIStreamSummariesLinks**](../Model/PIStreamSummariesLinks.md)**
**WebException** | **[**PIWebException**](../Model/PIWebException.md)**

## Methods

# **SetItem**
> void SetItem(int i, PISummaryValue values)

Set an item of the Items array.

### Parameters

Name | Type
------------- | -------------
 **i** | **int**
 **values** | **PISummaryValue**

### Return type

void


# **GetItem**
> PISummaryValue GetItem(int i)

Get item of the Items array.

### Parameters

Name | Type
------------- | -------------
 **i** | **int**

### Return type

PISummaryValue


# **GetItemsLength**
> int GetItemsLength()

Get the length of the Items array.


### Return type

int


# **CreateItemsArray**
> void CreateItemsArray(int i)

Create an array on the Items property.

### Parameters

Name | Type
------------- | -------------
 **i** | **int**

### Return type

void

[[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
