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
	[Guid("68E2BEDF-99B4-4DB6-921C-A10323D6472F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamSummariesLinks
	{
		[DispId(1)]
		PIStreamSummariesLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("8B3D69F5-32FE-4E87-BA31-4E6177E9E151")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamSummariesLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamSummariesLinks")]
	public class ApiResponsePIStreamSummariesLinks : ApiParentResponse, IApiResponsePIStreamSummariesLinks
	{
		public PIStreamSummariesLinks Data { get; set; }
		public ApiResponsePIStreamSummariesLinks(int statusCode, IDictionary<string, string> headers, PIStreamSummariesLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
