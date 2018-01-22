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
	[Guid("28C9BC84-6D78-4760-BEB2-005C05100A48")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIResponse
	{
		[DispId(1)]
		PIResponse Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("8F079DF9-A1FD-461C-912B-FC92A4B12EF2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIResponse))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIResponse")]
	public class ApiResponsePIResponse : ApiParentResponse, IApiResponsePIResponse
	{
		public PIResponse Data { get; set; }
		public ApiResponsePIResponse(int statusCode, IDictionary<string, string> headers, PIResponse data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
