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
	[Guid("88309895-F4E5-426B-9BED-772CF4928276")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEventFrame
	{
		[DispId(1)]
		PIEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("22FBD9E8-A9BD-4030-B8AB-24446EC579EB")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEventFrame")]
	public class ApiResponsePIEventFrame : ApiParentResponse, IApiResponsePIEventFrame
	{
		public PIEventFrame Data { get; set; }
		public ApiResponsePIEventFrame(int statusCode, IDictionary<string, string> headers, PIEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
