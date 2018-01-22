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
	[Guid("1FE62AC2-D1D9-4EF6-A521-94E70224EF50")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIRequest
	{
		[DispId(1)]
		PIRequest Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("85351E79-6A2F-49C6-8958-9E2C1A824738")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIRequest))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIRequest")]
	public class ApiResponsePIRequest : ApiParentResponse, IApiResponsePIRequest
	{
		public PIRequest Data { get; set; }
		public ApiResponsePIRequest(int statusCode, IDictionary<string, string> headers, PIRequest data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
