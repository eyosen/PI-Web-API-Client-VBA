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
	[Guid("FCA60F86-FDA3-4B73-A13D-190FAB8E2F6E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityEntryLinks
	{
		[DispId(1)]
		PISecurityEntryLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("A3A82644-52A9-4993-BDE9-96CDA39C5AA4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityEntryLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityEntryLinks")]
	public class ApiResponsePISecurityEntryLinks : ApiParentResponse, IApiResponsePISecurityEntryLinks
	{
		public PISecurityEntryLinks Data { get; set; }
		public ApiResponsePISecurityEntryLinks(int statusCode, IDictionary<string, string> headers, PISecurityEntryLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
