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
	[Guid("BE17C90A-C426-47F5-9ED6-6340108D3282")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISearchByAttribute
	{
		[DispId(1)]
		PISearchByAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1B7C3C27-F7DC-484A-B09D-B1B22CC8B9D9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISearchByAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISearchByAttribute")]
	public class ApiResponsePISearchByAttribute : ApiParentResponse, IApiResponsePISearchByAttribute
	{
		public PISearchByAttribute Data { get; set; }
		public ApiResponsePISearchByAttribute(int statusCode, IDictionary<string, string> headers, PISearchByAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
