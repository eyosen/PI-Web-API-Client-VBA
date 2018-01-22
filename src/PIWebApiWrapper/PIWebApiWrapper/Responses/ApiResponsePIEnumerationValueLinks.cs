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
	[Guid("17611871-5F8F-4A83-8CE2-2460C072AD85")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEnumerationValueLinks
	{
		[DispId(1)]
		PIEnumerationValueLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B60D4926-3C61-46FB-ACEE-ED65DF1ACAC3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEnumerationValueLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEnumerationValueLinks")]
	public class ApiResponsePIEnumerationValueLinks : ApiParentResponse, IApiResponsePIEnumerationValueLinks
	{
		public PIEnumerationValueLinks Data { get; set; }
		public ApiResponsePIEnumerationValueLinks(int statusCode, IDictionary<string, string> headers, PIEnumerationValueLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
