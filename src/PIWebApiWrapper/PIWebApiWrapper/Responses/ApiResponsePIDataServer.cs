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
	[Guid("19A2C245-303A-4482-8B29-B1FFD2CAF16B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIDataServer
	{
		[DispId(1)]
		PIDataServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("750CC382-4160-4F97-9192-4B017DE006B2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIDataServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIDataServer")]
	public class ApiResponsePIDataServer : ApiParentResponse, IApiResponsePIDataServer
	{
		public PIDataServer Data { get; set; }
		public ApiResponsePIDataServer(int statusCode, IDictionary<string, string> headers, PIDataServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
