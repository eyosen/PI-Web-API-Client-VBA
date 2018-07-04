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
	[Guid("78A9C97F-0F80-455E-8140-2D0CE908386E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamValueLinks
	{
		[DispId(1)]
		PIStreamValueLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1491057D-6017-455F-9099-CA7F0B00AC82")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamValueLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamValueLinks")]
	public class ApiResponsePIStreamValueLinks : ApiParentResponse, IApiResponsePIStreamValueLinks
	{
		public PIStreamValueLinks Data { get; set; }
		public ApiResponsePIStreamValueLinks(int statusCode, IDictionary<string, string> headers, PIStreamValueLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
