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
	[Guid("B64922BE-1CAA-4F56-A912-02FAD2756756")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISummaryValue
	{
		[DispId(1)]
		PISummaryValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3BC2E7BC-6FEC-4A20-B8D6-3F6C9A645A8E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISummaryValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISummaryValue")]
	public class ApiResponsePISummaryValue : ApiParentResponse, IApiResponsePISummaryValue
	{
		public PISummaryValue Data { get; set; }
		public ApiResponsePISummaryValue(int statusCode, IDictionary<string, string> headers, PISummaryValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
