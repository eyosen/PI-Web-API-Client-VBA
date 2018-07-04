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
	[Guid("09489F16-E87A-4F8B-B89B-17B1517E57F5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisRule
	{
		[DispId(1)]
		PIItemsAnalysisRule Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("9DA09837-F6BB-42A3-8DF2-E2D33F4B11E5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysisRule))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysisRule")]
	public class ApiResponsePIItemsAnalysisRule : ApiParentResponse, IApiResponsePIItemsAnalysisRule
	{
		public PIItemsAnalysisRule Data { get; set; }
		public ApiResponsePIItemsAnalysisRule(int statusCode, IDictionary<string, string> headers, PIItemsAnalysisRule data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
