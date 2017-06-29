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
	[Guid("575F3652-BEE4-4E73-B184-E05A5640B242")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityEntry
	{
		[DispId(1)]
		PIItemsSecurityEntry Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1A1C7A36-1CEE-4CC3-AF82-C89BF909C374")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSecurityEntry))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSecurityEntry")]
	public class ApiResponsePIItemsSecurityEntry : ApiParentResponse, IApiResponsePIItemsSecurityEntry
	{
		public PIItemsSecurityEntry Data { get; set; }
		public ApiResponsePIItemsSecurityEntry(int statusCode, IDictionary<string, string> headers, PIItemsSecurityEntry data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
