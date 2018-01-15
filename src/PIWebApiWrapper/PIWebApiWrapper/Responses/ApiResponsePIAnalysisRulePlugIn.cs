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
	[Guid("5EC7F819-F5E3-4E6E-8E2F-17DE50B67840")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisRulePlugIn
	{
		[DispId(1)]
		PIAnalysisRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3A58C0F8-C607-40A5-B620-68951420B831")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisRulePlugIn))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisRulePlugIn")]
	public class ApiResponsePIAnalysisRulePlugIn : ApiParentResponse, IApiResponsePIAnalysisRulePlugIn
	{
		public PIAnalysisRulePlugIn Data { get; set; }
		public ApiResponsePIAnalysisRulePlugIn(int statusCode, IDictionary<string, string> headers, PIAnalysisRulePlugIn data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
