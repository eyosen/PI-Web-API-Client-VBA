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

	[Guid("6DCBDAFB-15E6-4291-BABB-9D68EE231383")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IStreamApi
	{
		#region Synchronous Operations
		/// <summary>Opens a channel that will send messages about any value changes for the specified stream.</summary>
		[DispId(1)]
		PIItemsStreamValues GetChannel(string webId, bool includeInitialValues);

		/// <summary>Opens a channel that will send messages about any value changes for the specified stream.</summary>
		[DispId(2)]
		ApiResponsePIItemsStreamValues GetChannelWithHttpInfo(string webId, bool includeInitialValues);

		/// <summary>Returns the end-of-stream value of the stream.</summary>
		[DispId(3)]
		PITimedValue GetEnd(string webId, string desiredUnits = null, string selectedFields = null);

		/// <summary>Returns the end-of-stream value of the stream.</summary>
		[DispId(4)]
		ApiResponsePITimedValue GetEndWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null);

		/// <summary>Retrieves interpolated values over the specified time range at the specified sampling interval.</summary>
		[DispId(5)]
		PITimedValues GetInterpolated(string webId, bool includeFilteredValues, string desiredUnits = null, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Retrieves interpolated values over the specified time range at the specified sampling interval.</summary>
		[DispId(6)]
		ApiResponsePITimedValues GetInterpolatedWithHttpInfo(string webId, bool includeFilteredValues, string desiredUnits = null, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Retrieves interpolated values over the specified time range at the specified sampling interval.</summary>
		[DispId(7)]
		PITimedValues GetInterpolatedAtTimes(string webId, bool includeFilteredValues, string desiredUnits = null, string filterExpression = null, string selectedFields = null, string sortOrder = null, string times = null, string timeZone = null);

		/// <summary>Retrieves interpolated values over the specified time range at the specified sampling interval.</summary>
		[DispId(8)]
		ApiResponsePITimedValues GetInterpolatedAtTimesWithHttpInfo(string webId, bool includeFilteredValues, string desiredUnits = null, string filterExpression = null, string selectedFields = null, string sortOrder = null, string times = null, string timeZone = null);

		/// <summary>Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		[DispId(9)]
		PITimedValues GetPlot(string webId, int intervals, string desiredUnits = null, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		[DispId(10)]
		ApiResponsePITimedValues GetPlotWithHttpInfo(string webId, int intervals, string desiredUnits = null, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Returns a list of compressed values for the requested time range from the source provider.</summary>
		[DispId(11)]
		PITimedValues GetRecorded(string webId, bool includeFilteredValues, int maxCount, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Returns a list of compressed values for the requested time range from the source provider.</summary>
		[DispId(12)]
		ApiResponsePITimedValues GetRecordedWithHttpInfo(string webId, bool includeFilteredValues, int maxCount, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Updates multiple values for the specified stream.</summary>
		[DispId(13)]
		PIItemsSubstatus UpdateValues(string webId, PIStreamValues values, string bufferOption = null, string updateOption = null);

		/// <summary>Updates multiple values for the specified stream.</summary>
		[DispId(14)]
		ApiResponsePIItemsSubstatus UpdateValuesWithHttpInfo(string webId, PIStreamValues values, string bufferOption = null, string updateOption = null);

		/// <summary>Returns a single recorded value based on the passed time and retrieval mode from the stream.</summary>
		[DispId(15)]
		PITimedValue GetRecordedAtTime(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null);

		/// <summary>Returns a single recorded value based on the passed time and retrieval mode from the stream.</summary>
		[DispId(16)]
		ApiResponsePITimedValue GetRecordedAtTimeWithHttpInfo(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null);

		/// <summary>Retrieves recorded values at the specified times.</summary>
		[DispId(17)]
		PITimedValues GetRecordedAtTimes(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string times = null, string timeZone = null);

		/// <summary>Retrieves recorded values at the specified times.</summary>
		[DispId(18)]
		ApiResponsePITimedValues GetRecordedAtTimesWithHttpInfo(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string times = null, string timeZone = null);

		/// <summary>Returns a summary over the specified time range for the stream.</summary>
		[DispId(19)]
		PIItemsSummaryValue GetSummary(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null);

		/// <summary>Returns a summary over the specified time range for the stream.</summary>
		[DispId(20)]
		ApiResponsePIItemsSummaryValue GetSummaryWithHttpInfo(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null);

		/// <summary>Returns the value of the stream at the specified time. By default, this is usually the current value.</summary>
		[DispId(21)]
		PITimedValue GetValue(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null);

		/// <summary>Returns the value of the stream at the specified time. By default, this is usually the current value.</summary>
		[DispId(22)]
		ApiResponsePITimedValue GetValueWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null);

		/// <summary>Updates a value for the specified stream.</summary>
		[DispId(23)]
		Object UpdateValue(string webId, PITimedValue value, string bufferOption = null, string updateOption = null);

		/// <summary>Updates a value for the specified stream.</summary>
		[DispId(24)]
		ApiResponseObject UpdateValueWithHttpInfo(string webId, PITimedValue value, string bufferOption = null, string updateOption = null);

		#endregion
	}

	[Guid("B09786DD-8019-4A5B-B671-993E1F64C969")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IStreamApi))]
	[ProgId("PIWebAPIWrapper.StreamApi")]

	public class StreamApi : IStreamApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public StreamApi(Configuration configuration = null)
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

		/// <summary>Opens a channel that will send messages about any value changes for the specified stream.</summary>
		public PIItemsStreamValues GetChannel(string webId, bool includeInitialValues)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetChannelWithHttpInfo(webId, includeInitialValues);
			return localVarResponse.Data;
		}

		/// <summary>Opens a channel that will send messages about any value changes for the specified stream.</summary>
		public ApiResponsePIItemsStreamValues GetChannelWithHttpInfo(string webId, bool includeInitialValues)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/channel";
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
			localVarQueryParams.Add("includeInitialValues", Configuration.ApiClient.ParameterToString(includeInitialValues));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetChannel", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns the end-of-stream value of the stream.</summary>
		public PITimedValue GetEnd(string webId, string desiredUnits = null, string selectedFields = null)
		{
			ApiResponsePITimedValue localVarResponse = GetEndWithHttpInfo(webId, desiredUnits, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Returns the end-of-stream value of the stream.</summary>
		public ApiResponsePITimedValue GetEndWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(desiredUnits)==true)
			{
				desiredUnits = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/end";
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
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEnd", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValue)));
		}

		/// <summary>Retrieves interpolated values over the specified time range at the specified sampling interval.</summary>
		public PITimedValues GetInterpolated(string webId, bool includeFilteredValues, string desiredUnits = null, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponsePITimedValues localVarResponse = GetInterpolatedWithHttpInfo(webId, includeFilteredValues, desiredUnits, endTime, filterExpression, interval, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Retrieves interpolated values over the specified time range at the specified sampling interval.</summary>
		public ApiResponsePITimedValues GetInterpolatedWithHttpInfo(string webId, bool includeFilteredValues, string desiredUnits = null, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(desiredUnits)==true)
			{
				desiredUnits = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(filterExpression)==true)
			{
				filterExpression = null;
			}
			if (string.IsNullOrEmpty(interval)==true)
			{
				interval = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/interpolated";
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
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (interval!= null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolated", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>Retrieves interpolated values over the specified time range at the specified sampling interval.</summary>
		public PITimedValues GetInterpolatedAtTimes(string webId, bool includeFilteredValues, string desiredUnits = null, string filterExpression = null, string selectedFields = null, string sortOrder = null, string times = null, string timeZone = null)
		{
			ApiResponsePITimedValues localVarResponse = GetInterpolatedAtTimesWithHttpInfo(webId, includeFilteredValues, desiredUnits, filterExpression, selectedFields, sortOrder, times, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Retrieves interpolated values over the specified time range at the specified sampling interval.</summary>
		public ApiResponsePITimedValues GetInterpolatedAtTimesWithHttpInfo(string webId, bool includeFilteredValues, string desiredUnits = null, string filterExpression = null, string selectedFields = null, string sortOrder = null, string times = null, string timeZone = null)
		{
			List<string> time = ExtensionMethods.ConvertToList(times);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(desiredUnits)==true)
			{
				desiredUnits = null;
			}
			if (string.IsNullOrEmpty(filterExpression)==true)
			{
				filterExpression = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/interpolatedattimes";
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
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAtTimes", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		public PITimedValues GetPlot(string webId, int intervals, string desiredUnits = null, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponsePITimedValues localVarResponse = GetPlotWithHttpInfo(webId, intervals, desiredUnits, endTime, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Retrieves values over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		public ApiResponsePITimedValues GetPlotWithHttpInfo(string webId, int intervals, string desiredUnits = null, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(desiredUnits)==true)
			{
				desiredUnits = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/plot";
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
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			localVarQueryParams.Add("intervals", Configuration.ApiClient.ParameterToString(intervals));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetPlot", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>Returns a list of compressed values for the requested time range from the source provider.</summary>
		public PITimedValues GetRecorded(string webId, bool includeFilteredValues, int maxCount, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponsePITimedValues localVarResponse = GetRecordedWithHttpInfo(webId, includeFilteredValues, maxCount, boundaryType, desiredUnits, endTime, filterExpression, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns a list of compressed values for the requested time range from the source provider.</summary>
		public ApiResponsePITimedValues GetRecordedWithHttpInfo(string webId, bool includeFilteredValues, int maxCount, string boundaryType = null, string desiredUnits = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(boundaryType)==true)
			{
				boundaryType = null;
			}
			if (string.IsNullOrEmpty(desiredUnits)==true)
			{
				desiredUnits = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(filterExpression)==true)
			{
				filterExpression = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/recorded";
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
			if (boundaryType!= null) localVarQueryParams.Add("boundaryType", Configuration.ApiClient.ParameterToString(boundaryType));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecorded", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>Updates multiple values for the specified stream.</summary>
		public PIItemsSubstatus UpdateValues(string webId, PIStreamValues values, string bufferOption = null, string updateOption = null)
		{
			ApiResponsePIItemsSubstatus localVarResponse = UpdateValuesWithHttpInfo(webId, values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>Updates multiple values for the specified stream.</summary>
		public ApiResponsePIItemsSubstatus UpdateValuesWithHttpInfo(string webId, PIStreamValues values, string bufferOption = null, string updateOption = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(bufferOption)==true)
			{
				bufferOption = null;
			}
			if (string.IsNullOrEmpty(updateOption)==true)
			{
				updateOption = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streams/{webId}/recorded";
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
			if (values != null && values.GetType() != typeof(byte[]))
			{
				localVarPostBody = Configuration.ApiClient.Serialize(values.Items);
			}
			else
			{
				localVarPostBody = values;
			}
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", Configuration.ApiClient.ParameterToString(bufferOption));
			if (updateOption!= null) localVarQueryParams.Add("updateOption", Configuration.ApiClient.ParameterToString(updateOption));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValues", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSubstatus(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSubstatus)));
		}

		/// <summary>Returns a single recorded value based on the passed time and retrieval mode from the stream.</summary>
		public PITimedValue GetRecordedAtTime(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null)
		{
			ApiResponsePITimedValue localVarResponse = GetRecordedAtTimeWithHttpInfo(webId, time, desiredUnits, retrievalMode, selectedFields, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns a single recorded value based on the passed time and retrieval mode from the stream.</summary>
		public ApiResponsePITimedValue GetRecordedAtTimeWithHttpInfo(string webId, string time, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string timeZone = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(time)==true)
			{
				time = null;
			}
			if (string.IsNullOrEmpty(desiredUnits)==true)
			{
				desiredUnits = null;
			}
			if (string.IsNullOrEmpty(retrievalMode)==true)
			{
				retrievalMode = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streams/{webId}/recordedattime";
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
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTime", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValue)));
		}

		/// <summary>Retrieves recorded values at the specified times.</summary>
		public PITimedValues GetRecordedAtTimes(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string times = null, string timeZone = null)
		{
			ApiResponsePITimedValues localVarResponse = GetRecordedAtTimesWithHttpInfo(webId, desiredUnits, retrievalMode, selectedFields, sortOrder, times, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Retrieves recorded values at the specified times.</summary>
		public ApiResponsePITimedValues GetRecordedAtTimesWithHttpInfo(string webId, string desiredUnits = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string times = null, string timeZone = null)
		{
			List<string> time = ExtensionMethods.ConvertToList(times);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(desiredUnits)==true)
			{
				desiredUnits = null;
			}
			if (string.IsNullOrEmpty(retrievalMode)==true)
			{
				retrievalMode = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/recordedattimes";
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
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimes", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePITimedValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PITimedValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PITimedValues)));
		}

		/// <summary>Returns a summary over the specified time range for the stream.</summary>
		public PIItemsSummaryValue GetSummary(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null)
		{
			ApiResponsePIItemsSummaryValue localVarResponse = GetSummaryWithHttpInfo(webId, calculationBasis, endTime, filterExpression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryTypes, timeType, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns a summary over the specified time range for the stream.</summary>
		public ApiResponsePIItemsSummaryValue GetSummaryWithHttpInfo(string webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null)
		{
			List<string> summaryType = ExtensionMethods.ConvertToList(summaryTypes);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(calculationBasis)==true)
			{
				calculationBasis = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(filterExpression)==true)
			{
				filterExpression = null;
			}
			if (string.IsNullOrEmpty(sampleInterval)==true)
			{
				sampleInterval = null;
			}
			if (string.IsNullOrEmpty(sampleType)==true)
			{
				sampleType = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(summaryDuration)==true)
			{
				summaryDuration = null;
			}
			if (string.IsNullOrEmpty(timeType)==true)
			{
				timeType = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/summary";
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
			if (calculationBasis!= null) localVarQueryParams.Add("calculationBasis", Configuration.ApiClient.ParameterToString(calculationBasis));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", Configuration.ApiClient.ParameterToString(sampleInterval));
			if (sampleType!= null) localVarQueryParams.Add("sampleType", Configuration.ApiClient.ParameterToString(sampleType));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", Configuration.ApiClient.ParameterToString(summaryDuration));
			localVarQueryParams.Add("summaryType", Configuration.ApiClient.ParameterToString(summaryType));
			if (timeType!= null) localVarQueryParams.Add("timeType", Configuration.ApiClient.ParameterToString(timeType));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummary", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSummaryValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSummaryValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSummaryValue)));
		}

		/// <summary>Returns the value of the stream at the specified time. By default, this is usually the current value.</summary>
		public PITimedValue GetValue(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null)
		{
			ApiResponsePITimedValue localVarResponse = GetValueWithHttpInfo(webId, desiredUnits, selectedFields, time, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns the value of the stream at the specified time. By default, this is usually the current value.</summary>
		public ApiResponsePITimedValue GetValueWithHttpInfo(string webId, string desiredUnits = null, string selectedFields = null, string time = null, string timeZone = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(desiredUnits)==true)
			{
				desiredUnits = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(time)==true)
			{
				time = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streams/{webId}/value";
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
			if (desiredUnits!= null) localVarQueryParams.Add("desiredUnits", Configuration.ApiClient.ParameterToString(desiredUnits));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

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

		/// <summary>Updates a value for the specified stream.</summary>
		public Object UpdateValue(string webId, PITimedValue value, string bufferOption = null, string updateOption = null)
		{
			ApiResponseObject localVarResponse = UpdateValueWithHttpInfo(webId, value, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>Updates a value for the specified stream.</summary>
		public ApiResponseObject UpdateValueWithHttpInfo(string webId, PITimedValue value, string bufferOption = null, string updateOption = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(bufferOption)==true)
			{
				bufferOption = null;
			}
			if (string.IsNullOrEmpty(updateOption)==true)
			{
				updateOption = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (value == null)
				throw new ApiException(400, "Missing required parameter 'value'");

			var localVarPath = "/streams/{webId}/value";
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
			if (bufferOption!= null) localVarQueryParams.Add("bufferOption", Configuration.ApiClient.ParameterToString(bufferOption));
			if (updateOption!= null) localVarQueryParams.Add("updateOption", Configuration.ApiClient.ParameterToString(updateOption));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateValue", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponseObject(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

	}
}
