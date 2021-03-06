# DataServerApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**List**](DataServerApi.md#list) | **GET** /dataservers | Retrieve a list of Data Servers known to this service.
[**ListWithHttpInfo**](DataServerApi.md#listwithhttpinfo) | **GET** /dataservers | Retrieve a list of Data Servers known to this service.
[**GetByName**](DataServerApi.md#getbyname) | **GET** /dataservers#name | Retrieve a Data Server by name.
[**GetByNameWithHttpInfo**](DataServerApi.md#getbynamewithhttpinfo) | **GET** /dataservers#name | Retrieve a Data Server by name.
[**GetByPath**](DataServerApi.md#getbypath) | **GET** /dataservers#path | Retrieve a Data Server by path.
[**GetByPathWithHttpInfo**](DataServerApi.md#getbypathwithhttpinfo) | **GET** /dataservers#path | Retrieve a Data Server by path.
[**Get**](DataServerApi.md#get) | **GET** /dataservers/{webId} | Retrieve a Data Server.
[**GetWithHttpInfo**](DataServerApi.md#getwithhttpinfo) | **GET** /dataservers/{webId} | Retrieve a Data Server.
[**GetEnumerationSets**](DataServerApi.md#getenumerationsets) | **GET** /dataservers/{webId}/enumerationsets | Retrieve enumeration sets for given Data Server.
[**GetEnumerationSetsWithHttpInfo**](DataServerApi.md#getenumerationsetswithhttpinfo) | **GET** /dataservers/{webId}/enumerationsets | Retrieve enumeration sets for given Data Server.
[**CreateEnumerationSet**](DataServerApi.md#createenumerationset) | **POST** /dataservers/{webId}/enumerationsets | Create an enumeration set on the Data Server.
[**CreateEnumerationSetWithHttpInfo**](DataServerApi.md#createenumerationsetwithhttpinfo) | **POST** /dataservers/{webId}/enumerationsets | Create an enumeration set on the Data Server.
[**GetLicense**](DataServerApi.md#getlicense) | **GET** /dataservers/{webId}/license | Retrieves the specified license for the given Data Server. The fields of the response object are string representations of the numerical values reported by the Data Server, with "Infinity" representing a license field with no limit.
[**GetLicenseWithHttpInfo**](DataServerApi.md#getlicensewithhttpinfo) | **GET** /dataservers/{webId}/license | Retrieves the specified license for the given Data Server. The fields of the response object are string representations of the numerical values reported by the Data Server, with "Infinity" representing a license field with no limit.
[**GetPoints**](DataServerApi.md#getpoints) | **GET** /dataservers/{webId}/points | Retrieve a list of points on a specified Data Server.
[**GetPointsWithHttpInfo**](DataServerApi.md#getpointswithhttpinfo) | **GET** /dataservers/{webId}/points | Retrieve a list of points on a specified Data Server.
[**CreatePoint**](DataServerApi.md#createpoint) | **POST** /dataservers/{webId}/points | Create a point in the specified Data Server.
[**CreatePointWithHttpInfo**](DataServerApi.md#createpointwithhttpinfo) | **POST** /dataservers/{webId}/points | Create a point in the specified Data Server.


# **ListWithHttpInfo**
> ListWithHttpInfo(string selectedFields = null, string webIdType = null)

Retrieve a list of Data Servers known to this service.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIItemsDataServer**](../Response/ApiResponsePIItemsDataServer.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **List**
> List(string selectedFields = null, string webIdType = null)

Retrieve a list of Data Servers known to this service.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIItemsDataServer**](../Model/PIItemsDataServer.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetByNameWithHttpInfo**
> GetByNameWithHttpInfo(string name, string selectedFields = null, string webIdType = null)

Retrieve a Data Server by name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIDataServer**](../Response/ApiResponsePIDataServer.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetByName**
> GetByName(string name, string selectedFields = null, string webIdType = null)

Retrieve a Data Server by name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIDataServer**](../Model/PIDataServer.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null)

Retrieve a Data Server by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the server. Note that the path supplied to this method must be of the form '\\servername'.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIDataServer**](../Response/ApiResponsePIDataServer.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null, string webIdType = null)

Retrieve a Data Server by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the server. Note that the path supplied to this method must be of the form '\\servername'.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIDataServer**](../Model/PIDataServer.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)

Retrieve a Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIDataServer**](../Response/ApiResponsePIDataServer.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Get**
> Get(string webId, string selectedFields = null, string webIdType = null)

Retrieve a Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIDataServer**](../Model/PIDataServer.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetEnumerationSetsWithHttpInfo**
> GetEnumerationSetsWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)

Retrieve enumeration sets for given Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIItemsEnumerationSet**](../Response/ApiResponsePIItemsEnumerationSet.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetEnumerationSets**
> GetEnumerationSets(string webId, string selectedFields = null, string webIdType = null)

Retrieve enumeration sets for given Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIItemsEnumerationSet**](../Model/PIItemsEnumerationSet.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **CreateEnumerationSetWithHttpInfo**
> CreateEnumerationSetWithHttpInfo(string webId, PIEnumerationSet enumerationSet, string webIdType = null)

Create an enumeration set on the Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server on which to create the enumeration set.. | [required]
 **enumerationSet** | **PIEnumerationSet**| The new enumeration set definition.. | [required]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **CreateEnumerationSet**
> CreateEnumerationSet(string webId, PIEnumerationSet enumerationSet, string webIdType = null)

Create an enumeration set on the Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server on which to create the enumeration set.. | [required]
 **enumerationSet** | **PIEnumerationSet**| The new enumeration set definition.. | [required]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetLicenseWithHttpInfo**
> GetLicenseWithHttpInfo(string webId, string module = null, string selectedFields = null, string webIdType = null)

Retrieves the specified license for the given Data Server. The fields of the response object are string representations of the numerical values reported by the Data Server, with "Infinity" representing a license field with no limit.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **module** | **string**| The case-sensitive name of the module.. | [optional] - always use empty strings("") instead of Null
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIDataServerLicense**](../Response/ApiResponsePIDataServerLicense.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetLicense**
> GetLicense(string webId, string module = null, string selectedFields = null, string webIdType = null)

Retrieves the specified license for the given Data Server. The fields of the response object are string representations of the numerical values reported by the Data Server, with "Infinity" representing a license field with no limit.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **module** | **string**| The case-sensitive name of the module.. | [optional] - always use empty strings("") instead of Null
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIDataServerLicense**](../Model/PIDataServerLicense.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetPointsWithHttpInfo**
> GetPointsWithHttpInfo(string webId, int maxCount, int startIndex, string nameFilter = null, string selectedFields = null, string webIdType = null)

Retrieve a list of points on a specified Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [required]
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is '0'.. | [required]
 **nameFilter** | **string**| A query string for filtering by point name. The default is no filter.. | [optional] - always use empty strings("") instead of Null
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIItemsPoint**](../Response/ApiResponsePIItemsPoint.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetPoints**
> GetPoints(string webId, int maxCount, int startIndex, string nameFilter = null, string selectedFields = null, string webIdType = null)

Retrieve a list of points on a specified Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. | [required]
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is '0'.. | [required]
 **nameFilter** | **string**| A query string for filtering by point name. The default is no filter.. | [optional] - always use empty strings("") instead of Null
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIItemsPoint**](../Model/PIItemsPoint.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **CreatePointWithHttpInfo**
> CreatePointWithHttpInfo(string webId, PIPoint pointDTO, string webIdType = null)

Create a point in the specified Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **pointDTO** | **PIPoint**| The new point definition.. | [required]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **CreatePoint**
> CreatePoint(string webId, PIPoint pointDTO, string webIdType = null)

Create a point in the specified Data Server.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the server.. | [required]
 **pointDTO** | **PIPoint**| The new point definition.. | [required]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional] - always use empty strings("") instead of Null


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
