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

	[Guid("C1491A71-ABBE-40D0-8FF8-88EC0DEE1463")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IStreamSetApi
	{
		#region Synchronous Operations
		/// <summary>Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.</summary>
		[DispId(1)]
		PIItemsStreamValue GetChannel(string webId, bool includeInitialValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string templateName = null);

		/// <summary>Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.</summary>
		[DispId(2)]
		ApiResponsePIItemsStreamValue GetChannelWithHttpInfo(string webId, bool includeInitialValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string templateName = null);

		/// <summary>Returns End of stream values of the attributes for an Element, Event Frame or Attribute</summary>
		[DispId(3)]
		PIItemsStreamValue GetEnd(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null);

		/// <summary>Returns End of stream values of the attributes for an Element, Event Frame or Attribute</summary>
		[DispId(4)]
		ApiResponsePIItemsStreamValue GetEndWithHttpInfo(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null);

		/// <summary>Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.</summary>
		[DispId(5)]
		PIItemsStreamValues GetInterpolated(string webId, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string filterExpression = null, string interval = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null);

		/// <summary>Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.</summary>
		[DispId(6)]
		ApiResponsePIItemsStreamValues GetInterpolatedWithHttpInfo(string webId, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string filterExpression = null, string interval = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null);

		/// <summary>Returns interpolated values of attributes for an element, event frame or attribute at the specified times.</summary>
		[DispId(7)]
		PIItemsStreamValues GetInterpolatedAtTimes(string webId, string times, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null);

		/// <summary>Returns interpolated values of attributes for an element, event frame or attribute at the specified times.</summary>
		[DispId(8)]
		ApiResponsePIItemsStreamValues GetInterpolatedAtTimesWithHttpInfo(string webId, string times, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null);

		/// <summary>Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		[DispId(9)]
		PIItemsStreamValues GetPlot(string webId, int intervals, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null);

		/// <summary>Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		[DispId(10)]
		ApiResponsePIItemsStreamValues GetPlotWithHttpInfo(string webId, int intervals, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null);

		/// <summary>Returns recorded values of the attributes for an element, event frame, or attribute.</summary>
		[DispId(11)]
		PIItemsStreamValues GetRecorded(string webId, bool includeFilteredValues, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null);

		/// <summary>Returns recorded values of the attributes for an element, event frame, or attribute.</summary>
		[DispId(12)]
		ApiResponsePIItemsStreamValues GetRecordedWithHttpInfo(string webId, bool includeFilteredValues, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null);

		/// <summary>Updates multiple values for the specified streams.</summary>
		[DispId(13)]
		PIItemsItemsSubstatus UpdateValues(string webId, PIItemsStreamValues values, string bufferOption = null, string updateOption = null);

		/// <summary>Updates multiple values for the specified streams.</summary>
		[DispId(14)]
		ApiResponsePIItemsItemsSubstatus UpdateValuesWithHttpInfo(string webId, PIItemsStreamValues values, string bufferOption = null, string updateOption = null);

		/// <summary>Returns recorded values of the attributes for an element, event frame, or attribute.</summary>
		[DispId(15)]
		PIItemsStreamValues GetRecordedAtTime(string webId, string time, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string templateName = null, string timeZone = null);

		/// <summary>Returns recorded values of the attributes for an element, event frame, or attribute.</summary>
		[DispId(16)]
		ApiResponsePIItemsStreamValues GetRecordedAtTimeWithHttpInfo(string webId, string time, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string templateName = null, string timeZone = null);

		/// <summary>Returns recorded values of attributes for an element, event frame or attribute at the specified times.</summary>
		[DispId(17)]
		PIItemsStreamValues GetRecordedAtTimes(string webId, string times, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null);

		/// <summary>Returns recorded values of attributes for an element, event frame or attribute at the specified times.</summary>
		[DispId(18)]
		ApiResponsePIItemsStreamValues GetRecordedAtTimesWithHttpInfo(string webId, string times, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null);

		/// <summary>Returns summary values of the attributes for an element, event frame or attribute.</summary>
		[DispId(19)]
		PIItemsStreamSummaries GetSummaries(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string templateName = null, string timeType = null, string timeZone = null);

		/// <summary>Returns summary values of the attributes for an element, event frame or attribute.</summary>
		[DispId(20)]
		ApiResponsePIItemsStreamSummaries GetSummariesWithHttpInfo(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string templateName = null, string timeType = null, string timeZone = null);

		/// <summary>Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.</summary>
		[DispId(21)]
		PIItemsStreamValue GetValues(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null, string time = null, string timeZone = null);

		/// <summary>Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.</summary>
		[DispId(22)]
		ApiResponsePIItemsStreamValue GetValuesWithHttpInfo(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null, string time = null, string timeZone = null);

		/// <summary>Updates a single value for the specified streams.</summary>
		[DispId(23)]
		PIItemsSubstatus UpdateValue(string webId, PIItemsStreamValue values, string bufferOption = null, string updateOption = null);

		/// <summary>Updates a single value for the specified streams.</summary>
		[DispId(24)]
		ApiResponsePIItemsSubstatus UpdateValueWithHttpInfo(string webId, PIItemsStreamValue values, string bufferOption = null, string updateOption = null);

		/// <summary>Opens a channel that will send messages about any value changes for the specified streams.</summary>
		[DispId(25)]
		PIItemsStreamValue GetChannelAdHoc(string webIds, bool includeInitialValues);

		/// <summary>Opens a channel that will send messages about any value changes for the specified streams.</summary>
		[DispId(26)]
		ApiResponsePIItemsStreamValue GetChannelAdHocWithHttpInfo(string webIds, bool includeInitialValues);

		/// <summary>Returns End Of Stream values for attributes of the specified streams</summary>
		[DispId(27)]
		PIItemsStreamValues GetEndAdHoc(string webIds, string selectedFields = null);

		/// <summary>Returns End Of Stream values for attributes of the specified streams</summary>
		[DispId(28)]
		ApiResponsePIItemsStreamValues GetEndAdHocWithHttpInfo(string webIds, string selectedFields = null);

		/// <summary>Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.</summary>
		[DispId(29)]
		PIItemsStreamValues GetInterpolatedAdHoc(string webIds, bool includeFilteredValues, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.</summary>
		[DispId(30)]
		ApiResponsePIItemsStreamValues GetInterpolatedAdHocWithHttpInfo(string webIds, bool includeFilteredValues, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Returns interpolated values of the specified streams at the specified times.</summary>
		[DispId(31)]
		PIItemsStreamValues GetInterpolatedAtTimesAdHoc(string times, string webIds, bool includeFilteredValues, string filterExpression = null, string selectedFields = null, string sortOrder = null, string timeZone = null);

		/// <summary>Returns interpolated values of the specified streams at the specified times.</summary>
		[DispId(32)]
		ApiResponsePIItemsStreamValues GetInterpolatedAtTimesAdHocWithHttpInfo(string times, string webIds, bool includeFilteredValues, string filterExpression = null, string selectedFields = null, string sortOrder = null, string timeZone = null);

		/// <summary>Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		[DispId(33)]
		PIItemsStreamValues GetPlotAdHoc(string webIds, int intervals, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		[DispId(34)]
		ApiResponsePIItemsStreamValues GetPlotAdHocWithHttpInfo(string webIds, int intervals, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Returns recorded values of the specified streams.</summary>
		[DispId(35)]
		PIItemsStreamValues GetRecordedAdHoc(string webIds, bool includeFilteredValues, int maxCount, string boundaryType = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Returns recorded values of the specified streams.</summary>
		[DispId(36)]
		ApiResponsePIItemsStreamValues GetRecordedAdHocWithHttpInfo(string webIds, bool includeFilteredValues, int maxCount, string boundaryType = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null);

		/// <summary>Updates multiple values for the specified streams.</summary>
		[DispId(37)]
		PIItemsItemsSubstatus UpdateValuesAdHoc(PIItemsStreamValues values, string bufferOption = null, string updateOption = null);

		/// <summary>Updates multiple values for the specified streams.</summary>
		[DispId(38)]
		ApiResponsePIItemsItemsSubstatus UpdateValuesAdHocWithHttpInfo(PIItemsStreamValues values, string bufferOption = null, string updateOption = null);

		/// <summary>Returns recorded values based on the passed time and retrieval mode.</summary>
		[DispId(39)]
		PIItemsStreamValue GetRecordedAtTimeAdHoc(string time, string webIds, string retrievalMode = null, string selectedFields = null, string timeZone = null);

		/// <summary>Returns recorded values based on the passed time and retrieval mode.</summary>
		[DispId(40)]
		ApiResponsePIItemsStreamValue GetRecordedAtTimeAdHocWithHttpInfo(string time, string webIds, string retrievalMode = null, string selectedFields = null, string timeZone = null);

		/// <summary>Returns recorded values of the specified streams at the specified times.</summary>
		[DispId(41)]
		PIItemsStreamValues GetRecordedAtTimesAdHoc(string times, string webIds, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null);

		/// <summary>Returns recorded values of the specified streams at the specified times.</summary>
		[DispId(42)]
		ApiResponsePIItemsStreamValues GetRecordedAtTimesAdHocWithHttpInfo(string times, string webIds, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null);

		/// <summary>Returns summary values of the specified streams.</summary>
		[DispId(43)]
		PIItemsStreamSummaries GetSummariesAdHoc(string webIds, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null);

		/// <summary>Returns summary values of the specified streams.</summary>
		[DispId(44)]
		ApiResponsePIItemsStreamSummaries GetSummariesAdHocWithHttpInfo(string webIds, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null);

		/// <summary>Returns values of the specified streams.</summary>
		[DispId(45)]
		PIItemsStreamValue GetValuesAdHoc(string webIds, string selectedFields = null, string time = null, string timeZone = null);

		/// <summary>Returns values of the specified streams.</summary>
		[DispId(46)]
		ApiResponsePIItemsStreamValue GetValuesAdHocWithHttpInfo(string webIds, string selectedFields = null, string time = null, string timeZone = null);

		/// <summary>Updates a single value for the specified streams.</summary>
		[DispId(47)]
		PIItemsSubstatus UpdateValueAdHoc(PIItemsStreamValue values, string bufferOption = null, string updateOption = null);

		/// <summary>Updates a single value for the specified streams.</summary>
		[DispId(48)]
		ApiResponsePIItemsSubstatus UpdateValueAdHocWithHttpInfo(PIItemsStreamValue values, string bufferOption = null, string updateOption = null);

		#endregion
	}

	[Guid("7B110A51-84C7-4F93-BE86-8B25911C4414")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IStreamSetApi))]
	[ProgId("PIWebAPIWrapper.StreamSetApi")]

	public class StreamSetApi : IStreamSetApi
	{
		private PIWebAPIWrapper.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public StreamSetApi(Configuration configuration = null)
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

		/// <summary>Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.</summary>
		public PIItemsStreamValue GetChannel(string webId, bool includeInitialValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string templateName = null)
		{
			ApiResponsePIItemsStreamValue localVarResponse = GetChannelWithHttpInfo(webId, includeInitialValues, searchFullHierarchy, showExcluded, showHidden, categoryName, nameFilter, templateName);
			return localVarResponse.Data;
		}

		/// <summary>Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.</summary>
		public ApiResponsePIItemsStreamValue GetChannelWithHttpInfo(string webId, bool includeInitialValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string templateName = null)
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
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/channel";
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
			localVarQueryParams.Add("includeInitialValues", Configuration.ApiClient.ParameterToString(includeInitialValues));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetChannel", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>Returns End of stream values of the attributes for an Element, Event Frame or Attribute</summary>
		public PIItemsStreamValue GetEnd(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null)
		{
			ApiResponsePIItemsStreamValue localVarResponse = GetEndWithHttpInfo(webId, searchFullHierarchy, showExcluded, showHidden, categoryName, nameFilter, selectedFields, templateName);
			return localVarResponse.Data;
		}

		/// <summary>Returns End of stream values of the attributes for an Element, Event Frame or Attribute</summary>
		public ApiResponsePIItemsStreamValue GetEndWithHttpInfo(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null)
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
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/end";
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
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEnd", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.</summary>
		public PIItemsStreamValues GetInterpolated(string webId, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string filterExpression = null, string interval = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetInterpolatedWithHttpInfo(webId, includeFilteredValues, searchFullHierarchy, showExcluded, showHidden, categoryName, endTime, filterExpression, interval, nameFilter, selectedFields, startTime, templateName, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.</summary>
		public ApiResponsePIItemsStreamValues GetInterpolatedWithHttpInfo(string webId, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string filterExpression = null, string interval = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
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
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/interpolated";
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
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (interval!= null) localVarQueryParams.Add("interval", Configuration.ApiClient.ParameterToString(interval));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
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

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns interpolated values of attributes for an element, event frame or attribute at the specified times.</summary>
		public PIItemsStreamValues GetInterpolatedAtTimes(string webId, string times, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetInterpolatedAtTimesWithHttpInfo(webId, times, includeFilteredValues, searchFullHierarchy, showExcluded, showHidden, categoryName, filterExpression, nameFilter, selectedFields, sortOrder, templateName, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns interpolated values of attributes for an element, event frame or attribute at the specified times.</summary>
		public ApiResponsePIItemsStreamValues GetInterpolatedAtTimesWithHttpInfo(string webId, string times, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null)
		{
			List<string> time = ExtensionMethods.ConvertToList(times);
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
			}
			if (string.IsNullOrEmpty(filterExpression)==true)
			{
				filterExpression = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(sortOrder)==true)
			{
				sortOrder = null;
			}
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/interpolatedattimes";
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
			localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
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

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		public PIItemsStreamValues GetPlot(string webId, int intervals, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetPlotWithHttpInfo(webId, intervals, searchFullHierarchy, showExcluded, showHidden, categoryName, endTime, nameFilter, selectedFields, startTime, templateName, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		public ApiResponsePIItemsStreamValues GetPlotWithHttpInfo(string webId, int intervals, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/plot";
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
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			localVarQueryParams.Add("intervals", Configuration.ApiClient.ParameterToString(intervals));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
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

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns recorded values of the attributes for an element, event frame, or attribute.</summary>
		public PIItemsStreamValues GetRecorded(string webId, bool includeFilteredValues, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetRecordedWithHttpInfo(webId, includeFilteredValues, maxCount, searchFullHierarchy, showExcluded, showHidden, boundaryType, categoryName, endTime, filterExpression, nameFilter, selectedFields, startTime, templateName, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns recorded values of the attributes for an element, event frame, or attribute.</summary>
		public ApiResponsePIItemsStreamValues GetRecordedWithHttpInfo(string webId, bool includeFilteredValues, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(boundaryType)==true)
			{
				boundaryType = null;
			}
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(filterExpression)==true)
			{
				filterExpression = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(startTime)==true)
			{
				startTime = null;
			}
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/recorded";
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
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			localVarQueryParams.Add("maxCount", Configuration.ApiClient.ParameterToString(maxCount));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
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

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Updates multiple values for the specified streams.</summary>
		public PIItemsItemsSubstatus UpdateValues(string webId, PIItemsStreamValues values, string bufferOption = null, string updateOption = null)
		{
			ApiResponsePIItemsItemsSubstatus localVarResponse = UpdateValuesWithHttpInfo(webId, values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>Updates multiple values for the specified streams.</summary>
		public ApiResponsePIItemsItemsSubstatus UpdateValuesWithHttpInfo(string webId, PIItemsStreamValues values, string bufferOption = null, string updateOption = null)
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

			var localVarPath = "/streamsets/{webId}/recorded";
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

			return new ApiResponsePIItemsItemsSubstatus(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemsSubstatus)));
		}

		/// <summary>Returns recorded values of the attributes for an element, event frame, or attribute.</summary>
		public PIItemsStreamValues GetRecordedAtTime(string webId, string time, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string templateName = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetRecordedAtTimeWithHttpInfo(webId, time, searchFullHierarchy, showExcluded, showHidden, categoryName, nameFilter, retrievalMode, selectedFields, templateName, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns recorded values of the attributes for an element, event frame, or attribute.</summary>
		public ApiResponsePIItemsStreamValues GetRecordedAtTimeWithHttpInfo(string webId, string time, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string templateName = null, string timeZone = null)
		{
			if (string.IsNullOrEmpty(webId)==true)
			{
				webId = null;
			}
			if (string.IsNullOrEmpty(time)==true)
			{
				time = null;
			}
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
			}
			if (string.IsNullOrEmpty(retrievalMode)==true)
			{
				retrievalMode = null;
			}
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streamsets/{webId}/recordedattime";
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
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
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

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns recorded values of attributes for an element, event frame or attribute at the specified times.</summary>
		public PIItemsStreamValues GetRecordedAtTimes(string webId, string times, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetRecordedAtTimesWithHttpInfo(webId, times, searchFullHierarchy, showExcluded, showHidden, categoryName, nameFilter, retrievalMode, selectedFields, sortOrder, templateName, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns recorded values of attributes for an element, event frame or attribute at the specified times.</summary>
		public ApiResponsePIItemsStreamValues GetRecordedAtTimesWithHttpInfo(string webId, string times, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null)
		{
			List<string> time = ExtensionMethods.ConvertToList(times);
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
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
			}
			if (string.IsNullOrEmpty(timeZone)==true)
			{
				timeZone = null;
			}
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/streamsets/{webId}/recordedattimes";
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
			localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
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

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns summary values of the attributes for an element, event frame or attribute.</summary>
		public PIItemsStreamSummaries GetSummaries(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string templateName = null, string timeType = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamSummaries localVarResponse = GetSummariesWithHttpInfo(webId, searchFullHierarchy, showExcluded, showHidden, calculationBasis, categoryName, endTime, filterExpression, nameFilter, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryTypes, templateName, timeType, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns summary values of the attributes for an element, event frame or attribute.</summary>
		public ApiResponsePIItemsStreamSummaries GetSummariesWithHttpInfo(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string templateName = null, string timeType = null, string timeZone = null)
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
			if (string.IsNullOrEmpty(categoryName)==true)
			{
				categoryName = null;
			}
			if (string.IsNullOrEmpty(endTime)==true)
			{
				endTime = null;
			}
			if (string.IsNullOrEmpty(filterExpression)==true)
			{
				filterExpression = null;
			}
			if (string.IsNullOrEmpty(nameFilter)==true)
			{
				nameFilter = null;
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
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
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

			var localVarPath = "/streamsets/{webId}/summary";
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
			if (categoryName!= null) localVarQueryParams.Add("categoryName", Configuration.ApiClient.ParameterToString(categoryName));
			if (endTime!= null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			if (sampleInterval!= null) localVarQueryParams.Add("sampleInterval", Configuration.ApiClient.ParameterToString(sampleInterval));
			if (sampleType!= null) localVarQueryParams.Add("sampleType", Configuration.ApiClient.ParameterToString(sampleType));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (startTime!= null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime));
			if (summaryDuration!= null) localVarQueryParams.Add("summaryDuration", Configuration.ApiClient.ParameterToString(summaryDuration));
			localVarQueryParams.Add("summaryType", Configuration.ApiClient.ParameterToString(summaryType));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
			if (timeType!= null) localVarQueryParams.Add("timeType", Configuration.ApiClient.ParameterToString(timeType));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSummaries", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamSummaries(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamSummaries)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamSummaries)));
		}

		/// <summary>Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.</summary>
		public PIItemsStreamValue GetValues(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null, string time = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValue localVarResponse = GetValuesWithHttpInfo(webId, searchFullHierarchy, showExcluded, showHidden, categoryName, nameFilter, selectedFields, templateName, time, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.</summary>
		public ApiResponsePIItemsStreamValue GetValuesWithHttpInfo(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null, string time = null, string timeZone = null)
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
			if (string.IsNullOrEmpty(templateName)==true)
			{
				templateName = null;
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

			var localVarPath = "/streamsets/{webId}/value";
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
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", Configuration.ApiClient.ParameterToString(nameFilter));
			localVarQueryParams.Add("searchFullHierarchy", Configuration.ApiClient.ParameterToString(searchFullHierarchy));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			localVarQueryParams.Add("showExcluded", Configuration.ApiClient.ParameterToString(showExcluded));
			localVarQueryParams.Add("showHidden", Configuration.ApiClient.ParameterToString(showHidden));
			if (templateName!= null) localVarQueryParams.Add("templateName", Configuration.ApiClient.ParameterToString(templateName));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetValues", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>Updates a single value for the specified streams.</summary>
		public PIItemsSubstatus UpdateValue(string webId, PIItemsStreamValue values, string bufferOption = null, string updateOption = null)
		{
			ApiResponsePIItemsSubstatus localVarResponse = UpdateValueWithHttpInfo(webId, values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>Updates a single value for the specified streams.</summary>
		public ApiResponsePIItemsSubstatus UpdateValueWithHttpInfo(string webId, PIItemsStreamValue values, string bufferOption = null, string updateOption = null)
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

			var localVarPath = "/streamsets/{webId}/value";
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
				Exception exception = ExceptionFactory("UpdateValue", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSubstatus(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSubstatus)));
		}

		/// <summary>Opens a channel that will send messages about any value changes for the specified streams.</summary>
		public PIItemsStreamValue GetChannelAdHoc(string webIds, bool includeInitialValues)
		{
			ApiResponsePIItemsStreamValue localVarResponse = GetChannelAdHocWithHttpInfo(webIds, includeInitialValues);
			return localVarResponse.Data;
		}

		/// <summary>Opens a channel that will send messages about any value changes for the specified streams.</summary>
		public ApiResponsePIItemsStreamValue GetChannelAdHocWithHttpInfo(string webIds, bool includeInitialValues)
		{
			List<string> webId = ExtensionMethods.ConvertToList(webIds);

			var localVarPath = "/streamsets/channel";
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

			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarQueryParams.Add("includeInitialValues", Configuration.ApiClient.ParameterToString(includeInitialValues));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetChannelAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>Returns End Of Stream values for attributes of the specified streams</summary>
		public PIItemsStreamValues GetEndAdHoc(string webIds, string selectedFields = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetEndAdHocWithHttpInfo(webIds, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>Returns End Of Stream values for attributes of the specified streams</summary>
		public ApiResponsePIItemsStreamValues GetEndAdHocWithHttpInfo(string webIds, string selectedFields = null)
		{
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
			if (string.IsNullOrEmpty(selectedFields)==true)
			{
				selectedFields = null;
			}

			var localVarPath = "/streamsets/end";
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

			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetEndAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.</summary>
		public PIItemsStreamValues GetInterpolatedAdHoc(string webIds, bool includeFilteredValues, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetInterpolatedAdHocWithHttpInfo(webIds, includeFilteredValues, endTime, filterExpression, interval, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.</summary>
		public ApiResponsePIItemsStreamValues GetInterpolatedAdHocWithHttpInfo(string webIds, bool includeFilteredValues, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
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

			var localVarPath = "/streamsets/interpolated";
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

			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
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
				Exception exception = ExceptionFactory("GetInterpolatedAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns interpolated values of the specified streams at the specified times.</summary>
		public PIItemsStreamValues GetInterpolatedAtTimesAdHoc(string times, string webIds, bool includeFilteredValues, string filterExpression = null, string selectedFields = null, string sortOrder = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetInterpolatedAtTimesAdHocWithHttpInfo(times, webIds, includeFilteredValues, filterExpression, selectedFields, sortOrder, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns interpolated values of the specified streams at the specified times.</summary>
		public ApiResponsePIItemsStreamValues GetInterpolatedAtTimesAdHocWithHttpInfo(string times, string webIds, bool includeFilteredValues, string filterExpression = null, string selectedFields = null, string sortOrder = null, string timeZone = null)
		{
			List<string> time = ExtensionMethods.ConvertToList(times);
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
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

			var localVarPath = "/streamsets/interpolatedattimes";
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

			localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (filterExpression!= null) localVarQueryParams.Add("filterExpression", Configuration.ApiClient.ParameterToString(filterExpression));
			localVarQueryParams.Add("includeFilteredValues", Configuration.ApiClient.ParameterToString(includeFilteredValues));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetInterpolatedAtTimesAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		public PIItemsStreamValues GetPlotAdHoc(string webIds, int intervals, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetPlotAdHocWithHttpInfo(webIds, intervals, endTime, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).</summary>
		public ApiResponsePIItemsStreamValues GetPlotAdHocWithHttpInfo(string webIds, int intervals, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
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

			var localVarPath = "/streamsets/plot";
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

			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
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
				Exception exception = ExceptionFactory("GetPlotAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns recorded values of the specified streams.</summary>
		public PIItemsStreamValues GetRecordedAdHoc(string webIds, bool includeFilteredValues, int maxCount, string boundaryType = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetRecordedAdHocWithHttpInfo(webIds, includeFilteredValues, maxCount, boundaryType, endTime, filterExpression, selectedFields, startTime, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns recorded values of the specified streams.</summary>
		public ApiResponsePIItemsStreamValues GetRecordedAdHocWithHttpInfo(string webIds, bool includeFilteredValues, int maxCount, string boundaryType = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null)
		{
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
			if (string.IsNullOrEmpty(boundaryType)==true)
			{
				boundaryType = null;
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

			var localVarPath = "/streamsets/recorded";
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

			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (boundaryType!= null) localVarQueryParams.Add("boundaryType", Configuration.ApiClient.ParameterToString(boundaryType));
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
				Exception exception = ExceptionFactory("GetRecordedAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Updates multiple values for the specified streams.</summary>
		public PIItemsItemsSubstatus UpdateValuesAdHoc(PIItemsStreamValues values, string bufferOption = null, string updateOption = null)
		{
			ApiResponsePIItemsItemsSubstatus localVarResponse = UpdateValuesAdHocWithHttpInfo(values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>Updates multiple values for the specified streams.</summary>
		public ApiResponsePIItemsItemsSubstatus UpdateValuesAdHocWithHttpInfo(PIItemsStreamValues values, string bufferOption = null, string updateOption = null)
		{
			if (string.IsNullOrEmpty(bufferOption)==true)
			{
				bufferOption = null;
			}
			if (string.IsNullOrEmpty(updateOption)==true)
			{
				updateOption = null;
			}
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/recorded";
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
				Exception exception = ExceptionFactory("UpdateValuesAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsItemsSubstatus(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsItemsSubstatus)));
		}

		/// <summary>Returns recorded values based on the passed time and retrieval mode.</summary>
		public PIItemsStreamValue GetRecordedAtTimeAdHoc(string time, string webIds, string retrievalMode = null, string selectedFields = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValue localVarResponse = GetRecordedAtTimeAdHocWithHttpInfo(time, webIds, retrievalMode, selectedFields, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns recorded values based on the passed time and retrieval mode.</summary>
		public ApiResponsePIItemsStreamValue GetRecordedAtTimeAdHocWithHttpInfo(string time, string webIds, string retrievalMode = null, string selectedFields = null, string timeZone = null)
		{
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
			if (string.IsNullOrEmpty(time)==true)
			{
				time = null;
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
			if (time == null)
				throw new ApiException(400, "Missing required parameter 'time'");

			var localVarPath = "/streamsets/recordedattime";
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

			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimeAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>Returns recorded values of the specified streams at the specified times.</summary>
		public PIItemsStreamValues GetRecordedAtTimesAdHoc(string times, string webIds, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValues localVarResponse = GetRecordedAtTimesAdHocWithHttpInfo(times, webIds, retrievalMode, selectedFields, sortOrder, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns recorded values of the specified streams at the specified times.</summary>
		public ApiResponsePIItemsStreamValues GetRecordedAtTimesAdHocWithHttpInfo(string times, string webIds, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null)
		{
			List<string> time = ExtensionMethods.ConvertToList(times);
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
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

			var localVarPath = "/streamsets/recordedattimes";
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

			localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (retrievalMode!= null) localVarQueryParams.Add("retrievalMode", Configuration.ApiClient.ParameterToString(retrievalMode));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", Configuration.ApiClient.ParameterToString(sortOrder));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetRecordedAtTimesAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValues(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValues)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValues)));
		}

		/// <summary>Returns summary values of the specified streams.</summary>
		public PIItemsStreamSummaries GetSummariesAdHoc(string webIds, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamSummaries localVarResponse = GetSummariesAdHocWithHttpInfo(webIds, calculationBasis, endTime, filterExpression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryTypes, timeType, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns summary values of the specified streams.</summary>
		public ApiResponsePIItemsStreamSummaries GetSummariesAdHocWithHttpInfo(string webIds, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null)
		{
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
			List<string> summaryType = ExtensionMethods.ConvertToList(summaryTypes);
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

			var localVarPath = "/streamsets/summary";
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

			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
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
				Exception exception = ExceptionFactory("GetSummariesAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamSummaries(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamSummaries)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamSummaries)));
		}

		/// <summary>Returns values of the specified streams.</summary>
		public PIItemsStreamValue GetValuesAdHoc(string webIds, string selectedFields = null, string time = null, string timeZone = null)
		{
			ApiResponsePIItemsStreamValue localVarResponse = GetValuesAdHocWithHttpInfo(webIds, selectedFields, time, timeZone);
			return localVarResponse.Data;
		}

		/// <summary>Returns values of the specified streams.</summary>
		public ApiResponsePIItemsStreamValue GetValuesAdHocWithHttpInfo(string webIds, string selectedFields = null, string time = null, string timeZone = null)
		{
			List<string> webId = ExtensionMethods.ConvertToList(webIds);
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

			var localVarPath = "/streamsets/value";
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

			localVarQueryParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", Configuration.ApiClient.ParameterToString(selectedFields));
			if (time!= null) localVarQueryParams.Add("time", Configuration.ApiClient.ParameterToString(time));
			if (timeZone!= null) localVarQueryParams.Add("timeZone", Configuration.ApiClient.ParameterToString(timeZone));

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetValuesAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsStreamValue(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsStreamValue)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsStreamValue)));
		}

		/// <summary>Updates a single value for the specified streams.</summary>
		public PIItemsSubstatus UpdateValueAdHoc(PIItemsStreamValue values, string bufferOption = null, string updateOption = null)
		{
			ApiResponsePIItemsSubstatus localVarResponse = UpdateValueAdHocWithHttpInfo(values, bufferOption, updateOption);
			return localVarResponse.Data;
		}

		/// <summary>Updates a single value for the specified streams.</summary>
		public ApiResponsePIItemsSubstatus UpdateValueAdHocWithHttpInfo(PIItemsStreamValue values, string bufferOption = null, string updateOption = null)
		{
			if (string.IsNullOrEmpty(bufferOption)==true)
			{
				bufferOption = null;
			}
			if (string.IsNullOrEmpty(updateOption)==true)
			{
				updateOption = null;
			}
			if (values == null)
				throw new ApiException(400, "Missing required parameter 'values'");

			var localVarPath = "/streamsets/value";
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
				Exception exception = ExceptionFactory("UpdateValueAdHoc", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponsePIItemsSubstatus(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(PIItemsSubstatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSubstatus)));
		}

	}
}
