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
	[Guid("794AA60B-8C9E-4E5A-80EE-591D4871EC23")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamValuesLinks
	{
		[DispId(1)]
		PIStreamValuesLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("56AEDAB8-57B2-4A12-867F-37F27B504315")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamValuesLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamValuesLinks")]
	public class ApiResponsePIStreamValuesLinks : ApiParentResponse, IApiResponsePIStreamValuesLinks
	{
		public PIStreamValuesLinks Data { get; set; }
		public ApiResponsePIStreamValuesLinks(int statusCode, IDictionary<string, string> headers, PIStreamValuesLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
