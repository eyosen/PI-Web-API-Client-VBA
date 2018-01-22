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
	[Guid("A8F25A2E-1DC0-4C00-A087-5DED6D08999B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIWebException
	{
		[DispId(1)]
		PIWebException Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("472E4316-F833-4A39-B539-34E3BCC2D416")]
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
