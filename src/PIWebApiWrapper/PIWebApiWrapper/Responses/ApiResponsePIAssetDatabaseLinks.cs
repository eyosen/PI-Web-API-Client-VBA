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
	[Guid("17FC5100-65B7-4F17-B38D-A7E0B79B7255")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAssetDatabaseLinks
	{
		[DispId(1)]
		PIAssetDatabaseLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("52A11474-14A1-46E7-9976-5104AF3470B5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAssetDatabaseLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAssetDatabaseLinks")]
	public class ApiResponsePIAssetDatabaseLinks : ApiParentResponse, IApiResponsePIAssetDatabaseLinks
	{
		public PIAssetDatabaseLinks Data { get; set; }
		public ApiResponsePIAssetDatabaseLinks(int statusCode, IDictionary<string, string> headers, PIAssetDatabaseLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
