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
	[Guid("EBFADD0C-DF6D-4533-B720-DE5ABAC40E42")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeTrait
	{
		[DispId(1)]
		PIAttributeTrait Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("7B33636E-8228-4422-9198-3C42FB1C6E62")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeTrait))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeTrait")]
	public class ApiResponsePIAttributeTrait : ApiParentResponse, IApiResponsePIAttributeTrait
	{
		public PIAttributeTrait Data { get; set; }
		public ApiResponsePIAttributeTrait(int statusCode, IDictionary<string, string> headers, PIAttributeTrait data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
