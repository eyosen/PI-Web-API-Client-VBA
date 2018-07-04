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
	[Guid("AB78BE91-E5A7-47EB-BDA9-83059CF64F22")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttribute
	{
		[DispId(1)]
		PIAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1C59E90F-8F06-4603-99E1-F0CCA8A82766")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttribute")]
	public class ApiResponsePIAttribute : ApiParentResponse, IApiResponsePIAttribute
	{
		public PIAttribute Data { get; set; }
		public ApiResponsePIAttribute(int statusCode, IDictionary<string, string> headers, PIAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
