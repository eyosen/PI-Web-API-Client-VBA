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
	[Guid("938D5F96-728A-4179-B31B-FDBE733CF777")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimedValue
	{
		[DispId(1)]
		PITimedValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("A59581EF-0967-4A45-8609-6B0099152634")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITimedValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITimedValue")]
	public class ApiResponsePITimedValue : ApiParentResponse, IApiResponsePITimedValue
	{
		public PITimedValue Data { get; set; }
		public ApiResponsePITimedValue(int statusCode, IDictionary<string, string> headers, PITimedValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
