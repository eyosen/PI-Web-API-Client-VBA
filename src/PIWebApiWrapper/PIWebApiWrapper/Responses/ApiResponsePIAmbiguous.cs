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
	[Guid("1FD3FFE8-6E1D-47F3-BB4E-376E9AD1B398")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAmbiguous
	{
		[DispId(1)]
		PIAmbiguous Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5099E444-C00C-4587-9CFE-374073F786A8")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAmbiguous))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAmbiguous")]
	public class ApiResponsePIAmbiguous : ApiParentResponse, IApiResponsePIAmbiguous
	{
		public PIAmbiguous Data { get; set; }
		public ApiResponsePIAmbiguous(int statusCode, IDictionary<string, string> headers, PIAmbiguous data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
