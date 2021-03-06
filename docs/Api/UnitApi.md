# UnitApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](UnitApi.md#getbypath) | **GET** /units | Retrieve a unit by path.
[**GetByPathWithHttpInfo**](UnitApi.md#getbypathwithhttpinfo) | **GET** /units | Retrieve a unit by path.
[**Get**](UnitApi.md#get) | **GET** /units/{webId} | Retrieve a unit.
[**GetWithHttpInfo**](UnitApi.md#getwithhttpinfo) | **GET** /units/{webId} | Retrieve a unit.
[**Update**](UnitApi.md#update) | **PATCH** /units/{webId} | Update a unit.
[**UpdateWithHttpInfo**](UnitApi.md#updatewithhttpinfo) | **PATCH** /units/{webId} | Update a unit.
[**Delete**](UnitApi.md#delete) | **DELETE** /units/{webId} | Delete a unit.
[**DeleteWithHttpInfo**](UnitApi.md#deletewithhttpinfo) | **DELETE** /units/{webId} | Delete a unit.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null)

Retrieve a unit by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the unit.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIUnit**](../Response/ApiResponsePIUnit.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null, string webIdType = null)

Retrieve a unit by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the unit.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIUnit**](../Model/PIUnit.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)

Retrieve a unit.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIUnit**](../Response/ApiResponsePIUnit.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Get**
> Get(string webId, string selectedFields = null, string webIdType = null)

Retrieve a unit.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIUnit**](../Model/PIUnit.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIUnit unitDTO)

Update a unit.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit.. | [required]
 **unitDTO** | **PIUnit**| A partial unit containing the desired changes.. | [required]


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Update**
> Update(string webId, PIUnit unitDTO)

Update a unit.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit.. | [required]
 **unitDTO** | **PIUnit**| A partial unit containing the desired changes.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete a unit.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit.. | [required]


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Delete**
> Delete(string webId)

Delete a unit.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the unit.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
