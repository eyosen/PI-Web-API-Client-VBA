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
	[Guid("3C01FF73-166E-4DD4-9063-A829B0D8923E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITableLinks
	{
		[DispId(1)]
		PITableLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("874938F7-DE80-4DAB-82EC-92C6A98B8901")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITableLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITableLinks")]
	public class ApiResponsePITableLinks : ApiParentResponse, IApiResponsePITableLinks
	{
		public PITableLinks Data { get; set; }
		public ApiResponsePITableLinks(int statusCode, IDictionary<string, string> headers, PITableLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
