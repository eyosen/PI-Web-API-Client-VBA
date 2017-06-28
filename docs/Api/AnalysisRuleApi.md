# AnalysisRuleApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](AnalysisRuleApi.md#getbypath) | **GET** /analysisrules | Retrieve an Analysis Rule by path.
[**GetByPathWithHttpInfo**](AnalysisRuleApi.md#getbypathwithhttpinfo) | **GET** /analysisrules | Retrieve an Analysis Rule by path.
[**Get**](AnalysisRuleApi.md#get) | **GET** /analysisrules/{webId} | Retrieve an Analysis Rule.
[**GetWithHttpInfo**](AnalysisRuleApi.md#getwithhttpinfo) | **GET** /analysisrules/{webId} | Retrieve an Analysis Rule.
[**Update**](AnalysisRuleApi.md#update) | **PATCH** /analysisrules/{webId} | Update an Analysis Rule by replacing items in its definition.
[**UpdateWithHttpInfo**](AnalysisRuleApi.md#updatewithhttpinfo) | **PATCH** /analysisrules/{webId} | Update an Analysis Rule by replacing items in its definition.
[**Delete**](AnalysisRuleApi.md#delete) | **DELETE** /analysisrules/{webId} | Delete an Analysis Rule.
[**DeleteWithHttpInfo**](AnalysisRuleApi.md#deletewithhttpinfo) | **DELETE** /analysisrules/{webId} | Delete an Analysis Rule.
[**GetAnalysisRules**](AnalysisRuleApi.md#getanalysisrules) | **GET** /analysisrules/{webId}/analysisrules | Get the child Analysis Rules of the Analysis Rule.
[**GetAnalysisRulesWithHttpInfo**](AnalysisRuleApi.md#getanalysisruleswithhttpinfo) | **GET** /analysisrules/{webId}/analysisrules | Get the child Analysis Rules of the Analysis Rule.
[**CreateAnalysisRule**](AnalysisRuleApi.md#createanalysisrule) | **POST** /analysisrules/{webId}/analysisrules | Create a new Analysis Rule as a child of an existing Analysis Rule.
[**CreateAnalysisRuleWithHttpInfo**](AnalysisRuleApi.md#createanalysisrulewithhttpinfo) | **POST** /analysisrules/{webId}/analysisrules | Create a new Analysis Rule as a child of an existing Analysis Rule.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an Analysis Rule by path.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **path** | **string**| The path to the Analysis Rule.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIAnalysisRule**](../Responses/ApiResponsePIAnalysisRule.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve an Analysis Rule by path.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **path** | **string**| The path to the Analysis Rule.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIAnalysisRule**](../Model/PIAnalysisRule.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an Analysis Rule.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis Rule.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIAnalysisRule**](../Responses/ApiResponsePIAnalysisRule.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve an Analysis Rule.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis Rule.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIAnalysisRule**](../Model/PIAnalysisRule.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIAnalysisRule analysisRule)

Update an Analysis Rule by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis Rule.. |
 **analysisRule** | **PIAnalysisRule**| A partial Analysis Rule containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Update**
> Update(string webId, PIAnalysisRule analysisRule)

Update an Analysis Rule by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis Rule.. |
 **analysisRule** | **PIAnalysisRule**| A partial Analysis Rule containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an Analysis Rule.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis Rule.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Delete**
> Delete(string webId)

Delete an Analysis Rule.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis Rule.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetAnalysisRulesWithHttpInfo**
> GetAnalysisRulesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Get the child Analysis Rules of the Analysis Rule.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent Analysis Rule.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include Analysis Rules nested further than the immediate children of the searchRoot. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **nameFilter** | **string**| The name query string used for finding Analysis Rules. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |


### Return type

[**ApiResponsePIItemsAnalysisRule**](../Responses/ApiResponsePIItemsAnalysisRule.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetAnalysisRules**
> GetAnalysisRules(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Get the child Analysis Rules of the Analysis Rule.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent Analysis Rule.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include Analysis Rules nested further than the immediate children of the searchRoot. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **nameFilter** | **string**| The name query string used for finding Analysis Rules. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |


### Return type

[**PIItemsAnalysisRule**](../Model/PIItemsAnalysisRule.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateAnalysisRuleWithHttpInfo**
> CreateAnalysisRuleWithHttpInfo(string webId, PIAnalysisRule analysisRule)

Create a new Analysis Rule as a child of an existing Analysis Rule.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent Analysis Rule, on which to create the child Analysis Rule.. |
 **analysisRule** | **PIAnalysisRule**| The definition of the new Analysis Rule.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateAnalysisRule**
> CreateAnalysisRule(string webId, PIAnalysisRule analysisRule)

Create a new Analysis Rule as a child of an existing Analysis Rule.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent Analysis Rule, on which to create the child Analysis Rule.. |
 **analysisRule** | **PIAnalysisRule**| The definition of the new Analysis Rule.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)