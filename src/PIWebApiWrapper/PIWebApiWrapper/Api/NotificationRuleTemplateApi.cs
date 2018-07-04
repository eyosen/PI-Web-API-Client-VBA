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

	[Guid("20108134-BD57-4657-91EA-C24DE661F5FC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface INotificationRuleTemplateApi
	{
		#region Synchronous Operations
		/// <summary>Get the specified notification rule template.</summary>
		[DispId(1)]
		PINotificationRuleTemplate Get(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Get the specified notification rule template.</summary>
		[DispId(2)]
		ApiResponsePINotificationRuleTemplate GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve notification rule template subscribers.</summary>
		[DispId(3)]
		PIItemsNotificationRuleSubscriber GetNotificationRuleTemplateSubscribers(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve notification rule template subscribers.</summary>
		[DispId(4)]
		ApiResponsePIItemsNotificationRuleSubscriber GetNotificationRuleTemplateSubscribersWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.</summary>
		[DispId(5)]
		PIItemsNotificationRuleTemplate GetNotificationRuleTemplatesQuery(int maxCount, int startIndex, string databaseWebId = null, string query = null, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.</summary>
		[DispId(6)]
		ApiResponsePIItemsNotificationRuleTemplate GetNotificationRuleTemplatesQueryWithHttpInfo(int maxCount, int startIndex, string databaseWebId = null, string query = null, string selectedFields = null, string webIdType = null);

		#endregion
	}

	[Guid("8EA3B408-30A3-440C-AE79-7A0E79783139")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(INotificationRuleTemplateApi))]
	[ProgId("PIWebAPIWrapper.NotificationRuleTemplateApi")]

	public class NotificationRuleTemplateApi : INotificationRuleTemplateApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public NotificationRuleTemplateApi(Configuration configuration = null)
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

		/// <summary>Get the specified notification rule template.</summary>
		public PINotificationRuleTemplate Get(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePINotificationRuleTemplate localVarResponse = GetWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get the specified notification rule template.</summary>
		public ApiResponsePINotificationRuleTemplate GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/notificationruletemplates/{webId}";
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

			return new ApiResponsePINotificationRuleTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PINotificationRuleTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PINotificationRuleTemplate)));
		}

		/// <summary>Retrieve notification rule template subscribers.</summary>
		public PIItemsNotificationRuleSubscriber GetNotificationRuleTemplateSubscribers(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsNotificationRuleSubscriber localVarResponse = GetNotificationRuleTemplateSubscribersWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve notification rule template subscribers.</summary>
		public ApiResponsePIItemsNotificationRuleSubscriber GetNotificationRuleTemplateSubscribersWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/notificationruletemplates/{webId}/notificationrulesubscribers";
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
				Exception exception = ExceptionFactory("GetNotificationRuleTemplateSubscribers", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsNotificationRuleSubscriber(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsNotificationRuleSubscriber)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsNotificationRuleSubscriber)));
		}

		/// <summary>Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.</summary>
		public PIItemsNotificationRuleTemplate GetNotificationRuleTemplatesQuery(int maxCount, int startIndex, string databaseWebId = null, string query = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsNotificationRuleTemplate localVarResponse = GetNotificationRuleTemplatesQueryWithHttpInfo(maxCount, startIndex, databaseWebId, query, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve Notification rule templates based on the specified conditions. Returns Notification rule templates using the specified search query string.</summary>
		public ApiResponsePIItemsNotificationRuleTemplate GetNotificationRuleTemplatesQueryWithHttpInfo(int maxCount, int startIndex, string databaseWebId = null, string query = null, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(databaseWebId)==true)
			{
				databaseWebId = null;
			}
			if (string.IsNullOrEmpty(query)==true)
			{
				query = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}

			var localVarPath = "/notificationruletemplates/search";
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

			if (databaseWebId!= null) localVarQueryParams.Add("databaseWebId", Configuration.ApiClient.ParameterToString(databaseWebId), false);
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount), false);
			if (query!= null) localVarQueryParams.Add("query", Configuration.ApiClient.ParameterToString(query), false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields), false);
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex), false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType), false);

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetNotificationRuleTemplatesQuery", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsNotificationRuleTemplate(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsNotificationRuleTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsNotificationRuleTemplate)));
		}

	}
}
