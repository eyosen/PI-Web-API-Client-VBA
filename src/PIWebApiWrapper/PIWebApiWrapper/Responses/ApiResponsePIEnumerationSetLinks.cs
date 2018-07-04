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
	[Guid("1895D788-D233-41AF-BEDB-0B2E8C4A0022")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEnumerationSetLinks
	{
		[DispId(1)]
		PIEnumerationSetLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B17ECCD3-785E-44C0-A2CE-705AE0079575")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEnumerationSetLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEnumerationSetLinks")]
	public class ApiResponsePIEnumerationSetLinks : ApiParentResponse, IApiResponsePIEnumerationSetLinks
	{
		public PIEnumerationSetLinks Data { get; set; }
		public ApiResponsePIEnumerationSetLinks(int statusCode, IDictionary<string, string> headers, PIEnumerationSetLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
