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
	[Guid("D30CB9EF-C73C-4771-9201-AA989AE521E7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityRightsLinks
	{
		[DispId(1)]
		PISecurityRightsLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("0DAC828D-5C23-4DC6-8B8D-8B0C9C0C8E07")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityRightsLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityRightsLinks")]
	public class ApiResponsePISecurityRightsLinks : ApiParentResponse, IApiResponsePISecurityRightsLinks
	{
		public PISecurityRightsLinks Data { get; set; }
		public ApiResponsePISecurityRightsLinks(int statusCode, IDictionary<string, string> headers, PISecurityRightsLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
