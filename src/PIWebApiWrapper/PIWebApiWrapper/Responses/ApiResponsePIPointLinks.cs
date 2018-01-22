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
	[Guid("E87AFBBF-59F5-4B62-B94E-570102A4F20B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPointLinks
	{
		[DispId(1)]
		PIPointLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("157C2677-40E0-4496-88E0-891DD74D67C9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPointLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPointLinks")]
	public class ApiResponsePIPointLinks : ApiParentResponse, IApiResponsePIPointLinks
	{
		public PIPointLinks Data { get; set; }
		public ApiResponsePIPointLinks(int statusCode, IDictionary<string, string> headers, PIPointLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
