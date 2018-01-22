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
	[Guid("D8EBAA1C-87D6-42CF-B1CF-425D192DFA85")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIDataServerLicense
	{
		[DispId(1)]
		PIDataServerLicense Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("79B9A940-1CBF-4A76-BA42-3786E4C9C501")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIDataServerLicense))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIDataServerLicense")]
	public class ApiResponsePIDataServerLicense : ApiParentResponse, IApiResponsePIDataServerLicense
	{
		public PIDataServerLicense Data { get; set; }
		public ApiResponsePIDataServerLicense(int statusCode, IDictionary<string, string> headers, PIDataServerLicense data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
