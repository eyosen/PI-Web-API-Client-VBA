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
	[Guid("4C8E8FC2-4BD8-4D7F-9A90-087081E4B532")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemPoint
	{
		[DispId(1)]
		PIItemPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2026BD67-01EC-42DA-807D-81C53150152C")]
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
