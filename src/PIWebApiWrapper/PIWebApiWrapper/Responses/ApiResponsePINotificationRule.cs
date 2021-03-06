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
	[Guid("A511F3EE-F366-4E84-91CF-2D2C7CD214E3")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePINotificationRule
	{
		[DispId(1)]
		PINotificationRule Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5B1F5075-8D0B-4D6F-9628-8914DD917FDB")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePINotificationRule))]
	[ProgId("PIWebAPIWrapper.ApiResponsePINotificationRule")]
	public class ApiResponsePINotificationRule : ApiParentResponse, IApiResponsePINotificationRule
	{
		public PINotificationRule Data { get; set; }
		public ApiResponsePINotificationRule(int statusCode, IDictionary<string, string> headers, PINotificationRule data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
