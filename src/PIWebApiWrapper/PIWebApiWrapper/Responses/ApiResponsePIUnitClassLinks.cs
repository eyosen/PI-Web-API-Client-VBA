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
	[Guid("95B6BB75-1823-4BE6-A490-4175B8B08035")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIUnitClassLinks
	{
		[DispId(1)]
		PIUnitClassLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("843484DC-E6A2-4CC4-86C9-5E961A802E2B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIUnitClassLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIUnitClassLinks")]
	public class ApiResponsePIUnitClassLinks : ApiParentResponse, IApiResponsePIUnitClassLinks
	{
		public PIUnitClassLinks Data { get; set; }
		public ApiResponsePIUnitClassLinks(int statusCode, IDictionary<string, string> headers, PIUnitClassLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
