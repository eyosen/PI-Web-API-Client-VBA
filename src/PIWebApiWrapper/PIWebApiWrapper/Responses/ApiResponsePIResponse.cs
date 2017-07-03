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
	[Guid("B937B9AB-33CD-49C2-98DC-B4F3F52F4E60")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIResponse
	{
		[DispId(1)]
		PIResponse Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("10762210-5D6E-4A2C-9E6B-8C50779EDF2A")]
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
