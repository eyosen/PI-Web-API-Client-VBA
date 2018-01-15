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

	[Guid("00C01B95-F248-4DE7-98BF-2AFEE7ABA472")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IEnumerationValueApi
	{
		#region Synchronous Operations
		/// <summary>Retrieve an enumeration value by path.</summary>
		[DispId(1)]
		PIEnumerationValue GetByPath(string path, string selectedFields = null);

		/// <summary>Retrieve an enumeration value by path.</summary>
		[DispId(2)]
		ApiResponsePIEnumerationValue GetByPathWithHttpInfo(string path, string selectedFields = null);

		/// <summary>Retrieve an enumeration value mapping</summary>
		[DispId(3)]
		PIEnumerationValue Get(string webId, string selectedFields = null);

		/// <summary>Retrieve an enumeration value mapping</summary>
		[DispId(4)]
		ApiResponsePIEnumerationValue GetWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Update an enumeration value by replacing items in its definition.</summary>
		[DispId(5)]
		Object UpdateEnumerationValue(string webId, PIEnumerationValue enumerationValue);

		/// <summary>Update an enumeration value by replacing items in its definition.</summary>
		[DispId(6)]
		ApiResponseObject UpdateEnumerationValueWithHttpInfo(string webId, PIEnumerationValue enumerationValue);

		/// <summary>Delete an enumeration value from an enumeration set.</summary>
		[DispId(7)]
		Object DeleteEnumerationValue(string webId);

		/// <summary>Delete an enumeration value from an enumeration set.</summary>
		[DispId(8)]
		ApiResponseObject DeleteEnumerationValueWithHttpInfo(string webId);

		#endregion
	}

	[Guid("99C96C87-8784-4F68-B9BA-480CF7DFDD9D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IEnumerationValueApi))]
	[ProgId("PIWebAPIWrapper.EnumerationValueApi")]

	public class EnumerationValueApi : IEnumerationValueApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public EnumerationValueApi(Configuration configuration = null)
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

		/// <summary>Retrieve an enumeration value by path.</summary>
		public PIEnumerationValue GetByPath(string path, string selectedFields = null)
		{
			ApiResponsePIEnumerationValue localVarResponse = GetByPathWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an enumeration value by path.</summary>
		public ApiResponsePIEnumerationValue GetByPathWithHttpInfo(string path, string selectedFields = null)
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

			var localVarPath = "/enumerationvalues";
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

			return new ApiResponsePIEnumerationValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIEnumerationValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIEnumerationValue)));
		}

		/// <summary>Retrieve an enumeration value mapping</summary>
		public PIEnumerationValue Get(string webId, string selectedFields = null)
		{
			ApiResponsePIEnumerationValue localVarResponse = GetWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an enumeration value mapping</summary>
		public ApiResponsePIEnumerationValue GetWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/enumerationvalues/{webId}";
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

			return new ApiResponsePIEnumerationValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIEnumerationValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIEnumerationValue)));
		}

		/// <summary>Update an enumeration value by replacing items in its definition.</summary>
		public Object UpdateEnumerationValue(string webId, PIEnumerationValue enumerationValue)
		{
			ApiResponseObject localVarResponse = UpdateEnumerationValueWithHttpInfo(webId, enumerationValue);
			return localVarResponse.Data;
		}

		/// <summary>Update an enumeration value by replacing items in its definition.</summary>
		public ApiResponseObject UpdateEnumerationValueWithHttpInfo(string webId, PIEnumerationValue enumerationValue)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (enumerationValue == null)
				throw new ApiException(400, "Missing required parameter 'enumerationValue'");

			var localVarPath = "/enumerationvalues/{webId}";
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
			if (enumerationValue != null && enumerationValue.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(enumerationValue);
			}
			else
			{
				localVarPostBody = enumerationValue;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateEnumerationValue", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Delete an enumeration value from an enumeration set.</summary>
		public Object DeleteEnumerationValue(string webId)
		{
			ApiResponseObject localVarResponse = DeleteEnumerationValueWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>Delete an enumeration value from an enumeration set.</summary>
		public ApiResponseObject DeleteEnumerationValueWithHttpInfo(string webId)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/enumerationvalues/{webId}";
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
				Exception exception = ExceptionFactory("DeleteEnumerationValue", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

	}
}
