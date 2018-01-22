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
	[Guid("23FC1DB7-56EC-4E1C-A889-40A1AF8EB45C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElementLinks
	{
		[DispId(1)]
		PIElementLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("88D1B481-6051-4A88-889C-D6312D99C8B8")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElementLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElementLinks")]
	public class ApiResponsePIElementLinks : ApiParentResponse, IApiResponsePIElementLinks
	{
		public PIElementLinks Data { get; set; }
		public ApiResponsePIElementLinks(int statusCode, IDictionary<string, string> headers, PIElementLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
