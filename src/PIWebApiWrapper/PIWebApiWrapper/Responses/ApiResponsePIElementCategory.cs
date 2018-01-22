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
	[Guid("2F9931A5-1D16-4A21-9B55-C00605196B54")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElementCategory
	{
		[DispId(1)]
		PIElementCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B552DE1F-7DAA-4560-B91F-A5A03EA6E582")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElementCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElementCategory")]
	public class ApiResponsePIElementCategory : ApiParentResponse, IApiResponsePIElementCategory
	{
		public PIElementCategory Data { get; set; }
		public ApiResponsePIElementCategory(int statusCode, IDictionary<string, string> headers, PIElementCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
