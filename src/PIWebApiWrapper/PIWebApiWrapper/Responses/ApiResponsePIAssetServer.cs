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
	[Guid("080C76F4-6E6E-4BC1-99B6-0D42840AE69E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAssetServer
	{
		[DispId(1)]
		PIAssetServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("31733D51-A553-41F2-B7E5-B6E980DB430E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAssetServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAssetServer")]
	public class ApiResponsePIAssetServer : ApiParentResponse, IApiResponsePIAssetServer
	{
		public PIAssetServer Data { get; set; }
		public ApiResponsePIAssetServer(int statusCode, IDictionary<string, string> headers, PIAssetServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
