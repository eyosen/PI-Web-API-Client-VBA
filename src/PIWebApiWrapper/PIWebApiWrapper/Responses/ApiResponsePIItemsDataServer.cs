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
	[Guid("B395D3D6-3E82-4FB3-8B04-B928D3E4CB15")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsDataServer
	{
		[DispId(1)]
		PIItemsDataServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1F0089DD-26D0-4722-A458-D52C8B3ABF5C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsDataServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsDataServer")]
	public class ApiResponsePIItemsDataServer : ApiParentResponse, IApiResponsePIItemsDataServer
	{
		public PIItemsDataServer Data { get; set; }
		public ApiResponsePIItemsDataServer(int statusCode, IDictionary<string, string> headers, PIItemsDataServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
