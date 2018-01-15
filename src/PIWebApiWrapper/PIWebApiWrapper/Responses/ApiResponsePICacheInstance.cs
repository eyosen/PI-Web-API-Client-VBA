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
	[Guid("EEACB84F-B834-4798-AB7E-CE9123DE0F56")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePICacheInstance
	{
		[DispId(1)]
		PICacheInstance Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C160C972-65C6-47C7-A630-14A8288D95E0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePICacheInstance))]
	[ProgId("PIWebAPIWrapper.ApiResponsePICacheInstance")]
	public class ApiResponsePICacheInstance : ApiParentResponse, IApiResponsePICacheInstance
	{
		public PICacheInstance Data { get; set; }
		public ApiResponsePICacheInstance(int statusCode, IDictionary<string, string> headers, PICacheInstance data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
