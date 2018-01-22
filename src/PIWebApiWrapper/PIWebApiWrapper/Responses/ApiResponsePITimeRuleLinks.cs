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
	[Guid("D0D1748D-7C98-4F89-BA2E-1BFC635CF2F1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimeRuleLinks
	{
		[DispId(1)]
		PITimeRuleLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E5BD54E9-1C7F-4C02-9EE8-BCD0FFD3EC81")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITimeRuleLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITimeRuleLinks")]
	public class ApiResponsePITimeRuleLinks : ApiParentResponse, IApiResponsePITimeRuleLinks
	{
		public PITimeRuleLinks Data { get; set; }
		public ApiResponsePITimeRuleLinks(int statusCode, IDictionary<string, string> headers, PITimeRuleLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
