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
	[Guid("5FF7922A-187D-49B2-8A4D-5102D219490A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIUserInfo
	{
		[DispId(1)]
		PIUserInfo Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2072231B-EF25-4B83-9D95-89F8B30BC121")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIUserInfo))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIUserInfo")]
	public class ApiResponsePIUserInfo : ApiParentResponse, IApiResponsePIUserInfo
	{
		public PIUserInfo Data { get; set; }
		public ApiResponsePIUserInfo(int statusCode, IDictionary<string, string> headers, PIUserInfo data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
