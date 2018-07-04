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
	[Guid("CE9EBF43-7336-44A2-9B40-77834D025833")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsCacheInstance
	{
		[DispId(1)]
		PIItemsCacheInstance Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3FE4FCFF-2A4D-4F89-927F-419A5231F5AB")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsCacheInstance))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsCacheInstance")]
	public class ApiResponsePIItemsCacheInstance : ApiParentResponse, IApiResponsePIItemsCacheInstance
	{
		public PIItemsCacheInstance Data { get; set; }
		public ApiResponsePIItemsCacheInstance(int statusCode, IDictionary<string, string> headers, PIItemsCacheInstance data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
