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
	[Guid("D161A1D0-5006-4D25-9FA0-11C14BECF280")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemEventFrame
	{
		[DispId(1)]
		PIItemsItemEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("0EFDD6C2-083D-4889-A0E5-D12928495A5F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemEventFrame")]
	public class ApiResponsePIItemsItemEventFrame : ApiParentResponse, IApiResponsePIItemsItemEventFrame
	{
		public PIItemsItemEventFrame Data { get; set; }
		public ApiResponsePIItemsItemEventFrame(int statusCode, IDictionary<string, string> headers, PIItemsItemEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}