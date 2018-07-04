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
	[Guid("6168F3E1-763A-4A2A-AE28-0D16D88D0D93")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsNotificationRule
	{
		[DispId(1)]
		PIItemsNotificationRule Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("283CF758-E86D-495A-AE0E-8697A8152814")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsNotificationRule))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsNotificationRule")]
	public class ApiResponsePIItemsNotificationRule : ApiParentResponse, IApiResponsePIItemsNotificationRule
	{
		public PIItemsNotificationRule Data { get; set; }
		public ApiResponsePIItemsNotificationRule(int statusCode, IDictionary<string, string> headers, PIItemsNotificationRule data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
