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

	[Guid("2D9FF7EF-99AC-4A85-9A30-83AEE1A17D36")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IAnalysisRuleApi
	{
		#region Synchronous Operations
		/// <summary>Retrieve an Analysis Rule by path.</summary>
		[DispId(1)]
		PIAnalysisRule GetByPath(string path, string selectedFields = null);

		/// <summary>Retrieve an Analysis Rule by path.</summary>
		[DispId(2)]
		ApiResponsePIAnalysisRule GetByPathWithHttpInfo(string path, string selectedFields = null);

		/// <summary>Retrieve an Analysis Rule.</summary>
		[DispId(3)]
		PIAnalysisRule Get(string webId, string selectedFields = null);

		/// <summary>Retrieve an Analysis Rule.</summary>
		[DispId(4)]
		ApiResponsePIAnalysisRule GetWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Update an Analysis Rule by replacing items in its definition.</summary>
		[DispId(5)]
		Object Update(string webId, PIAnalysisRule analysisRule);

		/// <summary>Update an Analysis Rule by replacing items in its definition.</summary>
		[DispId(6)]
		ApiResponseObject UpdateWithHttpInfo(string webId, PIAnalysisRule analysisRule);

		/// <summary>Delete an Analysis Rule.</summary>
		[DispId(7)]
		Object Delete(string webId);

		/// <summary>Delete an Analysis Rule.</summary>
		[DispId(8)]
		ApiResponseObject DeleteWithHttpInfo(string webId);

		/// <summary>Get the child Analysis Rules of the Analysis Rule.</summary>
		[DispId(9)]
		PIItemsAnalysisRule GetAnalysisRules(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Get the child Analysis Rules of the Analysis Rule.</summary>
		[DispId(10)]
		ApiResponsePIItemsAnalysisRule GetAnalysisRulesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null);

		/// <summary>Create a new Analysis Rule as a child of an existing Analysis Rule.</summary>
		[DispId(11)]
		Object CreateAnalysisRule(string webId, PIAnalysisRule analysisRule);

		/// <summary>Create a new Analysis Rule as a child of an existing Analysis Rule.</summary>
		[DispId(12)]
		ApiResponseObject CreateAnalysisRuleWithHttpInfo(string webId, PIAnalysisRule analysisRule);

		#endregion
	}

	[Guid("20A0F5B6-9B19-46C6-8174-F4A56794C071")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IAnalysisRuleApi))]
	[ProgId("PIWebAPIWrapper.AnalysisRuleApi")]

	public class AnalysisRuleApi : IAnalysisRuleApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public AnalysisRuleApi(Configuration configuration = null)
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

		/// <summary>Retrieve an Analysis Rule by path.</summary>
		public PIAnalysisRule GetByPath(string path, string selectedFields = null)
		{
			ApiResponsePIAnalysisRule localVarResponse = GetByPathWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an Analysis Rule by path.</summary>
		public ApiResponsePIAnalysisRule GetByPathWithHttpInfo(string path, string selectedFields = null)
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

			var localVarPath = "/analysisrules";
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

			return new ApiResponsePIAnalysisRule(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAnalysisRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAnalysisRule)));
		}

		/// <summary>Retrieve an Analysis Rule.</summary>
		public PIAnalysisRule Get(string webId, string selectedFields = null)
		{
			ApiResponsePIAnalysisRule localVarResponse = GetWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an Analysis Rule.</summary>
		public ApiResponsePIAnalysisRule GetWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/analysisrules/{webId}";
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

			return new ApiResponsePIAnalysisRule(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAnalysisRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAnalysisRule)));
		}

		/// <summary>Update an Analysis Rule by replacing items in its definition.</summary>
		public Object Update(string webId, PIAnalysisRule analysisRule)
		{
			ApiResponseObject localVarResponse = UpdateWithHttpInfo(webId, analysisRule);
			return localVarResponse.Data;
		}

		/// <summary>Update an Analysis Rule by replacing items in its definition.</summary>
		public ApiResponseObject UpdateWithHttpInfo(string webId, PIAnalysisRule analysisRule)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (analysisRule == null)
				throw new ApiException(400, "Missing required parameter 'analysisRule'");

			var localVarPath = "/analysisrules/{webId}";
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
			if (analysisRule != null && analysisRule.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(analysisRule);
			}
			else
			{
				localVarPostBody = analysisRule;
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

		/// <summary>Delete an Analysis Rule.</summary>
		public Object Delete(string webId)
		{
			ApiResponseObject localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>Delete an Analysis Rule.</summary>
		public ApiResponseObject DeleteWithHttpInfo(string webId)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/analysisrules/{webId}";
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

		/// <summary>Get the child Analysis Rules of the Analysis Rule.</summary>
		public PIItemsAnalysisRule GetAnalysisRules(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null)
		{
			ApiResponsePIItemsAnalysisRule localVarResponse = GetAnalysisRulesWithHttpInfo(webId, maxCount, searchFullHierarchy, startIndex, nameFilter, selectedFields, sortField, sortOrder);
			return localVarResponse.Data;
		}

		/// <summary>Get the child Analysis Rules of the Analysis Rule.</summary>
		public ApiResponsePIItemsAnalysisRule GetAnalysisRulesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null)
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

			var localVarPath = "/analysisrules/{webId}/analysisrules";
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
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
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
				Exception exception = ExceptionFactory("GetAnalysisRules", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAnalysisRule(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAnalysisRule)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisRule)));
		}

		/// <summary>Create a new Analysis Rule as a child of an existing Analysis Rule.</summary>
		public Object CreateAnalysisRule(string webId, PIAnalysisRule analysisRule)
		{
			ApiResponseObject localVarResponse = CreateAnalysisRuleWithHttpInfo(webId, analysisRule);
			return localVarResponse.Data;
		}

		/// <summary>Create a new Analysis Rule as a child of an existing Analysis Rule.</summary>
		public ApiResponseObject CreateAnalysisRuleWithHttpInfo(string webId, PIAnalysisRule analysisRule)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (analysisRule == null)
				throw new ApiException(400, "Missing required parameter 'analysisRule'");

			var localVarPath = "/analysisrules/{webId}/analysisrules";
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
			if (analysisRule != null && analysisRule.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(analysisRule);
			}
			else
			{
				localVarPostBody = analysisRule;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAnalysisRule", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

	}
}
