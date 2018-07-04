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
	[Guid("15489B01-1B3A-4804-9858-89A6DC4C7D5F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsNotificationRuleTemplate
	{
		[DispId(1)]
		PIItemsNotificationRuleTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D27D2098-4325-42A4-B55C-5864CBE0035D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsNotificationRuleTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsNotificationRuleTemplate")]
	public class ApiResponsePIItemsNotificationRuleTemplate : ApiParentResponse, IApiResponsePIItemsNotificationRuleTemplate
	{
		public PIItemsNotificationRuleTemplate Data { get; set; }
		public ApiResponsePIItemsNotificationRuleTemplate(int statusCode, IDictionary<string, string> headers, PIItemsNotificationRuleTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
