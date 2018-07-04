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
	[Guid("0184E7B2-BE99-4BBE-AFBE-1BE8F2385B60")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIWebException
	{
		[DispId(1)]
		PIWebException Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("0BCEA569-97CD-4C13-9238-9DF41DFA9406")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIWebException))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIWebException")]
	public class ApiResponsePIWebException : ApiParentResponse, IApiResponsePIWebException
	{
		public PIWebException Data { get; set; }
		public ApiResponsePIWebException(int statusCode, IDictionary<string, string> headers, PIWebException data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
