// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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
	[Guid("76098305-D7C8-4B74-A67A-29ADA934E9B5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsUnitClass
	{
		[DispId(1)]
		PIItemsUnitClass Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C7AE3F0B-3A04-44C2-B7DA-37DD284D1200")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsUnitClass))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsUnitClass")]
	public class ApiResponsePIItemsUnitClass : ApiParentResponse, IApiResponsePIItemsUnitClass
	{
		public PIItemsUnitClass Data { get; set; }
		public ApiResponsePIItemsUnitClass(int statusCode, IDictionary<string, string> headers, PIItemsUnitClass data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
