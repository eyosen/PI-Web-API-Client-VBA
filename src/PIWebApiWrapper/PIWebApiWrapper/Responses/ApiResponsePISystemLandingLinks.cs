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
	[Guid("FC5A8BB1-B483-4EA7-B1D7-3D8864E6320A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISystemLandingLinks
	{
		[DispId(1)]
		PISystemLandingLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2E20A371-0586-4BBB-BC83-4953C51087BF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISystemLandingLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISystemLandingLinks")]
	public class ApiResponsePISystemLandingLinks : ApiParentResponse, IApiResponsePISystemLandingLinks
	{
		public PISystemLandingLinks Data { get; set; }
		public ApiResponsePISystemLandingLinks(int statusCode, IDictionary<string, string> headers, PISystemLandingLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
