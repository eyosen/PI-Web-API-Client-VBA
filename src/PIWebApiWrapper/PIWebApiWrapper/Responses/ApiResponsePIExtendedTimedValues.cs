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
	[Guid("FB73ED89-2729-4707-8E79-7B60AF22454C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIExtendedTimedValues
	{
		[DispId(1)]
		PIExtendedTimedValues Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("7527D9A5-D429-471E-BD9D-CBC3F7B5DA9B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIExtendedTimedValues))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIExtendedTimedValues")]
	public class ApiResponsePIExtendedTimedValues : ApiParentResponse, IApiResponsePIExtendedTimedValues
	{
		public PIExtendedTimedValues Data { get; set; }
		public ApiResponsePIExtendedTimedValues(int statusCode, IDictionary<string, string> headers, PIExtendedTimedValues data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
