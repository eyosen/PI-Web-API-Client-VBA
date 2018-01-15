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
	[Guid("6249658E-2C0E-4402-BF1A-CF8414C8288D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElement
	{
		[DispId(1)]
		PIElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("44E6BF4B-573F-4A81-92BD-B83940212260")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElement")]
	public class ApiResponsePIElement : ApiParentResponse, IApiResponsePIElement
	{
		public PIElement Data { get; set; }
		public ApiResponsePIElement(int statusCode, IDictionary<string, string> headers, PIElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
