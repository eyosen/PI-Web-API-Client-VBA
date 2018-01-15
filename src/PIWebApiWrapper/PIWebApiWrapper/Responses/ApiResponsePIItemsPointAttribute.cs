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
	[Guid("929ABF1B-1FCA-4CC7-9A50-03E97D0D3822")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsPointAttribute
	{
		[DispId(1)]
		PIItemsPointAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3E0A3D8D-9DDE-47F0-B61A-46CC51F60E05")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsPointAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsPointAttribute")]
	public class ApiResponsePIItemsPointAttribute : ApiParentResponse, IApiResponsePIItemsPointAttribute
	{
		public PIItemsPointAttribute Data { get; set; }
		public ApiResponsePIItemsPointAttribute(int statusCode, IDictionary<string, string> headers, PIItemsPointAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
