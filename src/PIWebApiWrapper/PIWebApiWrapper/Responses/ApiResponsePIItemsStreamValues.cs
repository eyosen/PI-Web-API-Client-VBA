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
	[Guid("CA10AF5E-DFE1-4888-A4E3-3BC506297A71")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamValues
	{
		[DispId(1)]
		PIItemsStreamValues Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2E061BE0-46D3-4AE4-8A1E-BE38642FB105")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamValues))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamValues")]
	public class ApiResponsePIItemsStreamValues : ApiParentResponse, IApiResponsePIItemsStreamValues
	{
		public PIItemsStreamValues Data { get; set; }
		public ApiResponsePIItemsStreamValues(int statusCode, IDictionary<string, string> headers, PIItemsStreamValues data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
