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
	[Guid("CEDBBA89-3400-476E-A0E8-C781EF2B9B68")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimeRule
	{
		[DispId(1)]
		PITimeRule Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("090A4D5B-2D7F-4C3E-8765-8C5F15483E41")]
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
