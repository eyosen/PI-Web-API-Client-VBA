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
	[Guid("8B05824F-D6B1-4BD2-AF4A-1BADA1CBD29B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAssetServer
	{
		[DispId(1)]
		PIItemsAssetServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("8B8E5441-B8CC-4BF2-9027-019DEE1184FC")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAssetServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAssetServer")]
	public class ApiResponsePIItemsAssetServer : ApiParentResponse, IApiResponsePIItemsAssetServer
	{
		public PIItemsAssetServer Data { get; set; }
		public ApiResponsePIItemsAssetServer(int statusCode, IDictionary<string, string> headers, PIItemsAssetServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
