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

	[Guid("53D71B05-6405-4FB8-9385-53044382A467")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IAnalysisApi
	{
		#region Synchronous Operations
		/// <summary>Retrieve an Analysis by path.</summary>
		[DispId(1)]
		PIAnalysis GetByPath(string path, string selectedFields = null);

		/// <summary>Retrieve an Analysis by path.</summary>
		[DispId(2)]
		ApiResponsePIAnalysis GetByPathWithHttpInfo(string path, string selectedFields = null);

		/// <summary>Retrieve an Analysis.</summary>
		[DispId(3)]
		PIAnalysis Get(string webId, string selectedFields = null);

		/// <summary>Retrieve an Analysis.</summary>
		[DispId(4)]
		ApiResponsePIAnalysis GetWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Update an Analysis.</summary>
		[DispId(5)]
		Object Update(string webId, PIAnalysis analysis);

		/// <summary>Update an Analysis.</summary>
		[DispId(6)]
		ApiResponseObject UpdateWithHttpInfo(string webId, PIAnalysis analysis);

		/// <summary>Delete an Analysis.</summary>
		[DispId(7)]
		Object Delete(string webId);

		/// <summary>Delete an Analysis.</summary>
		[DispId(8)]
		ApiResponseObject DeleteWithHttpInfo(string webId);

		/// <summary>Get an Analysis' categories.</summary>
		[DispId(9)]
		PIItemsAnalysisCategory GetCategories(string webId, string selectedFields = null);

		/// <summary>Get an Analysis' categories.</summary>
		[DispId(10)]
		ApiResponsePIItemsAnalysisCategory GetCategoriesWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Get the security information of the specified security item associated with the Analysis for a specified user.</summary>
		[DispId(11)]
		PIItemsSecurityRights GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null);

		/// <summary>Get the security information of the specified security item associated with the Analysis for a specified user.</summary>
		[DispId(12)]
		ApiResponsePIItemsSecurityRights GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null);

		/// <summary>Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.</summary>
		[DispId(13)]
		PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.</summary>
		[DispId(14)]
		ApiResponsePIItemsSecurityEntry GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null);

		/// <summary>Create a security entry owned by the analysis.</summary>
		[DispId(15)]
		Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren);

		/// <summary>Create a security entry owned by the analysis.</summary>
		[DispId(16)]
		ApiResponseObject CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren);

		/// <summary>Retrieve the security entry associated with the analysis with the specified name.</summary>
		[DispId(17)]
		PISecurityEntry GetSecurityEntryByName(string name, string webId, string selectedFields = null);

		/// <summary>Retrieve the security entry associated with the analysis with the specified name.</summary>
		[DispId(18)]
		ApiResponsePISecurityEntry GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null);

		/// <summary>Update a security entry owned by the analysis.</summary>
		[DispId(19)]
		Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren);

		/// <summary>Update a security entry owned by the analysis.</summary>
		[DispId(20)]
		ApiResponseObject UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren);

		/// <summary>Delete a security entry owned by the analysis.</summary>
		[DispId(21)]
		Object DeleteSecurityEntry(string name, string webId, bool applyToChildren);

		/// <summary>Delete a security entry owned by the analysis.</summary>
		[DispId(22)]
		ApiResponseObject DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren);

		#endregion
	}

	[Guid("B3D3468E-BAFA-4566-856D-BFC6DD882A2B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IAnalysisApi))]
	[ProgId("PIWebAPIWrapper.AnalysisApi")]

	public class AnalysisApi : IAnalysisApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public AnalysisApi(Configuration configuration = null)
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

		/// <summary>Retrieve an Analysis by path.</summary>
		public PIAnalysis GetByPath(string path, string selectedFields = null)
		{
			ApiResponsePIAnalysis localVarResponse = GetByPathWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an Analysis by path.</summary>
		public ApiResponsePIAnalysis GetByPathWithHttpInfo(string path, string selectedFields = null)
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

			var localVarPath = "/analyses";
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

			return new ApiResponsePIAnalysis(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAnalysis)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAnalysis)));
		}

		/// <summary>Retrieve an Analysis.</summary>
		public PIAnalysis Get(string webId, string selectedFields = null)
		{
			ApiResponsePIAnalysis localVarResponse = GetWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an Analysis.</summary>
		public ApiResponsePIAnalysis GetWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/analyses/{webId}";
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

			return new ApiResponsePIAnalysis(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAnalysis)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAnalysis)));
		}

		/// <summary>Update an Analysis.</summary>
		public Object Update(string webId, PIAnalysis analysis)
		{
			ApiResponseObject localVarResponse = UpdateWithHttpInfo(webId, analysis);
			return localVarResponse.Data;
		}

		/// <summary>Update an Analysis.</summary>
		public ApiResponseObject UpdateWithHttpInfo(string webId, PIAnalysis analysis)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (analysis == null)
				throw new ApiException(400, "Missing required parameter 'analysis'");

			var localVarPath = "/analyses/{webId}";
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
			if (analysis != null && analysis.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(analysis);
			}
			else
			{
				localVarPostBody = analysis;
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

		/// <summary>Delete an Analysis.</summary>
		public Object Delete(string webId)
		{
			ApiResponseObject localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>Delete an Analysis.</summary>
		public ApiResponseObject DeleteWithHttpInfo(string webId)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/analyses/{webId}";
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

		/// <summary>Get an Analysis' categories.</summary>
		public PIItemsAnalysisCategory GetCategories(string webId, string selectedFields = null)
		{
			ApiResponsePIItemsAnalysisCategory localVarResponse = GetCategoriesWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Get an Analysis' categories.</summary>
		public ApiResponsePIItemsAnalysisCategory GetCategoriesWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/analyses/{webId}/categories";
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
				Exception exception = ExceptionFactory("GetCategories", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAnalysisCategory(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnalysisCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisCategory)));
		}

		/// <summary>Get the security information of the specified security item associated with the Analysis for a specified user.</summary>
		public PIItemsSecurityRights GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)
		{
			ApiResponsePIItemsSecurityRights localVarResponse = GetSecurityWithHttpInfo(webId, userIdentities, forceRefresh, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Get the security information of the specified security item associated with the Analysis for a specified user.</summary>
		public ApiResponsePIItemsSecurityRights GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)
		{
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

			var localVarPath = "/analyses/{webId}/security";
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

		/// <summary>Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.</summary>
		public PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)
		{
			ApiResponsePIItemsSecurityEntry localVarResponse = GetSecurityEntriesWithHttpInfo(webId, nameFilter, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.</summary>
		public ApiResponsePIItemsSecurityEntry GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/analyses/{webId}/securityentries";
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

		/// <summary>Create a security entry owned by the analysis.</summary>
		public Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren)
		{
			ApiResponseObject localVarResponse = CreateSecurityEntryWithHttpInfo(webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>Create a security entry owned by the analysis.</summary>
		public ApiResponseObject CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/analyses/{webId}/securityentries";
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

		/// <summary>Retrieve the security entry associated with the analysis with the specified name.</summary>
		public PISecurityEntry GetSecurityEntryByName(string name, string webId, string selectedFields = null)
		{
			ApiResponsePISecurityEntry localVarResponse = GetSecurityEntryByNameWithHttpInfo(name, webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve the security entry associated with the analysis with the specified name.</summary>
		public ApiResponsePISecurityEntry GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(name)==true)
			{
				name = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/analyses/{webId}/securityentries/{name}";
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

		/// <summary>Update a security entry owned by the analysis.</summary>
		public Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)
		{
			ApiResponseObject localVarResponse = UpdateSecurityEntryWithHttpInfo(name, webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>Update a security entry owned by the analysis.</summary>
		public ApiResponseObject UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)
		{
			if (string.IsNullOrEmpty(name)==true)
			{
				name = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/analyses/{webId}/securityentries/{name}";
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

		/// <summary>Delete a security entry owned by the analysis.</summary>
		public Object DeleteSecurityEntry(string name, string webId, bool applyToChildren)
		{
			ApiResponseObject localVarResponse = DeleteSecurityEntryWithHttpInfo(name, webId, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>Delete a security entry owned by the analysis.</summary>
		public ApiResponseObject DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren)
		{
			if (string.IsNullOrEmpty(name)==true)
			{
				name = null;
			}
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/analyses/{webId}/securityentries/{name}";
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

	}
}
