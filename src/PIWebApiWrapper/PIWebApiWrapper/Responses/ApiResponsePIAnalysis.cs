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
	[Guid("5AAB8CF8-30A2-4434-9FEA-609B58842A5A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysis
	{
		[DispId(1)]
		PIAnalysis Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("450B31E3-BDE1-4D5D-B97F-4D408B3DB21F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysis))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysis")]
	public class ApiResponsePIAnalysis : ApiParentResponse, IApiResponsePIAnalysis
	{
		public PIAnalysis Data { get; set; }
		public ApiResponsePIAnalysis(int statusCode, IDictionary<string, string> headers, PIAnalysis data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
