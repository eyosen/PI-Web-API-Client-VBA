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
	[Guid("A1009F63-902A-4C6A-8935-44590B7D266C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisLinks
	{
		[DispId(1)]
		PIAnalysisLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("EDB46FA6-148C-46E7-84DD-1A801A1097AE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisLinks")]
	public class ApiResponsePIAnalysisLinks : ApiParentResponse, IApiResponsePIAnalysisLinks
	{
		public PIAnalysisLinks Data { get; set; }
		public ApiResponsePIAnalysisLinks(int statusCode, IDictionary<string, string> headers, PIAnalysisLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
