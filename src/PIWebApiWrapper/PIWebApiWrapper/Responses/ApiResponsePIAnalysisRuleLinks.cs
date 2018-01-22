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
	[Guid("6794054D-0927-4BB7-BA3D-60C471A78561")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisRuleLinks
	{
		[DispId(1)]
		PIAnalysisRuleLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2FEDCAEE-E9EF-4C9D-B992-8E0897144186")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisRuleLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisRuleLinks")]
	public class ApiResponsePIAnalysisRuleLinks : ApiParentResponse, IApiResponsePIAnalysisRuleLinks
	{
		public PIAnalysisRuleLinks Data { get; set; }
		public ApiResponsePIAnalysisRuleLinks(int statusCode, IDictionary<string, string> headers, PIAnalysisRuleLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
