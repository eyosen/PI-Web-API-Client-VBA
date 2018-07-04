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
	[Guid("27D2483D-B492-4BB7-8DC9-A207BEF465CF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPointLinks
	{
		[DispId(1)]
		PIPointLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("7AC497B0-4B91-4FC5-A485-62EEADE737AD")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPointLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPointLinks")]
	public class ApiResponsePIPointLinks : ApiParentResponse, IApiResponsePIPointLinks
	{
		public PIPointLinks Data { get; set; }
		public ApiResponsePIPointLinks(int statusCode, IDictionary<string, string> headers, PIPointLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
