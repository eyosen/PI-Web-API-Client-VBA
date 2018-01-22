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
	[Guid("6AF84DEC-EDCF-4AF5-87FC-86FBE01FFD8B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttribute
	{
		[DispId(1)]
		PIItemsAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("6BD8CF5B-8207-4022-BE69-A3873C2B863D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttribute")]
	public class ApiResponsePIItemsAttribute : ApiParentResponse, IApiResponsePIItemsAttribute
	{
		public PIItemsAttribute Data { get; set; }
		public ApiResponsePIItemsAttribute(int statusCode, IDictionary<string, string> headers, PIItemsAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
