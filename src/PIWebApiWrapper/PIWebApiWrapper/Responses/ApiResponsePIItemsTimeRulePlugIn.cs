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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;
using PIWebAPIWrapper.Model;

namespace PIWebAPIWrapper.Responses
{
	[Guid("F5F56693-AD28-41AD-B0A5-3A842E84F1F4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsTimeRulePlugIn
	{
		[DispId(1)]
		PIItemsTimeRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("0CA8FD2D-0445-4AC3-B22E-B95023DC8CE3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsTimeRulePlugIn))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsTimeRulePlugIn")]
	public class ApiResponsePIItemsTimeRulePlugIn : ApiParentResponse, IApiResponsePIItemsTimeRulePlugIn
	{
		public PIItemsTimeRulePlugIn Data { get; set; }
		public ApiResponsePIItemsTimeRulePlugIn(int statusCode, IDictionary<string, string> headers, PIItemsTimeRulePlugIn data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
