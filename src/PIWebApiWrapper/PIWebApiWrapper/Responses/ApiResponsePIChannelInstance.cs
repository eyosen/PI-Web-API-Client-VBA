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
	[Guid("0403384E-0C26-4D1B-B640-B956C27B6E33")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIChannelInstance
	{
		[DispId(1)]
		PIChannelInstance Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5403804F-E97A-40B0-9293-A5BBD9D55CC6")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIChannelInstance))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIChannelInstance")]
	public class ApiResponsePIChannelInstance : ApiParentResponse, IApiResponsePIChannelInstance
	{
		public PIChannelInstance Data { get; set; }
		public ApiResponsePIChannelInstance(int statusCode, IDictionary<string, string> headers, PIChannelInstance data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
