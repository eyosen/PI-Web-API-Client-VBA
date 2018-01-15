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

	[Guid("56B0BCF3-21BE-4994-8473-16F21528B677")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface ISystemApi
	{
		#region Synchronous Operations
		/// <summary>Get system links for this PI System Web API instance.</summary>
		[DispId(1)]
		PISystemLanding Landing();

		/// <summary>Get system links for this PI System Web API instance.</summary>
		[DispId(2)]
		ApiResponsePISystemLanding LandingWithHttpInfo();

		/// <summary>Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.</summary>
		[DispId(3)]
		PIItemsCacheInstance CacheInstances();

		/// <summary>Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.</summary>
		[DispId(4)]
		ApiResponsePIItemsCacheInstance CacheInstancesWithHttpInfo();

		/// <summary>Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.</summary>
		[DispId(5)]
		PISystemStatus Status();

		/// <summary>Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.</summary>
		[DispId(6)]
		ApiResponsePISystemStatus StatusWithHttpInfo();

		/// <summary>Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.</summary>
		[DispId(7)]
		PIUserInfo UserInfo();

		/// <summary>Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.</summary>
		[DispId(8)]
		ApiResponsePIUserInfo UserInfoWithHttpInfo();

		/// <summary>Get the current versions of the PI Web API instance and all external plugins.</summary>
		[DispId(9)]
		Object Versions();

		/// <summary>Get the current versions of the PI Web API instance and all external plugins.</summary>
		[DispId(10)]
		ApiResponseObject VersionsWithHttpInfo();

		#endregion
	}

	[Guid("CDB4F1ED-0FD5-4D3D-B2E6-E9693FE61358")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(ISystemApi))]
	[ProgId("PIWebAPIWrapper.SystemApi")]

	public class SystemApi : ISystemApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public SystemApi(Configuration configuration = null)
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

		/// <summary>Get system links for this PI System Web API instance.</summary>
		public PISystemLanding Landing()
		{
			ApiResponsePISystemLanding localVarResponse = LandingWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>Get system links for this PI System Web API instance.</summary>
		public ApiResponsePISystemLanding LandingWithHttpInfo()
		{

			var localVarPath = "/system";
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


			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Landing", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePISystemLanding(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PISystemLanding)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISystemLanding)));
		}

		/// <summary>Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.</summary>
		public PIItemsCacheInstance CacheInstances()
		{
			ApiResponsePIItemsCacheInstance localVarResponse = CacheInstancesWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.</summary>
		public ApiResponsePIItemsCacheInstance CacheInstancesWithHttpInfo()
		{

			var localVarPath = "/system/cacheinstances";
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


			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CacheInstances", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsCacheInstance(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsCacheInstance)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsCacheInstance)));
		}

		/// <summary>Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.</summary>
		public PISystemStatus Status()
		{
			ApiResponsePISystemStatus localVarResponse = StatusWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.</summary>
		public ApiResponsePISystemStatus StatusWithHttpInfo()
		{

			var localVarPath = "/system/status";
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


			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Status", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePISystemStatus(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PISystemStatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISystemStatus)));
		}

		/// <summary>Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.</summary>
		public PIUserInfo UserInfo()
		{
			ApiResponsePIUserInfo localVarResponse = UserInfoWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.</summary>
		public ApiResponsePIUserInfo UserInfoWithHttpInfo()
		{

			var localVarPath = "/system/userinfo";
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


			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UserInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIUserInfo(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIUserInfo)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIUserInfo)));
		}

		/// <summary>Get the current versions of the PI Web API instance and all external plugins.</summary>
		public Object Versions()
		{
			ApiResponseObject localVarResponse = VersionsWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>Get the current versions of the PI Web API instance and all external plugins.</summary>
		public ApiResponseObject VersionsWithHttpInfo()
		{

			var localVarPath = "/system/versions";
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


			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("Versions", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

	}
}
