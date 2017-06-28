PI Web API Wrapper for VBA
===

## Organization
This repository has the source code package of the PI Web API Wrapper for VBA.

## Requirements

 - PI Web API 2017 installed within your domain using Kerberos or Basic Authentication.
 - PI ProcessBook 2012 SP1+
 - .NET Framework 3.5  


## Installation

 - Download this source code
 - Create a new folder under %PIHOME% named WebAPIWrapper 
 - Copy all files from the dist folder to %PIHOME%\WebAPIWrapper 
 - Run as Administrator the reg.bat located on %PIHOME%\WebAPIWrapper in order to register the PIWebApiWrapper assmebly.


## Usage

Create or edit a PI ProcessBook display. Press ALT+F11 to open Visual Basic for Applications. On the menu, click on Tools --> References. Find PIWebApiWrapper on the list box of the available reference and add it to the VBA project.

## Source code
The Visual Studio solution that generates the final library is available on the src folder. You might want to add or edit a method and rebuild the solution in order to generate custom assemblies.

## Examples

There are two PI ProcessBook displays available on the Samples folder of this repository. In addition, please refer to the following examples to understand how to use this library: 


### Create an intance of the piwebapi top level object.

```vb# 
    Dim client As New PIWebApiClient
    Dim connectedToPIWebAPI As Boolean
    connectedToPIWebAPI = client.DefineProperties("https://marc-web-sql.marc.net/piwebapi", True)
``` 

If you want to use basic authentication instead of Kerberos, set useKerberos to False and set the username and password accordingly.


### Get the PI Data Archive WebId

```vb# 
    Set dataServer = client.dataServer.GetByName(tbPIDataArchiveName.Text)
```


### Get PI Points WebIds

```vb# 
    Set point1 = client.point.GetByPath("\\" + tbPIDataArchiveName.Text + "\" + tbTagName1.Text)
    Set point2 = client.point.GetByPath("\\" + tbPIDataArchiveName.Text + "\" + tbTagName2.Text)
    Set point3 = client.point.GetByPath("\\" + tbPIDataArchiveName.Text + "\" + tbTagName3.Text)
```

### Get recorded values in bulk using the StreamSet/GetRecordedAdHoc

```vb# 
    webIds = point1.webId + "," + point2.webId + "," + point3.webId
    Set compressedData = client.StreamSet.GetRecordedAdHoc(webIds, True, 1000)
```

### Send values in bulk using the StreamSet/UpdateValuesAdHoc

```vb# 
    Call GetPIPoints
    Dim streamValuesItems As New PIItemsStreamValues
    Dim streamValue1 As New PIStreamValues
    Dim streamValue2 As New PIStreamValues
    Dim streamValue3 As New PIStreamValues
    Dim value1 As New PITimedValue
    Dim value2 As New PITimedValue
    Dim value3 As New PITimedValue
    Dim value4 As New PITimedValue
    Dim value5 As New PITimedValue
    Dim value6 As New PITimedValue

    streamValuesItems.CreateItemsArray (3)
    value1.SetValueWithInt (2)
    value1.Timestamp = "*-1d"
    value2.SetValueWithInt (3)
    value2.Timestamp = "*-2d"
    value3.SetValueWithInt (4)
    value3.Timestamp = "*-1d"
    value4.SetValueWithInt (5)
    value4.Timestamp = "*-2d"
    value5.SetValueWithInt (6)
    value5.Timestamp = "*-1d"
    value6.SetValueWithInt (7)
    value6.Timestamp = "*-2d"

    streamValue1.webId = point1.webId
    streamValue1.CreateItemsArray (2)
    Call streamValue1.SetItem(0, value1)
    Call streamValue1.SetItem(1, value2)
    Call streamValuesItems.SetItem(0, streamValue1)

    streamValue2.webId = point2.webId
    streamValue2.CreateItemsArray (2)
    Call streamValue2.SetItem(0, value3)
    Call streamValue2.SetItem(1, value4)
    Call streamValuesItems.SetItem(1, streamValue2)

    streamValue3.webId = point2.webId
    streamValue3.CreateItemsArray (2)
    Call streamValue3.SetItem(0, value5)
    Call streamValue3.SetItem(1, value6)
    Call streamValuesItems.SetItem(2, streamValue3)

    Dim response As ApiResponsePIItemsItemsSubstatus
    Set response = client.StreamSet.UpdateValuesAdHocWithHttpInfo(streamValuesItems)
```


### Get AF Attribute given an AF Element path

```vb# 
    Set elem = client.element.GetByPath(ERD.CurrentContext(ThisDisplay))
    ElemDesc.Contents = elem.Description
    Dim attributes As PIItemsAttribute
    Set attributes = client.element.GetAttributes(elem.webId, 1000, False, False, False, 0)
```


### Get current value given an AF Attribute path

```vb# 
    attributePath = ERD.CurrentContext(ThisDisplay) + "|" + AttrList.Text
    Set attr = client.attribute.GetByPath(attributePath)
    Set timedValue = client.Stream.GetEnd(attr.webId)
    AttrValue.Contents = timedValue.value
```

### Get Event Frames given an AF database path

```vb# 
    Set db = client.AssetData.GetByPath(dbPath)
    Set efs = client.AssetData.GetEventFrames(db.webId, False, False, 100, True, 0, "", "*", "", elem.Name, elem.templateName, "", "", "None", "", "", "*-900", "*")
```


