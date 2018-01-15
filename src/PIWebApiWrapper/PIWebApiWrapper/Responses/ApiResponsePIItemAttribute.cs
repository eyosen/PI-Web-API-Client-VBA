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
	[Guid("A88C6E30-0463-4DE9-B5CE-E63B07D6B606")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemAttribute
	{
		[DispId(1)]
		PIItemAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("84BA606D-6F87-4E67-B97C-C0E2EAAB8284")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemAttribute")]
	public class ApiResponsePIItemAttribute : ApiParentResponse, IApiResponsePIItemAttribute
	{
		public PIItemAttribute Data { get; set; }
		public ApiResponsePIItemAttribute(int statusCode, IDictionary<string, string> headers, PIItemAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
