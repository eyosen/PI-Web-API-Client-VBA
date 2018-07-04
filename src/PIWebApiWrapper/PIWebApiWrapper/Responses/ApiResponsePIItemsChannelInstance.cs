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
	[Guid("A63DFBF8-000D-485B-A8D0-288FF8C8A7D1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsChannelInstance
	{
		[DispId(1)]
		PIItemsChannelInstance Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F44AC91B-1D40-482E-A342-F1E7F982ECA5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsChannelInstance))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsChannelInstance")]
	public class ApiResponsePIItemsChannelInstance : ApiParentResponse, IApiResponsePIItemsChannelInstance
	{
		public PIItemsChannelInstance Data { get; set; }
		public ApiResponsePIItemsChannelInstance(int statusCode, IDictionary<string, string> headers, PIItemsChannelInstance data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
