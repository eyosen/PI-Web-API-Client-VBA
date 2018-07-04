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
	[Guid("C4D4A87E-3F2A-44CA-9A3A-9A38729A98AE")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePINotificationRuleSubscriber
	{
		[DispId(1)]
		PINotificationRuleSubscriber Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("58D2DC8E-7342-4C49-94EE-6AE523BE7E1A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePINotificationRuleSubscriber))]
	[ProgId("PIWebAPIWrapper.ApiResponsePINotificationRuleSubscriber")]
	public class ApiResponsePINotificationRuleSubscriber : ApiParentResponse, IApiResponsePINotificationRuleSubscriber
	{
		public PINotificationRuleSubscriber Data { get; set; }
		public ApiResponsePINotificationRuleSubscriber(int statusCode, IDictionary<string, string> headers, PINotificationRuleSubscriber data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
