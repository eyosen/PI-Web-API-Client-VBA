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

	[Guid("330A45BF-32B6-4B84-91B2-94C83CBE92F1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IElementTemplateApi
	{
		#region Synchronous Operations
		/// <summary>Retrieve an element template by path.</summary>
		[DispId(1)]
		PIElementTemplate GetByPath(string path, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve an element template by path.</summary>
		[DispId(2)]
		ApiResponsePIElementTemplate GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve an element template.</summary>
		[DispId(3)]
		PIElementTemplate Get(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve an element template.</summary>
		[DispId(4)]
		ApiResponsePIElementTemplate GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Update an element template by replacing items in its definition.</summary>
		[DispId(5)]
		Object Update(string webId, PIElementTemplate template);

		/// <summary>Update an element template by replacing items in its definition.</summary>
		[DispId(6)]
		ApiResponseObject UpdateWithHttpInfo(string webId, PIElementTemplate template);

		/// <summary>Delete an element template.</summary>
		[DispId(7)]
		Object Delete(string webId);

		/// <summary>Delete an element template.</summary>
		[DispId(8)]
		ApiResponseObject DeleteWithHttpInfo(string webId);

		/// <summary>Get analysis templates for an element template.</summary>
		[DispId(9)]
		PIItemsAnalysisTemplate GetAnalysisTemplates(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Get analysis templates for an element template.</summary>
		[DispId(10)]
		ApiResponsePIItemsAnalysisTemplate GetAnalysisTemplatesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Get child attribute templates for an element template.</summary>
		[DispId(11)]
		PIItemsAttributeTemplate GetAttributeTemplates(string webId, bool depthFirstTraverse, int maxCount, bool showDescendants, bool showInherited, int startIndex, string selectedFields = null, string webIdType = null);

		/// <summary>Get child attribute templates for an element template.</summary>
		[DispId(12)]
		ApiResponsePIItemsAttributeTemplate GetAttributeTemplatesWithHttpInfo(string webId, bool depthFirstTraverse, int maxCount, bool showDescendants, bool showInherited, int startIndex, string selectedFields = null, string webIdType = null);

		/// <summary>Create an attribute template.</summary>
		[DispId(13)]
		Object CreateAttributeTemplate(string webId, PIAttributeTemplate template, string webIdType = null);

		/// <summary>Create an attribute template.</summary>
		[DispId(14)]
		ApiResponseObject CreateAttributeTemplateWithHttpInfo(string webId, PIAttributeTemplate template, string webIdType = null);

		/// <summary>Get base element templates for an element template.</summary>
		[DispId(15)]
		PIItemsElementTemplate GetBaseElementTemplates(string webId, int maxCount, string selectedFields = null, string webIdType = null);

		/// <summary>Get base element templates for an element template.</summary>
		[DispId(16)]
		ApiResponsePIItemsElementTemplate GetBaseElementTemplatesWithHttpInfo(string webId, int maxCount, string selectedFields = null, string webIdType = null);

		/// <summary>Get an element template's categories.</summary>
		[DispId(17)]
		PIItemsElementCategory GetCategories(string webId, bool showInherited, string selectedFields = null, string webIdType = null);

		/// <summary>Get an element template's categories.</summary>
		[DispId(18)]
		ApiResponsePIItemsElementCategory GetCategoriesWithHttpInfo(string webId, bool showInherited, string selectedFields = null, string webIdType = null);

		/// <summary>Get derived element templates for an element template.</summary>
		[DispId(19)]
		PIItemsElementTemplate GetDerivedElementTemplates(string webId, int maxCount, bool showDescendants, string selectedFields = null, string webIdType = null);

		/// <summary>Get derived element templates for an element template.</summary>
		[DispId(20)]
		ApiResponsePIItemsElementTemplate GetDerivedElementTemplatesWithHttpInfo(string webId, int maxCount, bool showDescendants, string selectedFields = null, string webIdType = null);

		/// <summary>Get notification rule templates for an element template</summary>
		[DispId(21)]
		PIItemsNotificationRuleTemplate GetNotificationRuleTemplates(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Get notification rule templates for an element template</summary>
		[DispId(22)]
		ApiResponsePIItemsNotificationRuleTemplate GetNotificationRuleTemplatesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Get the security information of the specified security item associated with the element template for a specified user.</summary>
		[DispId(23)]
		PIItemsSecurityRights GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null, string webIdType = null);

		/// <summary>Get the security information of the specified security item associated with the element template for a specified user.</summary>
		[DispId(24)]
		ApiResponsePIItemsSecurityRights GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve the security entries associated with the element template based on the specified criteria. By default, all security entries for this element template are returned.</summary>
		[DispId(25)]
		PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve the security entries associated with the element template based on the specified criteria. By default, all security entries for this element template are returned.</summary>
		[DispId(26)]
		ApiResponsePIItemsSecurityEntry GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null, string webIdType = null);

		/// <summary>Create a security entry owned by the element template.</summary>
		[DispId(27)]
		Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren, string webIdType = null);

		/// <summary>Create a security entry owned by the element template.</summary>
		[DispId(28)]
		ApiResponseObject CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren, string webIdType = null);

		/// <summary>Retrieve the security entry associated with the element template with the specified name.</summary>
		[DispId(29)]
		PIItemsSecurityEntry GetSecurityEntryByName(string name, string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve the security entry associated with the element template with the specified name.</summary>
		[DispId(30)]
		ApiResponsePIItemsSecurityEntry GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Update a security entry owned by the element template.</summary>
		[DispId(31)]
		Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren);

		/// <summary>Update a security entry owned by the element template.</summary>
		[DispId(32)]
		ApiResponseObject UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren);

		/// <summary>Delete a security entry owned by the element template.</summary>
		[DispId(33)]
		Object DeleteSecurityEntry(string name, string webId, bool applyToChildren);

		/// <summary>Delete a security entry owned by the element template.</summary>
		[DispId(34)]
		ApiResponseObject DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren);

		#endregion
	}

	[Guid("F911B1E5-9F20-4F07-8ECF-D81928168DAF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IElementTemplateApi))]
	[ProgId("PIWebAPIWrapper.ElementTemplateApi")]

	public class ElementTemplateApi : IElementTemplateApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public ElementTemplateApi(Configuration configuration = null)
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

		/// <summary>Retrieve an element template by path.</summary>
		public PIElementTemplate GetByPath(string path, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIElementTemplate localVarResponse = GetByPathWithHttpInfo(path, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an element template by path.</summary>
		public ApiResponsePIElementTemplate GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(path)==true)
			{
				path = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/elementtemplates";
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

			if (path!= null) localVarQueryParams.Add("path", Configuration.ApiClient.ParameterToString(path), false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPath", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIElementTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIElementTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIElementTemplate)));
		}

		/// <summary>Retrieve an element template.</summary>
		public PIElementTemplate Get(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIElementTemplate localVarResponse = GetWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an element template.</summary>
		public ApiResponsePIElementTemplate GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Get", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIElementTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIElementTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIElementTemplate)));
		}

		/// <summary>Update an element template by replacing items in its definition.</summary>
		public Object Update(string webId, PIElementTemplate template)
		{
			ApiResponseObject localVarResponse = UpdateWithHttpInfo(webId, template);
			return localVarResponse.Data;
		}

		/// <summary>Update an element template by replacing items in its definition.</summary>
		public ApiResponseObject UpdateWithHttpInfo(string webId, PIElementTemplate template)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (template == null)
				throw new ApiException(400, "Missing required parameter 'template'");

			var localVarPath = "/elementtemplates/{webId}";
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

		/// <summary>Delete an element template.</summary>
		public Object Delete(string webId)
		{
			ApiResponseObject localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>Delete an element template.</summary>
		public ApiResponseObject DeleteWithHttpInfo(string webId)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}";
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

		/// <summary>Get analysis templates for an element template.</summary>
		public PIItemsAnalysisTemplate GetAnalysisTemplates(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsAnalysisTemplate localVarResponse = GetAnalysisTemplatesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get analysis templates for an element template.</summary>
		public ApiResponsePIItemsAnalysisTemplate GetAnalysisTemplatesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}/analysistemplates";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

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

		/// <summary>Get child attribute templates for an element template.</summary>
		public PIItemsAttributeTemplate GetAttributeTemplates(string webId, bool depthFirstTraverse, int maxCount, bool showDescendants, bool showInherited, int startIndex, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsAttributeTemplate localVarResponse = GetAttributeTemplatesWithHttpInfo(webId, depthFirstTraverse, maxCount, showDescendants, showInherited, startIndex, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get child attribute templates for an element template.</summary>
		public ApiResponsePIItemsAttributeTemplate GetAttributeTemplatesWithHttpInfo(string webId, bool depthFirstTraverse, int maxCount, bool showDescendants, bool showInherited, int startIndex, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}/attributetemplates";
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
			localVarQueryParams.Add("depthFirstTraverse", Configuration.ApiClient.ParameterToString(depthFirstTraverse), false);
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount), false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			localVarQueryParams.Add("showDescendants", Configuration.ApiClient.ParameterToString(showDescendants), false);
			localVarQueryParams.Add("showInherited", Configuration.ApiClient.ParameterToString(showInherited), false);
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAttributeTemplates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAttributeTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttributeTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttributeTemplate)));
		}

		/// <summary>Create an attribute template.</summary>
		public Object CreateAttributeTemplate(string webId, PIAttributeTemplate template, string webIdType = null)
		{
			ApiResponseObject localVarResponse = CreateAttributeTemplateWithHttpInfo(webId, template, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Create an attribute template.</summary>
		public ApiResponseObject CreateAttributeTemplateWithHttpInfo(string webId, PIAttributeTemplate template, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (template == null)
				throw new ApiException(400, "Missing required parameter 'template'");

			var localVarPath = "/elementtemplates/{webId}/attributetemplates";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAttributeTemplate", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Get base element templates for an element template.</summary>
		public PIItemsElementTemplate GetBaseElementTemplates(string webId, int maxCount, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsElementTemplate localVarResponse = GetBaseElementTemplatesWithHttpInfo(webId, maxCount, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get base element templates for an element template.</summary>
		public ApiResponsePIItemsElementTemplate GetBaseElementTemplatesWithHttpInfo(string webId, int maxCount, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}/baseelementtemplates";
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
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount), false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetBaseElementTemplates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsElementTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElementTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementTemplate)));
		}

		/// <summary>Get an element template's categories.</summary>
		public PIItemsElementCategory GetCategories(string webId, bool showInherited, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsElementCategory localVarResponse = GetCategoriesWithHttpInfo(webId, showInherited, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get an element template's categories.</summary>
		public ApiResponsePIItemsElementCategory GetCategoriesWithHttpInfo(string webId, bool showInherited, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}/categories";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			localVarQueryParams.Add("showInherited", Configuration.ApiClient.ParameterToString(showInherited), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetCategories", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsElementCategory(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElementCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementCategory)));
		}

		/// <summary>Get derived element templates for an element template.</summary>
		public PIItemsElementTemplate GetDerivedElementTemplates(string webId, int maxCount, bool showDescendants, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsElementTemplate localVarResponse = GetDerivedElementTemplatesWithHttpInfo(webId, maxCount, showDescendants, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get derived element templates for an element template.</summary>
		public ApiResponsePIItemsElementTemplate GetDerivedElementTemplatesWithHttpInfo(string webId, int maxCount, bool showDescendants, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}/derivedelementtemplates";
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
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount), false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			localVarQueryParams.Add("showDescendants", Configuration.ApiClient.ParameterToString(showDescendants), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetDerivedElementTemplates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsElementTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsElementTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsElementTemplate)));
		}

		/// <summary>Get notification rule templates for an element template</summary>
		public PIItemsNotificationRuleTemplate GetNotificationRuleTemplates(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsNotificationRuleTemplate localVarResponse = GetNotificationRuleTemplatesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get notification rule templates for an element template</summary>
		public ApiResponsePIItemsNotificationRuleTemplate GetNotificationRuleTemplatesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}/notificationruletemplates";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetNotificationRuleTemplates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsNotificationRuleTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsNotificationRuleTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsNotificationRuleTemplate)));
		}

		/// <summary>Get the security information of the specified security item associated with the element template for a specified user.</summary>
		public PIItemsSecurityRights GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsSecurityRights localVarResponse = GetSecurityWithHttpInfo(webId, userIdentities, forceRefresh, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get the security information of the specified security item associated with the element template for a specified user.</summary>
		public ApiResponsePIItemsSecurityRights GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null, string webIdType = null)
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
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}/security";
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
			localVarQueryParams.Add("userIdentity", Configuration.ApiClient.ParameterToString(userIdentity), true);
			localVarQueryParams.Add("forceRefresh", Configuration.ApiClient.ParameterToString(forceRefresh), false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

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

		/// <summary>Retrieve the security entries associated with the element template based on the specified criteria. By default, all security entries for this element template are returned.</summary>
		public PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsSecurityEntry localVarResponse = GetSecurityEntriesWithHttpInfo(webId, nameFilter, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve the security entries associated with the element template based on the specified criteria. By default, all security entries for this element template are returned.</summary>
		public ApiResponsePIItemsSecurityEntry GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null, string webIdType = null)
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
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}/securityentries";
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
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter), false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

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

		/// <summary>Create a security entry owned by the element template.</summary>
		public Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren, string webIdType = null)
		{
			ApiResponseObject localVarResponse = CreateSecurityEntryWithHttpInfo(webId, securityEntry, applyToChildren, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Create a security entry owned by the element template.</summary>
		public ApiResponseObject CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/elementtemplates/{webId}/securityentries";
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
			localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

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

		/// <summary>Retrieve the security entry associated with the element template with the specified name.</summary>
		public PIItemsSecurityEntry GetSecurityEntryByName(string name, string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsSecurityEntry localVarResponse = GetSecurityEntryByNameWithHttpInfo(name, webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve the security entry associated with the element template with the specified name.</summary>
		public ApiResponsePIItemsSecurityEntry GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null, string webIdType = null)
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
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/elementtemplates/{webId}/securityentries/{name}";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntryByName", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSecurityEntry(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityEntry)));
		}

		/// <summary>Update a security entry owned by the element template.</summary>
		public Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)
		{
			ApiResponseObject localVarResponse = UpdateSecurityEntryWithHttpInfo(name, webId, securityEntry, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>Update a security entry owned by the element template.</summary>
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

			var localVarPath = "/elementtemplates/{webId}/securityentries/{name}";
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
			localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren), false);

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

		/// <summary>Delete a security entry owned by the element template.</summary>
		public Object DeleteSecurityEntry(string name, string webId, bool applyToChildren)
		{
			ApiResponseObject localVarResponse = DeleteSecurityEntryWithHttpInfo(name, webId, applyToChildren);
			return localVarResponse.Data;
		}

		/// <summary>Delete a security entry owned by the element template.</summary>
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

			var localVarPath = "/elementtemplates/{webId}/securityentries/{name}";
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
			localVarQueryParams.Add("applyToChildren", Configuration.ApiClient.ParameterToString(applyToChildren), false);

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
