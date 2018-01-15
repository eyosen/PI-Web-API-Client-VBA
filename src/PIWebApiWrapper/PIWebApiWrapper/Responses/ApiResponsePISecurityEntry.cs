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
	[Guid("A0B7E903-B10E-4268-8E98-3EAF184168A6")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityEntry
	{
		[DispId(1)]
		PISecurityEntry Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("73E3C84D-2ED6-44EE-98CF-D4CA674688C5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityEntry))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityEntry")]
	public class ApiResponsePISecurityEntry : ApiParentResponse, IApiResponsePISecurityEntry
	{
		public PISecurityEntry Data { get; set; }
		public ApiResponsePISecurityEntry(int statusCode, IDictionary<string, string> headers, PISecurityEntry data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
