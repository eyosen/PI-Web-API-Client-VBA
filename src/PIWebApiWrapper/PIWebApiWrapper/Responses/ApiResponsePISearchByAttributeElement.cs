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
	[Guid("D45813B0-CDA4-45E3-BF3E-658DB50CB3BA")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISearchByAttributeElement
	{
		[DispId(1)]
		PISearchByAttributeElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B2309A79-40AA-45FB-A63D-3A71B491BEE2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISearchByAttributeElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISearchByAttributeElement")]
	public class ApiResponsePISearchByAttributeElement : ApiParentResponse, IApiResponsePISearchByAttributeElement
	{
		public PISearchByAttributeElement Data { get; set; }
		public ApiResponsePISearchByAttributeElement(int statusCode, IDictionary<string, string> headers, PISearchByAttributeElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
