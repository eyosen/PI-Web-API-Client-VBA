// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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
	[Guid("2B9B5CA1-6D8A-42F9-A2A1-41F23270F04C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsElement
	{
		[DispId(1)]
		PIItemsElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2CE84BFC-9151-4218-B767-4C57E788AB5B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsElement")]
	public class ApiResponsePIItemsElement : ApiParentResponse, IApiResponsePIItemsElement
	{
		public PIItemsElement Data { get; set; }
		public ApiResponsePIItemsElement(int statusCode, IDictionary<string, string> headers, PIItemsElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
