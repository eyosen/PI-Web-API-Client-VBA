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
	[Guid("9990DA4F-1DB9-403F-8611-606D0D240B08")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityRights
	{
		[DispId(1)]
		PISecurityRights Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("10D7F690-D5A1-474C-8450-4B6B6348A8D4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityRights))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityRights")]
	public class ApiResponsePISecurityRights : ApiParentResponse, IApiResponsePISecurityRights
	{
		public PISecurityRights Data { get; set; }
		public ApiResponsePISecurityRights(int statusCode, IDictionary<string, string> headers, PISecurityRights data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
