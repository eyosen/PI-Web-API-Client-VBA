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
	[Guid("04EF1884-5B3C-4957-99AE-B24109A9C000")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamValues
	{
		[DispId(1)]
		PIStreamValues Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("8DF4DDD0-282C-4427-8EDC-E39017EDA3C5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamValues))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamValues")]
	public class ApiResponsePIStreamValues : ApiParentResponse, IApiResponsePIStreamValues
	{
		public PIStreamValues Data { get; set; }
		public ApiResponsePIStreamValues(int statusCode, IDictionary<string, string> headers, PIStreamValues data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
