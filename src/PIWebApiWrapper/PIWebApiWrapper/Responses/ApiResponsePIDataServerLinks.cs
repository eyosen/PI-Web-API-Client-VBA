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
	[Guid("5CE0D776-73B0-49FE-AA49-FCD9E6EBB0B9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIDataServerLinks
	{
		[DispId(1)]
		PIDataServerLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E583C2B4-1BB1-49AC-974E-ADC9CCA51F0C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIDataServerLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIDataServerLinks")]
	public class ApiResponsePIDataServerLinks : ApiParentResponse, IApiResponsePIDataServerLinks
	{
		public PIDataServerLinks Data { get; set; }
		public ApiResponsePIDataServerLinks(int statusCode, IDictionary<string, string> headers, PIDataServerLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
