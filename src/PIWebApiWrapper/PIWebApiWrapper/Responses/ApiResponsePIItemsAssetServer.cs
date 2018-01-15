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
	[Guid("C40E8AFA-01BA-47B1-925E-00CD3229FD71")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAssetServer
	{
		[DispId(1)]
		PIItemsAssetServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2D14C638-42B9-4D95-A84A-7B63D290CA2F")]
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
