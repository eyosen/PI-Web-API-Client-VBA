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
	[Guid("51FBFE20-8140-4ACB-BDB4-3B992DE10C1F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEventFrameLinks
	{
		[DispId(1)]
		PIEventFrameLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("7DE2851A-A887-4B3A-8D6B-BF79A40E87CF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEventFrameLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEventFrameLinks")]
	public class ApiResponsePIEventFrameLinks : ApiParentResponse, IApiResponsePIEventFrameLinks
	{
		public PIEventFrameLinks Data { get; set; }
		public ApiResponsePIEventFrameLinks(int statusCode, IDictionary<string, string> headers, PIEventFrameLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
