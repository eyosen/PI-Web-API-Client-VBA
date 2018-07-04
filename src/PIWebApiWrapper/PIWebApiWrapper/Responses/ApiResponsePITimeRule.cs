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
	[Guid("A03FAFF6-D5E9-4700-ABAC-56DD88F1B5E4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimeRule
	{
		[DispId(1)]
		PITimeRule Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F8EB35BA-F3B7-4EAC-9BD8-A3C288E4808D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITimeRule))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITimeRule")]
	public class ApiResponsePITimeRule : ApiParentResponse, IApiResponsePITimeRule
	{
		public PITimeRule Data { get; set; }
		public ApiResponsePITimeRule(int statusCode, IDictionary<string, string> headers, PITimeRule data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
