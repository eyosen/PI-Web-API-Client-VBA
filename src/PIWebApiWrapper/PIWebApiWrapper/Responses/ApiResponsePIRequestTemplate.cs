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
	[Guid("2774EE6E-2766-4F86-818B-D5C0D6E6CE39")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIRequestTemplate
	{
		[DispId(1)]
		PIRequestTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("569B1D6A-B77C-4990-88BD-FE73563C31F7")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIRequestTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIRequestTemplate")]
	public class ApiResponsePIRequestTemplate : ApiParentResponse, IApiResponsePIRequestTemplate
	{
		public PIRequestTemplate Data { get; set; }
		public ApiResponsePIRequestTemplate(int statusCode, IDictionary<string, string> headers, PIRequestTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
