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
	[Guid("43A4D15C-33A6-4B98-A37D-0F87C431010F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemPoint
	{
		[DispId(1)]
		PIItemPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B8C9FAF0-52C0-471A-AF1B-284F8699C2D3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemPoint))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemPoint")]
	public class ApiResponsePIItemPoint : ApiParentResponse, IApiResponsePIItemPoint
	{
		public PIItemPoint Data { get; set; }
		public ApiResponsePIItemPoint(int statusCode, IDictionary<string, string> headers, PIItemPoint data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
