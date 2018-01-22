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
	[Guid("9C880339-5C7A-419C-82C6-8E271F425287")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPaginationLinks
	{
		[DispId(1)]
		PIPaginationLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1E9127EA-3F47-4CE8-B7EA-8E6C332782EA")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPaginationLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPaginationLinks")]
	public class ApiResponsePIPaginationLinks : ApiParentResponse, IApiResponsePIPaginationLinks
	{
		public PIPaginationLinks Data { get; set; }
		public ApiResponsePIPaginationLinks(int statusCode, IDictionary<string, string> headers, PIPaginationLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
