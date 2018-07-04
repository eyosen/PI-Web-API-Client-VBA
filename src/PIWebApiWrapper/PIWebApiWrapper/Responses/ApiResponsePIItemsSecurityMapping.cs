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
	[Guid("8DEAAC9D-D8E7-4DB1-ACED-0BE719A79BF2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityMapping
	{
		[DispId(1)]
		PIItemsSecurityMapping Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3C02726A-EB0B-4287-B4C0-A675B49B7B10")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSecurityMapping))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSecurityMapping")]
	public class ApiResponsePIItemsSecurityMapping : ApiParentResponse, IApiResponsePIItemsSecurityMapping
	{
		public PIItemsSecurityMapping Data { get; set; }
		public ApiResponsePIItemsSecurityMapping(int statusCode, IDictionary<string, string> headers, PIItemsSecurityMapping data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
