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
	[Guid("1DFE7283-91AE-4D2A-A431-43614B721FCE")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsEnumerationValue
	{
		[DispId(1)]
		PIItemsEnumerationValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B1B21B38-F81F-4644-9AF7-D3527B4AFC23")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsEnumerationValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsEnumerationValue")]
	public class ApiResponsePIItemsEnumerationValue : ApiParentResponse, IApiResponsePIItemsEnumerationValue
	{
		public PIItemsEnumerationValue Data { get; set; }
		public ApiResponsePIItemsEnumerationValue(int statusCode, IDictionary<string, string> headers, PIItemsEnumerationValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
