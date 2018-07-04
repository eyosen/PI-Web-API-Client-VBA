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
	[Guid("AB669F15-BF7A-47BA-B163-21D4CC036DB8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIMediaMetadata
	{
		[DispId(1)]
		PIMediaMetadata Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("4F6434F3-0B19-43C7-B425-A060F20D2089")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIMediaMetadata))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIMediaMetadata")]
	public class ApiResponsePIMediaMetadata : ApiParentResponse, IApiResponsePIMediaMetadata
	{
		public PIMediaMetadata Data { get; set; }
		public ApiResponsePIMediaMetadata(int statusCode, IDictionary<string, string> headers, PIMediaMetadata data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
