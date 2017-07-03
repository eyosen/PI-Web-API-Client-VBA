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
	[Guid("562E575F-F6BB-461D-8579-6DBBA0A882B7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePILanding
	{
		[DispId(1)]
		PILanding Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("55AF735D-AFE3-47C2-8030-2C2689A0004F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePILanding))]
	[ProgId("PIWebAPIWrapper.ApiResponsePILanding")]
	public class ApiResponsePILanding : ApiParentResponse, IApiResponsePILanding
	{
		public PILanding Data { get; set; }
		public ApiResponsePILanding(int statusCode, IDictionary<string, string> headers, PILanding data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
