// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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
	[Guid("0CAA9089-357F-4E6C-8BC7-3739A9296D4E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisRule
	{
		[DispId(1)]
		PIAnalysisRule Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("85D362C9-B85B-44DB-BA69-181182009E94")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisRule))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisRule")]
	public class ApiResponsePIAnalysisRule : ApiParentResponse, IApiResponsePIAnalysisRule
	{
		public PIAnalysisRule Data { get; set; }
		public ApiResponsePIAnalysisRule(int statusCode, IDictionary<string, string> headers, PIAnalysisRule data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
