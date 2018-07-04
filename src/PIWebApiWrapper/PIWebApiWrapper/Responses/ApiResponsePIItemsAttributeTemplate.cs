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
	[Guid("019ED088-0841-42F0-B1F4-0C28A9A67E8A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttributeTemplate
	{
		[DispId(1)]
		PIItemsAttributeTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5CCFD5C8-1B93-4676-918E-62593AAF8E93")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttributeTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttributeTemplate")]
	public class ApiResponsePIItemsAttributeTemplate : ApiParentResponse, IApiResponsePIItemsAttributeTemplate
	{
		public PIItemsAttributeTemplate Data { get; set; }
		public ApiResponsePIItemsAttributeTemplate(int statusCode, IDictionary<string, string> headers, PIItemsAttributeTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
