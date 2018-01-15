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

	[Guid("4A98DBCD-A815-4F7A-92E1-FA73A168B85B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IAssetServerApi
	{
		#region Synchronous Operations
		/// <summary>Retrieve a list of all Asset Servers known to this service.</summary>
		[DispId(1)]
		PIItemsAssetServer List(string selectedFields = null);

		/// <summary>Retrieve a list of all Asset Servers known to this service.</summary>
		[DispId(2)]
		ApiResponsePIItemsAssetServer ListWithHttpInfo(string selectedFields = null);

		/// <summary>Retrieve an Asset Server by name.</summary>
		[DispId(3)]
		PIAssetServer GetByName(string name, string selectedFields = null);

		/// <summary>Retrieve an Asset Server by name.</summary>
		[DispId(4)]
		ApiResponsePIAssetServer GetByNameWithHttpInfo(string name, string selectedFields = null);

		/// <summary>Retrieve an Asset Server by path.</summary>
		[DispId(5)]
		PIAssetServer GetByPath(string path, string selectedFields = null);

		/// <summary>Retrieve an Asset Server by path.</summary>
		[DispId(6)]
		ApiResponsePIAssetServer GetByPathWithHttpInfo(string path, string selectedFields = null);

		/// <summary>Retrieve an Asset Server.</summary>
		[DispId(7)]
		PIAssetServer Get(string webId, string selectedFields = null);

		/// <summary>Retrieve an Asset Server.</summary>
		[DispId(8)]
		ApiResponsePIAssetServer GetWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Retrieve a list of all Analysis Rule Plug-in's.</summary>
		[DispId(9)]
		PIItemsAnalysisRulePlugIn GetAnalysisRulePlugIns(string webId, string selectedFields = null);

		/// <summary>Retrieve a list of all Analysis Rule Plug-in's.</summary>
		[DispId(10)]
		ApiResponsePIItemsAnalysisRulePlugIn GetAnalysisRulePlugInsWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Retrieve a list of all Asset Databases on the specified Asset Server.</summary>
		[DispId(11)]
		PIItemsAssetDatabase GetDatabases(string webId, string selectedFields = null);

		/// <summary>Retrieve a list of all Asset Databases on the specified Asset Server.</summary>
		[DispId(12)]
		ApiResponsePIItemsAssetDatabase GetDatabasesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Create an asset database.</summary>
		[DispId(13)]
		Object CreateAssetDatabase(string webId, PIAssetDatabase database);

		/// <summary>Create an asset database.</summary>
		[DispId(14)]
		ApiResponseObject CreateAssetDatabaseWithHttpInfo(string webId, PIAssetDatabase database);

		/// <summary>Get the security information of the specified security item associated with the asset server for a specified user.</summary>
		[DispId(15)]
		PIItemsSecurityRights GetSecurity(string webId, string securityItems, string userIdentities, bool forceRefresh, string selectedFields = null);

		/// <summary>Get the security information of the specified security item associated with the asset server for a specified user.</summary>
		[DispId(16)]
		ApiResponsePIItemsSecurityRights GetSecurityWithHttpInfo(string webId, string securityItems, string userIdentities, bool forceRefresh, string selectedFields = null);

		/// <summary>Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.</summary>
		[DispId(17)]
		PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null);

		/// <summary>Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.</summary>
		[DispId(18)]
		ApiResponsePIItemsSecurityEntry GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null);

		/// <summary>Create a security entry owned by the asset server.</summary>
		[DispId(19)]
		Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null);

		/// <summary>Create a security entry owned by the asset server.</summary>
		[DispId(20)]
		ApiResponseObject CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null);

		/// <summary>Retrieve the security entry of the specified security item associated with the asset server with the specified name.</summary>
		[DispId(21)]
		PISecurityEntry GetSecurityEntryByName(string name, string webId, string securityItem = null, string selectedFields = null);

		/// <summary>Retrieve the security entry of the specified security item associated with the asset server with the specified name.</summary>
		[DispId(22)]
		ApiResponsePISecurityEntry GetSecurityEntryByNameWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null);

		/// <summary>Update a security entry owned by the asset server.</summary>
		[DispId(23)]
		Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null);

		/// <summary>Update a security entry owned by the asset server.</summary>
		[DispId(24)]
		ApiResponseObject UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null);

		/// <summary>Delete a security entry owned by the asset server.</summary>
		[DispId(25)]
		Object DeleteSecurityEntry(string name, string webId, bool applyToChildren, string securityItem = null);

		/// <summary>Delete a security entry owned by the asset server.</summary>
		[DispId(26)]
		ApiResponseObject DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren, string securityItem = null);

		/// <summary>Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.</summary>
		[DispId(27)]
		PIItemsSecurityIdentity GetSecurityIdentities(string webId, int maxCount, string field = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.</summary>
		[DispId(28)]
		ApiResponsePIItemsSecurityIdentity GetSecurityIdentitiesWithHttpInfo(string webId, int maxCount, string field = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Create a security identity.</summary>
		[DispId(29)]
		Object CreateSecurityIdentity(string webId, PISecurityIdentity securityIdentity);

		/// <summary>Create a security identity.</summary>
		[DispId(30)]
		ApiResponseObject CreateSecurityIdentityWithHttpInfo(string webId, PISecurityIdentity securityIdentity);

		/// <summary>Retrieve security identities for a specific user.</summary>
		[DispId(31)]
		PIItemsSecurityIdentity GetSecurityIdentitiesForUser(string webId, string userIdentity, string selectedFields = null);

		/// <summary>Retrieve security identities for a specific user.</summary>
		[DispId(32)]
		ApiResponsePIItemsSecurityIdentity GetSecurityIdentitiesForUserWithHttpInfo(string webId, string userIdentity, string selectedFields = null);

		/// <summary>Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.</summary>
		[DispId(33)]
		PIItemsSecurityMapping GetSecurityMappings(string webId, int maxCount, string field = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.</summary>
		[DispId(34)]
		ApiResponsePIItemsSecurityMapping GetSecurityMappingsWithHttpInfo(string webId, int maxCount, string field = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Create a security mapping.</summary>
		[DispId(35)]
		Object CreateSecurityMapping(string webId, PISecurityMapping securityMapping);

		/// <summary>Create a security mapping.</summary>
		[DispId(36)]
		ApiResponseObject CreateSecurityMappingWithHttpInfo(string webId, PISecurityMapping securityMapping);

		/// <summary>Retrieve a list of all Time Rule Plug-in's.</summary>
		[DispId(37)]
		PIItemsTimeRulePlugIn GetTimeRulePlugIns(string webId, string selectedFields = null);

		/// <summary>Retrieve a list of all Time Rule Plug-in's.</summary>
		[DispId(38)]
		ApiResponsePIItemsTimeRulePlugIn GetTimeRulePlugInsWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Retrieve a list of all unit classes on the specified Asset Server.</summary>
		[DispId(39)]
		PIItemsUnitClass GetUnitClasses(string webId, string selectedFields = null);

		/// <summary>Retrieve a list of all unit classes on the specified Asset Server.</summary>
		[DispId(40)]
		ApiResponsePIItemsUnitClass GetUnitClassesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Create a unit class in the specified Asset Server.</summary>
		[DispId(41)]
		Object CreateUnitClass(string webId, PIUnitClass unitClass);

		/// <summary>Create a unit class in the specified Asset Server.</summary>
		[DispId(42)]
		ApiResponseObject CreateUnitClassWithHttpInfo(string webId, PIUnitClass unitClass);

		#endregion
	}

	[Guid("951FA519-5A69-4C1D-9B59-FC5B613A1FB1")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IAssetServerApi))]
	[ProgId("PIWebAPIWrapper.AssetServerApi")]

	public class AssetServerApi : IAssetServerApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public AssetServerApi(Configuration configuration = null)
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

		/// <summary>Retrieve a list of all Asset Servers known to this service.</summary>
		public PIItemsAssetServer List(string selectedFields = null)
		{
			ApiResponsePIItemsAssetServer localVarResponse = ListWithHttpInfo(selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a list of all Asset Servers known to this service.</summary>
		public ApiResponsePIItemsAssetServer ListWithHttpInfo(string selectedFields = null)
		{
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}

			var localVarPath = "/assetservers";
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

			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("List", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAssetServer(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAssetServer)));
		}

		/// <summary>Retrieve an Asset Server by name.</summary>
		public PIAssetServer GetByName(string name, string selectedFields = null)
		{
			ApiResponsePIAssetServer localVarResponse = GetByNameWithHttpInfo(name, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an Asset Server by name.</summary>
		public ApiResponsePIAssetServer GetByNameWithHttpInfo(string name, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(name)==true)
			{
				name = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");

			var localVarPath = "/assetservers";
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

			if (name!= null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByName", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIAssetServer(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetServer)));
		}

		/// <summary>Retrieve an Asset Server by path.</summary>
		public PIAssetServer GetByPath(string path, string selectedFields = null)
		{
			ApiResponsePIAssetServer localVarResponse = GetByPathWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an Asset Server by path.</summary>
		public ApiResponsePIAssetServer GetByPathWithHttpInfo(string path, string selectedFields = null)
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

			var localVarPath = "/assetservers";
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

			return new ApiResponsePIAssetServer(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetServer)));
		}

		/// <summary>Retrieve an Asset Server.</summary>
		public PIAssetServer Get(string webId, string selectedFields = null)
		{
			ApiResponsePIAssetServer localVarResponse = GetWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an Asset Server.</summary>
		public ApiResponsePIAssetServer GetWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/assetservers/{webId}";
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

			return new ApiResponsePIAssetServer(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetServer)));
		}

		/// <summary>Retrieve a list of all Analysis Rule Plug-in's.</summary>
		public PIItemsAnalysisRulePlugIn GetAnalysisRulePlugIns(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsAnalysisRulePlugIn localVarResponse = GetAnalysisRulePlugInsWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a list of all Analysis Rule Plug-in's.</summary>
		public ApiResponsePIItemsAnalysisRulePlugIn GetAnalysisRulePlugInsWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/assetservers/{webId}/analysisruleplugins";
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
				Exception exception = ExceptionFactory("GetAnalysisRulePlugIns", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAnalysisRulePlugIn(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnalysisRulePlugIn)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisRulePlugIn)));
		}

		/// <summary>Retrieve a list of all Asset Databases on the specified Asset Server.</summary>
		public PIItemsAssetDatabase GetDatabases(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsAssetDatabase localVarResponse = GetDatabasesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a list of all Asset Databases on the specified Asset Server.</summary>
		public ApiResponsePIItemsAssetDatabase GetDatabasesWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/assetservers/{webId}/assetdatabases";
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
				Exception exception = ExceptionFactory("GetDatabases", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAssetDatabase(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAssetDatabase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAssetDatabase)));
		}

		/// <summary>Create an asset database.</summary>
		public Object CreateAssetDatabase(string webId, PIAssetDatabase database)
		{
			ApiResponseObject localVarResponse = CreateAssetDatabaseWithHttpInfo(webId, database);
			return localVarResponse.Data;
		}

		/// <summary>Create an asset database.</summary>
		public ApiResponseObject CreateAssetDatabaseWithHttpInfo(string webId, PIAssetDatabase database)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (database == null)
				throw new ApiException(400, "Missing required parameter 'database'");

			var localVarPath = "/assetservers/{webId}/assetdatabases";
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
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAssetDatabase", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Get the security information of the specified security item associated with the asset server for a specified user.</summary>
		public PIItemsSecurityRights GetSecurity(string webId, string securityItems, string userIdentities, bool forceRefresh, string selectedFields = null)
		{
			ApiResponsePIItemsSecurityRights localVarResponse = GetSecurityWithHttpInfo(webId, securityItems, userIdentities, forceRefresh, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Get the security information of the specified security item associated with the asset server for a specified user.</summary>
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

			var localVarPath = "/assetservers/{webId}/security";
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

		/// <summary>Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.</summary>
		public PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null)
		{
			ApiResponsePIItemsSecurityEntry localVarResponse = GetSecurityEntriesWithHttpInfo(webId, nameFilter, securityItem, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.</summary>
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

			var localVarPath = "/assetservers/{webId}/securityentries";
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

		/// <summary>Create a security entry owned by the asset server.</summary>
		public Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null)
		{
			ApiResponseObject localVarResponse = CreateSecurityEntryWithHttpInfo(webId, securityEntry, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>Create a security entry owned by the asset server.</summary>
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

			var localVarPath = "/assetservers/{webId}/securityentries";
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

		/// <summary>Retrieve the security entry of the specified security item associated with the asset server with the specified name.</summary>
		public PISecurityEntry GetSecurityEntryByName(string name, string webId, string securityItem = null, string selectedFields = null)
		{
			ApiResponsePISecurityEntry localVarResponse = GetSecurityEntryByNameWithHttpInfo(name, webId, securityItem, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve the security entry of the specified security item associated with the asset server with the specified name.</summary>
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

			var localVarPath = "/assetservers/{webId}/securityentries/{name}";
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

		/// <summary>Update a security entry owned by the asset server.</summary>
		public Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren, string securityItem = null)
		{
			ApiResponseObject localVarResponse = UpdateSecurityEntryWithHttpInfo(name, webId, securityEntry, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>Update a security entry owned by the asset server.</summary>
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

			var localVarPath = "/assetservers/{webId}/securityentries/{name}";
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

		/// <summary>Delete a security entry owned by the asset server.</summary>
		public Object DeleteSecurityEntry(string name, string webId, bool applyToChildren, string securityItem = null)
		{
			ApiResponseObject localVarResponse = DeleteSecurityEntryWithHttpInfo(name, webId, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>Delete a security entry owned by the asset server.</summary>
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

			var localVarPath = "/assetservers/{webId}/securityentries/{name}";
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

		/// <summary>Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.</summary>
		public PIItemsSecurityIdentity GetSecurityIdentities(string webId, int maxCount, string field = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			ApiResponsePIItemsSecurityIdentity localVarResponse = GetSecurityIdentitiesWithHttpInfo(webId, maxCount, field, query, selectedFields, sortField, sortOrder);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.</summary>
		public ApiResponsePIItemsSecurityIdentity GetSecurityIdentitiesWithHttpInfo(string webId, int maxCount, string field = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(field)==true)
			{
				field = null;
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

			var localVarPath = "/assetservers/{webId}/securityidentities";
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
			if (field!= null) localVarQueryParams.Add("field", Configuration.ApiClient.ParameterToString(field));
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
				Exception exception = ExceptionFactory("GetSecurityIdentities", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSecurityIdentity(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityIdentity)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityIdentity)));
		}

		/// <summary>Create a security identity.</summary>
		public Object CreateSecurityIdentity(string webId, PISecurityIdentity securityIdentity)
		{
			ApiResponseObject localVarResponse = CreateSecurityIdentityWithHttpInfo(webId, securityIdentity);
			return localVarResponse.Data;
		}

		/// <summary>Create a security identity.</summary>
		public ApiResponseObject CreateSecurityIdentityWithHttpInfo(string webId, PISecurityIdentity securityIdentity)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (securityIdentity == null)
				throw new ApiException(400, "Missing required parameter 'securityIdentity'");

			var localVarPath = "/assetservers/{webId}/securityidentities";
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
			if (securityIdentity != null && securityIdentity.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(securityIdentity);
			}
			else
			{
				localVarPostBody = securityIdentity;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityIdentity", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve security identities for a specific user.</summary>
		public PIItemsSecurityIdentity GetSecurityIdentitiesForUser(string webId, string userIdentity, string selectedFields = null)
		{
			ApiResponsePIItemsSecurityIdentity localVarResponse = GetSecurityIdentitiesForUserWithHttpInfo(webId, userIdentity, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve security identities for a specific user.</summary>
		public ApiResponsePIItemsSecurityIdentity GetSecurityIdentitiesForUserWithHttpInfo(string webId, string userIdentity, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(userIdentity)==true)
			{
				userIdentity = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (userIdentity == null)
				throw new ApiException(400, "Missing required parameter 'userIdentity'");

			var localVarPath = "/assetservers/{webId}/securityidentities";
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
			if (userIdentity!= null) localVarQueryParams.Add("userIdentity", Configuration.ApiClient.ParameterToString(userIdentity));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityIdentitiesForUser", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSecurityIdentity(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityIdentity)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityIdentity)));
		}

		/// <summary>Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.</summary>
		public PIItemsSecurityMapping GetSecurityMappings(string webId, int maxCount, string field = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			ApiResponsePIItemsSecurityMapping localVarResponse = GetSecurityMappingsWithHttpInfo(webId, maxCount, field, query, selectedFields, sortField, sortOrder);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.</summary>
		public ApiResponsePIItemsSecurityMapping GetSecurityMappingsWithHttpInfo(string webId, int maxCount, string field = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(field)==true)
			{
				field = null;
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

			var localVarPath = "/assetservers/{webId}/securitymappings";
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
			if (field!= null) localVarQueryParams.Add("field", Configuration.ApiClient.ParameterToString(field));
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
				Exception exception = ExceptionFactory("GetSecurityMappings", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSecurityMapping(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityMapping)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityMapping)));
		}

		/// <summary>Create a security mapping.</summary>
		public Object CreateSecurityMapping(string webId, PISecurityMapping securityMapping)
		{
			ApiResponseObject localVarResponse = CreateSecurityMappingWithHttpInfo(webId, securityMapping);
			return localVarResponse.Data;
		}

		/// <summary>Create a security mapping.</summary>
		public ApiResponseObject CreateSecurityMappingWithHttpInfo(string webId, PISecurityMapping securityMapping)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (securityMapping == null)
				throw new ApiException(400, "Missing required parameter 'securityMapping'");

			var localVarPath = "/assetservers/{webId}/securitymappings";
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
			if (securityMapping != null && securityMapping.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(securityMapping);
			}
			else
			{
				localVarPostBody = securityMapping;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityMapping", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve a list of all Time Rule Plug-in's.</summary>
		public PIItemsTimeRulePlugIn GetTimeRulePlugIns(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsTimeRulePlugIn localVarResponse = GetTimeRulePlugInsWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a list of all Time Rule Plug-in's.</summary>
		public ApiResponsePIItemsTimeRulePlugIn GetTimeRulePlugInsWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/assetservers/{webId}/timeruleplugins";
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
				Exception exception = ExceptionFactory("GetTimeRulePlugIns", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsTimeRulePlugIn(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsTimeRulePlugIn)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsTimeRulePlugIn)));
		}

		/// <summary>Retrieve a list of all unit classes on the specified Asset Server.</summary>
		public PIItemsUnitClass GetUnitClasses(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsUnitClass localVarResponse = GetUnitClassesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a list of all unit classes on the specified Asset Server.</summary>
		public ApiResponsePIItemsUnitClass GetUnitClassesWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/assetservers/{webId}/unitclasses";
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
				Exception exception = ExceptionFactory("GetUnitClasses", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsUnitClass(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsUnitClass)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsUnitClass)));
		}

		/// <summary>Create a unit class in the specified Asset Server.</summary>
		public Object CreateUnitClass(string webId, PIUnitClass unitClass)
		{
			ApiResponseObject localVarResponse = CreateUnitClassWithHttpInfo(webId, unitClass);
			return localVarResponse.Data;
		}

		/// <summary>Create a unit class in the specified Asset Server.</summary>
		public ApiResponseObject CreateUnitClassWithHttpInfo(string webId, PIUnitClass unitClass)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (unitClass == null)
				throw new ApiException(400, "Missing required parameter 'unitClass'");

			var localVarPath = "/assetservers/{webId}/unitclasses";
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
			if (unitClass != null && unitClass.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(unitClass);
			}
			else
			{
				localVarPostBody = unitClass;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateUnitClass", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

	}
}
