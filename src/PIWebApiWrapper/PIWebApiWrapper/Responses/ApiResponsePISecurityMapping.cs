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
	[Guid("AB8E6605-6BAF-423F-9E0A-0C56157F7A2E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityMapping
	{
		[DispId(1)]
		PISecurityMapping Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1AF0A1F0-4505-4B16-8B20-A48C71F4A86D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityMapping))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityMapping")]
	public class ApiResponsePISecurityMapping : ApiParentResponse, IApiResponsePISecurityMapping
	{
		public PISecurityMapping Data { get; set; }
		public ApiResponsePISecurityMapping(int statusCode, IDictionary<string, string> headers, PISecurityMapping data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
