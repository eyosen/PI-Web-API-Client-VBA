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
	[Guid("3D6C70C7-A33C-4564-B1E3-FD0F014D2BC1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsNotificationRuleSubscriber
	{
		[DispId(1)]
		PIItemsNotificationRuleSubscriber Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("4517736E-AF23-4079-B59C-E8CC4194E92A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsNotificationRuleSubscriber))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsNotificationRuleSubscriber")]
	public class ApiResponsePIItemsNotificationRuleSubscriber : ApiParentResponse, IApiResponsePIItemsNotificationRuleSubscriber
	{
		public PIItemsNotificationRuleSubscriber Data { get; set; }
		public ApiResponsePIItemsNotificationRuleSubscriber(int statusCode, IDictionary<string, string> headers, PIItemsNotificationRuleSubscriber data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
