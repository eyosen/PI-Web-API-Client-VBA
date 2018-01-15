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
	[Guid("EAE90EAF-63C2-48DC-8375-6DE98167B53A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIValue
	{
		[DispId(1)]
		PIValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("912C89E6-3AB8-4E8D-B2B8-0B350B865C88")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIValue")]
	public class ApiResponsePIValue : ApiParentResponse, IApiResponsePIValue
	{
		public PIValue Data { get; set; }
		public ApiResponsePIValue(int statusCode, IDictionary<string, string> headers, PIValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
