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
	[Guid("1ED72762-C199-4401-BE7A-31B3686C42E7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPointAttribute
	{
		[DispId(1)]
		PIPointAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("BDBAB877-55E1-45F4-B6EC-B505F34E5F21")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPointAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPointAttribute")]
	public class ApiResponsePIPointAttribute : ApiParentResponse, IApiResponsePIPointAttribute
	{
		public PIPointAttribute Data { get; set; }
		public ApiResponsePIPointAttribute(int statusCode, IDictionary<string, string> headers, PIPointAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
