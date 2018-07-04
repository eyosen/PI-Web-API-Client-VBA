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
	[Guid("2AAF3525-76E4-46F1-A576-EED7C21D98B8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityIdentityLinks
	{
		[DispId(1)]
		PISecurityIdentityLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B615DD94-C8FF-40FA-A224-A1E3C2E8B6D0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityIdentityLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityIdentityLinks")]
	public class ApiResponsePISecurityIdentityLinks : ApiParentResponse, IApiResponsePISecurityIdentityLinks
	{
		public PISecurityIdentityLinks Data { get; set; }
		public ApiResponsePISecurityIdentityLinks(int statusCode, IDictionary<string, string> headers, PISecurityIdentityLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