## Documentation for API Endpoints

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*HomeApi* | [**Get**](docs/Api/HomeApi.md#get) | **GET** / | Get top level links for this PI System Web API instance.
*HomeApi* | [**GetWithHttpInfo**](docs/Api/HomeApi.md#getwithhttpinfo) | **GET** / | Get top level links for this PI System Web API instance.
*AnalysisApi* | [**GetByPath**](docs/Api/AnalysisApi.md#getbypath) | **GET** /analyses | Retrieve an Analysis by path.
*AnalysisApi* | [**GetByPathWithHttpInfo**](docs/Api/AnalysisApi.md#getbypathwithhttpinfo) | **GET** /analyses | Retrieve an Analysis by path.
*AnalysisApi* | [**Get**](docs/Api/AnalysisApi.md#get) | **GET** /analyses/{webId} | Retrieve an Analysis.
*AnalysisApi* | [**GetWithHttpInfo**](docs/Api/AnalysisApi.md#getwithhttpinfo) | **GET** /analyses/{webId} | Retrieve an Analysis.
*AnalysisApi* | [**Update**](docs/Api/AnalysisApi.md#update) | **PATCH** /analyses/{webId} | Update an Analysis.
*AnalysisApi* | [**UpdateWithHttpInfo**](docs/Api/AnalysisApi.md#updatewithhttpinfo) | **PATCH** /analyses/{webId} | Update an Analysis.
*AnalysisApi* | [**Delete**](docs/Api/AnalysisApi.md#delete) | **DELETE** /analyses/{webId} | Delete an Analysis.
*AnalysisApi* | [**DeleteWithHttpInfo**](docs/Api/AnalysisApi.md#deletewithhttpinfo) | **DELETE** /analyses/{webId} | Delete an Analysis.
*AnalysisApi* | [**GetCategories**](docs/Api/AnalysisApi.md#getcategories) | **GET** /analyses/{webId}/categories | Get an Analysis' categories.
*AnalysisApi* | [**GetCategoriesWithHttpInfo**](docs/Api/AnalysisApi.md#getcategorieswithhttpinfo) | **GET** /analyses/{webId}/categories | Get an Analysis' categories.
*AnalysisApi* | [**GetSecurity**](docs/Api/AnalysisApi.md#getsecurity) | **GET** /analyses/{webId}/security | Get the security information of the specified security item associated with the Analysis for a specified user.
*AnalysisApi* | [**GetSecurityWithHttpInfo**](docs/Api/AnalysisApi.md#getsecuritywithhttpinfo) | **GET** /analyses/{webId}/security | Get the security information of the specified security item associated with the Analysis for a specified user.
*AnalysisApi* | [**GetSecurityEntries**](docs/Api/AnalysisApi.md#getsecurityentries) | **GET** /analyses/{webId}/securityentries | Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.
*AnalysisApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/AnalysisApi.md#getsecurityentrieswithhttpinfo) | **GET** /analyses/{webId}/securityentries | Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.
*AnalysisApi* | [**CreateSecurityEntry**](docs/Api/AnalysisApi.md#createsecurityentry) | **POST** /analyses/{webId}/securityentries | Create a security entry owned by the analysis.
*AnalysisApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/AnalysisApi.md#createsecurityentrywithhttpinfo) | **POST** /analyses/{webId}/securityentries | Create a security entry owned by the analysis.
*AnalysisApi* | [**GetSecurityEntryByName**](docs/Api/AnalysisApi.md#getsecurityentrybyname) | **GET** /analyses/{webId}/securityentries/{name} | Retrieve the security entry associated with the analysis with the specified name.
*AnalysisApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/AnalysisApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /analyses/{webId}/securityentries/{name} | Retrieve the security entry associated with the analysis with the specified name.
*AnalysisApi* | [**UpdateSecurityEntry**](docs/Api/AnalysisApi.md#updatesecurityentry) | **PUT** /analyses/{webId}/securityentries/{name} | Update a security entry owned by the analysis.
*AnalysisApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/AnalysisApi.md#updatesecurityentrywithhttpinfo) | **PUT** /analyses/{webId}/securityentries/{name} | Update a security entry owned by the analysis.
*AnalysisApi* | [**DeleteSecurityEntry**](docs/Api/AnalysisApi.md#deletesecurityentry) | **DELETE** /analyses/{webId}/securityentries/{name} | Delete a security entry owned by the analysis.
*AnalysisApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/AnalysisApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /analyses/{webId}/securityentries/{name} | Delete a security entry owned by the analysis.
*AnalysisCategoryApi* | [**GetByPath**](docs/Api/AnalysisCategoryApi.md#getbypath) | **GET** /analysiscategories | Retrieve an analysis category by path.
*AnalysisCategoryApi* | [**GetByPathWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#getbypathwithhttpinfo) | **GET** /analysiscategories | Retrieve an analysis category by path.
*AnalysisCategoryApi* | [**Get**](docs/Api/AnalysisCategoryApi.md#get) | **GET** /analysiscategories/{webId} | Retrieve an analysis category.
*AnalysisCategoryApi* | [**GetWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#getwithhttpinfo) | **GET** /analysiscategories/{webId} | Retrieve an analysis category.
*AnalysisCategoryApi* | [**Update**](docs/Api/AnalysisCategoryApi.md#update) | **PATCH** /analysiscategories/{webId} | Update an analysis category by replacing items in its definition.
*AnalysisCategoryApi* | [**UpdateWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#updatewithhttpinfo) | **PATCH** /analysiscategories/{webId} | Update an analysis category by replacing items in its definition.
*AnalysisCategoryApi* | [**Delete**](docs/Api/AnalysisCategoryApi.md#delete) | **DELETE** /analysiscategories/{webId} | Delete an analysis category.
*AnalysisCategoryApi* | [**DeleteWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#deletewithhttpinfo) | **DELETE** /analysiscategories/{webId} | Delete an analysis category.
*AnalysisCategoryApi* | [**GetSecurity**](docs/Api/AnalysisCategoryApi.md#getsecurity) | **GET** /analysiscategories/{webId}/security | Get the security information of the specified security item associated with the analysis category for a specified user.
*AnalysisCategoryApi* | [**GetSecurityWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#getsecuritywithhttpinfo) | **GET** /analysiscategories/{webId}/security | Get the security information of the specified security item associated with the analysis category for a specified user.
*AnalysisCategoryApi* | [**GetSecurityEntries**](docs/Api/AnalysisCategoryApi.md#getsecurityentries) | **GET** /analysiscategories/{webId}/securityentries | Retrieve the security entries associated with the analysis category based on the specified criteria. By default, all security entries for this analysis category are returned.
*AnalysisCategoryApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#getsecurityentrieswithhttpinfo) | **GET** /analysiscategories/{webId}/securityentries | Retrieve the security entries associated with the analysis category based on the specified criteria. By default, all security entries for this analysis category are returned.
*AnalysisCategoryApi* | [**CreateSecurityEntry**](docs/Api/AnalysisCategoryApi.md#createsecurityentry) | **POST** /analysiscategories/{webId}/securityentries | Create a security entry owned by the analysis category.
*AnalysisCategoryApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#createsecurityentrywithhttpinfo) | **POST** /analysiscategories/{webId}/securityentries | Create a security entry owned by the analysis category.
*AnalysisCategoryApi* | [**GetSecurityEntryByName**](docs/Api/AnalysisCategoryApi.md#getsecurityentrybyname) | **GET** /analysiscategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the analysis category with the specified name.
*AnalysisCategoryApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /analysiscategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the analysis category with the specified name.
*AnalysisCategoryApi* | [**UpdateSecurityEntry**](docs/Api/AnalysisCategoryApi.md#updatesecurityentry) | **PUT** /analysiscategories/{webId}/securityentries/{name} | Update a security entry owned by the analysis category.
*AnalysisCategoryApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#updatesecurityentrywithhttpinfo) | **PUT** /analysiscategories/{webId}/securityentries/{name} | Update a security entry owned by the analysis category.
*AnalysisCategoryApi* | [**DeleteSecurityEntry**](docs/Api/AnalysisCategoryApi.md#deletesecurityentry) | **DELETE** /analysiscategories/{webId}/securityentries/{name} | Delete a security entry owned by the analysis category.
*AnalysisCategoryApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/AnalysisCategoryApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /analysiscategories/{webId}/securityentries/{name} | Delete a security entry owned by the analysis category.
*AnalysisRulePlugInApi* | [**GetByPath**](docs/Api/AnalysisRulePlugInApi.md#getbypath) | **GET** /analysisruleplugins | Retrieve an Analysis Rule Plug-in by path.
*AnalysisRulePlugInApi* | [**GetByPathWithHttpInfo**](docs/Api/AnalysisRulePlugInApi.md#getbypathwithhttpinfo) | **GET** /analysisruleplugins | Retrieve an Analysis Rule Plug-in by path.
*AnalysisRulePlugInApi* | [**Get**](docs/Api/AnalysisRulePlugInApi.md#get) | **GET** /analysisruleplugins/{webId} | Retrieve an Analysis Rule Plug-in.
*AnalysisRulePlugInApi* | [**GetWithHttpInfo**](docs/Api/AnalysisRulePlugInApi.md#getwithhttpinfo) | **GET** /analysisruleplugins/{webId} | Retrieve an Analysis Rule Plug-in.
*AnalysisRuleApi* | [**GetByPath**](docs/Api/AnalysisRuleApi.md#getbypath) | **GET** /analysisrules | Retrieve an Analysis Rule by path.
*AnalysisRuleApi* | [**GetByPathWithHttpInfo**](docs/Api/AnalysisRuleApi.md#getbypathwithhttpinfo) | **GET** /analysisrules | Retrieve an Analysis Rule by path.
*AnalysisRuleApi* | [**Get**](docs/Api/AnalysisRuleApi.md#get) | **GET** /analysisrules/{webId} | Retrieve an Analysis Rule.
*AnalysisRuleApi* | [**GetWithHttpInfo**](docs/Api/AnalysisRuleApi.md#getwithhttpinfo) | **GET** /analysisrules/{webId} | Retrieve an Analysis Rule.
*AnalysisRuleApi* | [**Update**](docs/Api/AnalysisRuleApi.md#update) | **PATCH** /analysisrules/{webId} | Update an Analysis Rule by replacing items in its definition.
*AnalysisRuleApi* | [**UpdateWithHttpInfo**](docs/Api/AnalysisRuleApi.md#updatewithhttpinfo) | **PATCH** /analysisrules/{webId} | Update an Analysis Rule by replacing items in its definition.
*AnalysisRuleApi* | [**Delete**](docs/Api/AnalysisRuleApi.md#delete) | **DELETE** /analysisrules/{webId} | Delete an Analysis Rule.
*AnalysisRuleApi* | [**DeleteWithHttpInfo**](docs/Api/AnalysisRuleApi.md#deletewithhttpinfo) | **DELETE** /analysisrules/{webId} | Delete an Analysis Rule.
*AnalysisRuleApi* | [**GetAnalysisRules**](docs/Api/AnalysisRuleApi.md#getanalysisrules) | **GET** /analysisrules/{webId}/analysisrules | Get the child Analysis Rules of the Analysis Rule.
*AnalysisRuleApi* | [**GetAnalysisRulesWithHttpInfo**](docs/Api/AnalysisRuleApi.md#getanalysisruleswithhttpinfo) | **GET** /analysisrules/{webId}/analysisrules | Get the child Analysis Rules of the Analysis Rule.
*AnalysisRuleApi* | [**CreateAnalysisRule**](docs/Api/AnalysisRuleApi.md#createanalysisrule) | **POST** /analysisrules/{webId}/analysisrules | Create a new Analysis Rule as a child of an existing Analysis Rule.
*AnalysisRuleApi* | [**CreateAnalysisRuleWithHttpInfo**](docs/Api/AnalysisRuleApi.md#createanalysisrulewithhttpinfo) | **POST** /analysisrules/{webId}/analysisrules | Create a new Analysis Rule as a child of an existing Analysis Rule.
*AnalysisTemplateApi* | [**GetByPath**](docs/Api/AnalysisTemplateApi.md#getbypath) | **GET** /analysistemplates | Retrieve an analysis template by path.
*AnalysisTemplateApi* | [**GetByPathWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#getbypathwithhttpinfo) | **GET** /analysistemplates | Retrieve an analysis template by path.
*AnalysisTemplateApi* | [**CreateFromAnalysis**](docs/Api/AnalysisTemplateApi.md#createfromanalysis) | **POST** /analysistemplates | Create an Analysis template based upon a specified Analysis.
*AnalysisTemplateApi* | [**CreateFromAnalysisWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#createfromanalysiswithhttpinfo) | **POST** /analysistemplates | Create an Analysis template based upon a specified Analysis.
*AnalysisTemplateApi* | [**Get**](docs/Api/AnalysisTemplateApi.md#get) | **GET** /analysistemplates/{webId} | Retrieve an analysis template.
*AnalysisTemplateApi* | [**GetWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#getwithhttpinfo) | **GET** /analysistemplates/{webId} | Retrieve an analysis template.
*AnalysisTemplateApi* | [**Update**](docs/Api/AnalysisTemplateApi.md#update) | **PATCH** /analysistemplates/{webId} | Update an analysis template by replacing items in its definition.
*AnalysisTemplateApi* | [**UpdateWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#updatewithhttpinfo) | **PATCH** /analysistemplates/{webId} | Update an analysis template by replacing items in its definition.
*AnalysisTemplateApi* | [**Delete**](docs/Api/AnalysisTemplateApi.md#delete) | **DELETE** /analysistemplates/{webId} | Delete an analysis template.
*AnalysisTemplateApi* | [**DeleteWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#deletewithhttpinfo) | **DELETE** /analysistemplates/{webId} | Delete an analysis template.
*AnalysisTemplateApi* | [**GetCategories**](docs/Api/AnalysisTemplateApi.md#getcategories) | **GET** /analysistemplates/{webId}/categories | Get an analysis template's categories.
*AnalysisTemplateApi* | [**GetCategoriesWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#getcategorieswithhttpinfo) | **GET** /analysistemplates/{webId}/categories | Get an analysis template's categories.
*AnalysisTemplateApi* | [**GetSecurity**](docs/Api/AnalysisTemplateApi.md#getsecurity) | **GET** /analysistemplates/{webId}/security | Get the security information of the specified security item associated with the analysis template for a specified user.
*AnalysisTemplateApi* | [**GetSecurityWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#getsecuritywithhttpinfo) | **GET** /analysistemplates/{webId}/security | Get the security information of the specified security item associated with the analysis template for a specified user.
*AnalysisTemplateApi* | [**GetSecurityEntries**](docs/Api/AnalysisTemplateApi.md#getsecurityentries) | **GET** /analysistemplates/{webId}/securityentries | Retrieve the security entries associated with the analysis template based on the specified criteria. By default, all security entries for this analysis template are returned.
*AnalysisTemplateApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#getsecurityentrieswithhttpinfo) | **GET** /analysistemplates/{webId}/securityentries | Retrieve the security entries associated with the analysis template based on the specified criteria. By default, all security entries for this analysis template are returned.
*AnalysisTemplateApi* | [**CreateSecurityEntry**](docs/Api/AnalysisTemplateApi.md#createsecurityentry) | **POST** /analysistemplates/{webId}/securityentries | Create a security entry owned by the analysis template.
*AnalysisTemplateApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#createsecurityentrywithhttpinfo) | **POST** /analysistemplates/{webId}/securityentries | Create a security entry owned by the analysis template.
*AnalysisTemplateApi* | [**GetSecurityEntryByName**](docs/Api/AnalysisTemplateApi.md#getsecurityentrybyname) | **GET** /analysistemplates/{webId}/securityentries/{name} | Retrieve the security entry associated with the analysis template with the specified name.
*AnalysisTemplateApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /analysistemplates/{webId}/securityentries/{name} | Retrieve the security entry associated with the analysis template with the specified name.
*AnalysisTemplateApi* | [**UpdateSecurityEntry**](docs/Api/AnalysisTemplateApi.md#updatesecurityentry) | **PUT** /analysistemplates/{webId}/securityentries/{name} | Update a security entry owned by the analysis template.
*AnalysisTemplateApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#updatesecurityentrywithhttpinfo) | **PUT** /analysistemplates/{webId}/securityentries/{name} | Update a security entry owned by the analysis template.
*AnalysisTemplateApi* | [**DeleteSecurityEntry**](docs/Api/AnalysisTemplateApi.md#deletesecurityentry) | **DELETE** /analysistemplates/{webId}/securityentries/{name} | Delete a security entry owned by the analysis template.
*AnalysisTemplateApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/AnalysisTemplateApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /analysistemplates/{webId}/securityentries/{name} | Delete a security entry owned by the analysis template.
*AssetDatabaseApi* | [**GetByPath**](docs/Api/AssetDatabaseApi.md#getbypath) | **GET** /assetdatabases | Retrieve an Asset Database by path.
*AssetDatabaseApi* | [**GetByPathWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getbypathwithhttpinfo) | **GET** /assetdatabases | Retrieve an Asset Database by path.
*AssetDatabaseApi* | [**Get**](docs/Api/AssetDatabaseApi.md#get) | **GET** /assetdatabases/{webId} | Retrieve an Asset Database.
*AssetDatabaseApi* | [**GetWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getwithhttpinfo) | **GET** /assetdatabases/{webId} | Retrieve an Asset Database.
*AssetDatabaseApi* | [**Update**](docs/Api/AssetDatabaseApi.md#update) | **PATCH** /assetdatabases/{webId} | Update an asset database by replacing items in its definition.
*AssetDatabaseApi* | [**UpdateWithHttpInfo**](docs/Api/AssetDatabaseApi.md#updatewithhttpinfo) | **PATCH** /assetdatabases/{webId} | Update an asset database by replacing items in its definition.
*AssetDatabaseApi* | [**Delete**](docs/Api/AssetDatabaseApi.md#delete) | **DELETE** /assetdatabases/{webId} | Delete an asset database.
*AssetDatabaseApi* | [**DeleteWithHttpInfo**](docs/Api/AssetDatabaseApi.md#deletewithhttpinfo) | **DELETE** /assetdatabases/{webId} | Delete an asset database.
*AssetDatabaseApi* | [**FindAnalyses**](docs/Api/AssetDatabaseApi.md#findanalyses) | **GET** /assetdatabases/{webId}/analyses | Retrieve analyses based on the specified conditions.
*AssetDatabaseApi* | [**FindAnalysesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#findanalyseswithhttpinfo) | **GET** /assetdatabases/{webId}/analyses | Retrieve analyses based on the specified conditions.
*AssetDatabaseApi* | [**GetAnalysisCategories**](docs/Api/AssetDatabaseApi.md#getanalysiscategories) | **GET** /assetdatabases/{webId}/analysiscategories | Retrieve analysis categories for a given Asset Database.
*AssetDatabaseApi* | [**GetAnalysisCategoriesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getanalysiscategorieswithhttpinfo) | **GET** /assetdatabases/{webId}/analysiscategories | Retrieve analysis categories for a given Asset Database.
*AssetDatabaseApi* | [**CreateAnalysisCategory**](docs/Api/AssetDatabaseApi.md#createanalysiscategory) | **POST** /assetdatabases/{webId}/analysiscategories | Create an analysis category at the Asset Database root.
*AssetDatabaseApi* | [**CreateAnalysisCategoryWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createanalysiscategorywithhttpinfo) | **POST** /assetdatabases/{webId}/analysiscategories | Create an analysis category at the Asset Database root.
*AssetDatabaseApi* | [**GetAnalysisTemplates**](docs/Api/AssetDatabaseApi.md#getanalysistemplates) | **GET** /assetdatabases/{webId}/analysistemplates | Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
*AssetDatabaseApi* | [**GetAnalysisTemplatesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getanalysistemplateswithhttpinfo) | **GET** /assetdatabases/{webId}/analysistemplates | Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.
*AssetDatabaseApi* | [**CreateAnalysisTemplate**](docs/Api/AssetDatabaseApi.md#createanalysistemplate) | **POST** /assetdatabases/{webId}/analysistemplates | Create an analysis template at the Asset Database root.
*AssetDatabaseApi* | [**CreateAnalysisTemplateWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createanalysistemplatewithhttpinfo) | **POST** /assetdatabases/{webId}/analysistemplates | Create an analysis template at the Asset Database root.
*AssetDatabaseApi* | [**GetAttributeCategories**](docs/Api/AssetDatabaseApi.md#getattributecategories) | **GET** /assetdatabases/{webId}/attributecategories | Retrieve attribute categories for a given Asset Database.
*AssetDatabaseApi* | [**GetAttributeCategoriesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getattributecategorieswithhttpinfo) | **GET** /assetdatabases/{webId}/attributecategories | Retrieve attribute categories for a given Asset Database.
*AssetDatabaseApi* | [**CreateAttributeCategory**](docs/Api/AssetDatabaseApi.md#createattributecategory) | **POST** /assetdatabases/{webId}/attributecategories | Create an attribute category at the Asset Database root.
*AssetDatabaseApi* | [**CreateAttributeCategoryWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createattributecategorywithhttpinfo) | **POST** /assetdatabases/{webId}/attributecategories | Create an attribute category at the Asset Database root.
*AssetDatabaseApi* | [**FindElementAttributes**](docs/Api/AssetDatabaseApi.md#findelementattributes) | **GET** /assetdatabases/{webId}/elementattributes | Retrieves a list of element attributes matching the specified filters from the specified asset database.
*AssetDatabaseApi* | [**FindElementAttributesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#findelementattributeswithhttpinfo) | **GET** /assetdatabases/{webId}/elementattributes | Retrieves a list of element attributes matching the specified filters from the specified asset database.
*AssetDatabaseApi* | [**GetElementCategories**](docs/Api/AssetDatabaseApi.md#getelementcategories) | **GET** /assetdatabases/{webId}/elementcategories | Retrieve element categories for a given Asset Database.
*AssetDatabaseApi* | [**GetElementCategoriesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getelementcategorieswithhttpinfo) | **GET** /assetdatabases/{webId}/elementcategories | Retrieve element categories for a given Asset Database.
*AssetDatabaseApi* | [**CreateElementCategory**](docs/Api/AssetDatabaseApi.md#createelementcategory) | **POST** /assetdatabases/{webId}/elementcategories | Create an element category at the Asset Database root.
*AssetDatabaseApi* | [**CreateElementCategoryWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createelementcategorywithhttpinfo) | **POST** /assetdatabases/{webId}/elementcategories | Create an element category at the Asset Database root.
*AssetDatabaseApi* | [**GetElements**](docs/Api/AssetDatabaseApi.md#getelements) | **GET** /assetdatabases/{webId}/elements | Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
*AssetDatabaseApi* | [**GetElementsWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getelementswithhttpinfo) | **GET** /assetdatabases/{webId}/elements | Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.
*AssetDatabaseApi* | [**CreateElement**](docs/Api/AssetDatabaseApi.md#createelement) | **POST** /assetdatabases/{webId}/elements | Create a child element.
*AssetDatabaseApi* | [**CreateElementWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createelementwithhttpinfo) | **POST** /assetdatabases/{webId}/elements | Create a child element.
*AssetDatabaseApi* | [**GetElementTemplates**](docs/Api/AssetDatabaseApi.md#getelementtemplates) | **GET** /assetdatabases/{webId}/elementtemplates | Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
*AssetDatabaseApi* | [**GetElementTemplatesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getelementtemplateswithhttpinfo) | **GET** /assetdatabases/{webId}/elementtemplates | Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.
*AssetDatabaseApi* | [**CreateElementTemplate**](docs/Api/AssetDatabaseApi.md#createelementtemplate) | **POST** /assetdatabases/{webId}/elementtemplates | Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
*AssetDatabaseApi* | [**CreateElementTemplateWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createelementtemplatewithhttpinfo) | **POST** /assetdatabases/{webId}/elementtemplates | Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.
*AssetDatabaseApi* | [**GetEnumerationSets**](docs/Api/AssetDatabaseApi.md#getenumerationsets) | **GET** /assetdatabases/{webId}/enumerationsets | Retrieve enumeration sets for given asset database.
*AssetDatabaseApi* | [**GetEnumerationSetsWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getenumerationsetswithhttpinfo) | **GET** /assetdatabases/{webId}/enumerationsets | Retrieve enumeration sets for given asset database.
*AssetDatabaseApi* | [**CreateEnumerationSet**](docs/Api/AssetDatabaseApi.md#createenumerationset) | **POST** /assetdatabases/{webId}/enumerationsets | Create an enumeration set at the Asset Database.
*AssetDatabaseApi* | [**CreateEnumerationSetWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createenumerationsetwithhttpinfo) | **POST** /assetdatabases/{webId}/enumerationsets | Create an enumeration set at the Asset Database.
*AssetDatabaseApi* | [**FindEventFrameAttributes**](docs/Api/AssetDatabaseApi.md#findeventframeattributes) | **GET** /assetdatabases/{webId}/eventframeattributes | Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
*AssetDatabaseApi* | [**FindEventFrameAttributesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#findeventframeattributeswithhttpinfo) | **GET** /assetdatabases/{webId}/eventframeattributes | Retrieves a list of event frame attributes matching the specified filters from the specified asset database.
*AssetDatabaseApi* | [**GetEventFrames**](docs/Api/AssetDatabaseApi.md#geteventframes) | **GET** /assetdatabases/{webId}/eventframes | Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.
*AssetDatabaseApi* | [**GetEventFramesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#geteventframeswithhttpinfo) | **GET** /assetdatabases/{webId}/eventframes | Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.
*AssetDatabaseApi* | [**CreateEventFrame**](docs/Api/AssetDatabaseApi.md#createeventframe) | **POST** /assetdatabases/{webId}/eventframes | Create an event frame.
*AssetDatabaseApi* | [**CreateEventFrameWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createeventframewithhttpinfo) | **POST** /assetdatabases/{webId}/eventframes | Create an event frame.
*AssetDatabaseApi* | [**Export**](docs/Api/AssetDatabaseApi.md#export) | **GET** /assetdatabases/{webId}/export | Export the asset database.
*AssetDatabaseApi* | [**ExportWithHttpInfo**](docs/Api/AssetDatabaseApi.md#exportwithhttpinfo) | **GET** /assetdatabases/{webId}/export | Export the asset database.
*AssetDatabaseApi* | [**Import**](docs/Api/AssetDatabaseApi.md#import) | **POST** /assetdatabases/{webId}/import | Import an asset database.
*AssetDatabaseApi* | [**ImportWithHttpInfo**](docs/Api/AssetDatabaseApi.md#importwithhttpinfo) | **POST** /assetdatabases/{webId}/import | Import an asset database.
*AssetDatabaseApi* | [**GetReferencedElements**](docs/Api/AssetDatabaseApi.md#getreferencedelements) | **GET** /assetdatabases/{webId}/referencedelements | Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
*AssetDatabaseApi* | [**GetReferencedElementsWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getreferencedelementswithhttpinfo) | **GET** /assetdatabases/{webId}/referencedelements | Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.
*AssetDatabaseApi* | [**AddReferencedElement**](docs/Api/AssetDatabaseApi.md#addreferencedelement) | **POST** /assetdatabases/{webId}/referencedelements | Add a reference to an existing element to the specified database.
*AssetDatabaseApi* | [**AddReferencedElementWithHttpInfo**](docs/Api/AssetDatabaseApi.md#addreferencedelementwithhttpinfo) | **POST** /assetdatabases/{webId}/referencedelements | Add a reference to an existing element to the specified database.
*AssetDatabaseApi* | [**RemoveReferencedElement**](docs/Api/AssetDatabaseApi.md#removereferencedelement) | **DELETE** /assetdatabases/{webId}/referencedelements | Remove a reference to an existing element from the specified database.
*AssetDatabaseApi* | [**RemoveReferencedElementWithHttpInfo**](docs/Api/AssetDatabaseApi.md#removereferencedelementwithhttpinfo) | **DELETE** /assetdatabases/{webId}/referencedelements | Remove a reference to an existing element from the specified database.
*AssetDatabaseApi* | [**GetSecurity**](docs/Api/AssetDatabaseApi.md#getsecurity) | **GET** /assetdatabases/{webId}/security | Get the security information of the specified security item associated with the asset database for a specified user.
*AssetDatabaseApi* | [**GetSecurityWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getsecuritywithhttpinfo) | **GET** /assetdatabases/{webId}/security | Get the security information of the specified security item associated with the asset database for a specified user.
*AssetDatabaseApi* | [**GetSecurityEntries**](docs/Api/AssetDatabaseApi.md#getsecurityentries) | **GET** /assetdatabases/{webId}/securityentries | Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
*AssetDatabaseApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getsecurityentrieswithhttpinfo) | **GET** /assetdatabases/{webId}/securityentries | Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.
*AssetDatabaseApi* | [**CreateSecurityEntry**](docs/Api/AssetDatabaseApi.md#createsecurityentry) | **POST** /assetdatabases/{webId}/securityentries | Create a security entry owned by the asset database.
*AssetDatabaseApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createsecurityentrywithhttpinfo) | **POST** /assetdatabases/{webId}/securityentries | Create a security entry owned by the asset database.
*AssetDatabaseApi* | [**GetSecurityEntryByName**](docs/Api/AssetDatabaseApi.md#getsecurityentrybyname) | **GET** /assetdatabases/{webId}/securityentries/{name} | Retrieve the security entry of the specified security item associated with the asset database with the specified name.
*AssetDatabaseApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/AssetDatabaseApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /assetdatabases/{webId}/securityentries/{name} | Retrieve the security entry of the specified security item associated with the asset database with the specified name.
*AssetDatabaseApi* | [**UpdateSecurityEntry**](docs/Api/AssetDatabaseApi.md#updatesecurityentry) | **PUT** /assetdatabases/{webId}/securityentries/{name} | Update a security entry owned by the asset database.
*AssetDatabaseApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/AssetDatabaseApi.md#updatesecurityentrywithhttpinfo) | **PUT** /assetdatabases/{webId}/securityentries/{name} | Update a security entry owned by the asset database.
*AssetDatabaseApi* | [**DeleteSecurityEntry**](docs/Api/AssetDatabaseApi.md#deletesecurityentry) | **DELETE** /assetdatabases/{webId}/securityentries/{name} | Delete a security entry owned by the asset database.
*AssetDatabaseApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/AssetDatabaseApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /assetdatabases/{webId}/securityentries/{name} | Delete a security entry owned by the asset database.
*AssetDatabaseApi* | [**GetTableCategories**](docs/Api/AssetDatabaseApi.md#gettablecategories) | **GET** /assetdatabases/{webId}/tablecategories | Retrieve table categories for a given Asset Database.
*AssetDatabaseApi* | [**GetTableCategoriesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#gettablecategorieswithhttpinfo) | **GET** /assetdatabases/{webId}/tablecategories | Retrieve table categories for a given Asset Database.
*AssetDatabaseApi* | [**CreateTableCategory**](docs/Api/AssetDatabaseApi.md#createtablecategory) | **POST** /assetdatabases/{webId}/tablecategories | Create a table category on the Asset Database.
*AssetDatabaseApi* | [**CreateTableCategoryWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createtablecategorywithhttpinfo) | **POST** /assetdatabases/{webId}/tablecategories | Create a table category on the Asset Database.
*AssetDatabaseApi* | [**GetTables**](docs/Api/AssetDatabaseApi.md#gettables) | **GET** /assetdatabases/{webId}/tables | Retrieve tables for given Asset Database.
*AssetDatabaseApi* | [**GetTablesWithHttpInfo**](docs/Api/AssetDatabaseApi.md#gettableswithhttpinfo) | **GET** /assetdatabases/{webId}/tables | Retrieve tables for given Asset Database.
*AssetDatabaseApi* | [**CreateTable**](docs/Api/AssetDatabaseApi.md#createtable) | **POST** /assetdatabases/{webId}/tables | Create a table on the Asset Database.
*AssetDatabaseApi* | [**CreateTableWithHttpInfo**](docs/Api/AssetDatabaseApi.md#createtablewithhttpinfo) | **POST** /assetdatabases/{webId}/tables | Create a table on the Asset Database.
*AssetServerApi* | [**List**](docs/Api/AssetServerApi.md#list) | **GET** /assetservers | Retrieve a list of all Asset Servers known to this service.
*AssetServerApi* | [**ListWithHttpInfo**](docs/Api/AssetServerApi.md#listwithhttpinfo) | **GET** /assetservers | Retrieve a list of all Asset Servers known to this service.
*AssetServerApi* | [**GetByName**](docs/Api/AssetServerApi.md#getbyname) | **GET** /assetservers#name | Retrieve an Asset Server by name.
*AssetServerApi* | [**GetByNameWithHttpInfo**](docs/Api/AssetServerApi.md#getbynamewithhttpinfo) | **GET** /assetservers#name | Retrieve an Asset Server by name.
*AssetServerApi* | [**GetByPath**](docs/Api/AssetServerApi.md#getbypath) | **GET** /assetservers#path | Retrieve an Asset Server by path.
*AssetServerApi* | [**GetByPathWithHttpInfo**](docs/Api/AssetServerApi.md#getbypathwithhttpinfo) | **GET** /assetservers#path | Retrieve an Asset Server by path.
*AssetServerApi* | [**Get**](docs/Api/AssetServerApi.md#get) | **GET** /assetservers/{webId} | Retrieve an Asset Server.
*AssetServerApi* | [**GetWithHttpInfo**](docs/Api/AssetServerApi.md#getwithhttpinfo) | **GET** /assetservers/{webId} | Retrieve an Asset Server.
*AssetServerApi* | [**GetAnalysisRulePlugIns**](docs/Api/AssetServerApi.md#getanalysisruleplugins) | **GET** /assetservers/{webId}/analysisruleplugins | Retrieve a list of all Analysis Rule Plug-in's.
*AssetServerApi* | [**GetAnalysisRulePlugInsWithHttpInfo**](docs/Api/AssetServerApi.md#getanalysisrulepluginswithhttpinfo) | **GET** /assetservers/{webId}/analysisruleplugins | Retrieve a list of all Analysis Rule Plug-in's.
*AssetServerApi* | [**GetDatabases**](docs/Api/AssetServerApi.md#getdatabases) | **GET** /assetservers/{webId}/assetdatabases | Retrieve a list of all Asset Databases on the specified Asset Server.
*AssetServerApi* | [**GetDatabasesWithHttpInfo**](docs/Api/AssetServerApi.md#getdatabaseswithhttpinfo) | **GET** /assetservers/{webId}/assetdatabases | Retrieve a list of all Asset Databases on the specified Asset Server.
*AssetServerApi* | [**CreateAssetDatabase**](docs/Api/AssetServerApi.md#createassetdatabase) | **POST** /assetservers/{webId}/assetdatabases | Create an asset database.
*AssetServerApi* | [**CreateAssetDatabaseWithHttpInfo**](docs/Api/AssetServerApi.md#createassetdatabasewithhttpinfo) | **POST** /assetservers/{webId}/assetdatabases | Create an asset database.
*AssetServerApi* | [**GetSecurity**](docs/Api/AssetServerApi.md#getsecurity) | **GET** /assetservers/{webId}/security | Get the security information of the specified security item associated with the asset server for a specified user.
*AssetServerApi* | [**GetSecurityWithHttpInfo**](docs/Api/AssetServerApi.md#getsecuritywithhttpinfo) | **GET** /assetservers/{webId}/security | Get the security information of the specified security item associated with the asset server for a specified user.
*AssetServerApi* | [**GetSecurityEntries**](docs/Api/AssetServerApi.md#getsecurityentries) | **GET** /assetservers/{webId}/securityentries | Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
*AssetServerApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/AssetServerApi.md#getsecurityentrieswithhttpinfo) | **GET** /assetservers/{webId}/securityentries | Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
*AssetServerApi* | [**CreateSecurityEntry**](docs/Api/AssetServerApi.md#createsecurityentry) | **POST** /assetservers/{webId}/securityentries | Create a security entry owned by the asset server.
*AssetServerApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/AssetServerApi.md#createsecurityentrywithhttpinfo) | **POST** /assetservers/{webId}/securityentries | Create a security entry owned by the asset server.
*AssetServerApi* | [**GetSecurityEntryByName**](docs/Api/AssetServerApi.md#getsecurityentrybyname) | **GET** /assetservers/{webId}/securityentries/{name} | Retrieve the security entry of the specified security item associated with the asset server with the specified name.
*AssetServerApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/AssetServerApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /assetservers/{webId}/securityentries/{name} | Retrieve the security entry of the specified security item associated with the asset server with the specified name.
*AssetServerApi* | [**UpdateSecurityEntry**](docs/Api/AssetServerApi.md#updatesecurityentry) | **PUT** /assetservers/{webId}/securityentries/{name} | Update a security entry owned by the asset server.
*AssetServerApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/AssetServerApi.md#updatesecurityentrywithhttpinfo) | **PUT** /assetservers/{webId}/securityentries/{name} | Update a security entry owned by the asset server.
*AssetServerApi* | [**DeleteSecurityEntry**](docs/Api/AssetServerApi.md#deletesecurityentry) | **DELETE** /assetservers/{webId}/securityentries/{name} | Delete a security entry owned by the asset server.
*AssetServerApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/AssetServerApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /assetservers/{webId}/securityentries/{name} | Delete a security entry owned by the asset server.
*AssetServerApi* | [**GetSecurityIdentities**](docs/Api/AssetServerApi.md#getsecurityidentities) | **GET** /assetservers/{webId}/securityidentities | Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
*AssetServerApi* | [**GetSecurityIdentitiesWithHttpInfo**](docs/Api/AssetServerApi.md#getsecurityidentitieswithhttpinfo) | **GET** /assetservers/{webId}/securityidentities | Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
*AssetServerApi* | [**CreateSecurityIdentity**](docs/Api/AssetServerApi.md#createsecurityidentity) | **POST** /assetservers/{webId}/securityidentities | Create a security identity.
*AssetServerApi* | [**CreateSecurityIdentityWithHttpInfo**](docs/Api/AssetServerApi.md#createsecurityidentitywithhttpinfo) | **POST** /assetservers/{webId}/securityidentities | Create a security identity.
*AssetServerApi* | [**GetSecurityIdentitiesForUser**](docs/Api/AssetServerApi.md#getsecurityidentitiesforuser) | **GET** /assetservers/{webId}/securityidentities#userIdentity | Retrieve security identities for a specific user.
*AssetServerApi* | [**GetSecurityIdentitiesForUserWithHttpInfo**](docs/Api/AssetServerApi.md#getsecurityidentitiesforuserwithhttpinfo) | **GET** /assetservers/{webId}/securityidentities#userIdentity | Retrieve security identities for a specific user.
*AssetServerApi* | [**GetSecurityMappings**](docs/Api/AssetServerApi.md#getsecuritymappings) | **GET** /assetservers/{webId}/securitymappings | Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
*AssetServerApi* | [**GetSecurityMappingsWithHttpInfo**](docs/Api/AssetServerApi.md#getsecuritymappingswithhttpinfo) | **GET** /assetservers/{webId}/securitymappings | Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
*AssetServerApi* | [**CreateSecurityMapping**](docs/Api/AssetServerApi.md#createsecuritymapping) | **POST** /assetservers/{webId}/securitymappings | Create a security mapping.
*AssetServerApi* | [**CreateSecurityMappingWithHttpInfo**](docs/Api/AssetServerApi.md#createsecuritymappingwithhttpinfo) | **POST** /assetservers/{webId}/securitymappings | Create a security mapping.
*AssetServerApi* | [**GetTimeRulePlugIns**](docs/Api/AssetServerApi.md#gettimeruleplugins) | **GET** /assetservers/{webId}/timeruleplugins | Retrieve a list of all Time Rule Plug-in's.
*AssetServerApi* | [**GetTimeRulePlugInsWithHttpInfo**](docs/Api/AssetServerApi.md#gettimerulepluginswithhttpinfo) | **GET** /assetservers/{webId}/timeruleplugins | Retrieve a list of all Time Rule Plug-in's.
*AssetServerApi* | [**GetUnitClasses**](docs/Api/AssetServerApi.md#getunitclasses) | **GET** /assetservers/{webId}/unitclasses | Retrieve a list of all unit classes on the specified Asset Server.
*AssetServerApi* | [**GetUnitClassesWithHttpInfo**](docs/Api/AssetServerApi.md#getunitclasseswithhttpinfo) | **GET** /assetservers/{webId}/unitclasses | Retrieve a list of all unit classes on the specified Asset Server.
*AssetServerApi* | [**CreateUnitClass**](docs/Api/AssetServerApi.md#createunitclass) | **POST** /assetservers/{webId}/unitclasses | Create a unit class in the specified Asset Server.
*AssetServerApi* | [**CreateUnitClassWithHttpInfo**](docs/Api/AssetServerApi.md#createunitclasswithhttpinfo) | **POST** /assetservers/{webId}/unitclasses | Create a unit class in the specified Asset Server.
*AttributeCategoryApi* | [**GetByPath**](docs/Api/AttributeCategoryApi.md#getbypath) | **GET** /attributecategories | Retrieve an attribute category by path.
*AttributeCategoryApi* | [**GetByPathWithHttpInfo**](docs/Api/AttributeCategoryApi.md#getbypathwithhttpinfo) | **GET** /attributecategories | Retrieve an attribute category by path.
*AttributeCategoryApi* | [**Get**](docs/Api/AttributeCategoryApi.md#get) | **GET** /attributecategories/{webId} | Retrieve an attribute category.
*AttributeCategoryApi* | [**GetWithHttpInfo**](docs/Api/AttributeCategoryApi.md#getwithhttpinfo) | **GET** /attributecategories/{webId} | Retrieve an attribute category.
*AttributeCategoryApi* | [**Update**](docs/Api/AttributeCategoryApi.md#update) | **PATCH** /attributecategories/{webId} | Update an attribute category by replacing items in its definition.
*AttributeCategoryApi* | [**UpdateWithHttpInfo**](docs/Api/AttributeCategoryApi.md#updatewithhttpinfo) | **PATCH** /attributecategories/{webId} | Update an attribute category by replacing items in its definition.
*AttributeCategoryApi* | [**Delete**](docs/Api/AttributeCategoryApi.md#delete) | **DELETE** /attributecategories/{webId} | Delete an attribute category.
*AttributeCategoryApi* | [**DeleteWithHttpInfo**](docs/Api/AttributeCategoryApi.md#deletewithhttpinfo) | **DELETE** /attributecategories/{webId} | Delete an attribute category.
*AttributeCategoryApi* | [**GetSecurity**](docs/Api/AttributeCategoryApi.md#getsecurity) | **GET** /attributecategories/{webId}/security | Get the security information of the specified security item associated with the attribute category for a specified user.
*AttributeCategoryApi* | [**GetSecurityWithHttpInfo**](docs/Api/AttributeCategoryApi.md#getsecuritywithhttpinfo) | **GET** /attributecategories/{webId}/security | Get the security information of the specified security item associated with the attribute category for a specified user.
*AttributeCategoryApi* | [**GetSecurityEntries**](docs/Api/AttributeCategoryApi.md#getsecurityentries) | **GET** /attributecategories/{webId}/securityentries | Retrieve the security entries associated with the attribute category based on the specified criteria. By default, all security entries for this attribute category are returned.
*AttributeCategoryApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/AttributeCategoryApi.md#getsecurityentrieswithhttpinfo) | **GET** /attributecategories/{webId}/securityentries | Retrieve the security entries associated with the attribute category based on the specified criteria. By default, all security entries for this attribute category are returned.
*AttributeCategoryApi* | [**CreateSecurityEntry**](docs/Api/AttributeCategoryApi.md#createsecurityentry) | **POST** /attributecategories/{webId}/securityentries | Create a security entry owned by the attribute category.
*AttributeCategoryApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/AttributeCategoryApi.md#createsecurityentrywithhttpinfo) | **POST** /attributecategories/{webId}/securityentries | Create a security entry owned by the attribute category.
*AttributeCategoryApi* | [**GetSecurityEntryByName**](docs/Api/AttributeCategoryApi.md#getsecurityentrybyname) | **GET** /attributecategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the attribute category with the specified name.
*AttributeCategoryApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/AttributeCategoryApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /attributecategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the attribute category with the specified name.
*AttributeCategoryApi* | [**UpdateSecurityEntry**](docs/Api/AttributeCategoryApi.md#updatesecurityentry) | **PUT** /attributecategories/{webId}/securityentries/{name} | Update a security entry owned by the attribute category.
*AttributeCategoryApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/AttributeCategoryApi.md#updatesecurityentrywithhttpinfo) | **PUT** /attributecategories/{webId}/securityentries/{name} | Update a security entry owned by the attribute category.
*AttributeCategoryApi* | [**DeleteSecurityEntry**](docs/Api/AttributeCategoryApi.md#deletesecurityentry) | **DELETE** /attributecategories/{webId}/securityentries/{name} | Delete a security entry owned by the attribute category.
*AttributeCategoryApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/AttributeCategoryApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /attributecategories/{webId}/securityentries/{name} | Delete a security entry owned by the attribute category.
*AttributeApi* | [**GetByPath**](docs/Api/AttributeApi.md#getbypath) | **GET** /attributes | Retrieve an attribute by path.
*AttributeApi* | [**GetByPathWithHttpInfo**](docs/Api/AttributeApi.md#getbypathwithhttpinfo) | **GET** /attributes | Retrieve an attribute by path.
*AttributeApi* | [**Get**](docs/Api/AttributeApi.md#get) | **GET** /attributes/{webId} | Retrieve an attribute.
*AttributeApi* | [**GetWithHttpInfo**](docs/Api/AttributeApi.md#getwithhttpinfo) | **GET** /attributes/{webId} | Retrieve an attribute.
*AttributeApi* | [**Update**](docs/Api/AttributeApi.md#update) | **PATCH** /attributes/{webId} | Update an attribute by replacing items in its definition.
*AttributeApi* | [**UpdateWithHttpInfo**](docs/Api/AttributeApi.md#updatewithhttpinfo) | **PATCH** /attributes/{webId} | Update an attribute by replacing items in its definition.
*AttributeApi* | [**Delete**](docs/Api/AttributeApi.md#delete) | **DELETE** /attributes/{webId} | Delete an attribute.
*AttributeApi* | [**DeleteWithHttpInfo**](docs/Api/AttributeApi.md#deletewithhttpinfo) | **DELETE** /attributes/{webId} | Delete an attribute.
*AttributeApi* | [**GetAttributes**](docs/Api/AttributeApi.md#getattributes) | **GET** /attributes/{webId}/attributes | Get the child attributes of the specified attribute.
*AttributeApi* | [**GetAttributesWithHttpInfo**](docs/Api/AttributeApi.md#getattributeswithhttpinfo) | **GET** /attributes/{webId}/attributes | Get the child attributes of the specified attribute.
*AttributeApi* | [**CreateAttribute**](docs/Api/AttributeApi.md#createattribute) | **POST** /attributes/{webId}/attributes | Create a new attribute as a child of the specified attribute.
*AttributeApi* | [**CreateAttributeWithHttpInfo**](docs/Api/AttributeApi.md#createattributewithhttpinfo) | **POST** /attributes/{webId}/attributes | Create a new attribute as a child of the specified attribute.
*AttributeApi* | [**GetCategories**](docs/Api/AttributeApi.md#getcategories) | **GET** /attributes/{webId}/categories | Get an attribute's categories.
*AttributeApi* | [**GetCategoriesWithHttpInfo**](docs/Api/AttributeApi.md#getcategorieswithhttpinfo) | **GET** /attributes/{webId}/categories | Get an attribute's categories.
*AttributeApi* | [**CreateConfig**](docs/Api/AttributeApi.md#createconfig) | **POST** /attributes/{webId}/config | Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).
*AttributeApi* | [**CreateConfigWithHttpInfo**](docs/Api/AttributeApi.md#createconfigwithhttpinfo) | **POST** /attributes/{webId}/config | Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).
*AttributeApi* | [**GetValue**](docs/Api/AttributeApi.md#getvalue) | **GET** /attributes/{webId}/value | Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.
*AttributeApi* | [**GetValueWithHttpInfo**](docs/Api/AttributeApi.md#getvaluewithhttpinfo) | **GET** /attributes/{webId}/value | Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.
*AttributeApi* | [**SetValue**](docs/Api/AttributeApi.md#setvalue) | **PUT** /attributes/{webId}/value | Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.
*AttributeApi* | [**SetValueWithHttpInfo**](docs/Api/AttributeApi.md#setvaluewithhttpinfo) | **PUT** /attributes/{webId}/value | Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.
*AttributeApi* | [**GetMultiple**](docs/Api/AttributeApi.md#getmultiple) | **GET** /attributes/multiple | Retrieve multiple attributes by web id or path.
*AttributeApi* | [**GetMultipleWithHttpInfo**](docs/Api/AttributeApi.md#getmultiplewithhttpinfo) | **GET** /attributes/multiple | Retrieve multiple attributes by web id or path.
*AttributeTemplateApi* | [**GetByPath**](docs/Api/AttributeTemplateApi.md#getbypath) | **GET** /attributetemplates | Retrieve an attribute template by path.
*AttributeTemplateApi* | [**GetByPathWithHttpInfo**](docs/Api/AttributeTemplateApi.md#getbypathwithhttpinfo) | **GET** /attributetemplates | Retrieve an attribute template by path.
*AttributeTemplateApi* | [**Get**](docs/Api/AttributeTemplateApi.md#get) | **GET** /attributetemplates/{webId} | Retrieve an attribute template.
*AttributeTemplateApi* | [**GetWithHttpInfo**](docs/Api/AttributeTemplateApi.md#getwithhttpinfo) | **GET** /attributetemplates/{webId} | Retrieve an attribute template.
*AttributeTemplateApi* | [**Update**](docs/Api/AttributeTemplateApi.md#update) | **PATCH** /attributetemplates/{webId} | Update an existing attribute template by replacing items in its definition.
*AttributeTemplateApi* | [**UpdateWithHttpInfo**](docs/Api/AttributeTemplateApi.md#updatewithhttpinfo) | **PATCH** /attributetemplates/{webId} | Update an existing attribute template by replacing items in its definition.
*AttributeTemplateApi* | [**Delete**](docs/Api/AttributeTemplateApi.md#delete) | **DELETE** /attributetemplates/{webId} | Delete an attribute template.
*AttributeTemplateApi* | [**DeleteWithHttpInfo**](docs/Api/AttributeTemplateApi.md#deletewithhttpinfo) | **DELETE** /attributetemplates/{webId} | Delete an attribute template.
*AttributeTemplateApi* | [**GetAttributeTemplates**](docs/Api/AttributeTemplateApi.md#getattributetemplates) | **GET** /attributetemplates/{webId}/attributetemplates | Retrieve an attribute template's child attribute templates.
*AttributeTemplateApi* | [**GetAttributeTemplatesWithHttpInfo**](docs/Api/AttributeTemplateApi.md#getattributetemplateswithhttpinfo) | **GET** /attributetemplates/{webId}/attributetemplates | Retrieve an attribute template's child attribute templates.
*AttributeTemplateApi* | [**CreateAttributeTemplate**](docs/Api/AttributeTemplateApi.md#createattributetemplate) | **POST** /attributetemplates/{webId}/attributetemplates | Create an attribute template as a child of another attribute template.
*AttributeTemplateApi* | [**CreateAttributeTemplateWithHttpInfo**](docs/Api/AttributeTemplateApi.md#createattributetemplatewithhttpinfo) | **POST** /attributetemplates/{webId}/attributetemplates | Create an attribute template as a child of another attribute template.
*AttributeTemplateApi* | [**GetCategories**](docs/Api/AttributeTemplateApi.md#getcategories) | **GET** /attributetemplates/{webId}/categories | Get an attribute template's categories.
*AttributeTemplateApi* | [**GetCategoriesWithHttpInfo**](docs/Api/AttributeTemplateApi.md#getcategorieswithhttpinfo) | **GET** /attributetemplates/{webId}/categories | Get an attribute template's categories.
*AttributeTraitApi* | [**GetByCategory**](docs/Api/AttributeTraitApi.md#getbycategory) | **GET** /attributetraits | Retrieve all attribute traits of the specified category/categories.
*AttributeTraitApi* | [**GetByCategoryWithHttpInfo**](docs/Api/AttributeTraitApi.md#getbycategorywithhttpinfo) | **GET** /attributetraits | Retrieve all attribute traits of the specified category/categories.
*AttributeTraitApi* | [**Get**](docs/Api/AttributeTraitApi.md#get) | **GET** /attributetraits/{name} | Retrieve an attribute trait.
*AttributeTraitApi* | [**GetWithHttpInfo**](docs/Api/AttributeTraitApi.md#getwithhttpinfo) | **GET** /attributetraits/{name} | Retrieve an attribute trait.
*CalculationApi* | [**GetAtIntervals**](docs/Api/CalculationApi.md#getatintervals) | **GET** /calculation/intervals | Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
*CalculationApi* | [**GetAtIntervalsWithHttpInfo**](docs/Api/CalculationApi.md#getatintervalswithhttpinfo) | **GET** /calculation/intervals | Returns results of evaluating the expression over the time range from the start time to the end time at a defined interval.
*CalculationApi* | [**GetAtRecorded**](docs/Api/CalculationApi.md#getatrecorded) | **GET** /calculation/recorded | Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
*CalculationApi* | [**GetAtRecordedWithHttpInfo**](docs/Api/CalculationApi.md#getatrecordedwithhttpinfo) | **GET** /calculation/recorded | Returns the result of evaluating the expression at each point in time over the time range from the start time to the end time where a recorded value exists for a member of the expression.
*CalculationApi* | [**GetSummary**](docs/Api/CalculationApi.md#getsummary) | **GET** /calculation/summary | Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
*CalculationApi* | [**GetSummaryWithHttpInfo**](docs/Api/CalculationApi.md#getsummarywithhttpinfo) | **GET** /calculation/summary | Returns the result of evaluating the expression over the time range from the start time to the end time. The time range is first divided into a number of summary intervals. Then the calculation is performed for the specified summaries over each interval.
*CalculationApi* | [**GetAtTimes**](docs/Api/CalculationApi.md#getattimes) | **GET** /calculation/times | Returns the result of evaluating the expression at the specified timestamps.
*CalculationApi* | [**GetAtTimesWithHttpInfo**](docs/Api/CalculationApi.md#getattimeswithhttpinfo) | **GET** /calculation/times | Returns the result of evaluating the expression at the specified timestamps.
*ChannelApi* | [**Instances**](docs/Api/ChannelApi.md#instances) | **GET** /channels/instances | Retrieves a list of currently running channel instances.
*ChannelApi* | [**InstancesWithHttpInfo**](docs/Api/ChannelApi.md#instanceswithhttpinfo) | **GET** /channels/instances | Retrieves a list of currently running channel instances.
*DataServerApi* | [**List**](docs/Api/DataServerApi.md#list) | **GET** /dataservers | Retrieve a list of Data Servers known to this service.
*DataServerApi* | [**ListWithHttpInfo**](docs/Api/DataServerApi.md#listwithhttpinfo) | **GET** /dataservers | Retrieve a list of Data Servers known to this service.
*DataServerApi* | [**GetByName**](docs/Api/DataServerApi.md#getbyname) | **GET** /dataservers#name | Retrieve a Data Server by name.
*DataServerApi* | [**GetByNameWithHttpInfo**](docs/Api/DataServerApi.md#getbynamewithhttpinfo) | **GET** /dataservers#name | Retrieve a Data Server by name.
*DataServerApi* | [**GetByPath**](docs/Api/DataServerApi.md#getbypath) | **GET** /dataservers#path | Retrieve a Data Server by path.
*DataServerApi* | [**GetByPathWithHttpInfo**](docs/Api/DataServerApi.md#getbypathwithhttpinfo) | **GET** /dataservers#path | Retrieve a Data Server by path.
*DataServerApi* | [**Get**](docs/Api/DataServerApi.md#get) | **GET** /dataservers/{webId} | Retrieve a Data Server.
*DataServerApi* | [**GetWithHttpInfo**](docs/Api/DataServerApi.md#getwithhttpinfo) | **GET** /dataservers/{webId} | Retrieve a Data Server.
*DataServerApi* | [**GetEnumerationSets**](docs/Api/DataServerApi.md#getenumerationsets) | **GET** /dataservers/{webId}/enumerationsets | Retrieve enumeration sets for given Data Server.
*DataServerApi* | [**GetEnumerationSetsWithHttpInfo**](docs/Api/DataServerApi.md#getenumerationsetswithhttpinfo) | **GET** /dataservers/{webId}/enumerationsets | Retrieve enumeration sets for given Data Server.
*DataServerApi* | [**CreateEnumerationSet**](docs/Api/DataServerApi.md#createenumerationset) | **POST** /dataservers/{webId}/enumerationsets | Create an enumeration set on the Data Server.
*DataServerApi* | [**CreateEnumerationSetWithHttpInfo**](docs/Api/DataServerApi.md#createenumerationsetwithhttpinfo) | **POST** /dataservers/{webId}/enumerationsets | Create an enumeration set on the Data Server.
*DataServerApi* | [**GetPoints**](docs/Api/DataServerApi.md#getpoints) | **GET** /dataservers/{webId}/points | Retrieve a list of points on a specified Data Server.
*DataServerApi* | [**GetPointsWithHttpInfo**](docs/Api/DataServerApi.md#getpointswithhttpinfo) | **GET** /dataservers/{webId}/points | Retrieve a list of points on a specified Data Server.
*DataServerApi* | [**CreatePoint**](docs/Api/DataServerApi.md#createpoint) | **POST** /dataservers/{webId}/points | Create a point in the specified Data Server.
*DataServerApi* | [**CreatePointWithHttpInfo**](docs/Api/DataServerApi.md#createpointwithhttpinfo) | **POST** /dataservers/{webId}/points | Create a point in the specified Data Server.
*ElementCategoryApi* | [**GetByPath**](docs/Api/ElementCategoryApi.md#getbypath) | **GET** /elementcategories | Retrieve an element category by path.
*ElementCategoryApi* | [**GetByPathWithHttpInfo**](docs/Api/ElementCategoryApi.md#getbypathwithhttpinfo) | **GET** /elementcategories | Retrieve an element category by path.
*ElementCategoryApi* | [**Get**](docs/Api/ElementCategoryApi.md#get) | **GET** /elementcategories/{webId} | Retrieve an element category.
*ElementCategoryApi* | [**GetWithHttpInfo**](docs/Api/ElementCategoryApi.md#getwithhttpinfo) | **GET** /elementcategories/{webId} | Retrieve an element category.
*ElementCategoryApi* | [**Update**](docs/Api/ElementCategoryApi.md#update) | **PATCH** /elementcategories/{webId} | Update an element category by replacing items in its definition.
*ElementCategoryApi* | [**UpdateWithHttpInfo**](docs/Api/ElementCategoryApi.md#updatewithhttpinfo) | **PATCH** /elementcategories/{webId} | Update an element category by replacing items in its definition.
*ElementCategoryApi* | [**Delete**](docs/Api/ElementCategoryApi.md#delete) | **DELETE** /elementcategories/{webId} | Delete an element category.
*ElementCategoryApi* | [**DeleteWithHttpInfo**](docs/Api/ElementCategoryApi.md#deletewithhttpinfo) | **DELETE** /elementcategories/{webId} | Delete an element category.
*ElementCategoryApi* | [**GetSecurity**](docs/Api/ElementCategoryApi.md#getsecurity) | **GET** /elementcategories/{webId}/security | Get the security information of the specified security item associated with the element category for a specified user.
*ElementCategoryApi* | [**GetSecurityWithHttpInfo**](docs/Api/ElementCategoryApi.md#getsecuritywithhttpinfo) | **GET** /elementcategories/{webId}/security | Get the security information of the specified security item associated with the element category for a specified user.
*ElementCategoryApi* | [**GetSecurityEntries**](docs/Api/ElementCategoryApi.md#getsecurityentries) | **GET** /elementcategories/{webId}/securityentries | Retrieve the security entries associated with the element category based on the specified criteria. By default, all security entries for this element category are returned.
*ElementCategoryApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/ElementCategoryApi.md#getsecurityentrieswithhttpinfo) | **GET** /elementcategories/{webId}/securityentries | Retrieve the security entries associated with the element category based on the specified criteria. By default, all security entries for this element category are returned.
*ElementCategoryApi* | [**CreateSecurityEntry**](docs/Api/ElementCategoryApi.md#createsecurityentry) | **POST** /elementcategories/{webId}/securityentries | Create a security entry owned by the element category.
*ElementCategoryApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/ElementCategoryApi.md#createsecurityentrywithhttpinfo) | **POST** /elementcategories/{webId}/securityentries | Create a security entry owned by the element category.
*ElementCategoryApi* | [**GetSecurityEntryByName**](docs/Api/ElementCategoryApi.md#getsecurityentrybyname) | **GET** /elementcategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the element category with the specified name.
*ElementCategoryApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/ElementCategoryApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /elementcategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the element category with the specified name.
*ElementCategoryApi* | [**UpdateSecurityEntry**](docs/Api/ElementCategoryApi.md#updatesecurityentry) | **PUT** /elementcategories/{webId}/securityentries/{name} | Update a security entry owned by the element category.
*ElementCategoryApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/ElementCategoryApi.md#updatesecurityentrywithhttpinfo) | **PUT** /elementcategories/{webId}/securityentries/{name} | Update a security entry owned by the element category.
*ElementCategoryApi* | [**DeleteSecurityEntry**](docs/Api/ElementCategoryApi.md#deletesecurityentry) | **DELETE** /elementcategories/{webId}/securityentries/{name} | Delete a security entry owned by the element category.
*ElementCategoryApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/ElementCategoryApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /elementcategories/{webId}/securityentries/{name} | Delete a security entry owned by the element category.
*ElementApi* | [**GetByPath**](docs/Api/ElementApi.md#getbypath) | **GET** /elements | Retrieve an element by path.
*ElementApi* | [**GetByPathWithHttpInfo**](docs/Api/ElementApi.md#getbypathwithhttpinfo) | **GET** /elements | Retrieve an element by path.
*ElementApi* | [**Get**](docs/Api/ElementApi.md#get) | **GET** /elements/{webId} | Retrieve an element.
*ElementApi* | [**GetWithHttpInfo**](docs/Api/ElementApi.md#getwithhttpinfo) | **GET** /elements/{webId} | Retrieve an element.
*ElementApi* | [**Update**](docs/Api/ElementApi.md#update) | **PATCH** /elements/{webId} | Update an element by replacing items in its definition.
*ElementApi* | [**UpdateWithHttpInfo**](docs/Api/ElementApi.md#updatewithhttpinfo) | **PATCH** /elements/{webId} | Update an element by replacing items in its definition.
*ElementApi* | [**Delete**](docs/Api/ElementApi.md#delete) | **DELETE** /elements/{webId} | Delete an element.
*ElementApi* | [**DeleteWithHttpInfo**](docs/Api/ElementApi.md#deletewithhttpinfo) | **DELETE** /elements/{webId} | Delete an element.
*ElementApi* | [**GetAnalyses**](docs/Api/ElementApi.md#getanalyses) | **GET** /elements/{webId}/analyses | Retrieve analyses based on the specified conditions.
*ElementApi* | [**GetAnalysesWithHttpInfo**](docs/Api/ElementApi.md#getanalyseswithhttpinfo) | **GET** /elements/{webId}/analyses | Retrieve analyses based on the specified conditions.
*ElementApi* | [**CreateAnalysis**](docs/Api/ElementApi.md#createanalysis) | **POST** /elements/{webId}/analyses | Create an Analysis.
*ElementApi* | [**CreateAnalysisWithHttpInfo**](docs/Api/ElementApi.md#createanalysiswithhttpinfo) | **POST** /elements/{webId}/analyses | Create an Analysis.
*ElementApi* | [**GetAttributes**](docs/Api/ElementApi.md#getattributes) | **GET** /elements/{webId}/attributes | Get the attributes of the specified element.
*ElementApi* | [**GetAttributesWithHttpInfo**](docs/Api/ElementApi.md#getattributeswithhttpinfo) | **GET** /elements/{webId}/attributes | Get the attributes of the specified element.
*ElementApi* | [**CreateAttribute**](docs/Api/ElementApi.md#createattribute) | **POST** /elements/{webId}/attributes | Create a new attribute of the specified element.
*ElementApi* | [**CreateAttributeWithHttpInfo**](docs/Api/ElementApi.md#createattributewithhttpinfo) | **POST** /elements/{webId}/attributes | Create a new attribute of the specified element.
*ElementApi* | [**GetCategories**](docs/Api/ElementApi.md#getcategories) | **GET** /elements/{webId}/categories | Get an element's categories.
*ElementApi* | [**GetCategoriesWithHttpInfo**](docs/Api/ElementApi.md#getcategorieswithhttpinfo) | **GET** /elements/{webId}/categories | Get an element's categories.
*ElementApi* | [**CreateConfig**](docs/Api/ElementApi.md#createconfig) | **POST** /elements/{webId}/config | Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
*ElementApi* | [**CreateConfigWithHttpInfo**](docs/Api/ElementApi.md#createconfigwithhttpinfo) | **POST** /elements/{webId}/config | Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
*ElementApi* | [**FindElementAttributes**](docs/Api/ElementApi.md#findelementattributes) | **GET** /elements/{webId}/elementattributes | Retrieves a list of element attributes matching the specified filters from the specified element.
*ElementApi* | [**FindElementAttributesWithHttpInfo**](docs/Api/ElementApi.md#findelementattributeswithhttpinfo) | **GET** /elements/{webId}/elementattributes | Retrieves a list of element attributes matching the specified filters from the specified element.
*ElementApi* | [**GetElements**](docs/Api/ElementApi.md#getelements) | **GET** /elements/{webId}/elements | Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
*ElementApi* | [**GetElementsWithHttpInfo**](docs/Api/ElementApi.md#getelementswithhttpinfo) | **GET** /elements/{webId}/elements | Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
*ElementApi* | [**CreateElement**](docs/Api/ElementApi.md#createelement) | **POST** /elements/{webId}/elements | Create a child element.
*ElementApi* | [**CreateElementWithHttpInfo**](docs/Api/ElementApi.md#createelementwithhttpinfo) | **POST** /elements/{webId}/elements | Create a child element.
*ElementApi* | [**GetEventFrames**](docs/Api/ElementApi.md#geteventframes) | **GET** /elements/{webId}/eventframes | Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
*ElementApi* | [**GetEventFramesWithHttpInfo**](docs/Api/ElementApi.md#geteventframeswithhttpinfo) | **GET** /elements/{webId}/eventframes | Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
*ElementApi* | [**GetReferencedElements**](docs/Api/ElementApi.md#getreferencedelements) | **GET** /elements/{webId}/referencedelements | Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
*ElementApi* | [**GetReferencedElementsWithHttpInfo**](docs/Api/ElementApi.md#getreferencedelementswithhttpinfo) | **GET** /elements/{webId}/referencedelements | Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
*ElementApi* | [**AddReferencedElement**](docs/Api/ElementApi.md#addreferencedelement) | **POST** /elements/{webId}/referencedelements | Add a reference to an existing element to the child elements collection.
*ElementApi* | [**AddReferencedElementWithHttpInfo**](docs/Api/ElementApi.md#addreferencedelementwithhttpinfo) | **POST** /elements/{webId}/referencedelements | Add a reference to an existing element to the child elements collection.
*ElementApi* | [**RemoveReferencedElement**](docs/Api/ElementApi.md#removereferencedelement) | **DELETE** /elements/{webId}/referencedelements | Remove a reference to an existing element from the child elements collection.
*ElementApi* | [**RemoveReferencedElementWithHttpInfo**](docs/Api/ElementApi.md#removereferencedelementwithhttpinfo) | **DELETE** /elements/{webId}/referencedelements | Remove a reference to an existing element from the child elements collection.
*ElementApi* | [**GetSecurity**](docs/Api/ElementApi.md#getsecurity) | **GET** /elements/{webId}/security | Get the security information of the specified security item associated with the element for a specified user.
*ElementApi* | [**GetSecurityWithHttpInfo**](docs/Api/ElementApi.md#getsecuritywithhttpinfo) | **GET** /elements/{webId}/security | Get the security information of the specified security item associated with the element for a specified user.
*ElementApi* | [**GetSecurityEntries**](docs/Api/ElementApi.md#getsecurityentries) | **GET** /elements/{webId}/securityentries | Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
*ElementApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/ElementApi.md#getsecurityentrieswithhttpinfo) | **GET** /elements/{webId}/securityentries | Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
*ElementApi* | [**CreateSecurityEntry**](docs/Api/ElementApi.md#createsecurityentry) | **POST** /elements/{webId}/securityentries | Create a security entry owned by the element.
*ElementApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/ElementApi.md#createsecurityentrywithhttpinfo) | **POST** /elements/{webId}/securityentries | Create a security entry owned by the element.
*ElementApi* | [**GetSecurityEntryByName**](docs/Api/ElementApi.md#getsecurityentrybyname) | **GET** /elements/{webId}/securityentries/{name} | Retrieve the security entry associated with the element with the specified name.
*ElementApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/ElementApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /elements/{webId}/securityentries/{name} | Retrieve the security entry associated with the element with the specified name.
*ElementApi* | [**UpdateSecurityEntry**](docs/Api/ElementApi.md#updatesecurityentry) | **PUT** /elements/{webId}/securityentries/{name} | Update a security entry owned by the element.
*ElementApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/ElementApi.md#updatesecurityentrywithhttpinfo) | **PUT** /elements/{webId}/securityentries/{name} | Update a security entry owned by the element.
*ElementApi* | [**DeleteSecurityEntry**](docs/Api/ElementApi.md#deletesecurityentry) | **DELETE** /elements/{webId}/securityentries/{name} | Delete a security entry owned by the element.
*ElementApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/ElementApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /elements/{webId}/securityentries/{name} | Delete a security entry owned by the element.
*ElementApi* | [**GetMultiple**](docs/Api/ElementApi.md#getmultiple) | **GET** /elements/multiple | Retrieve multiple elements by web id or path.
*ElementApi* | [**GetMultipleWithHttpInfo**](docs/Api/ElementApi.md#getmultiplewithhttpinfo) | **GET** /elements/multiple | Retrieve multiple elements by web id or path.
*ElementApi* | [**CreateSearchByAttribute**](docs/Api/ElementApi.md#createsearchbyattribute) | **POST** /elements/searchbyattribute | Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
*ElementApi* | [**CreateSearchByAttributeWithHttpInfo**](docs/Api/ElementApi.md#createsearchbyattributewithhttpinfo) | **POST** /elements/searchbyattribute | Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
*ElementApi* | [**ExecuteSearchByAttribute**](docs/Api/ElementApi.md#executesearchbyattribute) | **GET** /elements/searchbyattribute/{searchId} | Execute a "Search Elements By Attribute Value" operation.
*ElementApi* | [**ExecuteSearchByAttributeWithHttpInfo**](docs/Api/ElementApi.md#executesearchbyattributewithhttpinfo) | **GET** /elements/searchbyattribute/{searchId} | Execute a "Search Elements By Attribute Value" operation.
*ElementTemplateApi* | [**GetByPath**](docs/Api/ElementTemplateApi.md#getbypath) | **GET** /elementtemplates | Retrieve an element template by path.
*ElementTemplateApi* | [**GetByPathWithHttpInfo**](docs/Api/ElementTemplateApi.md#getbypathwithhttpinfo) | **GET** /elementtemplates | Retrieve an element template by path.
*ElementTemplateApi* | [**Get**](docs/Api/ElementTemplateApi.md#get) | **GET** /elementtemplates/{webId} | Retrieve an element template.
*ElementTemplateApi* | [**GetWithHttpInfo**](docs/Api/ElementTemplateApi.md#getwithhttpinfo) | **GET** /elementtemplates/{webId} | Retrieve an element template.
*ElementTemplateApi* | [**Update**](docs/Api/ElementTemplateApi.md#update) | **PATCH** /elementtemplates/{webId} | Update an element template by replacing items in its definition.
*ElementTemplateApi* | [**UpdateWithHttpInfo**](docs/Api/ElementTemplateApi.md#updatewithhttpinfo) | **PATCH** /elementtemplates/{webId} | Update an element template by replacing items in its definition.
*ElementTemplateApi* | [**Delete**](docs/Api/ElementTemplateApi.md#delete) | **DELETE** /elementtemplates/{webId} | Delete an element template.
*ElementTemplateApi* | [**DeleteWithHttpInfo**](docs/Api/ElementTemplateApi.md#deletewithhttpinfo) | **DELETE** /elementtemplates/{webId} | Delete an element template.
*ElementTemplateApi* | [**GetAnalysisTemplates**](docs/Api/ElementTemplateApi.md#getanalysistemplates) | **GET** /elementtemplates/{webId}/analysistemplates | Get analysis templates for an element template.
*ElementTemplateApi* | [**GetAnalysisTemplatesWithHttpInfo**](docs/Api/ElementTemplateApi.md#getanalysistemplateswithhttpinfo) | **GET** /elementtemplates/{webId}/analysistemplates | Get analysis templates for an element template.
*ElementTemplateApi* | [**GetAttributeTemplates**](docs/Api/ElementTemplateApi.md#getattributetemplates) | **GET** /elementtemplates/{webId}/attributetemplates | Get child attribute templates for an element template.
*ElementTemplateApi* | [**GetAttributeTemplatesWithHttpInfo**](docs/Api/ElementTemplateApi.md#getattributetemplateswithhttpinfo) | **GET** /elementtemplates/{webId}/attributetemplates | Get child attribute templates for an element template.
*ElementTemplateApi* | [**CreateAttributeTemplate**](docs/Api/ElementTemplateApi.md#createattributetemplate) | **POST** /elementtemplates/{webId}/attributetemplates | Create an attribute template.
*ElementTemplateApi* | [**CreateAttributeTemplateWithHttpInfo**](docs/Api/ElementTemplateApi.md#createattributetemplatewithhttpinfo) | **POST** /elementtemplates/{webId}/attributetemplates | Create an attribute template.
*ElementTemplateApi* | [**GetCategories**](docs/Api/ElementTemplateApi.md#getcategories) | **GET** /elementtemplates/{webId}/categories | Get an element template's categories.
*ElementTemplateApi* | [**GetCategoriesWithHttpInfo**](docs/Api/ElementTemplateApi.md#getcategorieswithhttpinfo) | **GET** /elementtemplates/{webId}/categories | Get an element template's categories.
*ElementTemplateApi* | [**GetSecurity**](docs/Api/ElementTemplateApi.md#getsecurity) | **GET** /elementtemplates/{webId}/security | Get the security information of the specified security item associated with the element template for a specified user.
*ElementTemplateApi* | [**GetSecurityWithHttpInfo**](docs/Api/ElementTemplateApi.md#getsecuritywithhttpinfo) | **GET** /elementtemplates/{webId}/security | Get the security information of the specified security item associated with the element template for a specified user.
*ElementTemplateApi* | [**GetSecurityEntries**](docs/Api/ElementTemplateApi.md#getsecurityentries) | **GET** /elementtemplates/{webId}/securityentries | Retrieve the security entries associated with the element template based on the specified criteria. By default, all security entries for this element template are returned.
*ElementTemplateApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/ElementTemplateApi.md#getsecurityentrieswithhttpinfo) | **GET** /elementtemplates/{webId}/securityentries | Retrieve the security entries associated with the element template based on the specified criteria. By default, all security entries for this element template are returned.
*ElementTemplateApi* | [**CreateSecurityEntry**](docs/Api/ElementTemplateApi.md#createsecurityentry) | **POST** /elementtemplates/{webId}/securityentries | Create a security entry owned by the element template.
*ElementTemplateApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/ElementTemplateApi.md#createsecurityentrywithhttpinfo) | **POST** /elementtemplates/{webId}/securityentries | Create a security entry owned by the element template.
*ElementTemplateApi* | [**GetSecurityEntryByName**](docs/Api/ElementTemplateApi.md#getsecurityentrybyname) | **GET** /elementtemplates/{webId}/securityentries/{name} | Retrieve the security entry associated with the element template with the specified name.
*ElementTemplateApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/ElementTemplateApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /elementtemplates/{webId}/securityentries/{name} | Retrieve the security entry associated with the element template with the specified name.
*ElementTemplateApi* | [**UpdateSecurityEntry**](docs/Api/ElementTemplateApi.md#updatesecurityentry) | **PUT** /elementtemplates/{webId}/securityentries/{name} | Update a security entry owned by the element template.
*ElementTemplateApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/ElementTemplateApi.md#updatesecurityentrywithhttpinfo) | **PUT** /elementtemplates/{webId}/securityentries/{name} | Update a security entry owned by the element template.
*ElementTemplateApi* | [**DeleteSecurityEntry**](docs/Api/ElementTemplateApi.md#deletesecurityentry) | **DELETE** /elementtemplates/{webId}/securityentries/{name} | Delete a security entry owned by the element template.
*ElementTemplateApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/ElementTemplateApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /elementtemplates/{webId}/securityentries/{name} | Delete a security entry owned by the element template.
*EnumerationSetApi* | [**GetByPath**](docs/Api/EnumerationSetApi.md#getbypath) | **GET** /enumerationsets | Retrieve an enumeration set by path.
*EnumerationSetApi* | [**GetByPathWithHttpInfo**](docs/Api/EnumerationSetApi.md#getbypathwithhttpinfo) | **GET** /enumerationsets | Retrieve an enumeration set by path.
*EnumerationSetApi* | [**Get**](docs/Api/EnumerationSetApi.md#get) | **GET** /enumerationsets/{webId} | Retrieve an enumeration set.
*EnumerationSetApi* | [**GetWithHttpInfo**](docs/Api/EnumerationSetApi.md#getwithhttpinfo) | **GET** /enumerationsets/{webId} | Retrieve an enumeration set.
*EnumerationSetApi* | [**Update**](docs/Api/EnumerationSetApi.md#update) | **PATCH** /enumerationsets/{webId} | Update an enumeration set by replacing items in its definition.
*EnumerationSetApi* | [**UpdateWithHttpInfo**](docs/Api/EnumerationSetApi.md#updatewithhttpinfo) | **PATCH** /enumerationsets/{webId} | Update an enumeration set by replacing items in its definition.
*EnumerationSetApi* | [**Delete**](docs/Api/EnumerationSetApi.md#delete) | **DELETE** /enumerationsets/{webId} | Delete an enumeration set.
*EnumerationSetApi* | [**DeleteWithHttpInfo**](docs/Api/EnumerationSetApi.md#deletewithhttpinfo) | **DELETE** /enumerationsets/{webId} | Delete an enumeration set.
*EnumerationSetApi* | [**GetValues**](docs/Api/EnumerationSetApi.md#getvalues) | **GET** /enumerationsets/{webId}/enumerationvalues | Retrieve an enumeration set's values.
*EnumerationSetApi* | [**GetValuesWithHttpInfo**](docs/Api/EnumerationSetApi.md#getvalueswithhttpinfo) | **GET** /enumerationsets/{webId}/enumerationvalues | Retrieve an enumeration set's values.
*EnumerationSetApi* | [**CreateValue**](docs/Api/EnumerationSetApi.md#createvalue) | **POST** /enumerationsets/{webId}/enumerationvalues | Create an enumeration value for a enumeration set.
*EnumerationSetApi* | [**CreateValueWithHttpInfo**](docs/Api/EnumerationSetApi.md#createvaluewithhttpinfo) | **POST** /enumerationsets/{webId}/enumerationvalues | Create an enumeration value for a enumeration set.
*EnumerationSetApi* | [**GetSecurity**](docs/Api/EnumerationSetApi.md#getsecurity) | **GET** /enumerationsets/{webId}/security | Get the security information of the specified security item associated with the enumeration set for a specified user.
*EnumerationSetApi* | [**GetSecurityWithHttpInfo**](docs/Api/EnumerationSetApi.md#getsecuritywithhttpinfo) | **GET** /enumerationsets/{webId}/security | Get the security information of the specified security item associated with the enumeration set for a specified user.
*EnumerationSetApi* | [**GetSecurityEntries**](docs/Api/EnumerationSetApi.md#getsecurityentries) | **GET** /enumerationsets/{webId}/securityentries | Retrieve the security entries associated with the enumeration set based on the specified criteria. By default, all security entries for this enumeration set are returned.
*EnumerationSetApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/EnumerationSetApi.md#getsecurityentrieswithhttpinfo) | **GET** /enumerationsets/{webId}/securityentries | Retrieve the security entries associated with the enumeration set based on the specified criteria. By default, all security entries for this enumeration set are returned.
*EnumerationSetApi* | [**CreateSecurityEntry**](docs/Api/EnumerationSetApi.md#createsecurityentry) | **POST** /enumerationsets/{webId}/securityentries | Create a security entry owned by the enumeration set.
*EnumerationSetApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/EnumerationSetApi.md#createsecurityentrywithhttpinfo) | **POST** /enumerationsets/{webId}/securityentries | Create a security entry owned by the enumeration set.
*EnumerationSetApi* | [**GetSecurityEntryByName**](docs/Api/EnumerationSetApi.md#getsecurityentrybyname) | **GET** /enumerationsets/{webId}/securityentries/{name} | Retrieve the security entry associated with the enumeration set with the specified name.
*EnumerationSetApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/EnumerationSetApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /enumerationsets/{webId}/securityentries/{name} | Retrieve the security entry associated with the enumeration set with the specified name.
*EnumerationSetApi* | [**UpdateSecurityEntry**](docs/Api/EnumerationSetApi.md#updatesecurityentry) | **PUT** /enumerationsets/{webId}/securityentries/{name} | Update a security entry owned by the enumeration set.
*EnumerationSetApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/EnumerationSetApi.md#updatesecurityentrywithhttpinfo) | **PUT** /enumerationsets/{webId}/securityentries/{name} | Update a security entry owned by the enumeration set.
*EnumerationSetApi* | [**DeleteSecurityEntry**](docs/Api/EnumerationSetApi.md#deletesecurityentry) | **DELETE** /enumerationsets/{webId}/securityentries/{name} | Delete a security entry owned by the enumeration set.
*EnumerationSetApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/EnumerationSetApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /enumerationsets/{webId}/securityentries/{name} | Delete a security entry owned by the enumeration set.
*EnumerationValueApi* | [**GetByPath**](docs/Api/EnumerationValueApi.md#getbypath) | **GET** /enumerationvalues | Retrieve an enumeration value by path.
*EnumerationValueApi* | [**GetByPathWithHttpInfo**](docs/Api/EnumerationValueApi.md#getbypathwithhttpinfo) | **GET** /enumerationvalues | Retrieve an enumeration value by path.
*EnumerationValueApi* | [**Get**](docs/Api/EnumerationValueApi.md#get) | **GET** /enumerationvalues/{webId} | Retrieve an enumeration value mapping
*EnumerationValueApi* | [**GetWithHttpInfo**](docs/Api/EnumerationValueApi.md#getwithhttpinfo) | **GET** /enumerationvalues/{webId} | Retrieve an enumeration value mapping
*EnumerationValueApi* | [**UpdateEnumerationValue**](docs/Api/EnumerationValueApi.md#updateenumerationvalue) | **PATCH** /enumerationvalues/{webId} | Update an enumeration value by replacing items in its definition.
*EnumerationValueApi* | [**UpdateEnumerationValueWithHttpInfo**](docs/Api/EnumerationValueApi.md#updateenumerationvaluewithhttpinfo) | **PATCH** /enumerationvalues/{webId} | Update an enumeration value by replacing items in its definition.
*EnumerationValueApi* | [**DeleteEnumerationValue**](docs/Api/EnumerationValueApi.md#deleteenumerationvalue) | **DELETE** /enumerationvalues/{webId} | Delete an enumeration value from an enumeration set.
*EnumerationValueApi* | [**DeleteEnumerationValueWithHttpInfo**](docs/Api/EnumerationValueApi.md#deleteenumerationvaluewithhttpinfo) | **DELETE** /enumerationvalues/{webId} | Delete an enumeration value from an enumeration set.
*EventFrameApi* | [**GetByPath**](docs/Api/EventFrameApi.md#getbypath) | **GET** /eventframes | Retrieve an event frame by path.
*EventFrameApi* | [**GetByPathWithHttpInfo**](docs/Api/EventFrameApi.md#getbypathwithhttpinfo) | **GET** /eventframes | Retrieve an event frame by path.
*EventFrameApi* | [**Get**](docs/Api/EventFrameApi.md#get) | **GET** /eventframes/{webId} | Retrieve an event frame.
*EventFrameApi* | [**GetWithHttpInfo**](docs/Api/EventFrameApi.md#getwithhttpinfo) | **GET** /eventframes/{webId} | Retrieve an event frame.
*EventFrameApi* | [**Update**](docs/Api/EventFrameApi.md#update) | **PATCH** /eventframes/{webId} | Update an event frame by replacing items in its definition.
*EventFrameApi* | [**UpdateWithHttpInfo**](docs/Api/EventFrameApi.md#updatewithhttpinfo) | **PATCH** /eventframes/{webId} | Update an event frame by replacing items in its definition.
*EventFrameApi* | [**Delete**](docs/Api/EventFrameApi.md#delete) | **DELETE** /eventframes/{webId} | Delete an event frame.
*EventFrameApi* | [**DeleteWithHttpInfo**](docs/Api/EventFrameApi.md#deletewithhttpinfo) | **DELETE** /eventframes/{webId} | Delete an event frame.
*EventFrameApi* | [**Acknowledge**](docs/Api/EventFrameApi.md#acknowledge) | **PATCH** /eventframes/{webId}/acknowledge | Calls the EventFrame's Acknowledge method.
*EventFrameApi* | [**AcknowledgeWithHttpInfo**](docs/Api/EventFrameApi.md#acknowledgewithhttpinfo) | **PATCH** /eventframes/{webId}/acknowledge | Calls the EventFrame's Acknowledge method.
*EventFrameApi* | [**GetAnnotations**](docs/Api/EventFrameApi.md#getannotations) | **GET** /eventframes/{webId}/annotations | Get an event frame's annotations.
*EventFrameApi* | [**GetAnnotationsWithHttpInfo**](docs/Api/EventFrameApi.md#getannotationswithhttpinfo) | **GET** /eventframes/{webId}/annotations | Get an event frame's annotations.
*EventFrameApi* | [**CreateAnnotation**](docs/Api/EventFrameApi.md#createannotation) | **POST** /eventframes/{webId}/annotations | Create an annotation on an event frame.
*EventFrameApi* | [**CreateAnnotationWithHttpInfo**](docs/Api/EventFrameApi.md#createannotationwithhttpinfo) | **POST** /eventframes/{webId}/annotations | Create an annotation on an event frame.
*EventFrameApi* | [**GetAnnotationById**](docs/Api/EventFrameApi.md#getannotationbyid) | **GET** /eventframes/{webId}/annotations/{id} | Get a specific annotation on an event frame.
*EventFrameApi* | [**GetAnnotationByIdWithHttpInfo**](docs/Api/EventFrameApi.md#getannotationbyidwithhttpinfo) | **GET** /eventframes/{webId}/annotations/{id} | Get a specific annotation on an event frame.
*EventFrameApi* | [**UpdateAnnotation**](docs/Api/EventFrameApi.md#updateannotation) | **PATCH** /eventframes/{webId}/annotations/{id} | Update an annotation on an event frame by replacing items in its definition.
*EventFrameApi* | [**UpdateAnnotationWithHttpInfo**](docs/Api/EventFrameApi.md#updateannotationwithhttpinfo) | **PATCH** /eventframes/{webId}/annotations/{id} | Update an annotation on an event frame by replacing items in its definition.
*EventFrameApi* | [**DeleteAnnotation**](docs/Api/EventFrameApi.md#deleteannotation) | **DELETE** /eventframes/{webId}/annotations/{id} | Delete an annotation on an event frame.
*EventFrameApi* | [**DeleteAnnotationWithHttpInfo**](docs/Api/EventFrameApi.md#deleteannotationwithhttpinfo) | **DELETE** /eventframes/{webId}/annotations/{id} | Delete an annotation on an event frame.
*EventFrameApi* | [**GetAttributes**](docs/Api/EventFrameApi.md#getattributes) | **GET** /eventframes/{webId}/attributes | Get the attributes of the specified event frame.
*EventFrameApi* | [**GetAttributesWithHttpInfo**](docs/Api/EventFrameApi.md#getattributeswithhttpinfo) | **GET** /eventframes/{webId}/attributes | Get the attributes of the specified event frame.
*EventFrameApi* | [**CreateAttribute**](docs/Api/EventFrameApi.md#createattribute) | **POST** /eventframes/{webId}/attributes | Create a new attribute of the specified event frame.
*EventFrameApi* | [**CreateAttributeWithHttpInfo**](docs/Api/EventFrameApi.md#createattributewithhttpinfo) | **POST** /eventframes/{webId}/attributes | Create a new attribute of the specified event frame.
*EventFrameApi* | [**CaptureValues**](docs/Api/EventFrameApi.md#capturevalues) | **POST** /eventframes/{webId}/attributes/capture | Calls the EventFrame's CaptureValues method.
*EventFrameApi* | [**CaptureValuesWithHttpInfo**](docs/Api/EventFrameApi.md#capturevalueswithhttpinfo) | **POST** /eventframes/{webId}/attributes/capture | Calls the EventFrame's CaptureValues method.
*EventFrameApi* | [**GetCategories**](docs/Api/EventFrameApi.md#getcategories) | **GET** /eventframes/{webId}/categories | Get an event frame's categories.
*EventFrameApi* | [**GetCategoriesWithHttpInfo**](docs/Api/EventFrameApi.md#getcategorieswithhttpinfo) | **GET** /eventframes/{webId}/categories | Get an event frame's categories.
*EventFrameApi* | [**CreateConfig**](docs/Api/EventFrameApi.md#createconfig) | **POST** /eventframes/{webId}/config | Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
*EventFrameApi* | [**CreateConfigWithHttpInfo**](docs/Api/EventFrameApi.md#createconfigwithhttpinfo) | **POST** /eventframes/{webId}/config | Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
*EventFrameApi* | [**FindEventFrameAttributes**](docs/Api/EventFrameApi.md#findeventframeattributes) | **GET** /eventframes/{webId}/eventframeattributes | Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
*EventFrameApi* | [**FindEventFrameAttributesWithHttpInfo**](docs/Api/EventFrameApi.md#findeventframeattributeswithhttpinfo) | **GET** /eventframes/{webId}/eventframeattributes | Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
*EventFrameApi* | [**GetEventFrames**](docs/Api/EventFrameApi.md#geteventframes) | **GET** /eventframes/{webId}/eventframes | Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
*EventFrameApi* | [**GetEventFramesWithHttpInfo**](docs/Api/EventFrameApi.md#geteventframeswithhttpinfo) | **GET** /eventframes/{webId}/eventframes | Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
*EventFrameApi* | [**CreateEventFrame**](docs/Api/EventFrameApi.md#createeventframe) | **POST** /eventframes/{webId}/eventframes | Create an event frame as a child of the specified event frame.
*EventFrameApi* | [**CreateEventFrameWithHttpInfo**](docs/Api/EventFrameApi.md#createeventframewithhttpinfo) | **POST** /eventframes/{webId}/eventframes | Create an event frame as a child of the specified event frame.
*EventFrameApi* | [**GetReferencedElements**](docs/Api/EventFrameApi.md#getreferencedelements) | **GET** /eventframes/{webId}/referencedelements | Retrieve the event frame's referenced elements.
*EventFrameApi* | [**GetReferencedElementsWithHttpInfo**](docs/Api/EventFrameApi.md#getreferencedelementswithhttpinfo) | **GET** /eventframes/{webId}/referencedelements | Retrieve the event frame's referenced elements.
*EventFrameApi* | [**GetSecurity**](docs/Api/EventFrameApi.md#getsecurity) | **GET** /eventframes/{webId}/security | Get the security information of the specified security item associated with the event frame for a specified user.
*EventFrameApi* | [**GetSecurityWithHttpInfo**](docs/Api/EventFrameApi.md#getsecuritywithhttpinfo) | **GET** /eventframes/{webId}/security | Get the security information of the specified security item associated with the event frame for a specified user.
*EventFrameApi* | [**GetSecurityEntries**](docs/Api/EventFrameApi.md#getsecurityentries) | **GET** /eventframes/{webId}/securityentries | Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
*EventFrameApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/EventFrameApi.md#getsecurityentrieswithhttpinfo) | **GET** /eventframes/{webId}/securityentries | Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
*EventFrameApi* | [**CreateSecurityEntry**](docs/Api/EventFrameApi.md#createsecurityentry) | **POST** /eventframes/{webId}/securityentries | Create a security entry owned by the event frame.
*EventFrameApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/EventFrameApi.md#createsecurityentrywithhttpinfo) | **POST** /eventframes/{webId}/securityentries | Create a security entry owned by the event frame.
*EventFrameApi* | [**GetSecurityEntryByName**](docs/Api/EventFrameApi.md#getsecurityentrybyname) | **GET** /eventframes/{webId}/securityentries/{name} | Retrieve the security entry associated with the event frame with the specified name.
*EventFrameApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/EventFrameApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /eventframes/{webId}/securityentries/{name} | Retrieve the security entry associated with the event frame with the specified name.
*EventFrameApi* | [**UpdateSecurityEntry**](docs/Api/EventFrameApi.md#updatesecurityentry) | **PUT** /eventframes/{webId}/securityentries/{name} | Update a security entry owned by the event frame.
*EventFrameApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/EventFrameApi.md#updatesecurityentrywithhttpinfo) | **PUT** /eventframes/{webId}/securityentries/{name} | Update a security entry owned by the event frame.
*EventFrameApi* | [**DeleteSecurityEntry**](docs/Api/EventFrameApi.md#deletesecurityentry) | **DELETE** /eventframes/{webId}/securityentries/{name} | Delete a security entry owned by the event frame.
*EventFrameApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/EventFrameApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /eventframes/{webId}/securityentries/{name} | Delete a security entry owned by the event frame.
*EventFrameApi* | [**GetMultiple**](docs/Api/EventFrameApi.md#getmultiple) | **GET** /eventframes/multiple | Retrieve multiple event frames by web ids or paths.
*EventFrameApi* | [**GetMultipleWithHttpInfo**](docs/Api/EventFrameApi.md#getmultiplewithhttpinfo) | **GET** /eventframes/multiple | Retrieve multiple event frames by web ids or paths.
*EventFrameApi* | [**CreateSearchByAttribute**](docs/Api/EventFrameApi.md#createsearchbyattribute) | **POST** /eventframes/searchbyattribute | Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
*EventFrameApi* | [**CreateSearchByAttributeWithHttpInfo**](docs/Api/EventFrameApi.md#createsearchbyattributewithhttpinfo) | **POST** /eventframes/searchbyattribute | Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
*EventFrameApi* | [**ExecuteSearchByAttribute**](docs/Api/EventFrameApi.md#executesearchbyattribute) | **GET** /eventframes/searchbyattribute/{searchId} | Execute a "Search EventFrames By Attribute Value" operation.
*EventFrameApi* | [**ExecuteSearchByAttributeWithHttpInfo**](docs/Api/EventFrameApi.md#executesearchbyattributewithhttpinfo) | **GET** /eventframes/searchbyattribute/{searchId} | Execute a "Search EventFrames By Attribute Value" operation.
*PointApi* | [**GetByPath**](docs/Api/PointApi.md#getbypath) | **GET** /points | Get a point by path.
*PointApi* | [**GetByPathWithHttpInfo**](docs/Api/PointApi.md#getbypathwithhttpinfo) | **GET** /points | Get a point by path.
*PointApi* | [**Get**](docs/Api/PointApi.md#get) | **GET** /points/{webId} | Get a point.
*PointApi* | [**GetWithHttpInfo**](docs/Api/PointApi.md#getwithhttpinfo) | **GET** /points/{webId} | Get a point.
*PointApi* | [**Update**](docs/Api/PointApi.md#update) | **PATCH** /points/{webId} | Update a point.
*PointApi* | [**UpdateWithHttpInfo**](docs/Api/PointApi.md#updatewithhttpinfo) | **PATCH** /points/{webId} | Update a point.
*PointApi* | [**Delete**](docs/Api/PointApi.md#delete) | **DELETE** /points/{webId} | Delete a point.
*PointApi* | [**DeleteWithHttpInfo**](docs/Api/PointApi.md#deletewithhttpinfo) | **DELETE** /points/{webId} | Delete a point.
*PointApi* | [**GetAttributes**](docs/Api/PointApi.md#getattributes) | **GET** /points/{webId}/attributes | Get point attributes.
*PointApi* | [**GetAttributesWithHttpInfo**](docs/Api/PointApi.md#getattributeswithhttpinfo) | **GET** /points/{webId}/attributes | Get point attributes.
*PointApi* | [**GetAttributeByName**](docs/Api/PointApi.md#getattributebyname) | **GET** /points/{webId}/attributes/{name} | Get a point attribute by name.
*PointApi* | [**GetAttributeByNameWithHttpInfo**](docs/Api/PointApi.md#getattributebynamewithhttpinfo) | **GET** /points/{webId}/attributes/{name} | Get a point attribute by name.
*PointApi* | [**GetMultiple**](docs/Api/PointApi.md#getmultiple) | **GET** /points/multiple | Retrieve multiple points by web id or path.
*PointApi* | [**GetMultipleWithHttpInfo**](docs/Api/PointApi.md#getmultiplewithhttpinfo) | **GET** /points/multiple | Retrieve multiple points by web id or path.
*SecurityIdentityApi* | [**GetByPath**](docs/Api/SecurityIdentityApi.md#getbypath) | **GET** /securityidentities | Retrieve a security identity by path.
*SecurityIdentityApi* | [**GetByPathWithHttpInfo**](docs/Api/SecurityIdentityApi.md#getbypathwithhttpinfo) | **GET** /securityidentities | Retrieve a security identity by path.
*SecurityIdentityApi* | [**Get**](docs/Api/SecurityIdentityApi.md#get) | **GET** /securityidentities/{webId} | Retrieve a security identity.
*SecurityIdentityApi* | [**GetWithHttpInfo**](docs/Api/SecurityIdentityApi.md#getwithhttpinfo) | **GET** /securityidentities/{webId} | Retrieve a security identity.
*SecurityIdentityApi* | [**Update**](docs/Api/SecurityIdentityApi.md#update) | **PATCH** /securityidentities/{webId} | Update a security identity by replacing items in its definition.
*SecurityIdentityApi* | [**UpdateWithHttpInfo**](docs/Api/SecurityIdentityApi.md#updatewithhttpinfo) | **PATCH** /securityidentities/{webId} | Update a security identity by replacing items in its definition.
*SecurityIdentityApi* | [**Delete**](docs/Api/SecurityIdentityApi.md#delete) | **DELETE** /securityidentities/{webId} | Delete a security identity.
*SecurityIdentityApi* | [**DeleteWithHttpInfo**](docs/Api/SecurityIdentityApi.md#deletewithhttpinfo) | **DELETE** /securityidentities/{webId} | Delete a security identity.
*SecurityIdentityApi* | [**GetSecurity**](docs/Api/SecurityIdentityApi.md#getsecurity) | **GET** /securityidentities/{webId}/security | Get the security information of the specified security item associated with the security identity for a specified user.
*SecurityIdentityApi* | [**GetSecurityWithHttpInfo**](docs/Api/SecurityIdentityApi.md#getsecuritywithhttpinfo) | **GET** /securityidentities/{webId}/security | Get the security information of the specified security item associated with the security identity for a specified user.
*SecurityIdentityApi* | [**GetSecurityEntries**](docs/Api/SecurityIdentityApi.md#getsecurityentries) | **GET** /securityidentities/{webId}/securityentries | Retrieve the security entries associated with the security identity based on the specified criteria. By default, all security entries for this security identity are returned.
*SecurityIdentityApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/SecurityIdentityApi.md#getsecurityentrieswithhttpinfo) | **GET** /securityidentities/{webId}/securityentries | Retrieve the security entries associated with the security identity based on the specified criteria. By default, all security entries for this security identity are returned.
*SecurityIdentityApi* | [**GetSecurityEntryByName**](docs/Api/SecurityIdentityApi.md#getsecurityentrybyname) | **GET** /securityidentities/{webId}/securityentries/{name} | Retrieve the security entry associated with the security identity with the specified name.
*SecurityIdentityApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/SecurityIdentityApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /securityidentities/{webId}/securityentries/{name} | Retrieve the security entry associated with the security identity with the specified name.
*SecurityIdentityApi* | [**GetSecurityMappings**](docs/Api/SecurityIdentityApi.md#getsecuritymappings) | **GET** /securityidentities/{webId}/securitymappings | Get security mappings for the specified security identity.
*SecurityIdentityApi* | [**GetSecurityMappingsWithHttpInfo**](docs/Api/SecurityIdentityApi.md#getsecuritymappingswithhttpinfo) | **GET** /securityidentities/{webId}/securitymappings | Get security mappings for the specified security identity.
*SecurityMappingApi* | [**GetByPath**](docs/Api/SecurityMappingApi.md#getbypath) | **GET** /securitymappings | Retrieve a security mapping by path.
*SecurityMappingApi* | [**GetByPathWithHttpInfo**](docs/Api/SecurityMappingApi.md#getbypathwithhttpinfo) | **GET** /securitymappings | Retrieve a security mapping by path.
*SecurityMappingApi* | [**Get**](docs/Api/SecurityMappingApi.md#get) | **GET** /securitymappings/{webId} | Retrieve a security mapping.
*SecurityMappingApi* | [**GetWithHttpInfo**](docs/Api/SecurityMappingApi.md#getwithhttpinfo) | **GET** /securitymappings/{webId} | Retrieve a security mapping.
*SecurityMappingApi* | [**Update**](docs/Api/SecurityMappingApi.md#update) | **PATCH** /securitymappings/{webId} | Update a security mapping by replacing items in its definition.
*SecurityMappingApi* | [**UpdateWithHttpInfo**](docs/Api/SecurityMappingApi.md#updatewithhttpinfo) | **PATCH** /securitymappings/{webId} | Update a security mapping by replacing items in its definition.
*SecurityMappingApi* | [**Delete**](docs/Api/SecurityMappingApi.md#delete) | **DELETE** /securitymappings/{webId} | Delete a security mapping.
*SecurityMappingApi* | [**DeleteWithHttpInfo**](docs/Api/SecurityMappingApi.md#deletewithhttpinfo) | **DELETE** /securitymappings/{webId} | Delete a security mapping.
*SecurityMappingApi* | [**GetSecurity**](docs/Api/SecurityMappingApi.md#getsecurity) | **GET** /securitymappings/{webId}/security | Get the security information of the specified security item associated with the security mapping for a specified user.
*SecurityMappingApi* | [**GetSecurityWithHttpInfo**](docs/Api/SecurityMappingApi.md#getsecuritywithhttpinfo) | **GET** /securitymappings/{webId}/security | Get the security information of the specified security item associated with the security mapping for a specified user.
*SecurityMappingApi* | [**GetSecurityEntries**](docs/Api/SecurityMappingApi.md#getsecurityentries) | **GET** /securitymappings/{webId}/securityentries | Retrieve the security entries associated with the security mapping based on the specified criteria. By default, all security entries for this security mapping are returned.
*SecurityMappingApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/SecurityMappingApi.md#getsecurityentrieswithhttpinfo) | **GET** /securitymappings/{webId}/securityentries | Retrieve the security entries associated with the security mapping based on the specified criteria. By default, all security entries for this security mapping are returned.
*SecurityMappingApi* | [**GetSecurityEntryByName**](docs/Api/SecurityMappingApi.md#getsecurityentrybyname) | **GET** /securitymappings/{webId}/securityentries/{name} | Retrieve the security entry associated with the security mapping with the specified name.
*SecurityMappingApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/SecurityMappingApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /securitymappings/{webId}/securityentries/{name} | Retrieve the security entry associated with the security mapping with the specified name.
*StreamApi* | [**GetChannel**](docs/Api/StreamApi.md#getchannel) | **GET** /streams/{webId}/channel | Opens a channel that will send messages about any value changes for the specified stream.
*StreamApi* | [**GetChannelWithHttpInfo**](docs/Api/StreamApi.md#getchannelwithhttpinfo) | **GET** /streams/{webId}/channel | Opens a channel that will send messages about any value changes for the specified stream.
*StreamApi* | [**GetEnd**](docs/Api/StreamApi.md#getend) | **GET** /streams/{webId}/end | Returns the end-of-stream value of the stream.
*StreamApi* | [**GetEndWithHttpInfo**](docs/Api/StreamApi.md#getendwithhttpinfo) | **GET** /streams/{webId}/end | Returns the end-of-stream value of the stream.
*StreamApi* | [**GetInterpolated**](docs/Api/StreamApi.md#getinterpolated) | **GET** /streams/{webId}/interpolated | Retrieves interpolated values over the specified time range at the specified sampling interval.
*StreamApi* | [**GetInterpolatedWithHttpInfo**](docs/Api/StreamApi.md#getinterpolatedwithhttpinfo) | **GET** /streams/{webId}/interpolated | Retrieves interpolated values over the specified time range at the specified sampling interval.
*StreamApi* | [**GetInterpolatedAtTimes**](docs/Api/StreamApi.md#getinterpolatedattimes) | **GET** /streams/{webId}/interpolatedattimes | Retrieves interpolated values over the specified time range at the specified sampling interval.
*StreamApi* | [**GetInterpolatedAtTimesWithHttpInfo**](docs/Api/StreamApi.md#getinterpolatedattimeswithhttpinfo) | **GET** /streams/{webId}/interpolatedattimes | Retrieves interpolated values over the specified time range at the specified sampling interval.
*StreamApi* | [**GetPlot**](docs/Api/StreamApi.md#getplot) | **GET** /streams/{webId}/plot | Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
*StreamApi* | [**GetPlotWithHttpInfo**](docs/Api/StreamApi.md#getplotwithhttpinfo) | **GET** /streams/{webId}/plot | Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
*StreamApi* | [**GetRecorded**](docs/Api/StreamApi.md#getrecorded) | **GET** /streams/{webId}/recorded | Returns a list of compressed values for the requested time range from the source provider.
*StreamApi* | [**GetRecordedWithHttpInfo**](docs/Api/StreamApi.md#getrecordedwithhttpinfo) | **GET** /streams/{webId}/recorded | Returns a list of compressed values for the requested time range from the source provider.
*StreamApi* | [**UpdateValues**](docs/Api/StreamApi.md#updatevalues) | **POST** /streams/{webId}/recorded | Updates multiple values for the specified stream.
*StreamApi* | [**UpdateValuesWithHttpInfo**](docs/Api/StreamApi.md#updatevalueswithhttpinfo) | **POST** /streams/{webId}/recorded | Updates multiple values for the specified stream.
*StreamApi* | [**GetRecordedAtTime**](docs/Api/StreamApi.md#getrecordedattime) | **GET** /streams/{webId}/recordedattime | Returns a single recorded value based on the passed time and retrieval mode from the stream.
*StreamApi* | [**GetRecordedAtTimeWithHttpInfo**](docs/Api/StreamApi.md#getrecordedattimewithhttpinfo) | **GET** /streams/{webId}/recordedattime | Returns a single recorded value based on the passed time and retrieval mode from the stream.
*StreamApi* | [**GetRecordedAtTimes**](docs/Api/StreamApi.md#getrecordedattimes) | **GET** /streams/{webId}/recordedattimes | Retrieves recorded values at the specified times.
*StreamApi* | [**GetRecordedAtTimesWithHttpInfo**](docs/Api/StreamApi.md#getrecordedattimeswithhttpinfo) | **GET** /streams/{webId}/recordedattimes | Retrieves recorded values at the specified times.
*StreamApi* | [**GetSummary**](docs/Api/StreamApi.md#getsummary) | **GET** /streams/{webId}/summary | Returns a summary over the specified time range for the stream.
*StreamApi* | [**GetSummaryWithHttpInfo**](docs/Api/StreamApi.md#getsummarywithhttpinfo) | **GET** /streams/{webId}/summary | Returns a summary over the specified time range for the stream.
*StreamApi* | [**GetValue**](docs/Api/StreamApi.md#getvalue) | **GET** /streams/{webId}/value | Returns the value of the stream at the specified time. By default, this is usually the current value.
*StreamApi* | [**GetValueWithHttpInfo**](docs/Api/StreamApi.md#getvaluewithhttpinfo) | **GET** /streams/{webId}/value | Returns the value of the stream at the specified time. By default, this is usually the current value.
*StreamApi* | [**UpdateValue**](docs/Api/StreamApi.md#updatevalue) | **POST** /streams/{webId}/value | Updates a value for the specified stream.
*StreamApi* | [**UpdateValueWithHttpInfo**](docs/Api/StreamApi.md#updatevaluewithhttpinfo) | **POST** /streams/{webId}/value | Updates a value for the specified stream.
*StreamSetApi* | [**GetChannel**](docs/Api/StreamSetApi.md#getchannel) | **GET** /streamsets/{webId}/channel | Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
*StreamSetApi* | [**GetChannelWithHttpInfo**](docs/Api/StreamSetApi.md#getchannelwithhttpinfo) | **GET** /streamsets/{webId}/channel | Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
*StreamSetApi* | [**GetEnd**](docs/Api/StreamSetApi.md#getend) | **GET** /streamsets/{webId}/end | Returns End of stream values of the attributes for an Element, Event Frame or Attribute
*StreamSetApi* | [**GetEndWithHttpInfo**](docs/Api/StreamSetApi.md#getendwithhttpinfo) | **GET** /streamsets/{webId}/end | Returns End of stream values of the attributes for an Element, Event Frame or Attribute
*StreamSetApi* | [**GetInterpolated**](docs/Api/StreamSetApi.md#getinterpolated) | **GET** /streamsets/{webId}/interpolated | Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
*StreamSetApi* | [**GetInterpolatedWithHttpInfo**](docs/Api/StreamSetApi.md#getinterpolatedwithhttpinfo) | **GET** /streamsets/{webId}/interpolated | Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
*StreamSetApi* | [**GetInterpolatedAtTimes**](docs/Api/StreamSetApi.md#getinterpolatedattimes) | **GET** /streamsets/{webId}/interpolatedattimes | Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
*StreamSetApi* | [**GetInterpolatedAtTimesWithHttpInfo**](docs/Api/StreamSetApi.md#getinterpolatedattimeswithhttpinfo) | **GET** /streamsets/{webId}/interpolatedattimes | Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
*StreamSetApi* | [**GetPlot**](docs/Api/StreamSetApi.md#getplot) | **GET** /streamsets/{webId}/plot | Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
*StreamSetApi* | [**GetPlotWithHttpInfo**](docs/Api/StreamSetApi.md#getplotwithhttpinfo) | **GET** /streamsets/{webId}/plot | Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
*StreamSetApi* | [**GetRecorded**](docs/Api/StreamSetApi.md#getrecorded) | **GET** /streamsets/{webId}/recorded | Returns recorded values of the attributes for an element, event frame, or attribute.
*StreamSetApi* | [**GetRecordedWithHttpInfo**](docs/Api/StreamSetApi.md#getrecordedwithhttpinfo) | **GET** /streamsets/{webId}/recorded | Returns recorded values of the attributes for an element, event frame, or attribute.
*StreamSetApi* | [**UpdateValues**](docs/Api/StreamSetApi.md#updatevalues) | **POST** /streamsets/{webId}/recorded | Updates multiple values for the specified streams.
*StreamSetApi* | [**UpdateValuesWithHttpInfo**](docs/Api/StreamSetApi.md#updatevalueswithhttpinfo) | **POST** /streamsets/{webId}/recorded | Updates multiple values for the specified streams.
*StreamSetApi* | [**GetRecordedAtTime**](docs/Api/StreamSetApi.md#getrecordedattime) | **GET** /streamsets/{webId}/recordedattime | Returns recorded values of the attributes for an element, event frame, or attribute.
*StreamSetApi* | [**GetRecordedAtTimeWithHttpInfo**](docs/Api/StreamSetApi.md#getrecordedattimewithhttpinfo) | **GET** /streamsets/{webId}/recordedattime | Returns recorded values of the attributes for an element, event frame, or attribute.
*StreamSetApi* | [**GetRecordedAtTimes**](docs/Api/StreamSetApi.md#getrecordedattimes) | **GET** /streamsets/{webId}/recordedattimes | Returns recorded values of attributes for an element, event frame or attribute at the specified times.
*StreamSetApi* | [**GetRecordedAtTimesWithHttpInfo**](docs/Api/StreamSetApi.md#getrecordedattimeswithhttpinfo) | **GET** /streamsets/{webId}/recordedattimes | Returns recorded values of attributes for an element, event frame or attribute at the specified times.
*StreamSetApi* | [**GetSummaries**](docs/Api/StreamSetApi.md#getsummaries) | **GET** /streamsets/{webId}/summary | Returns summary values of the attributes for an element, event frame or attribute.
*StreamSetApi* | [**GetSummariesWithHttpInfo**](docs/Api/StreamSetApi.md#getsummarieswithhttpinfo) | **GET** /streamsets/{webId}/summary | Returns summary values of the attributes for an element, event frame or attribute.
*StreamSetApi* | [**GetValues**](docs/Api/StreamSetApi.md#getvalues) | **GET** /streamsets/{webId}/value | Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
*StreamSetApi* | [**GetValuesWithHttpInfo**](docs/Api/StreamSetApi.md#getvalueswithhttpinfo) | **GET** /streamsets/{webId}/value | Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
*StreamSetApi* | [**UpdateValue**](docs/Api/StreamSetApi.md#updatevalue) | **POST** /streamsets/{webId}/value | Updates a single value for the specified streams.
*StreamSetApi* | [**UpdateValueWithHttpInfo**](docs/Api/StreamSetApi.md#updatevaluewithhttpinfo) | **POST** /streamsets/{webId}/value | Updates a single value for the specified streams.
*StreamSetApi* | [**GetChannelAdHoc**](docs/Api/StreamSetApi.md#getchanneladhoc) | **GET** /streamsets/channel | Opens a channel that will send messages about any value changes for the specified streams.
*StreamSetApi* | [**GetChannelAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getchanneladhocwithhttpinfo) | **GET** /streamsets/channel | Opens a channel that will send messages about any value changes for the specified streams.
*StreamSetApi* | [**GetEndAdHoc**](docs/Api/StreamSetApi.md#getendadhoc) | **GET** /streamsets/end | Returns End Of Stream values for attributes of the specified streams
*StreamSetApi* | [**GetEndAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getendadhocwithhttpinfo) | **GET** /streamsets/end | Returns End Of Stream values for attributes of the specified streams
*StreamSetApi* | [**GetInterpolatedAdHoc**](docs/Api/StreamSetApi.md#getinterpolatedadhoc) | **GET** /streamsets/interpolated | Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
*StreamSetApi* | [**GetInterpolatedAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getinterpolatedadhocwithhttpinfo) | **GET** /streamsets/interpolated | Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
*StreamSetApi* | [**GetInterpolatedAtTimesAdHoc**](docs/Api/StreamSetApi.md#getinterpolatedattimesadhoc) | **GET** /streamsets/interpolatedattimes | Returns interpolated values of the specified streams at the specified times.
*StreamSetApi* | [**GetInterpolatedAtTimesAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getinterpolatedattimesadhocwithhttpinfo) | **GET** /streamsets/interpolatedattimes | Returns interpolated values of the specified streams at the specified times.
*StreamSetApi* | [**GetPlotAdHoc**](docs/Api/StreamSetApi.md#getplotadhoc) | **GET** /streamsets/plot | Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
*StreamSetApi* | [**GetPlotAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getplotadhocwithhttpinfo) | **GET** /streamsets/plot | Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
*StreamSetApi* | [**GetRecordedAdHoc**](docs/Api/StreamSetApi.md#getrecordedadhoc) | **GET** /streamsets/recorded | Returns recorded values of the specified streams.
*StreamSetApi* | [**GetRecordedAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getrecordedadhocwithhttpinfo) | **GET** /streamsets/recorded | Returns recorded values of the specified streams.
*StreamSetApi* | [**UpdateValuesAdHoc**](docs/Api/StreamSetApi.md#updatevaluesadhoc) | **POST** /streamsets/recorded | Updates multiple values for the specified streams.
*StreamSetApi* | [**UpdateValuesAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#updatevaluesadhocwithhttpinfo) | **POST** /streamsets/recorded | Updates multiple values for the specified streams.
*StreamSetApi* | [**GetRecordedAtTimeAdHoc**](docs/Api/StreamSetApi.md#getrecordedattimeadhoc) | **GET** /streamsets/recordedattime | Returns recorded values based on the passed time and retrieval mode.
*StreamSetApi* | [**GetRecordedAtTimeAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getrecordedattimeadhocwithhttpinfo) | **GET** /streamsets/recordedattime | Returns recorded values based on the passed time and retrieval mode.
*StreamSetApi* | [**GetRecordedAtTimesAdHoc**](docs/Api/StreamSetApi.md#getrecordedattimesadhoc) | **GET** /streamsets/recordedattimes | Returns recorded values of the specified streams at the specified times.
*StreamSetApi* | [**GetRecordedAtTimesAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getrecordedattimesadhocwithhttpinfo) | **GET** /streamsets/recordedattimes | Returns recorded values of the specified streams at the specified times.
*StreamSetApi* | [**GetSummariesAdHoc**](docs/Api/StreamSetApi.md#getsummariesadhoc) | **GET** /streamsets/summary | Returns summary values of the specified streams.
*StreamSetApi* | [**GetSummariesAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getsummariesadhocwithhttpinfo) | **GET** /streamsets/summary | Returns summary values of the specified streams.
*StreamSetApi* | [**GetValuesAdHoc**](docs/Api/StreamSetApi.md#getvaluesadhoc) | **GET** /streamsets/value | Returns values of the specified streams.
*StreamSetApi* | [**GetValuesAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#getvaluesadhocwithhttpinfo) | **GET** /streamsets/value | Returns values of the specified streams.
*StreamSetApi* | [**UpdateValueAdHoc**](docs/Api/StreamSetApi.md#updatevalueadhoc) | **POST** /streamsets/value | Updates a single value for the specified streams.
*StreamSetApi* | [**UpdateValueAdHocWithHttpInfo**](docs/Api/StreamSetApi.md#updatevalueadhocwithhttpinfo) | **POST** /streamsets/value | Updates a single value for the specified streams.
*SystemApi* | [**Landing**](docs/Api/SystemApi.md#landing) | **GET** /system | Get system links for this PI System Web API instance.
*SystemApi* | [**LandingWithHttpInfo**](docs/Api/SystemApi.md#landingwithhttpinfo) | **GET** /system | Get system links for this PI System Web API instance.
*SystemApi* | [**CacheInstances**](docs/Api/SystemApi.md#cacheinstances) | **GET** /system/cacheinstances | Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
*SystemApi* | [**CacheInstancesWithHttpInfo**](docs/Api/SystemApi.md#cacheinstanceswithhttpinfo) | **GET** /system/cacheinstances | Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
*SystemApi* | [**Status**](docs/Api/SystemApi.md#status) | **GET** /system/status | Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.
*SystemApi* | [**StatusWithHttpInfo**](docs/Api/SystemApi.md#statuswithhttpinfo) | **GET** /system/status | Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.
*SystemApi* | [**UserInfo**](docs/Api/SystemApi.md#userinfo) | **GET** /system/userinfo | Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
*SystemApi* | [**UserInfoWithHttpInfo**](docs/Api/SystemApi.md#userinfowithhttpinfo) | **GET** /system/userinfo | Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
*SystemApi* | [**Versions**](docs/Api/SystemApi.md#versions) | **GET** /system/versions | Get the current versions of the PI Web API instance and all external plugins.
*SystemApi* | [**VersionsWithHttpInfo**](docs/Api/SystemApi.md#versionswithhttpinfo) | **GET** /system/versions | Get the current versions of the PI Web API instance and all external plugins.
*ConfigurationApi* | [**List**](docs/Api/ConfigurationApi.md#list) | **GET** /system/configuration | Get the current system configuration.
*ConfigurationApi* | [**ListWithHttpInfo**](docs/Api/ConfigurationApi.md#listwithhttpinfo) | **GET** /system/configuration | Get the current system configuration.
*ConfigurationApi* | [**Get**](docs/Api/ConfigurationApi.md#get) | **GET** /system/configuration/{key} | Get the value of a configuration item.
*ConfigurationApi* | [**GetWithHttpInfo**](docs/Api/ConfigurationApi.md#getwithhttpinfo) | **GET** /system/configuration/{key} | Get the value of a configuration item.
*ConfigurationApi* | [**Delete**](docs/Api/ConfigurationApi.md#delete) | **DELETE** /system/configuration/{key} | Delete a configuration item.
*ConfigurationApi* | [**DeleteWithHttpInfo**](docs/Api/ConfigurationApi.md#deletewithhttpinfo) | **DELETE** /system/configuration/{key} | Delete a configuration item.
*TableCategoryApi* | [**GetByPath**](docs/Api/TableCategoryApi.md#getbypath) | **GET** /tablecategories | Retrieve a table category by path.
*TableCategoryApi* | [**GetByPathWithHttpInfo**](docs/Api/TableCategoryApi.md#getbypathwithhttpinfo) | **GET** /tablecategories | Retrieve a table category by path.
*TableCategoryApi* | [**Get**](docs/Api/TableCategoryApi.md#get) | **GET** /tablecategories/{webId} | Retrieve a table category.
*TableCategoryApi* | [**GetWithHttpInfo**](docs/Api/TableCategoryApi.md#getwithhttpinfo) | **GET** /tablecategories/{webId} | Retrieve a table category.
*TableCategoryApi* | [**Update**](docs/Api/TableCategoryApi.md#update) | **PATCH** /tablecategories/{webId} | Update a table category by replacing items in its definition.
*TableCategoryApi* | [**UpdateWithHttpInfo**](docs/Api/TableCategoryApi.md#updatewithhttpinfo) | **PATCH** /tablecategories/{webId} | Update a table category by replacing items in its definition.
*TableCategoryApi* | [**Delete**](docs/Api/TableCategoryApi.md#delete) | **DELETE** /tablecategories/{webId} | Delete a table category.
*TableCategoryApi* | [**DeleteWithHttpInfo**](docs/Api/TableCategoryApi.md#deletewithhttpinfo) | **DELETE** /tablecategories/{webId} | Delete a table category.
*TableCategoryApi* | [**GetSecurity**](docs/Api/TableCategoryApi.md#getsecurity) | **GET** /tablecategories/{webId}/security | Get the security information of the specified security item associated with the table category for a specified user.
*TableCategoryApi* | [**GetSecurityWithHttpInfo**](docs/Api/TableCategoryApi.md#getsecuritywithhttpinfo) | **GET** /tablecategories/{webId}/security | Get the security information of the specified security item associated with the table category for a specified user.
*TableCategoryApi* | [**GetSecurityEntries**](docs/Api/TableCategoryApi.md#getsecurityentries) | **GET** /tablecategories/{webId}/securityentries | Retrieve the security entries associated with the table category based on the specified criteria. By default, all security entries for this table category are returned.
*TableCategoryApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/TableCategoryApi.md#getsecurityentrieswithhttpinfo) | **GET** /tablecategories/{webId}/securityentries | Retrieve the security entries associated with the table category based on the specified criteria. By default, all security entries for this table category are returned.
*TableCategoryApi* | [**CreateSecurityEntry**](docs/Api/TableCategoryApi.md#createsecurityentry) | **POST** /tablecategories/{webId}/securityentries | Create a security entry owned by the table category.
*TableCategoryApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/TableCategoryApi.md#createsecurityentrywithhttpinfo) | **POST** /tablecategories/{webId}/securityentries | Create a security entry owned by the table category.
*TableCategoryApi* | [**GetSecurityEntryByName**](docs/Api/TableCategoryApi.md#getsecurityentrybyname) | **GET** /tablecategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the table category with the specified name.
*TableCategoryApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/TableCategoryApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /tablecategories/{webId}/securityentries/{name} | Retrieve the security entry associated with the table category with the specified name.
*TableCategoryApi* | [**UpdateSecurityEntry**](docs/Api/TableCategoryApi.md#updatesecurityentry) | **PUT** /tablecategories/{webId}/securityentries/{name} | Update a security entry owned by the table category.
*TableCategoryApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/TableCategoryApi.md#updatesecurityentrywithhttpinfo) | **PUT** /tablecategories/{webId}/securityentries/{name} | Update a security entry owned by the table category.
*TableCategoryApi* | [**DeleteSecurityEntry**](docs/Api/TableCategoryApi.md#deletesecurityentry) | **DELETE** /tablecategories/{webId}/securityentries/{name} | Delete a security entry owned by the table category.
*TableCategoryApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/TableCategoryApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /tablecategories/{webId}/securityentries/{name} | Delete a security entry owned by the table category.
*TableApi* | [**GetByPath**](docs/Api/TableApi.md#getbypath) | **GET** /tables | Retrieve a table by path.
*TableApi* | [**GetByPathWithHttpInfo**](docs/Api/TableApi.md#getbypathwithhttpinfo) | **GET** /tables | Retrieve a table by path.
*TableApi* | [**Get**](docs/Api/TableApi.md#get) | **GET** /tables/{webId} | Retrieve a table.
*TableApi* | [**GetWithHttpInfo**](docs/Api/TableApi.md#getwithhttpinfo) | **GET** /tables/{webId} | Retrieve a table.
*TableApi* | [**Update**](docs/Api/TableApi.md#update) | **PATCH** /tables/{webId} | Update a table by replacing items in its definition.
*TableApi* | [**UpdateWithHttpInfo**](docs/Api/TableApi.md#updatewithhttpinfo) | **PATCH** /tables/{webId} | Update a table by replacing items in its definition.
*TableApi* | [**Delete**](docs/Api/TableApi.md#delete) | **DELETE** /tables/{webId} | Delete a table.
*TableApi* | [**DeleteWithHttpInfo**](docs/Api/TableApi.md#deletewithhttpinfo) | **DELETE** /tables/{webId} | Delete a table.
*TableApi* | [**GetCategories**](docs/Api/TableApi.md#getcategories) | **GET** /tables/{webId}/categories | Get a table's categories.
*TableApi* | [**GetCategoriesWithHttpInfo**](docs/Api/TableApi.md#getcategorieswithhttpinfo) | **GET** /tables/{webId}/categories | Get a table's categories.
*TableApi* | [**GetData**](docs/Api/TableApi.md#getdata) | **GET** /tables/{webId}/data | Get the table's data.
*TableApi* | [**GetDataWithHttpInfo**](docs/Api/TableApi.md#getdatawithhttpinfo) | **GET** /tables/{webId}/data | Get the table's data.
*TableApi* | [**UpdateData**](docs/Api/TableApi.md#updatedata) | **PUT** /tables/{webId}/data | Update the table's data.
*TableApi* | [**UpdateDataWithHttpInfo**](docs/Api/TableApi.md#updatedatawithhttpinfo) | **PUT** /tables/{webId}/data | Update the table's data.
*TableApi* | [**GetSecurity**](docs/Api/TableApi.md#getsecurity) | **GET** /tables/{webId}/security | Get the security information of the specified security item associated with the table for a specified user.
*TableApi* | [**GetSecurityWithHttpInfo**](docs/Api/TableApi.md#getsecuritywithhttpinfo) | **GET** /tables/{webId}/security | Get the security information of the specified security item associated with the table for a specified user.
*TableApi* | [**GetSecurityEntries**](docs/Api/TableApi.md#getsecurityentries) | **GET** /tables/{webId}/securityentries | Retrieve the security entries associated with the table based on the specified criteria. By default, all security entries for this table are returned.
*TableApi* | [**GetSecurityEntriesWithHttpInfo**](docs/Api/TableApi.md#getsecurityentrieswithhttpinfo) | **GET** /tables/{webId}/securityentries | Retrieve the security entries associated with the table based on the specified criteria. By default, all security entries for this table are returned.
*TableApi* | [**CreateSecurityEntry**](docs/Api/TableApi.md#createsecurityentry) | **POST** /tables/{webId}/securityentries | Create a security entry owned by the table.
*TableApi* | [**CreateSecurityEntryWithHttpInfo**](docs/Api/TableApi.md#createsecurityentrywithhttpinfo) | **POST** /tables/{webId}/securityentries | Create a security entry owned by the table.
*TableApi* | [**GetSecurityEntryByName**](docs/Api/TableApi.md#getsecurityentrybyname) | **GET** /tables/{webId}/securityentries/{name} | Retrieve the security entry associated with the table with the specified name.
*TableApi* | [**GetSecurityEntryByNameWithHttpInfo**](docs/Api/TableApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /tables/{webId}/securityentries/{name} | Retrieve the security entry associated with the table with the specified name.
*TableApi* | [**UpdateSecurityEntry**](docs/Api/TableApi.md#updatesecurityentry) | **PUT** /tables/{webId}/securityentries/{name} | Update a security entry owned by the table.
*TableApi* | [**UpdateSecurityEntryWithHttpInfo**](docs/Api/TableApi.md#updatesecurityentrywithhttpinfo) | **PUT** /tables/{webId}/securityentries/{name} | Update a security entry owned by the table.
*TableApi* | [**DeleteSecurityEntry**](docs/Api/TableApi.md#deletesecurityentry) | **DELETE** /tables/{webId}/securityentries/{name} | Delete a security entry owned by the table.
*TableApi* | [**DeleteSecurityEntryWithHttpInfo**](docs/Api/TableApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /tables/{webId}/securityentries/{name} | Delete a security entry owned by the table.
*TimeRulePlugInApi* | [**GetByPath**](docs/Api/TimeRulePlugInApi.md#getbypath) | **GET** /timeruleplugins | Retrieve a Time Rule Plug-in by path.
*TimeRulePlugInApi* | [**GetByPathWithHttpInfo**](docs/Api/TimeRulePlugInApi.md#getbypathwithhttpinfo) | **GET** /timeruleplugins | Retrieve a Time Rule Plug-in by path.
*TimeRulePlugInApi* | [**Get**](docs/Api/TimeRulePlugInApi.md#get) | **GET** /timeruleplugins/{webId} | Retrieve a Time Rule Plug-in.
*TimeRulePlugInApi* | [**GetWithHttpInfo**](docs/Api/TimeRulePlugInApi.md#getwithhttpinfo) | **GET** /timeruleplugins/{webId} | Retrieve a Time Rule Plug-in.
*TimeRuleApi* | [**GetByPath**](docs/Api/TimeRuleApi.md#getbypath) | **GET** /timerules | Retrieve a Time Rule by path.
*TimeRuleApi* | [**GetByPathWithHttpInfo**](docs/Api/TimeRuleApi.md#getbypathwithhttpinfo) | **GET** /timerules | Retrieve a Time Rule by path.
*TimeRuleApi* | [**Get**](docs/Api/TimeRuleApi.md#get) | **GET** /timerules/{webId} | Retrieve a Time Rule.
*TimeRuleApi* | [**GetWithHttpInfo**](docs/Api/TimeRuleApi.md#getwithhttpinfo) | **GET** /timerules/{webId} | Retrieve a Time Rule.
*TimeRuleApi* | [**Update**](docs/Api/TimeRuleApi.md#update) | **PATCH** /timerules/{webId} | Update a Time Rule by replacing items in its definition.
*TimeRuleApi* | [**UpdateWithHttpInfo**](docs/Api/TimeRuleApi.md#updatewithhttpinfo) | **PATCH** /timerules/{webId} | Update a Time Rule by replacing items in its definition.
*TimeRuleApi* | [**Delete**](docs/Api/TimeRuleApi.md#delete) | **DELETE** /timerules/{webId} | Delete a Time Rule.
*TimeRuleApi* | [**DeleteWithHttpInfo**](docs/Api/TimeRuleApi.md#deletewithhttpinfo) | **DELETE** /timerules/{webId} | Delete a Time Rule.
*UnitClassApi* | [**GetByPath**](docs/Api/UnitClassApi.md#getbypath) | **GET** /unitclasses | Retrieve a unit class by path.
*UnitClassApi* | [**GetByPathWithHttpInfo**](docs/Api/UnitClassApi.md#getbypathwithhttpinfo) | **GET** /unitclasses | Retrieve a unit class by path.
*UnitClassApi* | [**Get**](docs/Api/UnitClassApi.md#get) | **GET** /unitclasses/{webId} | Retrieve a unit class.
*UnitClassApi* | [**GetWithHttpInfo**](docs/Api/UnitClassApi.md#getwithhttpinfo) | **GET** /unitclasses/{webId} | Retrieve a unit class.
*UnitClassApi* | [**Update**](docs/Api/UnitClassApi.md#update) | **PATCH** /unitclasses/{webId} | Update a unit class.
*UnitClassApi* | [**UpdateWithHttpInfo**](docs/Api/UnitClassApi.md#updatewithhttpinfo) | **PATCH** /unitclasses/{webId} | Update a unit class.
*UnitClassApi* | [**Delete**](docs/Api/UnitClassApi.md#delete) | **DELETE** /unitclasses/{webId} | Delete a unit class.
*UnitClassApi* | [**DeleteWithHttpInfo**](docs/Api/UnitClassApi.md#deletewithhttpinfo) | **DELETE** /unitclasses/{webId} | Delete a unit class.
*UnitClassApi* | [**GetCanonicalUnit**](docs/Api/UnitClassApi.md#getcanonicalunit) | **GET** /unitclasses/{webId}/canonicalunit | Get the canonical unit of a unit class.
*UnitClassApi* | [**GetCanonicalUnitWithHttpInfo**](docs/Api/UnitClassApi.md#getcanonicalunitwithhttpinfo) | **GET** /unitclasses/{webId}/canonicalunit | Get the canonical unit of a unit class.
*UnitClassApi* | [**GetUnits**](docs/Api/UnitClassApi.md#getunits) | **GET** /unitclasses/{webId}/units | Get a list of all units belonging to the unit class.
*UnitClassApi* | [**GetUnitsWithHttpInfo**](docs/Api/UnitClassApi.md#getunitswithhttpinfo) | **GET** /unitclasses/{webId}/units | Get a list of all units belonging to the unit class.
*UnitClassApi* | [**CreateUnit**](docs/Api/UnitClassApi.md#createunit) | **POST** /unitclasses/{webId}/units | Create a unit in the specified Unit Class.
*UnitClassApi* | [**CreateUnitWithHttpInfo**](docs/Api/UnitClassApi.md#createunitwithhttpinfo) | **POST** /unitclasses/{webId}/units | Create a unit in the specified Unit Class.
*UnitApi* | [**GetByPath**](docs/Api/UnitApi.md#getbypath) | **GET** /units | Retrieve a unit by path.
*UnitApi* | [**GetByPathWithHttpInfo**](docs/Api/UnitApi.md#getbypathwithhttpinfo) | **GET** /units | Retrieve a unit by path.
*UnitApi* | [**Get**](docs/Api/UnitApi.md#get) | **GET** /units/{webId} | Retrieve a unit.
*UnitApi* | [**GetWithHttpInfo**](docs/Api/UnitApi.md#getwithhttpinfo) | **GET** /units/{webId} | Retrieve a unit.
*UnitApi* | [**Update**](docs/Api/UnitApi.md#update) | **PATCH** /units/{webId} | Update a unit.
*UnitApi* | [**UpdateWithHttpInfo**](docs/Api/UnitApi.md#updatewithhttpinfo) | **PATCH** /units/{webId} | Update a unit.
*UnitApi* | [**Delete**](docs/Api/UnitApi.md#delete) | **DELETE** /units/{webId} | Delete a unit.
*UnitApi* | [**DeleteWithHttpInfo**](docs/Api/UnitApi.md#deletewithhttpinfo) | **DELETE** /units/{webId} | Delete a unit.

## Documentation For Models

- [PIAnalysis](docs/Model/PIAnalysis.md)
- [PIAnalysisCategory](docs/Model/PIAnalysisCategory.md)
- [PIAnalysisRule](docs/Model/PIAnalysisRule.md)
- [PIAnalysisRulePlugIn](docs/Model/PIAnalysisRulePlugIn.md)
- [PIAnalysisTemplate](docs/Model/PIAnalysisTemplate.md)
- [PIAnnotation](docs/Model/PIAnnotation.md)
- [PIAssetDatabase](docs/Model/PIAssetDatabase.md)
- [PIAssetServer](docs/Model/PIAssetServer.md)
- [PIAttribute](docs/Model/PIAttribute.md)
- [PIAttributeCategory](docs/Model/PIAttributeCategory.md)
- [PIAttributeTemplate](docs/Model/PIAttributeTemplate.md)
- [PIAttributeTrait](docs/Model/PIAttributeTrait.md)
- [PICacheInstance](docs/Model/PICacheInstance.md)
- [PIDataServer](docs/Model/PIDataServer.md)
- [PIElement](docs/Model/PIElement.md)
- [PIElementCategory](docs/Model/PIElementCategory.md)
- [PIElementTemplate](docs/Model/PIElementTemplate.md)
- [PIEnumerationSet](docs/Model/PIEnumerationSet.md)
- [PIEnumerationValue](docs/Model/PIEnumerationValue.md)
- [PIErrors](docs/Model/PIErrors.md)
- [PIEventFrame](docs/Model/PIEventFrame.md)
- [PIItemAttribute](docs/Model/PIItemAttribute.md)
- [PIItemElement](docs/Model/PIItemElement.md)
- [PIItemEventFrame](docs/Model/PIItemEventFrame.md)
- [PIItemPoint](docs/Model/PIItemPoint.md)
- [PIItemsAnalysis](docs/Model/PIItemsAnalysis.md)
- [PIItemsAnalysisCategory](docs/Model/PIItemsAnalysisCategory.md)
- [PIItemsAnalysisRule](docs/Model/PIItemsAnalysisRule.md)
- [PIItemsAnalysisRulePlugIn](docs/Model/PIItemsAnalysisRulePlugIn.md)
- [PIItemsAnalysisTemplate](docs/Model/PIItemsAnalysisTemplate.md)
- [PIItemsAnnotation](docs/Model/PIItemsAnnotation.md)
- [PIItemsAssetDatabase](docs/Model/PIItemsAssetDatabase.md)
- [PIItemsAssetServer](docs/Model/PIItemsAssetServer.md)
- [PIItemsAttribute](docs/Model/PIItemsAttribute.md)
- [PIItemsAttributeCategory](docs/Model/PIItemsAttributeCategory.md)
- [PIItemsAttributeTemplate](docs/Model/PIItemsAttributeTemplate.md)
- [PIItemsAttributeTrait](docs/Model/PIItemsAttributeTrait.md)
- [PIItemsCacheInstance](docs/Model/PIItemsCacheInstance.md)
- [PIItemsDataServer](docs/Model/PIItemsDataServer.md)
- [PIItemsElement](docs/Model/PIItemsElement.md)
- [PIItemsElementCategory](docs/Model/PIItemsElementCategory.md)
- [PIItemsElementTemplate](docs/Model/PIItemsElementTemplate.md)
- [PIItemsEnumerationSet](docs/Model/PIItemsEnumerationSet.md)
- [PIItemsEnumerationValue](docs/Model/PIItemsEnumerationValue.md)
- [PIItemsEventFrame](docs/Model/PIItemsEventFrame.md)
- [PIItemsItemAttribute](docs/Model/PIItemsItemAttribute.md)
- [PIItemsItemElement](docs/Model/PIItemsItemElement.md)
- [PIItemsItemEventFrame](docs/Model/PIItemsItemEventFrame.md)
- [PIItemsItemPoint](docs/Model/PIItemsItemPoint.md)
- [PIItemsItemsSubstatus](docs/Model/PIItemsItemsSubstatus.md)
- [PIItemsPoint](docs/Model/PIItemsPoint.md)
- [PIItemsPointAttribute](docs/Model/PIItemsPointAttribute.md)
- [PIItemsSecurityEntry](docs/Model/PIItemsSecurityEntry.md)
- [PIItemsSecurityIdentity](docs/Model/PIItemsSecurityIdentity.md)
- [PIItemsSecurityMapping](docs/Model/PIItemsSecurityMapping.md)
- [PIItemsSecurityRights](docs/Model/PIItemsSecurityRights.md)
- [PIItemsStreamSummaries](docs/Model/PIItemsStreamSummaries.md)
- [PIItemsStreamValue](docs/Model/PIItemsStreamValue.md)
- [PIItemsStreamValues](docs/Model/PIItemsStreamValues.md)
- [PIItemsSubstatus](docs/Model/PIItemsSubstatus.md)
- [PIItemsSummaryValue](docs/Model/PIItemsSummaryValue.md)
- [PIItemsTable](docs/Model/PIItemsTable.md)
- [PIItemsTableCategory](docs/Model/PIItemsTableCategory.md)
- [PIItemsTimeRulePlugIn](docs/Model/PIItemsTimeRulePlugIn.md)
- [PIItemsUnitClass](docs/Model/PIItemsUnitClass.md)
- [PILanding](docs/Model/PILanding.md)
- [PIPoint](docs/Model/PIPoint.md)
- [PIPointAttribute](docs/Model/PIPointAttribute.md)
- [PIRequest](docs/Model/PIRequest.md)
- [PIRequestTemplate](docs/Model/PIRequestTemplate.md)
- [PIResponse](docs/Model/PIResponse.md)
- [PISecurity](docs/Model/PISecurity.md)
- [PISecurityEntry](docs/Model/PISecurityEntry.md)
- [PISecurityIdentity](docs/Model/PISecurityIdentity.md)
- [PISecurityMapping](docs/Model/PISecurityMapping.md)
- [PISecurityRights](docs/Model/PISecurityRights.md)
- [PIStreamSummaries](docs/Model/PIStreamSummaries.md)
- [PIStreamValue](docs/Model/PIStreamValue.md)
- [PIStreamValues](docs/Model/PIStreamValues.md)
- [PISubstatus](docs/Model/PISubstatus.md)
- [PISummaryValue](docs/Model/PISummaryValue.md)
- [PISystemLanding](docs/Model/PISystemLanding.md)
- [PISystemStatus](docs/Model/PISystemStatus.md)
- [PITable](docs/Model/PITable.md)
- [PITableCategory](docs/Model/PITableCategory.md)
- [PITableData](docs/Model/PITableData.md)
- [PITimedValue](docs/Model/PITimedValue.md)
- [PITimedValues](docs/Model/PITimedValues.md)
- [PITimeRule](docs/Model/PITimeRule.md)
- [PITimeRulePlugIn](docs/Model/PITimeRulePlugIn.md)
- [PIUnit](docs/Model/PIUnit.md)
- [PIUnitClass](docs/Model/PIUnitClass.md)
- [PIUserInfo](docs/Model/PIUserInfo.md)
- [PIValue](docs/Model/PIValue.md)
- [PIVersion](docs/Model/PIVersion.md)

## Documentation For ApiResponses

- [ApiResponseObject](docs/Responses/ApiResponseObject.md)
- [ApiResponsePIAnalysis](docs/Responses/ApiResponsePIAnalysis.md)
- [ApiResponsePIAnalysisCategory](docs/Responses/ApiResponsePIAnalysisCategory.md)
- [ApiResponsePIAnalysisRule](docs/Responses/ApiResponsePIAnalysisRule.md)
- [ApiResponsePIAnalysisRulePlugIn](docs/Responses/ApiResponsePIAnalysisRulePlugIn.md)
- [ApiResponsePIAnalysisTemplate](docs/Responses/ApiResponsePIAnalysisTemplate.md)
- [ApiResponsePIAnnotation](docs/Responses/ApiResponsePIAnnotation.md)
- [ApiResponsePIAssetDatabase](docs/Responses/ApiResponsePIAssetDatabase.md)
- [ApiResponsePIAssetServer](docs/Responses/ApiResponsePIAssetServer.md)
- [ApiResponsePIAttribute](docs/Responses/ApiResponsePIAttribute.md)
- [ApiResponsePIAttributeCategory](docs/Responses/ApiResponsePIAttributeCategory.md)
- [ApiResponsePIAttributeTemplate](docs/Responses/ApiResponsePIAttributeTemplate.md)
- [ApiResponsePIAttributeTrait](docs/Responses/ApiResponsePIAttributeTrait.md)
- [ApiResponsePICacheInstance](docs/Responses/ApiResponsePICacheInstance.md)
- [ApiResponsePIDataServer](docs/Responses/ApiResponsePIDataServer.md)
- [ApiResponsePIElement](docs/Responses/ApiResponsePIElement.md)
- [ApiResponsePIElementCategory](docs/Responses/ApiResponsePIElementCategory.md)
- [ApiResponsePIElementTemplate](docs/Responses/ApiResponsePIElementTemplate.md)
- [ApiResponsePIEnumerationSet](docs/Responses/ApiResponsePIEnumerationSet.md)
- [ApiResponsePIEnumerationValue](docs/Responses/ApiResponsePIEnumerationValue.md)
- [ApiResponsePIErrors](docs/Responses/ApiResponsePIErrors.md)
- [ApiResponsePIEventFrame](docs/Responses/ApiResponsePIEventFrame.md)
- [ApiResponsePIItemAttribute](docs/Responses/ApiResponsePIItemAttribute.md)
- [ApiResponsePIItemElement](docs/Responses/ApiResponsePIItemElement.md)
- [ApiResponsePIItemEventFrame](docs/Responses/ApiResponsePIItemEventFrame.md)
- [ApiResponsePIItemPoint](docs/Responses/ApiResponsePIItemPoint.md)
- [ApiResponsePIItemsAnalysis](docs/Responses/ApiResponsePIItemsAnalysis.md)
- [ApiResponsePIItemsAnalysisCategory](docs/Responses/ApiResponsePIItemsAnalysisCategory.md)
- [ApiResponsePIItemsAnalysisRule](docs/Responses/ApiResponsePIItemsAnalysisRule.md)
- [ApiResponsePIItemsAnalysisRulePlugIn](docs/Responses/ApiResponsePIItemsAnalysisRulePlugIn.md)
- [ApiResponsePIItemsAnalysisTemplate](docs/Responses/ApiResponsePIItemsAnalysisTemplate.md)
- [ApiResponsePIItemsAnnotation](docs/Responses/ApiResponsePIItemsAnnotation.md)
- [ApiResponsePIItemsAssetDatabase](docs/Responses/ApiResponsePIItemsAssetDatabase.md)
- [ApiResponsePIItemsAssetServer](docs/Responses/ApiResponsePIItemsAssetServer.md)
- [ApiResponsePIItemsAttribute](docs/Responses/ApiResponsePIItemsAttribute.md)
- [ApiResponsePIItemsAttributeCategory](docs/Responses/ApiResponsePIItemsAttributeCategory.md)
- [ApiResponsePIItemsAttributeTemplate](docs/Responses/ApiResponsePIItemsAttributeTemplate.md)
- [ApiResponsePIItemsAttributeTrait](docs/Responses/ApiResponsePIItemsAttributeTrait.md)
- [ApiResponsePIItemsCacheInstance](docs/Responses/ApiResponsePIItemsCacheInstance.md)
- [ApiResponsePIItemsDataServer](docs/Responses/ApiResponsePIItemsDataServer.md)
- [ApiResponsePIItemsElement](docs/Responses/ApiResponsePIItemsElement.md)
- [ApiResponsePIItemsElementCategory](docs/Responses/ApiResponsePIItemsElementCategory.md)
- [ApiResponsePIItemsElementTemplate](docs/Responses/ApiResponsePIItemsElementTemplate.md)
- [ApiResponsePIItemsEnumerationSet](docs/Responses/ApiResponsePIItemsEnumerationSet.md)
- [ApiResponsePIItemsEnumerationValue](docs/Responses/ApiResponsePIItemsEnumerationValue.md)
- [ApiResponsePIItemsEventFrame](docs/Responses/ApiResponsePIItemsEventFrame.md)
- [ApiResponsePIItemsItemAttribute](docs/Responses/ApiResponsePIItemsItemAttribute.md)
- [ApiResponsePIItemsItemElement](docs/Responses/ApiResponsePIItemsItemElement.md)
- [ApiResponsePIItemsItemEventFrame](docs/Responses/ApiResponsePIItemsItemEventFrame.md)
- [ApiResponsePIItemsItemPoint](docs/Responses/ApiResponsePIItemsItemPoint.md)
- [ApiResponsePIItemsItemsSubstatus](docs/Responses/ApiResponsePIItemsItemsSubstatus.md)
- [ApiResponsePIItemsPoint](docs/Responses/ApiResponsePIItemsPoint.md)
- [ApiResponsePIItemsPointAttribute](docs/Responses/ApiResponsePIItemsPointAttribute.md)
- [ApiResponsePIItemsSecurityEntry](docs/Responses/ApiResponsePIItemsSecurityEntry.md)
- [ApiResponsePIItemsSecurityIdentity](docs/Responses/ApiResponsePIItemsSecurityIdentity.md)
- [ApiResponsePIItemsSecurityMapping](docs/Responses/ApiResponsePIItemsSecurityMapping.md)
- [ApiResponsePIItemsSecurityRights](docs/Responses/ApiResponsePIItemsSecurityRights.md)
- [ApiResponsePIItemsStreamSummaries](docs/Responses/ApiResponsePIItemsStreamSummaries.md)
- [ApiResponsePIItemsStreamValue](docs/Responses/ApiResponsePIItemsStreamValue.md)
- [ApiResponsePIItemsStreamValues](docs/Responses/ApiResponsePIItemsStreamValues.md)
- [ApiResponsePIItemsSubstatus](docs/Responses/ApiResponsePIItemsSubstatus.md)
- [ApiResponsePIItemsSummaryValue](docs/Responses/ApiResponsePIItemsSummaryValue.md)
- [ApiResponsePIItemsTable](docs/Responses/ApiResponsePIItemsTable.md)
- [ApiResponsePIItemsTableCategory](docs/Responses/ApiResponsePIItemsTableCategory.md)
- [ApiResponsePIItemsTimeRulePlugIn](docs/Responses/ApiResponsePIItemsTimeRulePlugIn.md)
- [ApiResponsePIItemsUnitClass](docs/Responses/ApiResponsePIItemsUnitClass.md)
- [ApiResponsePILanding](docs/Responses/ApiResponsePILanding.md)
- [ApiResponsePIPoint](docs/Responses/ApiResponsePIPoint.md)
- [ApiResponsePIPointAttribute](docs/Responses/ApiResponsePIPointAttribute.md)
- [ApiResponsePIRequest](docs/Responses/ApiResponsePIRequest.md)
- [ApiResponsePIRequestTemplate](docs/Responses/ApiResponsePIRequestTemplate.md)
- [ApiResponsePIResponse](docs/Responses/ApiResponsePIResponse.md)
- [ApiResponsePISecurity](docs/Responses/ApiResponsePISecurity.md)
- [ApiResponsePISecurityEntry](docs/Responses/ApiResponsePISecurityEntry.md)
- [ApiResponsePISecurityIdentity](docs/Responses/ApiResponsePISecurityIdentity.md)
- [ApiResponsePISecurityMapping](docs/Responses/ApiResponsePISecurityMapping.md)
- [ApiResponsePISecurityRights](docs/Responses/ApiResponsePISecurityRights.md)
- [ApiResponsePIStreamSummaries](docs/Responses/ApiResponsePIStreamSummaries.md)
- [ApiResponsePIStreamValue](docs/Responses/ApiResponsePIStreamValue.md)
- [ApiResponsePIStreamValues](docs/Responses/ApiResponsePIStreamValues.md)
- [ApiResponsePISubstatus](docs/Responses/ApiResponsePISubstatus.md)
- [ApiResponsePISummaryValue](docs/Responses/ApiResponsePISummaryValue.md)
- [ApiResponsePISystemLanding](docs/Responses/ApiResponsePISystemLanding.md)
- [ApiResponsePISystemStatus](docs/Responses/ApiResponsePISystemStatus.md)
- [ApiResponsePITable](docs/Responses/ApiResponsePITable.md)
- [ApiResponsePITableCategory](docs/Responses/ApiResponsePITableCategory.md)
- [ApiResponsePITableData](docs/Responses/ApiResponsePITableData.md)
- [ApiResponsePITimedValue](docs/Responses/ApiResponsePITimedValue.md)
- [ApiResponsePITimedValues](docs/Responses/ApiResponsePITimedValues.md)
- [ApiResponsePITimeRule](docs/Responses/ApiResponsePITimeRule.md)
- [ApiResponsePITimeRulePlugIn](docs/Responses/ApiResponsePITimeRulePlugIn.md)
- [ApiResponsePIUnit](docs/Responses/ApiResponsePIUnit.md)
- [ApiResponsePIUnitClass](docs/Responses/ApiResponsePIUnitClass.md)
- [ApiResponsePIUserInfo](docs/Responses/ApiResponsePIUserInfo.md)
- [ApiResponsePIValue](docs/Responses/ApiResponsePIValue.md)
- [ApiResponsePIVersion](docs/Responses/ApiResponsePIVersion.md)



## Licensing
Copyright 2017 OSIsoft, LLC.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   
Please see the file named [LICENSE.md](LICENSE.md).
