# SecurityMappingApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](SecurityMappingApi.md#getbypath) | **GET** /securitymappings | Retrieve a security mapping by path.
[**GetByPathWithHttpInfo**](SecurityMappingApi.md#getbypathwithhttpinfo) | **GET** /securitymappings | Retrieve a security mapping by path.
[**Get**](SecurityMappingApi.md#get) | **GET** /securitymappings/{webId} | Retrieve a security mapping.
[**GetWithHttpInfo**](SecurityMappingApi.md#getwithhttpinfo) | **GET** /securitymappings/{webId} | Retrieve a security mapping.
[**Update**](SecurityMappingApi.md#update) | **PATCH** /securitymappings/{webId} | Update a security mapping by replacing items in its definition.
[**UpdateWithHttpInfo**](SecurityMappingApi.md#updatewithhttpinfo) | **PATCH** /securitymappings/{webId} | Update a security mapping by replacing items in its definition.
[**Delete**](SecurityMappingApi.md#delete) | **DELETE** /securitymappings/{webId} | Delete a security mapping.
[**DeleteWithHttpInfo**](SecurityMappingApi.md#deletewithhttpinfo) | **DELETE** /securitymappings/{webId} | Delete a security mapping.
[**GetSecurity**](SecurityMappingApi.md#getsecurity) | **GET** /securitymappings/{webId}/security | Get the security information of the specified security item associated with the security mapping for a specified user.
[**GetSecurityWithHttpInfo**](SecurityMappingApi.md#getsecuritywithhttpinfo) | **GET** /securitymappings/{webId}/security | Get the security information of the specified security item associated with the security mapping for a specified user.
[**GetSecurityEntries**](SecurityMappingApi.md#getsecurityentries) | **GET** /securitymappings/{webId}/securityentries | Retrieve the security entries associated with the security mapping based on the specified criteria. By default, all security entries for this security mapping are returned.
[**GetSecurityEntriesWithHttpInfo**](SecurityMappingApi.md#getsecurityentrieswithhttpinfo) | **GET** /securitymappings/{webId}/securityentries | Retrieve the security entries associated with the security mapping based on the specified criteria. By default, all security entries for this security mapping are returned.
[**GetSecurityEntryByName**](SecurityMappingApi.md#getsecurityentrybyname) | **GET** /securitymappings/{webId}/securityentries/{name} | Retrieve the security entry associated with the security mapping with the specified name.
[**GetSecurityEntryByNameWithHttpInfo**](SecurityMappingApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /securitymappings/{webId}/securityentries/{name} | Retrieve the security entry associated with the security mapping with the specified name.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve a security mapping by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the security mapping.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePISecurityMapping**](../Response/ApiResponsePISecurityMapping.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve a security mapping by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the security mapping.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PISecurityMapping**](../Model/PISecurityMapping.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve a security mapping.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePISecurityMapping**](../Response/ApiResponsePISecurityMapping.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve a security mapping.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PISecurityMapping**](../Model/PISecurityMapping.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PISecurityMapping securityMapping)

Update a security mapping by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping.. |
 **securityMapping** | **PISecurityMapping**| A partial security mapping containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Update**
> Update(string webId, PISecurityMapping securityMapping)

Update a security mapping by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping.. |
 **securityMapping** | **PISecurityMapping**| A partial security mapping containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete a security mapping.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping.. |


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string webId)

Delete a security mapping.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityWithHttpInfo**
> GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the security mapping for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityRights**](../Response/ApiResponsePIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurity**
> GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the security mapping for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityRights**](../Model/PIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntriesWithHttpInfo**
> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the security mapping based on the specified criteria. By default, all security entries for this security mapping are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityEntry**](../Response/ApiResponsePIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntries**
> GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the security mapping based on the specified criteria. By default, all security entries for this security mapping are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the security mapping.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityEntry**](../Model/PIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByNameWithHttpInfo**
> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the security mapping with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the security mapping.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePISecurityEntry**](../Response/ApiResponsePISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByName**
> GetSecurityEntryByName(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the security mapping with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the security mapping.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PISecurityEntry**](../Model/PISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
