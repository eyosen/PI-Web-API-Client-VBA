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
	[Guid("3B6B442F-B601-45C2-B68E-B7A7C4555B77")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSummaryValue
	{
		[DispId(1)]
		PIItemsSummaryValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("EF8C1C52-6BD0-491C-A8FD-8EE1B6DC6BEC")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSummaryValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSummaryValue")]
	public class ApiResponsePIItemsSummaryValue : ApiParentResponse, IApiResponsePIItemsSummaryValue
	{
		public PIItemsSummaryValue Data { get; set; }
		public ApiResponsePIItemsSummaryValue(int statusCode, IDictionary<string, string> headers, PIItemsSummaryValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
