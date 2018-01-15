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

	[Guid("F96DF7F8-339E-4091-8364-4C4A8CD2A13B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface ITimeRulePlugInApi
	{
		#region Synchronous Operations
		/// <summary>Retrieve a Time Rule Plug-in by path.</summary>
		[DispId(1)]
		PITimeRulePlugIn GetByPath(string path, string selectedFields = null);

		/// <summary>Retrieve a Time Rule Plug-in by path.</summary>
		[DispId(2)]
		ApiResponsePITimeRulePlugIn GetByPathWithHttpInfo(string path, string selectedFields = null);

		/// <summary>Retrieve a Time Rule Plug-in.</summary>
		[DispId(3)]
		PITimeRulePlugIn Get(string webId, string selectedFields = null);

		/// <summary>Retrieve a Time Rule Plug-in.</summary>
		[DispId(4)]
		ApiResponsePITimeRulePlugIn GetWithHttpInfo(string webId, string selectedFields = null);

		#endregion
	}

	[Guid("1ED3559B-39C4-470C-B9FA-B8982ADE363F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(ITimeRulePlugInApi))]
	[ProgId("PIWebAPIWrapper.TimeRulePlugInApi")]

	public class TimeRulePlugInApi : ITimeRulePlugInApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public TimeRulePlugInApi(Configuration configuration = null)
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

		/// <summary>Retrieve a Time Rule Plug-in by path.</summary>
		public PITimeRulePlugIn GetByPath(string path, string selectedFields = null)
		{
			ApiResponsePITimeRulePlugIn localVarResponse = GetByPathWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a Time Rule Plug-in by path.</summary>
		public ApiResponsePITimeRulePlugIn GetByPathWithHttpInfo(string path, string selectedFields = null)
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

			var localVarPath = "/timeruleplugins";
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

			return new ApiResponsePITimeRulePlugIn(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimeRulePlugIn)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimeRulePlugIn)));
		}

		/// <summary>Retrieve a Time Rule Plug-in.</summary>
		public PITimeRulePlugIn Get(string webId, string selectedFields = null)
		{
			ApiResponsePITimeRulePlugIn localVarResponse = GetWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a Time Rule Plug-in.</summary>
		public ApiResponsePITimeRulePlugIn GetWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/timeruleplugins/{webId}";
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

			return new ApiResponsePITimeRulePlugIn(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimeRulePlugIn)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimeRulePlugIn)));
		}

	}
}
