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

	[Guid("6A35DCEE-B87B-48AA-A248-F8F8AE59D005")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IDataServerApi
	{
		#region Synchronous Operations
		/// <summary>Retrieve a list of Data Servers known to this service.</summary>
		[DispId(1)]
		PIItemsDataServer List(string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve a list of Data Servers known to this service.</summary>
		[DispId(2)]
		ApiResponsePIItemsDataServer ListWithHttpInfo(string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve a Data Server by name.</summary>
		[DispId(3)]
		PIDataServer GetByName(string name, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve a Data Server by name.</summary>
		[DispId(4)]
		ApiResponsePIDataServer GetByNameWithHttpInfo(string name, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve a Data Server by path.</summary>
		[DispId(5)]
		PIDataServer GetByPath(string path, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve a Data Server by path.</summary>
		[DispId(6)]
		ApiResponsePIDataServer GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve a Data Server.</summary>
		[DispId(7)]
		PIDataServer Get(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve a Data Server.</summary>
		[DispId(8)]
		ApiResponsePIDataServer GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve enumeration sets for given Data Server.</summary>
		[DispId(9)]
		PIItemsEnumerationSet GetEnumerationSets(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve enumeration sets for given Data Server.</summary>
		[DispId(10)]
		ApiResponsePIItemsEnumerationSet GetEnumerationSetsWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>Create an enumeration set on the Data Server.</summary>
		[DispId(11)]
		Object CreateEnumerationSet(string webId, PIEnumerationSet enumerationSet, string webIdType = null);

		/// <summary>Create an enumeration set on the Data Server.</summary>
		[DispId(12)]
		ApiResponseObject CreateEnumerationSetWithHttpInfo(string webId, PIEnumerationSet enumerationSet, string webIdType = null);

		/// <summary>Retrieves the specified license for the given Data Server. The fields of the response object are string representations of the numerical values reported by the Data Server, with "Infinity" representing a license field with no limit.</summary>
		[DispId(13)]
		PIDataServerLicense GetLicense(string webId, string module, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieves the specified license for the given Data Server. The fields of the response object are string representations of the numerical values reported by the Data Server, with "Infinity" representing a license field with no limit.</summary>
		[DispId(14)]
		ApiResponsePIDataServerLicense GetLicenseWithHttpInfo(string webId, string module, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve a list of points on a specified Data Server.</summary>
		[DispId(15)]
		PIItemsPoint GetPoints(string webId, int maxCount, int startIndex, string nameFilter = null, string selectedFields = null, string webIdType = null);

		/// <summary>Retrieve a list of points on a specified Data Server.</summary>
		[DispId(16)]
		ApiResponsePIItemsPoint GetPointsWithHttpInfo(string webId, int maxCount, int startIndex, string nameFilter = null, string selectedFields = null, string webIdType = null);

		/// <summary>Create a point in the specified Data Server.</summary>
		[DispId(17)]
		Object CreatePoint(string webId, PIPoint pointDTO, string webIdType = null);

		/// <summary>Create a point in the specified Data Server.</summary>
		[DispId(18)]
		ApiResponseObject CreatePointWithHttpInfo(string webId, PIPoint pointDTO, string webIdType = null);

		#endregion
	}

	[Guid("8A465CDB-14FC-400B-BF87-9AB5AEE8D00A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IDataServerApi))]
	[ProgId("PIWebAPIWrapper.DataServerApi")]

	public class DataServerApi : IDataServerApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public DataServerApi(Configuration configuration = null)
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

		/// <summary>Retrieve a list of Data Servers known to this service.</summary>
		public PIItemsDataServer List(string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsDataServer localVarResponse = ListWithHttpInfo(selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a list of Data Servers known to this service.</summary>
		public ApiResponsePIItemsDataServer ListWithHttpInfo(string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(webIdType)==true)
			{
				webIdType = null;
			}

			var localVarPath = "/dataservers";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("List", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsDataServer(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsDataServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsDataServer)));
		}

		/// <summary>Retrieve a Data Server by name.</summary>
		public PIDataServer GetByName(string name, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIDataServer localVarResponse = GetByNameWithHttpInfo(name, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a Data Server by name.</summary>
		public ApiResponsePIDataServer GetByNameWithHttpInfo(string name, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(name)==true)
			{
				name = null;
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

			var localVarPath = "/dataservers";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByName", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIDataServer(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIDataServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIDataServer)));
		}

		/// <summary>Retrieve a Data Server by path.</summary>
		public PIDataServer GetByPath(string path, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIDataServer localVarResponse = GetByPathWithHttpInfo(path, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a Data Server by path.</summary>
		public ApiResponsePIDataServer GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/dataservers";
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

			return new ApiResponsePIDataServer(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIDataServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIDataServer)));
		}

		/// <summary>Retrieve a Data Server.</summary>
		public PIDataServer Get(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIDataServer localVarResponse = GetWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a Data Server.</summary>
		public ApiResponsePIDataServer GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/dataservers/{webId}";
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

			return new ApiResponsePIDataServer(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIDataServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIDataServer)));
		}

		/// <summary>Retrieve enumeration sets for given Data Server.</summary>
		public PIItemsEnumerationSet GetEnumerationSets(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsEnumerationSet localVarResponse = GetEnumerationSetsWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve enumeration sets for given Data Server.</summary>
		public ApiResponsePIItemsEnumerationSet GetEnumerationSetsWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/dataservers/{webId}/enumerationsets";
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
				Exception exception = ExceptionFactory("GetEnumerationSets", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsEnumerationSet(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsEnumerationSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsEnumerationSet)));
		}

		/// <summary>Create an enumeration set on the Data Server.</summary>
		public Object CreateEnumerationSet(string webId, PIEnumerationSet enumerationSet, string webIdType = null)
		{
			ApiResponseObject localVarResponse = CreateEnumerationSetWithHttpInfo(webId, enumerationSet, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Create an enumeration set on the Data Server.</summary>
		public ApiResponseObject CreateEnumerationSetWithHttpInfo(string webId, PIEnumerationSet enumerationSet, string webIdType = null)
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
			if (enumerationSet == null)
				throw new ApiException(400, "Missing required parameter 'enumerationSet'");

			var localVarPath = "/dataservers/{webId}/enumerationsets";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

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

		/// <summary>Retrieves the specified license for the given Data Server. The fields of the response object are string representations of the numerical values reported by the Data Server, with "Infinity" representing a license field with no limit.</summary>
		public PIDataServerLicense GetLicense(string webId, string module, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIDataServerLicense localVarResponse = GetLicenseWithHttpInfo(webId, module, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieves the specified license for the given Data Server. The fields of the response object are string representations of the numerical values reported by the Data Server, with "Infinity" representing a license field with no limit.</summary>
		public ApiResponsePIDataServerLicense GetLicenseWithHttpInfo(string webId, string module, string selectedFields = null, string webIdType = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(module)==true)
			{
				module = null;
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
			if (module == null)
				throw new ApiException(400, "Missing required parameter 'module'");

			var localVarPath = "/dataservers/{webId}/license";
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
			if (module!= null) localVarQueryParams.Add("module", Configuration.ApiClient.ParameterToString(module));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetLicense", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIDataServerLicense(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIDataServerLicense)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIDataServerLicense)));
		}

		/// <summary>Retrieve a list of points on a specified Data Server.</summary>
		public PIItemsPoint GetPoints(string webId, int maxCount, int startIndex, string nameFilter = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponsePIItemsPoint localVarResponse = GetPointsWithHttpInfo(webId, maxCount, startIndex, nameFilter, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Retrieve a list of points on a specified Data Server.</summary>
		public ApiResponsePIItemsPoint GetPointsWithHttpInfo(string webId, int maxCount, int startIndex, string nameFilter = null, string selectedFields = null, string webIdType = null)
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

			var localVarPath = "/dataservers/{webId}/points";
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
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("startIndex", Configuration.ApiClient.ParameterToString(startIndex));
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetPoints", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsPoint(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsPoint)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsPoint)));
		}

		/// <summary>Create a point in the specified Data Server.</summary>
		public Object CreatePoint(string webId, PIPoint pointDTO, string webIdType = null)
		{
			ApiResponseObject localVarResponse = CreatePointWithHttpInfo(webId, pointDTO, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>Create a point in the specified Data Server.</summary>
		public ApiResponseObject CreatePointWithHttpInfo(string webId, PIPoint pointDTO, string webIdType = null)
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
			if (pointDTO == null)
				throw new ApiException(400, "Missing required parameter 'pointDTO'");

			var localVarPath = "/dataservers/{webId}/points";
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
			if (webIdType!= null) localVarQueryParams.Add("webIdType", Configuration.ApiClient.ParameterToString(webIdType));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreatePoint", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

	}
}
