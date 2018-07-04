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
	[Guid("F9A93567-2AEA-4DEB-8DC2-F2833F57FE35")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIErrors
	{
		[DispId(1)]
		PIErrors Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C26665D7-469A-4B20-911A-FF831E45F59A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIErrors))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIErrors")]
	public class ApiResponsePIErrors : ApiParentResponse, IApiResponsePIErrors
	{
		public PIErrors Data { get; set; }
		public ApiResponsePIErrors(int statusCode, IDictionary<string, string> headers, PIErrors data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
