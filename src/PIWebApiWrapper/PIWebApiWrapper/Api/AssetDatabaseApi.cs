// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PIWebAPIWrapper.Client;
using PIWebAPIWrapper.Model;
using PIWebAPIWrapper.Responses;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Api
{

	[Guid("60A932AC-79AC-4C1F-9CE6-FC202B17C513")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IAssetDatabaseApi
	{
		#region Synchronous Operations
		/// <summary>Retrieve an Asset Database by path.</summary>
		[DispId(1)]
		PIAssetDatabase GetByPath(string path, string selectedFields = null);

		/// <summary>Retrieve an Asset Database by path.</summary>
		[DispId(2)]
		ApiResponsePIAssetDatabase GetByPathWithHttpInfo(string path, string selectedFields = null);

		/// <summary>Retrieve an Asset Database.</summary>
		[DispId(3)]
		PIAssetDatabase Get(string webId, string selectedFields = null);

		/// <summary>Retrieve an Asset Database.</summary>
		[DispId(4)]
		ApiResponsePIAssetDatabase GetWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Update an asset database by replacing items in its definition.</summary>
		[DispId(5)]
		Object Update(string webId, PIAssetDatabase database);

		/// <summary>Update an asset database by replacing items in its definition.</summary>
		[DispId(6)]
		ApiResponseObject UpdateWithHttpInfo(string webId, PIAssetDatabase database);

		/// <summary>Delete an asset database.</summary>
		[DispId(7)]
		Object Delete(string webId);

		/// <summary>Delete an asset database.</summary>
		[DispId(8)]
		ApiResponseObject DeleteWithHttpInfo(string webId);

		/// <summary>Retrieve analyses based on the specified conditions.</summary>
		[DispId(9)]
		PIItemsAnalysis FindAnalyses(string webId, string fields, int maxCount, int startIndex, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Retrieve analyses based on the specified conditions.</summary>
		[DispId(10)]
		ApiResponsePIItemsAnalysis FindAnalysesWithHttpInfo(string webId, string fields, int maxCount, int startIndex, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Retrieve analysis categories for a given Asset Database.</summary>
		[DispId(11)]
		PIItemsAnalysisCategory GetAnalysisCategories(string webId, string selectedFields = null);

		/// <summary>Retrieve analysis categories for a given Asset Database.</summary>
		[DispId(12)]
		ApiResponsePIItemsAnalysisCategory GetAnalysisCategoriesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Create an analysis category at the Asset Database root.</summary>
		[DispId(13)]
		Object CreateAnalysisCategory(string webId, PIAnalysisCategory analysisCategory);

		/// <summary>Create an analysis category at the Asset Database root.</summary>
		[DispId(14)]
		ApiResponseObject CreateAnalysisCategoryWithHttpInfo(string webId, PIAnalysisCategory analysisCategory);

		/// <summary>Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.</summary>
		[DispId(15)]
		PIItemsAnalysisTemplate GetAnalysisTemplates(string webId, string fields, int maxCount, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.</summary>
		[DispId(16)]
		ApiResponsePIItemsAnalysisTemplate GetAnalysisTemplatesWithHttpInfo(string webId, string fields, int maxCount, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Create an analysis template at the Asset Database root.</summary>
		[DispId(17)]
		Object CreateAnalysisTemplate(string webId, PIAnalysisTemplate template);

		/// <summary>Create an analysis template at the Asset Database root.</summary>
		[DispId(18)]
		ApiResponseObject CreateAnalysisTemplateWithHttpInfo(string webId, PIAnalysisTemplate template);

		/// <summary>Retrieve attribute categories for a given Asset Database.</summary>
		[DispId(19)]
		PIItemsAttributeCategory GetAttributeCategories(string webId, string selectedFields = null);

		/// <summary>Retrieve attribute categories for a given Asset Database.</summary>
		[DispId(20)]
		ApiResponsePIItemsAttributeCategory GetAttributeCategoriesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Create an attribute category at the Asset Database root.</summary>
		[DispId(21)]
		Object CreateAttributeCategory(string webId, PIAttributeCategory attributeCategory);

		/// <summary>Create an attribute category at the Asset Database root.</summary>
		[DispId(22)]
		ApiResponseObject CreateAttributeCategoryWithHttpInfo(string webId, PIAttributeCategory attributeCategory);

		/// <summary>Retrieves a list of element attributes matching the specified filters from the specified asset database.</summary>
		[DispId(23)]
		PIItemsAttribute FindElementAttributes(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Retrieves a list of element attributes matching the specified filters from the specified asset database.</summary>
		[DispId(24)]
		ApiResponsePIItemsAttribute FindElementAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Retrieve element categories for a given Asset Database.</summary>
		[DispId(25)]
		PIItemsElementCategory GetElementCategories(string webId, string selectedFields = null);

		/// <summary>Retrieve element categories for a given Asset Database.</summary>
		[DispId(26)]
		ApiResponsePIItemsElementCategory GetElementCategoriesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Create an element category at the Asset Database root.</summary>
		[DispId(27)]
		Object CreateElementCategory(string webId, PIElementCategory elementCategory);

		/// <summary>Create an element category at the Asset Database root.</summary>
		[DispId(28)]
		ApiResponseObject CreateElementCategoryWithHttpInfo(string webId, PIElementCategory elementCategory);

		/// <summary>Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.</summary>
		[DispId(29)]
		PIItemsElement GetElements(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null);

		/// <summary>Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.</summary>
		[DispId(30)]
		ApiResponsePIItemsElement GetElementsWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null);

		/// <summary>Create a child element.</summary>
		[DispId(31)]
		Object CreateElement(string webId, PIElement element);

		/// <summary>Create a child element.</summary>
		[DispId(32)]
		ApiResponseObject CreateElementWithHttpInfo(string webId, PIElement element);

		/// <summary>Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.</summary>
		[DispId(33)]
		PIItemsElementTemplate GetElementTemplates(string webId, string fields, int maxCount, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.</summary>
		[DispId(34)]
		ApiResponsePIItemsElementTemplate GetElementTemplatesWithHttpInfo(string webId, string fields, int maxCount, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.</summary>
		[DispId(35)]
		Object CreateElementTemplate(string webId, PIElementTemplate template);

		/// <summary>Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.</summary>
		[DispId(36)]
		ApiResponseObject CreateElementTemplateWithHttpInfo(string webId, PIElementTemplate template);

		/// <summary>Retrieve enumeration sets for given asset database.</summary>
		[DispId(37)]
		PIItemsEnumerationSet GetEnumerationSets(string webId, string selectedFields = null);

		/// <summary>Retrieve enumeration sets for given asset database.</summary>
		[DispId(38)]
		ApiResponsePIItemsEnumerationSet GetEnumerationSetsWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Create an enumeration set at the Asset Database.</summary>
		[DispId(39)]
		Object CreateEnumerationSet(string webId, PIEnumerationSet enumerationSet);

		/// <summary>Create an enumeration set at the Asset Database.</summary>
		[DispId(40)]
		ApiResponseObject CreateEnumerationSetWithHttpInfo(string webId, PIEnumerationSet enumerationSet);

		/// <summary>Retrieves a list of event frame attributes matching the specified filters from the specified asset database.</summary>
		[DispId(41)]
		PIItemsAttribute FindEventFrameAttributes(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, string referencedElementNameFilter = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null);

		/// <summary>Retrieves a list of event frame attributes matching the specified filters from the specified asset database.</summary>
		[DispId(42)]
		ApiResponsePIItemsAttribute FindEventFrameAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, string referencedElementNameFilter = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null);

		/// <summary>Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.</summary>
		[DispId(43)]
		PIItemsEventFrame GetEventFrames(string webId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string endTime = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null);

		/// <summary>Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.</summary>
		[DispId(44)]
		ApiResponsePIItemsEventFrame GetEventFramesWithHttpInfo(string webId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string endTime = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null);

		/// <summary>Create an event frame.</summary>
		[DispId(45)]
		Object CreateEventFrame(string webId, PIEventFrame eventFrame);

		/// <summary>Create an event frame.</summary>
		[DispId(46)]
		ApiResponseObject CreateEventFrameWithHttpInfo(string webId, PIEventFrame eventFrame);

		/// <summary>Export the asset database.</summary>
		[DispId(47)]
		Object Export(string webId, string endTime = null, string exportModes = null, string startTime = null);

		/// <summary>Export the asset database.</summary>
		[DispId(48)]
		ApiResponseObject ExportWithHttpInfo(string webId, string endTime = null, string exportModes = null, string startTime = null);

		/// <summary>Import an asset database.</summary>
		[DispId(49)]
		Object Import(string webId, string importModes = null);

		/// <summary>Import an asset database.</summary>
		[DispId(50)]
		ApiResponseObject ImportWithHttpInfo(string webId, string importModes = null);

		/// <summary>Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.</summary>
		[DispId(51)]
		PIItemsElement GetReferencedElements(string webId, int maxCount, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null);

		/// <summary>Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.</summary>
		[DispId(52)]
		ApiResponsePIItemsElement GetReferencedElementsWithHttpInfo(string webId, int maxCount, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null);

		/// <summary>Add a reference to an existing element to the specified database.</summary>
		[DispId(53)]
		Object AddReferencedElement(string webId, string referencedElementWebIds, string referenceType = null);

		/// <summary>Add a reference to an existing element to the specified database.</summary>
		[DispId(54)]
		ApiResponseObject AddReferencedElementWithHttpInfo(string webId, string referencedElementWebIds, string referenceType = null);

		/// <summary>Remove a reference to an existing element from the specified database.</summary>
		[DispId(55)]
		Object RemoveReferencedElement(string webId, string referencedElementWebIds);

		/// <summary>Remove a reference to an existing element from the specified database.</summary>
		[DispId(56)]
		ApiResponseObject RemoveReferencedElementWithHttpInfo(string webId, string referencedElementWebIds);

		/// <summary>Get the security information of the specified security item associated with the asset database for a specified user.</summary>
		[DispId(57)]
		PIItemsSecurityRights GetSecurity(string webId, string securityItems, string userIdentities, bool forceRefresh, string selectedFields = null);

		/// <summary>Get the security information of the specified security item associated with the asset database for a specified user.</summary>
		[DispId(58)]
		ApiResponsePIItemsSecurityRights GetSecurityWithHttpInfo(string webId, string securityItems, string userIdentities, bool forceRefresh, string selectedFields = null);

		/// <summary>Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.</summary>
		[DispId(59)]
		PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null);

		/// <summary>Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.</summary>
		[DispId(60)]
		ApiResponsePIItemsSecurityEntry GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null);

		/// <summary>Create a security entry owned by the asset database.</summary>
		[DispId(61)]
		Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null);

		/// <summary>Create a security entry owned by the asset database.</summary>
		[DispId(62)]
		ApiResponseObject CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null);

		/// <summary>Retrieve the security entry of the specified security item associated with the asset database with the specified name.</summary>
		[DispId(63)]
		PISecurityEntry GetSecurityEntryByName(string name, string webId, string securityItem = null, string selectedFields = null);

		/// <summary>Retrieve the security entry of the specified security item associated with the asset database with the specified name.</summary>
		[DispId(64)]
		ApiResponsePISecurityEntry GetSecurityEntryByNameWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null);

		/// <summary>Update a security entry owned by the asset database.</summary>
		[DispId(65)]
		Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null);

		/// <summary>Update a security entry owned by the asset database.</summary>
		[DispId(66)]
		ApiResponseObject UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null);

		/// <summary>Delete a security entry owned by the asset database.</summary>
		[DispId(67)]
		Object DeleteSecurityEntry(string name, string webId, bool applyToChildren, string securityItem = null);

		/// <summary>Delete a security entry owned by the asset database.</summary>
		[DispId(68)]
		ApiResponseObject DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren, string securityItem = null);

		/// <summary>Retrieve table categories for a given Asset Database.</summary>
		[DispId(69)]
		PIItemsTableCategory GetTableCategories(string webId, string selectedFields = null);

		/// <summary>Retrieve table categories for a given Asset Database.</summary>
		[DispId(70)]
		ApiResponsePIItemsTableCategory GetTableCategoriesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Create a table category on the Asset Database.</summary>
		[DispId(71)]
		Object CreateTableCategory(string webId, PITableCategory tableCategory);

		/// <summary>Create a table category on the Asset Database.</summary>
		[DispId(72)]
		ApiResponseObject CreateTableCategoryWithHttpInfo(string webId, PITableCategory tableCategory);

		/// <summary>Retrieve tables for given Asset Database.</summary>
		[DispId(73)]
		PIItemsTable GetTables(string webId, string selectedFields = null);

		/// <summary>Retrieve tables for given Asset Database.</summary>
		[DispId(74)]
		ApiResponsePIItemsTable GetTablesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Create a table on the Asset Database.</summary>
		[DispId(75)]
		Object CreateTable(string webId, PITable table);

		/// <summary>Create a table on the Asset Database.</summary>
		[DispId(76)]
		ApiResponseObject CreateTableWithHttpInfo(string webId, PITable table);

		#endregion
	}

	[Guid("B9E29E17-F878-49A2-9683-69E3FE848C58")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IAssetDatabaseApi))]
	[ProgId("PIWebAPIWrapper.AssetDatabaseApi")]

	public class AssetDatabaseApi : IAssetDatabaseApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public AssetDatabaseApi(Configuration configuration = null)
		{
			if (configuration == null)
				this.Configuration = Configuration.Default;
			else
				this.Configuration = configuration;

			ExceptionFactory = PIWebAPIWrapper.Client.Configuration.DefaultExceptionFactory;
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		public Configuration Configuration { get; set; }

		public PIWebAPIWrapper.Client.ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
				{
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				}
				return _exceptionFactory;
			}
			set { _exceptionFactory = value; }
		}

		/// <summary>Retrieve an Asset Database by path.</summary>
		public PIAssetDatabase GetByPath(string path, string selectedFields = null)
		{
			ApiResponsePIAssetDatabase localVarResponse = GetByPathWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an Asset Database by path.</summary>
		public ApiResponsePIAssetDatabase GetByPathWithHttpInfo(string path, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(path)==true)
			{
				path = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/assetdatabases";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (path!= null) localVarQueryParams.Add("path", Configuration.ApiClient.ParameterToString(path));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPath", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIAssetDatabase(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAssetDatabase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetDatabase)));
		}

		/// <summary>Retrieve an Asset Database.</summary>
		public PIAssetDatabase Get(string webId, string selectedFields = null)
		{
			ApiResponsePIAssetDatabase localVarResponse = GetWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an Asset Database.</summary>
		public ApiResponsePIAssetDatabase GetWithHttpInfo(string webId, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Get", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIAssetDatabase(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAssetDatabase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetDatabase)));
		}

		/// <summary>Update an asset database by replacing items in its definition.</summary>
		public Object Update(string webId, PIAssetDatabase database)
		{
			ApiResponseObject localVarResponse = UpdateWithHttpInfo(webId, database);
			return localVarResponse.Data;
		}

		/// <summary>Update an asset database by replacing items in its definition.</summary>
		public ApiResponseObject UpdateWithHttpInfo(string webId, PIAssetDatabase database)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (database == null)
				throw new ApiException(400, "Missing required parameter 'database'");

			var localVarPath = "/assetdatabases/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (database != null && database.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(database);
			}
			else
			{
				localVarPostBody = database;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Update", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Delete an asset database.</summary>
		public Object Delete(string webId)
		{
			ApiResponseObject localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>Delete an asset database.</summary>
		public ApiResponseObject DeleteWithHttpInfo(string webId)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Delete", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve analyses based on the specified conditions.</summary>
		public PIItemsAnalysis FindAnalyses(string webId, string fields, int maxCount, int startIndex, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			ApiResponsePIItemsAnalysis localVarResponse = FindAnalysesWithHttpInfo(webId, fields, maxCount, startIndex, query, selectedFields, sortField, sortOrder);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve analyses based on the specified conditions.</summary>
		public ApiResponsePIItemsAnalysis FindAnalysesWithHttpInfo(string webId, string fields, int maxCount, int startIndex, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			List<string> field = ExtensionMethods.ConvertToList(fields);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(query)==true)
			{
				query = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortField)==true)
			{
				sortField = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/analyses";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("field", Configuration.ApiClient.ParameterToString(field));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (query!= null) localVarQueryParams.Add("query", Configuration.ApiClient.ParameterToString(query));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindAnalyses", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAnalysis(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnalysis)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysis)));
		}

		/// <summary>Retrieve analysis categories for a given Asset Database.</summary>
		public PIItemsAnalysisCategory GetAnalysisCategories(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsAnalysisCategory localVarResponse = GetAnalysisCategoriesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve analysis categories for a given Asset Database.</summary>
		public ApiResponsePIItemsAnalysisCategory GetAnalysisCategoriesWithHttpInfo(string webId, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/analysiscategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysisCategories", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAnalysisCategory(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnalysisCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisCategory)));
		}

		/// <summary>Create an analysis category at the Asset Database root.</summary>
		public Object CreateAnalysisCategory(string webId, PIAnalysisCategory analysisCategory)
		{
			ApiResponseObject localVarResponse = CreateAnalysisCategoryWithHttpInfo(webId, analysisCategory);
			return localVarResponse.Data;
		}

		/// <summary>Create an analysis category at the Asset Database root.</summary>
		public ApiResponseObject CreateAnalysisCategoryWithHttpInfo(string webId, PIAnalysisCategory analysisCategory)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (analysisCategory == null)
				throw new ApiException(400, "Missing required parameter 'analysisCategory'");

			var localVarPath = "/assetdatabases/{webId}/analysiscategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (analysisCategory != null && analysisCategory.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(analysisCategory);
			}
			else
			{
				localVarPostBody = analysisCategory;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnalysisCategory", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.</summary>
		public PIItemsAnalysisTemplate GetAnalysisTemplates(string webId, string fields, int maxCount, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			ApiResponsePIItemsAnalysisTemplate localVarResponse = GetAnalysisTemplatesWithHttpInfo(webId, fields, maxCount, query, selectedFields, sortField, sortOrder);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve analysis templates based on the specified criteria. By default, all analysis templates in the specified Asset Database are returned.</summary>
		public ApiResponsePIItemsAnalysisTemplate GetAnalysisTemplatesWithHttpInfo(string webId, string fields, int maxCount, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			List<string> field = ExtensionMethods.ConvertToList(fields);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(query)==true)
			{
				query = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortField)==true)
			{
				sortField = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/analysistemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("field", Configuration.ApiClient.ParameterToString(field));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (query!= null) localVarQueryParams.Add("query", Configuration.ApiClient.ParameterToString(query));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysisTemplates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAnalysisTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnalysisTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisTemplate)));
		}

		/// <summary>Create an analysis template at the Asset Database root.</summary>
		public Object CreateAnalysisTemplate(string webId, PIAnalysisTemplate template)
		{
			ApiResponseObject localVarResponse = CreateAnalysisTemplateWithHttpInfo(webId, template);
			return localVarResponse.Data;
		}

		/// <summary>Create an analysis template at the Asset Database root.</summary>
		public ApiResponseObject CreateAnalysisTemplateWithHttpInfo(string webId, PIAnalysisTemplate template)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (template == null)
				throw new ApiException(400, "Missing required parameter 'template'");

			var localVarPath = "/assetdatabases/{webId}/analysistemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (template != null && template.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(template);
			}
			else
			{
				localVarPostBody = template;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnalysisTemplate", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve attribute categories for a given Asset Database.</summary>
		public PIItemsAttributeCategory GetAttributeCategories(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsAttributeCategory localVarResponse = GetAttributeCategoriesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve attribute categories for a given Asset Database.</summary>
		public ApiResponsePIItemsAttributeCategory GetAttributeCategoriesWithHttpInfo(string webId, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/attributecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAttributeCategories", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAttributeCategory(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttributeCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttributeCategory)));
		}

		/// <summary>Create an attribute category at the Asset Database root.</summary>
		public Object CreateAttributeCategory(string webId, PIAttributeCategory attributeCategory)
		{
			ApiResponseObject localVarResponse = CreateAttributeCategoryWithHttpInfo(webId, attributeCategory);
			return localVarResponse.Data;
		}

		/// <summary>Create an attribute category at the Asset Database root.</summary>
		public ApiResponseObject CreateAttributeCategoryWithHttpInfo(string webId, PIAttributeCategory attributeCategory)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (attributeCategory == null)
				throw new ApiException(400, "Missing required parameter 'attributeCategory'");

			var localVarPath = "/assetdatabases/{webId}/attributecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (attributeCategory != null && attributeCategory.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(attributeCategory);
			}
			else
			{
				localVarPostBody = attributeCategory;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAttributeCategory", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieves a list of element attributes matching the specified filters from the specified asset database.</summary>
		public PIItemsAttribute FindElementAttributes(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			ApiResponsePIItemsAttribute localVarResponse = FindElementAttributesWithHttpInfo(webId, maxCount, searchFullHierarchy, startIndex, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, elementCategory, elementDescriptionFilter, elementNameFilter, elementTemplate, elementType, selectedFields, sortField, sortOrder);
			return localVarResponse.Data;
		}

		/// <summary>Retrieves a list of element attributes matching the specified filters from the specified asset database.</summary>
		public ApiResponsePIItemsAttribute FindElementAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(attributeCategory)==true)
			{
				attributeCategory = null;
			}
			if (string.IsNullOrEmpty(attributeDescriptionFilter)==true)
			{
				attributeDescriptionFilter = null;
			}
			if (string.IsNullOrEmpty(attributeNameFilter)==true)
			{
				attributeNameFilter = null;
			}
			if (string.IsNullOrEmpty(attributeType)==true)
			{
				attributeType = null;
			}
			if (string.IsNullOrEmpty(elementCategory)==true)
			{
				elementCategory = null;
			}
			if (string.IsNullOrEmpty(elementDescriptionFilter)==true)
			{
				elementDescriptionFilter = null;
			}
			if (string.IsNullOrEmpty(elementNameFilter)==true)
			{
				elementNameFilter = null;
			}
			if (string.IsNullOrEmpty(elementTemplate)==true)
			{
				elementTemplate = null;
			}
			if (string.IsNullOrEmpty(elementType)==true)
			{
				elementType = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortField)==true)
			{
				sortField = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elementattributes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (attributeCategory!= null) localVarQueryParams.Add("attributeCategory", Configuration.ApiClient.ParameterToString(attributeCategory));
			if (attributeDescriptionFilter!= null) localVarQueryParams.Add("attributeDescriptionFilter", Configuration.ApiClient.ParameterToString(attributeDescriptionFilter));
			if (attributeNameFilter!= null) localVarQueryParams.Add("attributeNameFilter", Configuration.ApiClient.ParameterToString(attributeNameFilter));
			if (attributeType!= null) localVarQueryParams.Add("attributeType", Configuration.ApiClient.ParameterToString(attributeType));
			if (elementCategory!= null) localVarQueryParams.Add("elementCategory", Configuration.ApiClient.ParameterToString(elementCategory));
			if (elementDescriptionFilter!= null) localVarQueryParams.Add("elementDescriptionFilter", Configuration.ApiClient.ParameterToString(elementDescriptionFilter));
			if (elementNameFilter!= null) localVarQueryParams.Add("elementNameFilter", Configuration.ApiClient.ParameterToString(elementNameFilter));
			if (elementTemplate!= null) localVarQueryParams.Add("elementTemplate", Configuration.ApiClient.ParameterToString(elementTemplate));
			if (elementType!= null) localVarQueryParams.Add("elementType", Configuration.ApiClient.ParameterToString(elementType));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindElementAttributes", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAttribute(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>Retrieve element categories for a given Asset Database.</summary>
		public PIItemsElementCategory GetElementCategories(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsElementCategory localVarResponse = GetElementCategoriesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve element categories for a given Asset Database.</summary>
		public ApiResponsePIItemsElementCategory GetElementCategoriesWithHttpInfo(string webId, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elementcategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementCategories", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsElementCategory(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElementCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementCategory)));
		}

		/// <summary>Create an element category at the Asset Database root.</summary>
		public Object CreateElementCategory(string webId, PIElementCategory elementCategory)
		{
			ApiResponseObject localVarResponse = CreateElementCategoryWithHttpInfo(webId, elementCategory);
			return localVarResponse.Data;
		}

		/// <summary>Create an element category at the Asset Database root.</summary>
		public ApiResponseObject CreateElementCategoryWithHttpInfo(string webId, PIElementCategory elementCategory)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (elementCategory == null)
				throw new ApiException(400, "Missing required parameter 'elementCategory'");

			var localVarPath = "/assetdatabases/{webId}/elementcategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (elementCategory != null && elementCategory.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(elementCategory);
			}
			else
			{
				localVarPostBody = elementCategory;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementCategory", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.</summary>
		public PIItemsElement GetElements(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null)
		{
			ApiResponsePIItemsElement localVarResponse = GetElementsWithHttpInfo(webId, maxCount, searchFullHierarchy, startIndex, categoryName, descriptionFilter, elementType, nameFilter, selectedFields, sortField, sortOrder, templateName);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified asset database.</summary>
		public ApiResponsePIItemsElement GetElementsWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
			}
			if (string.IsNullOrEmpty(descriptionFilter)==true)
			{
				descriptionFilter = null;
			}
			if (string.IsNullOrEmpty(elementType)==true)
			{
				elementType = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortField)==true)
			{
				sortField = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", Configuration.ApiClient.ParameterToString(descriptionFilter));
			if (elementType!= null) localVarQueryParams.Add("elementType", Configuration.ApiClient.ParameterToString(elementType));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElements", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsElement(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>Create a child element.</summary>
		public Object CreateElement(string webId, PIElement element)
		{
			ApiResponseObject localVarResponse = CreateElementWithHttpInfo(webId, element);
			return localVarResponse.Data;
		}

		/// <summary>Create a child element.</summary>
		public ApiResponseObject CreateElementWithHttpInfo(string webId, PIElement element)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (element == null)
				throw new ApiException(400, "Missing required parameter 'element'");

			var localVarPath = "/assetdatabases/{webId}/elements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (element != null && element.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(element);
			}
			else
			{
				localVarPostBody = element;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElement", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.</summary>
		public PIItemsElementTemplate GetElementTemplates(string webId, string fields, int maxCount, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			ApiResponsePIItemsElementTemplate localVarResponse = GetElementTemplatesWithHttpInfo(webId, fields, maxCount, query, selectedFields, sortField, sortOrder);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve element templates based on the specified criteria. Only templates of instance type "Element" and "EventFrame" are returned. By default, all element and event frame templates in the specified Asset Database are returned.</summary>
		public ApiResponsePIItemsElementTemplate GetElementTemplatesWithHttpInfo(string webId, string fields, int maxCount, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			List<string> field = ExtensionMethods.ConvertToList(fields);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(query)==true)
			{
				query = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortField)==true)
			{
				sortField = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/elementtemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("field", Configuration.ApiClient.ParameterToString(field));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (query!= null) localVarQueryParams.Add("query", Configuration.ApiClient.ParameterToString(query));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetElementTemplates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsElementTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElementTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementTemplate)));
		}

		/// <summary>Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.</summary>
		public Object CreateElementTemplate(string webId, PIElementTemplate template)
		{
			ApiResponseObject localVarResponse = CreateElementTemplateWithHttpInfo(webId, template);
			return localVarResponse.Data;
		}

		/// <summary>Create a template at the Asset Database root. Specify InstanceType of "Element" or "EventFrame" to create element or event frame template respectively. Only these two types of templates can be created.</summary>
		public ApiResponseObject CreateElementTemplateWithHttpInfo(string webId, PIElementTemplate template)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (template == null)
				throw new ApiException(400, "Missing required parameter 'template'");

			var localVarPath = "/assetdatabases/{webId}/elementtemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (template != null && template.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(template);
			}
			else
			{
				localVarPostBody = template;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateElementTemplate", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve enumeration sets for given asset database.</summary>
		public PIItemsEnumerationSet GetEnumerationSets(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsEnumerationSet localVarResponse = GetEnumerationSetsWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve enumeration sets for given asset database.</summary>
		public ApiResponsePIItemsEnumerationSet GetEnumerationSetsWithHttpInfo(string webId, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/enumerationsets";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEnumerationSets", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsEnumerationSet(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsEnumerationSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsEnumerationSet)));
		}

		/// <summary>Create an enumeration set at the Asset Database.</summary>
		public Object CreateEnumerationSet(string webId, PIEnumerationSet enumerationSet)
		{
			ApiResponseObject localVarResponse = CreateEnumerationSetWithHttpInfo(webId, enumerationSet);
			return localVarResponse.Data;
		}

		/// <summary>Create an enumeration set at the Asset Database.</summary>
		public ApiResponseObject CreateEnumerationSetWithHttpInfo(string webId, PIEnumerationSet enumerationSet)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (enumerationSet == null)
				throw new ApiException(400, "Missing required parameter 'enumerationSet'");

			var localVarPath = "/assetdatabases/{webId}/enumerationsets";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (enumerationSet != null && enumerationSet.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(enumerationSet);
			}
			else
			{
				localVarPostBody = enumerationSet;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateEnumerationSet", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieves a list of event frame attributes matching the specified filters from the specified asset database.</summary>
		public PIItemsAttribute FindEventFrameAttributes(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, string referencedElementNameFilter = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null)
		{
			ApiResponsePIItemsAttribute localVarResponse = FindEventFrameAttributesWithHttpInfo(webId, maxCount, searchFullHierarchy, startIndex, attributeCategory, attributeDescriptionFilter, attributeNameFilter, attributeType, endTime, eventFrameCategory, eventFrameDescriptionFilter, eventFrameNameFilter, eventFrameTemplate, referencedElementNameFilter, searchMode, selectedFields, sortField, sortOrder, startTime);
			return localVarResponse.Data;
		}

		/// <summary>Retrieves a list of event frame attributes matching the specified filters from the specified asset database.</summary>
		public ApiResponsePIItemsAttribute FindEventFrameAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, string referencedElementNameFilter = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(attributeCategory)==true)
			{
				attributeCategory = null;
			}
			if (string.IsNullOrEmpty(attributeDescriptionFilter)==true)
			{
				attributeDescriptionFilter = null;
			}
			if (string.IsNullOrEmpty(attributeNameFilter)==true)
			{
				attributeNameFilter = null;
			}
			if (string.IsNullOrEmpty(attributeType)==true)
			{
				attributeType = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(eventFrameCategory)==true)
			{
				eventFrameCategory = null;
			}
			if (string.IsNullOrEmpty(eventFrameDescriptionFilter)==true)
			{
				eventFrameDescriptionFilter = null;
			}
			if (string.IsNullOrEmpty(eventFrameNameFilter)==true)
			{
				eventFrameNameFilter = null;
			}
			if (string.IsNullOrEmpty(eventFrameTemplate)==true)
			{
				eventFrameTemplate = null;
			}
			if (string.IsNullOrEmpty(referencedElementNameFilter)==true)
			{
				referencedElementNameFilter = null;
			}
			if (string.IsNullOrEmpty(searchMode)==true)
			{
				searchMode = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortField)==true)
			{
				sortField = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/eventframeattributes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (attributeCategory!= null) localVarQueryParams.Add("attributeCategory", Configuration.ApiClient.ParameterToString(attributeCategory));
			if (attributeDescriptionFilter!= null) localVarQueryParams.Add("attributeDescriptionFilter", Configuration.ApiClient.ParameterToString(attributeDescriptionFilter));
			if (attributeNameFilter!= null) localVarQueryParams.Add("attributeNameFilter", Configuration.ApiClient.ParameterToString(attributeNameFilter));
			if (attributeType!= null) localVarQueryParams.Add("attributeType", Configuration.ApiClient.ParameterToString(attributeType));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (eventFrameCategory!= null) localVarQueryParams.Add("eventFrameCategory", Configuration.ApiClient.ParameterToString(eventFrameCategory));
			if (eventFrameDescriptionFilter!= null) localVarQueryParams.Add("eventFrameDescriptionFilter", Configuration.ApiClient.ParameterToString(eventFrameDescriptionFilter));
			if (eventFrameNameFilter!= null) localVarQueryParams.Add("eventFrameNameFilter", Configuration.ApiClient.ParameterToString(eventFrameNameFilter));
			if (eventFrameTemplate!= null) localVarQueryParams.Add("eventFrameTemplate", Configuration.ApiClient.ParameterToString(eventFrameTemplate));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", Configuration.ApiClient.ParameterToString(referencedElementNameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (searchMode!= null) localVarQueryParams.Add("searchMode", Configuration.ApiClient.ParameterToString(searchMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("FindEventFrameAttributes", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAttribute(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.</summary>
		public PIItemsEventFrame GetEventFrames(string webId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string endTime = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null)
		{
			ApiResponsePIItemsEventFrame localVarResponse = GetEventFramesWithHttpInfo(webId, canBeAcknowledged, isAcknowledged, maxCount, searchFullHierarchy, startIndex, categoryName, endTime, nameFilter, referencedElementNameFilter, referencedElementTemplateName, searchMode, selectedFields, severities, sortField, sortOrder, startTime, templateName);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve event frames based on the specified conditions. By default, returns all children of the specified root resource with a start time in the past 8 hours.</summary>
		public ApiResponsePIItemsEventFrame GetEventFramesWithHttpInfo(string webId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string endTime = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null)
		{
			List<string> severity = ExtensionMethods.ConvertToList(severities);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(referencedElementNameFilter)==true)
			{
				referencedElementNameFilter = null;
			}
			if (string.IsNullOrEmpty(referencedElementTemplateName)==true)
			{
				referencedElementTemplateName = null;
			}
			if (string.IsNullOrEmpty(searchMode)==true)
			{
				searchMode = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortField)==true)
			{
				sortField = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/eventframes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("canBeAcknowledged", Configuration.ApiClient.ParameterToString(canBeAcknowledged));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			localVarQueryParams.Add("isAcknowledged", Configuration.ApiClient.ParameterToString(isAcknowledged));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (referencedElementNameFilter!= null) localVarQueryParams.Add("referencedElementNameFilter", Configuration.ApiClient.ParameterToString(referencedElementNameFilter));
			if (referencedElementTemplateName!= null) localVarQueryParams.Add("referencedElementTemplateName", Configuration.ApiClient.ParameterToString(referencedElementTemplateName));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (searchMode!= null) localVarQueryParams.Add("searchMode", Configuration.ApiClient.ParameterToString(searchMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("severity", Configuration.ApiClient.ParameterToString(severity));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEventFrames", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsEventFrame(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsEventFrame)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsEventFrame)));
		}

		/// <summary>Create an event frame.</summary>
		public Object CreateEventFrame(string webId, PIEventFrame eventFrame)
		{
			ApiResponseObject localVarResponse = CreateEventFrameWithHttpInfo(webId, eventFrame);
			return localVarResponse.Data;
		}

		/// <summary>Create an event frame.</summary>
		public ApiResponseObject CreateEventFrameWithHttpInfo(string webId, PIEventFrame eventFrame)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (eventFrame == null)
				throw new ApiException(400, "Missing required parameter 'eventFrame'");

			var localVarPath = "/assetdatabases/{webId}/eventframes";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (eventFrame != null && eventFrame.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(eventFrame);
			}
			else
			{
				localVarPostBody = eventFrame;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateEventFrame", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Export the asset database.</summary>
		public Object Export(string webId, string endTime = null, string exportModes = null, string startTime = null)
		{
			ApiResponseObject localVarResponse = ExportWithHttpInfo(webId, endTime, exportModes, startTime);
			return localVarResponse.Data;
		}

		/// <summary>Export the asset database.</summary>
		public ApiResponseObject ExportWithHttpInfo(string webId, string endTime = null, string exportModes = null, string startTime = null)
		{
			List<string> exportMode = ExtensionMethods.ConvertToList(exportModes);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/export";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			localVarQueryParams.Add("exportMode", Configuration.ApiClient.ParameterToString(exportMode));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Export", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Import an asset database.</summary>
		public Object Import(string webId, string importModes = null)
		{
			ApiResponseObject localVarResponse = ImportWithHttpInfo(webId, importModes);
			return localVarResponse.Data;
		}

		/// <summary>Import an asset database.</summary>
		public ApiResponseObject ImportWithHttpInfo(string webId, string importModes = null)
		{
			List<string> importMode = ExtensionMethods.ConvertToList(importModes);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/import";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("importMode", Configuration.ApiClient.ParameterToString(importMode));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Import", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.</summary>
		public PIItemsElement GetReferencedElements(string webId, int maxCount, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null)
		{
			ApiResponsePIItemsElement localVarResponse = GetReferencedElementsWithHttpInfo(webId, maxCount, startIndex, categoryName, descriptionFilter, elementType, nameFilter, selectedFields, sortField, sortOrder, templateName);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements at the root level of the asset database.</summary>
		public ApiResponsePIItemsElement GetReferencedElementsWithHttpInfo(string webId, int maxCount, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
			}
			if (string.IsNullOrEmpty(descriptionFilter)==true)
			{
				descriptionFilter = null;
			}
			if (string.IsNullOrEmpty(elementType)==true)
			{
				elementType = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortField)==true)
			{
				sortField = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/referencedelements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (descriptionFilter!= null) localVarQueryParams.Add("descriptionFilter", Configuration.ApiClient.ParameterToString(descriptionFilter));
			if (elementType!= null) localVarQueryParams.Add("elementType", Configuration.ApiClient.ParameterToString(elementType));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetReferencedElements", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsElement(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElement)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElement)));
		}

		/// <summary>Add a reference to an existing element to the specified database.</summary>
		public Object AddReferencedElement(string webId, string referencedElementWebIds, string referenceType = null)
		{
			ApiResponseObject localVarResponse = AddReferencedElementWithHttpInfo(webId, referencedElementWebIds, referenceType);
			return localVarResponse.Data;
		}

		/// <summary>Add a reference to an existing element to the specified database.</summary>
		public ApiResponseObject AddReferencedElementWithHttpInfo(string webId, string referencedElementWebIds, string referenceType = null)
		{
			List<string> referencedElementWebId = ExtensionMethods.ConvertToList(referencedElementWebIds);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(referenceType)==true)
			{
				referenceType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/referencedelements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("referencedElementWebId", Configuration.ApiClient.ParameterToString(referencedElementWebId));
			if (referenceType!= null) localVarQueryParams.Add("referenceType", Configuration.ApiClient.ParameterToString(referenceType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("AddReferencedElement", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Remove a reference to an existing element from the specified database.</summary>
		public Object RemoveReferencedElement(string webId, string referencedElementWebIds)
		{
			ApiResponseObject localVarResponse = RemoveReferencedElementWithHttpInfo(webId, referencedElementWebIds);
			return localVarResponse.Data;
		}

		/// <summary>Remove a reference to an existing element from the specified database.</summary>
		public ApiResponseObject RemoveReferencedElementWithHttpInfo(string webId, string referencedElementWebIds)
		{
			List<string> referencedElementWebId = ExtensionMethods.ConvertToList(referencedElementWebIds);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/referencedelements";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("referencedElementWebId", Configuration.ApiClient.ParameterToString(referencedElementWebId));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("RemoveReferencedElement", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Get the security information of the specified security item associated with the asset database for a specified user.</summary>
		public PIItemsSecurityRights GetSecurity(string webId, string securityItems, string userIdentities, bool forceRefresh, string selectedFields = null)
		{
			ApiResponsePIItemsSecurityRights localVarResponse = GetSecurityWithHttpInfo(webId, securityItems, userIdentities, forceRefresh, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Get the security information of the specified security item associated with the asset database for a specified user.</summary>
		public ApiResponsePIItemsSecurityRights GetSecurityWithHttpInfo(string webId, string securityItems, string userIdentities, bool forceRefresh, string selectedFields = null)
		{
			List<string> securityItem = ExtensionMethods.ConvertToList(securityItems);
			List<string> userIdentity = ExtensionMethods.ConvertToList(userIdentities);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/security";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("securityItem", Configuration.ApiClient.ParameterToString(securityItem));
			localVarQueryParams.Add("userIdentity", Configuration.ApiClient.ParameterToString(userIdentity));
			localVarQueryParams.Add("forceRefresh", Configuration.ApiClient.ParameterToString(forceRefresh));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurity", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSecurityRights(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityRights)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityRights)));
		}

		/// <summary>Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.</summary>
		public PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null)
		{
			ApiResponsePIItemsSecurityEntry localVarResponse = GetSecurityEntriesWithHttpInfo(webId, nameFilter, securityItem, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve the security entries of the specified security item associated with the asset database based on the specified criteria. By default, all security entries for this asset database are returned.</summary>
		public ApiResponsePIItemsSecurityEntry GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(securityItem)==true)
			{
				securityItem = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", Configuration.ApiClient.ParameterToString(securityItem));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntries", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSecurityEntry(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityEntry)));
		}

		/// <summary>Create a security entry owned by the asset database.</summary>
		public Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null)
		{
			ApiResponseObject localVarResponse = CreateSecurityEntryWithHttpInfo(webId, securityEntry, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>Create a security entry owned by the asset database.</summary>
		public ApiResponseObject CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(securityItem)==true)
			{
				securityItem = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetdatabases/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityEntry != null && securityEntry.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			}
			else
			{
				localVarPostBody = securityEntry;
			}
			localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", Configuration.ApiClient.ParameterToString(securityItem));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityEntry", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve the security entry of the specified security item associated with the asset database with the specified name.</summary>
		public PISecurityEntry GetSecurityEntryByName(string name, string webId, string securityItem = null, string selectedFields = null)
		{
			ApiResponsePISecurityEntry localVarResponse = GetSecurityEntryByNameWithHttpInfo(name, webId, securityItem, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve the security entry of the specified security item associated with the asset database with the specified name.</summary>
		public ApiResponsePISecurityEntry GetSecurityEntryByNameWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(name)==true)
			{
				name = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(securityItem)==true)
			{
				securityItem = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", Configuration.ApiClient.ParameterToString(securityItem));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntryByName", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePISecurityEntry(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PISecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISecurityEntry)));
		}

		/// <summary>Update a security entry owned by the asset database.</summary>
		public Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null)
		{
			ApiResponseObject localVarResponse = UpdateSecurityEntryWithHttpInfo(name, webId, securityEntry, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>Update a security entry owned by the asset database.</summary>
		public ApiResponseObject UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null)
		{
			if (string.IsNullOrEmpty(name)==true)
			{
				name = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(securityItem)==true)
			{
				securityItem = null;
			}
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetdatabases/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityEntry != null && securityEntry.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			}
			else
			{
				localVarPostBody = securityEntry;
			}
			localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", Configuration.ApiClient.ParameterToString(securityItem));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateSecurityEntry", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Delete a security entry owned by the asset database.</summary>
		public Object DeleteSecurityEntry(string name, string webId, bool applyToChildren, string securityItem = null)
		{
			ApiResponseObject localVarResponse = DeleteSecurityEntryWithHttpInfo(name, webId, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>Delete a security entry owned by the asset database.</summary>
		public ApiResponseObject DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren, string securityItem = null)
		{
			if (string.IsNullOrEmpty(name)==true)
			{
				name = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(securityItem)==true)
			{
				securityItem = null;
			}
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", Configuration.ApiClient.ParameterToString(securityItem));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteSecurityEntry", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve table categories for a given Asset Database.</summary>
		public PIItemsTableCategory GetTableCategories(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsTableCategory localVarResponse = GetTableCategoriesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve table categories for a given Asset Database.</summary>
		public ApiResponsePIItemsTableCategory GetTableCategoriesWithHttpInfo(string webId, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/tablecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetTableCategories", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsTableCategory(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsTableCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsTableCategory)));
		}

		/// <summary>Create a table category on the Asset Database.</summary>
		public Object CreateTableCategory(string webId, PITableCategory tableCategory)
		{
			ApiResponseObject localVarResponse = CreateTableCategoryWithHttpInfo(webId, tableCategory);
			return localVarResponse.Data;
		}

		/// <summary>Create a table category on the Asset Database.</summary>
		public ApiResponseObject CreateTableCategoryWithHttpInfo(string webId, PITableCategory tableCategory)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (tableCategory == null)
				throw new ApiException(400, "Missing required parameter 'tableCategory'");

			var localVarPath = "/assetdatabases/{webId}/tablecategories";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (tableCategory != null && tableCategory.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(tableCategory);
			}
			else
			{
				localVarPostBody = tableCategory;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateTableCategory", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve tables for given Asset Database.</summary>
		public PIItemsTable GetTables(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsTable localVarResponse = GetTablesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve tables for given Asset Database.</summary>
		public ApiResponsePIItemsTable GetTablesWithHttpInfo(string webId, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetdatabases/{webId}/tables";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetTables", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsTable(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsTable)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsTable)));
		}

		/// <summary>Create a table on the Asset Database.</summary>
		public Object CreateTable(string webId, PITable table)
		{
			ApiResponseObject localVarResponse = CreateTableWithHttpInfo(webId, table);
			return localVarResponse.Data;
		}

		/// <summary>Create a table on the Asset Database.</summary>
		public ApiResponseObject CreateTableWithHttpInfo(string webId, PITable table)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (table == null)
				throw new ApiException(400, "Missing required parameter 'table'");

			var localVarPath = "/assetdatabases/{webId}/tables";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			var localVarFileParams = new Dictionary<String, FileParameter>();
			Object localVarPostBody = null;

			String[] localVarHttpContentTypes = new String[] { }; 
			String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
			String[] localVarHttpHeaderAccepts = new String[] { "application/json", "text/json", "text/xml" };
			String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

			localVarPathParams.Add("format", "json");

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (table != null && table.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(table);
			}
			else
			{
				localVarPostBody = table;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateTable", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

	}
}
