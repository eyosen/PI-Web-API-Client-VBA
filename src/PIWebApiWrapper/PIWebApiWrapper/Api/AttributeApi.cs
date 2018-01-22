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

	[Guid("E30367BB-B050-4C00-BAC7-B218B0A1C9B8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IAttributeApi
	{
		#region Synchronous Operations
		/// <summary>Retrieve an attribute by path.</summary>
		[DispId(1)]
		PIAttribute GetByPath(string path, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve an attribute by path.</summary>
		[DispId(2)]
		ApiResponsePIAttribute GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve an attribute.</summary>
		[DispId(3)]
		PIAttribute Get(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve an attribute.</summary>
		[DispId(4)]
		ApiResponsePIAttribute GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Update an attribute by replacing items in its definition.</summary>
		[DispId(5)]
		Object Update(string webId, PIAttribute attribute);

		/// <summary>Update an attribute by replacing items in its definition.</summary>
		[DispId(6)]
		ApiResponseObject UpdateWithHttpInfo(string webId, PIAttribute attribute);

		/// <summary>Delete an attribute.</summary>
		[DispId(7)]
		Object Delete(string webId);

		/// <summary>Delete an attribute.</summary>
		[DispId(8)]
		ApiResponseObject DeleteWithHttpInfo(string webId);

		/// <summary>Get the child attributes of the specified attribute.</summary>
		[DispId(9)]
		PIItemsAttribute GetAttributes(string webId, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, int startIndex, string categoryName = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null, string valueType = null, string webIdType = null);

		/// <summary>Get the child attributes of the specified attribute.</summary>
		[DispId(10)]
		ApiResponsePIItemsAttribute GetAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, int startIndex, string categoryName = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null, string valueType = null, string webIdType = null);

		/// <summary>Create a new attribute as a child of the specified attribute.</summary>
		[DispId(11)]
		Object CreateAttribute(string webId, PIAttribute attribute, string webIdType = null);

		/// <summary>Create a new attribute as a child of the specified attribute.</summary>
		[DispId(12)]
		ApiResponseObject CreateAttributeWithHttpInfo(string webId, PIAttribute attribute, string webIdType = null);

		/// <summary>Get an attribute's categories.</summary>
		[DispId(13)]
		PIItemsAttributeCategory GetCategories(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Get an attribute's categories.</summary>
		[DispId(14)]
		ApiResponsePIItemsAttributeCategory GetCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).</summary>
		[DispId(15)]
		Object CreateConfig(string webId, string webIdType = null);

		/// <summary>Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).</summary>
		[DispId(16)]
		ApiResponseObject CreateConfigWithHttpInfo(string webId, string webIdType = null);

		/// <summary>Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.</summary>
		[DispId(17)]
		PITimedValue GetValue(string webId, string selectedFields = null);

		/// <summary>Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.</summary>
		[DispId(18)]
		ApiResponsePITimedValue GetValueWithHttpInfo(string webId, string selectedFields = null);

		/// <summary>Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.</summary>
		[DispId(19)]
		Object SetValue(string webId, PITimedValue value);

		/// <summary>Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.</summary>
		[DispId(20)]
		ApiResponseObject SetValueWithHttpInfo(string webId, PITimedValue value);

		/// <summary>Retrieve multiple attributes by web id or path.</summary>
		[DispId(21)]
		PIItemsItemAttribute GetMultiple(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null, string webIdType = null);

		/// <summary>Retrieve multiple attributes by web id or path.</summary>
		[DispId(22)]
		ApiResponsePIItemsItemAttribute GetMultipleWithHttpInfo(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null, string webIdType = null);

		/// <summary>Retrieve attributes based on the specified conditions. Returns attributes using the specified search query string.</summary>
		[DispId(23)]
		PIItemsAttribute GetAttributesQuery(int maxCount, int startIndex, string databaseWebId = null, string query = null, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve attributes based on the specified conditions. Returns attributes using the specified search query string.</summary>
		[DispId(24)]
		ApiResponsePIItemsAttribute GetAttributesQueryWithHttpInfo(int maxCount, int startIndex, string databaseWebId = null, string query = null, string selectedFields = null, string webIdType = null);

		#endregion
	}

	[Guid("F60254FF-B700-4B00-83E1-53542AC9A402")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IAttributeApi))]
	[ProgId("PIWebAPIWrapper.AttributeApi")]

	public class AttributeApi : IAttributeApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public AttributeApi(Configuration configuration = null)
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

		/// <summary>Retrieve an attribute by path.</summary>
		public PIAttribute GetByPath(string path, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIAttribute localVarResponse = GetByPathWithHttpInfo(path, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an attribute by path.</summary>
		public ApiResponsePIAttribute GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/attributes";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPath", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIAttribute(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAttribute)));
		}

		/// <summary>Retrieve an attribute.</summary>
		public PIAttribute Get(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIAttribute localVarResponse = GetWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve an attribute.</summary>
		public ApiResponsePIAttribute GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/attributes/{webId}";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Get", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIAttribute(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAttribute)));
		}

		/// <summary>Update an attribute by replacing items in its definition.</summary>
		public Object Update(string webId, PIAttribute attribute)
		{
			ApiResponseObject localVarResponse = UpdateWithHttpInfo(webId, attribute);
			return localVarResponse.Data;
		}

		/// <summary>Update an attribute by replacing items in its definition.</summary>
		public ApiResponseObject UpdateWithHttpInfo(string webId, PIAttribute attribute)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (attribute == null)
				throw new ApiException(400, "Missing required parameter 'attribute'");

			var localVarPath = "/attributes/{webId}";
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
			if (attribute != null && attribute.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(attribute);
			}
			else
			{
				localVarPostBody = attribute;
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

		/// <summary>Delete an attribute.</summary>
		public Object Delete(string webId)
		{
			ApiResponseObject localVarResponse = DeleteWithHttpInfo(webId);
			return localVarResponse.Data;
		}

		/// <summary>Delete an attribute.</summary>
		public ApiResponseObject DeleteWithHttpInfo(string webId)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/attributes/{webId}";
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

		/// <summary>Get the child attributes of the specified attribute.</summary>
		public PIItemsAttribute GetAttributes(string webId, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, int startIndex, string categoryName = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null, string valueType = null, string webIdType = null)
		{
			ApiResponsePIItemsAttribute localVarResponse = GetAttributesWithHttpInfo(webId, maxCount, searchFullHierarchy, showExcluded, showHidden, startIndex, categoryName, nameFilter, selectedFields, sortField, sortOrder, templateName, valueType, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get the child attributes of the specified attribute.</summary>
		public ApiResponsePIItemsAttribute GetAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, int startIndex, string categoryName = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null, string valueType = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
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
			if (string.IsNullOrEmpty(valueType)==true)
			{
				valueType = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/attributes/{webId}/attributes";
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
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (sortField!= null) localVarQueryParams.Add("sortField", Configuration.ApiClient.ParameterToString(sortField));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
			if (valueType!= null) localVarQueryParams.Add("valueType", Configuration.ApiClient.ParameterToString(valueType));
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAttributes", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAttribute(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

		/// <summary>Create a new attribute as a child of the specified attribute.</summary>
		public Object CreateAttribute(string webId, PIAttribute attribute, string webIdType = null)
		{
			ApiResponseObject localVarResponse = CreateAttributeWithHttpInfo(webId, attribute, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Create a new attribute as a child of the specified attribute.</summary>
		public ApiResponseObject CreateAttributeWithHttpInfo(string webId, PIAttribute attribute, string webIdType = null)
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
			if (attribute == null)
				throw new ApiException(400, "Missing required parameter 'attribute'");

			var localVarPath = "/attributes/{webId}/attributes";
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
			if (attribute != null && attribute.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(attribute);
			}
			else
			{
				localVarPostBody = attribute;
			}
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAttribute", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Get an attribute's categories.</summary>
		public PIItemsAttributeCategory GetCategories(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsAttributeCategory localVarResponse = GetCategoriesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Get an attribute's categories.</summary>
		public ApiResponsePIItemsAttributeCategory GetCategoriesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/attributes/{webId}/categories";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetCategories", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAttributeCategory(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttributeCategory)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttributeCategory)));
		}

		/// <summary>Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).</summary>
		public Object CreateConfig(string webId, string webIdType = null)
		{
			ApiResponseObject localVarResponse = CreateConfigWithHttpInfo(webId, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).</summary>
		public ApiResponseObject CreateConfigWithHttpInfo(string webId, string webIdType = null)
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

			var localVarPath = "/attributes/{webId}/config";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateConfig", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.</summary>
		public PITimedValue GetValue(string webId, string selectedFields = null)
		{
			ApiResponsePITimedValue localVarResponse = GetValueWithHttpInfo(webId, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.</summary>
		public ApiResponsePITimedValue GetValueWithHttpInfo(string webId, string selectedFields = null)
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

			var localVarPath = "/attributes/{webId}/value";
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
				Exception exception = ExceptionFactory("GetValue", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValue)));
		}

		/// <summary>Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.</summary>
		public Object SetValue(string webId, PITimedValue value)
		{
			ApiResponseObject localVarResponse = SetValueWithHttpInfo(webId, value);
			return localVarResponse.Data;
		}

		/// <summary>Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.</summary>
		public ApiResponseObject SetValueWithHttpInfo(string webId, PITimedValue value)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (value == null)
				throw new ApiException(400, "Missing required parameter 'value'");

			var localVarPath = "/attributes/{webId}/value";
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
				Exception exception = ExceptionFactory("SetValue", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>Retrieve multiple attributes by web id or path.</summary>
		public PIItemsItemAttribute GetMultiple(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null, string webIdType = null)
		{
			ApiResponsePIItemsItemAttribute localVarResponse = GetMultipleWithHttpInfo(asParallel, includeMode, paths, selectedFields, webIds, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve multiple attributes by web id or path.</summary>
		public ApiResponsePIItemsItemAttribute GetMultipleWithHttpInfo(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null, string webIdType = null)
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
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}

			var localVarPath = "/attributes/multiple";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetMultiple", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsItemAttribute(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsItemAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemAttribute)));
		}

		/// <summary>Retrieve attributes based on the specified conditions. Returns attributes using the specified search query string.</summary>
		public PIItemsAttribute GetAttributesQuery(int maxCount, int startIndex, string databaseWebId = null, string query = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsAttribute localVarResponse = GetAttributesQueryWithHttpInfo(maxCount, startIndex, databaseWebId, query, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve attributes based on the specified conditions. Returns attributes using the specified search query string.</summary>
		public ApiResponsePIItemsAttribute GetAttributesQueryWithHttpInfo(int maxCount, int startIndex, string databaseWebId = null, string query = null, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/attributes/search";
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

			if (databaseWebId!= null) localVarQueryParams.Add("databaseWebId", Configuration.ApiClient.ParameterToString(databaseWebId));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (query!= null) localVarQueryParams.Add("query", Configuration.ApiClient.ParameterToString(query));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAttributesQuery", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsAttribute(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsAttribute)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttribute)));
		}

	}
}
