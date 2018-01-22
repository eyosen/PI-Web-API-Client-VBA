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
	[Guid("71E16A16-2297-47D1-867A-D26B371B46FC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityIdentity
	{
		[DispId(1)]
		PISecurityIdentity Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("6FF987D9-35ED-4CD3-B0AA-CF69A822B4ED")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityIdentity))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityIdentity")]
	public class ApiResponsePISecurityIdentity : ApiParentResponse, IApiResponsePISecurityIdentity
	{
		public PISecurityIdentity Data { get; set; }
		public ApiResponsePISecurityIdentity(int statusCode, IDictionary<string, string> headers, PISecurityIdentity data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
