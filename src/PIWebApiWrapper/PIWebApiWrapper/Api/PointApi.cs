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

	[Guid("C5183286-ED86-4829-9062-50E659574A3A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPointApi
	{
		#region Synchronous Operations
		/// <summary>Get a point by path.</summary>
		[DispId(1)]
		PIPoint GetByPath(string path, string selectedFields = null);

		/// <summary>Get a point by path.</summary>
		[DispId(2)]
		ApiResponsePIPoint GetByPathWithHttpInfo(string path, string selectedFields = null);

		/// <summary>Get a point.</summary>
		[DispId(3)]
		PIPoint Get(string webId, string selectedFields = null);

		/// <summary>Get a point.</summary>
		[DispId(4)]
		ApiResponsePIPoint GetWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Update a point.</summary>
		[DispId(5)]
		Object Update(string webId, PIPoint pointDTO);

		/// <summary>Update a point.</summary>
		[DispId(6)]
		ApiResponseObject UpdateWithHttpInfo(string webId, PIPoint pointDTO);

		/// <summary>Delete a point.</summary>
		[DispId(7)]
		Object Delete(string webId);

		/// <summary>Delete a point.</summary>
		[DispId(8)]
		ApiResponseObject DeleteWithHttpInfo(string webId);

		/// <summary>Get point attributes.</summary>
		[DispId(9)]
		PIItemsPointAttribute GetAttributes(string webId, string names = null, string nameFilter = null, string selectedFields = null);

		/// <summary>Get point attributes.</summary>
		[DispId(10)]
		ApiResponsePIItemsPointAttribute GetAttributesWithHttpInfo(string webId, string names = null, string nameFilter = null, string selectedFields = null);

		/// <summary>Get a point attribute by name.</summary>
		[DispId(11)]
		PIPointAttribute GetAttributeByName(string name, string webId, string selectedFields = null);

		/// <summary>Get a point attribute by name.</summary>
		[DispId(12)]
		ApiResponsePIPointAttribute GetAttributeByNameWithHttpInfo(string name, string webId, string selectedFields = null);

		/// <summary>Update a point attribute value.</summary>
		[DispId(13)]
		Object UpdateAttributeValue(string webId, string name, string value);

		/// <summary>Update a point attribute value.</summary>
		[DispId(14)]
		ApiResponseObject UpdateAttributeValueWithHttpInfo(string webId, string name, string value);

		/// <summary>Retrieve multiple points by web id or path.</summary>
		[DispId(15)]
		PIItemsItemPoint GetMultiple(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null);

		/// <summary>Retrieve multiple points by web id or path.</summary>
		[DispId(16)]
		ApiResponsePIItemsItemPoint GetMultipleWithHttpInfo(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null);

		#endregion
	}

	[Guid("63015201-FA25-4DD8-809B-477080FE9578")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPointApi))]
	[ProgId("PIWebAPIWrapper.PointApi")]

	public class PointApi : IPointApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public PointApi(Configuration configuration = null)
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

		/// <summary>Get a point by path.</summary>
		public PIPoint GetByPath(string path, string selectedFields = null)
		{
			ApiResponsePIPoint localVarResponse = GetByPathWithHttpInfo(path, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Get a point by path.</summary>
		public ApiResponsePIPoint GetByPathWithHttpInfo(string path, string selectedFields = null)
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

			var localVarPath = "/points";
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

			return new ApiResponsePIPoint(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIPoint)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIPoint)));
		}

		/// <summary>Get a point.</summary>
		public PIPoint Get(string webId, string selectedFields = null)
		{
			ApiResponsePIPoint localVarResponse = GetWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Get a point.</summary>
		public ApiResponsePIPoint GetWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/points/{webId}";
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

			return new ApiResponsePIPoint(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIPoint)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIPoint)));
		}

		/// <summary>Update a point.</summary>
		public Object Update(string webId, PIPoint pointDTO)
		{
			ApiResponseObject localVarResponse = UpdateWithHttpInfo(webId, pointDTO);
			return localVarResponse.Data;
		}

		/// <summary>Update a point.</summary>
		public ApiResponseObject UpdateWithHttpInfo(string webId, PIPoint pointDTO)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (pointDTO == null)
				throw new ApiException(400, "Missing required parameter 'pointDTO'");

			var localVarPath = "/points/{webId}";
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
			if (pointDTO != null && pointDTO.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(pointDTO);
			}
			else
			{
				localVarPostBody = pointDTO;
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

		/// <summary>Delete a point.</summary>
		public Object Delete(string webId)
		{
			ApiResponseObject localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>Delete a point.</summary>
		public ApiResponseObject DeleteWithHttpInfo(string webId)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/points/{webId}";
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

		/// <summary>Get point attributes.</summary>
		public PIItemsPointAttribute GetAttributes(string webId, string names = null, string nameFilter = null, string selectedFields = null)
		{
			ApiResponsePIItemsPointAttribute localVarResponse = GetAttributesWithHttpInfo(webId, names, nameFilter, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Get point attributes.</summary>
		public ApiResponsePIItemsPointAttribute GetAttributesWithHttpInfo(string webId, string names = null, string nameFilter = null, string selectedFields = null)
		{
			List<string> name = ExtensionMethods.ConvertToList(names);
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

			var localVarPath = "/points/{webId}/attributes";
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
			localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAttributes", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsPointAttribute(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsPointAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsPointAttribute)));
		}

		/// <summary>Get a point attribute by name.</summary>
		public PIPointAttribute GetAttributeByName(string name, string webId, string selectedFields = null)
		{
			ApiResponsePIPointAttribute localVarResponse = GetAttributeByNameWithHttpInfo(name, webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Get a point attribute by name.</summary>
		public ApiResponsePIPointAttribute GetAttributeByNameWithHttpInfo(string name, string webId, string selectedFields = null)
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

			var localVarPath = "/points/{webId}/attributes/{name}";
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
				Exception exception = ExceptionFactory("GetAttributeByName", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIPointAttribute(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIPointAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIPointAttribute)));
		}

		/// <summary>Update a point attribute value.</summary>
		public Object UpdateAttributeValue(string webId, string name, string value)
		{
			ApiResponseObject localVarResponse = UpdateAttributeValueWithHttpInfo(webId, name, value);
			return localVarResponse.Data;
		}

		/// <summary>Update a point attribute value.</summary>
		public ApiResponseObject UpdateAttributeValueWithHttpInfo(string webId, string name, string value)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(name)==true)
			{
				name = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			if (value == null)
				throw new ApiException(400, "Missing required parameter 'value'");

			var localVarPath = "/points/{webId}/attributes/{name}";
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
			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (value != null && value.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(value);
			}
			else
			{
				localVarPostBody = value;
			}

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateAttributeValue", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve multiple points by web id or path.</summary>
		public PIItemsItemPoint GetMultiple(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)
		{
			ApiResponsePIItemsItemPoint localVarResponse = GetMultipleWithHttpInfo(asParallel, includeMode, paths, selectedFields, webIds);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve multiple points by web id or path.</summary>
		public ApiResponsePIItemsItemPoint GetMultipleWithHttpInfo(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)
		{
			List<string> path = ExtensionMethods.ConvertToList(paths);
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
			if (string.IsNullOrEmpty(includeMode)==true)
			{
				includeMode = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}

			var localVarPath = "/points/multiple";
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

			localVarQueryParams.Add("asParallel", Configuration.ApiClient.ParameterToString(asParallel));
			if (includeMode!= null) localVarQueryParams.Add("includeMode", Configuration.ApiClient.ParameterToString(includeMode));
			localVarQueryParams.Add("path", Configuration.ApiClient.ParameterToString(path));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetMultiple", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsItemPoint(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsItemPoint)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemPoint)));
		}

	}
}
