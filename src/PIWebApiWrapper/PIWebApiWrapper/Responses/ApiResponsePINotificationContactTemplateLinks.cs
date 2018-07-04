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
	[Guid("A68DB429-8E6E-42E1-B5EC-32B2A05A1E9F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePINotificationContactTemplateLinks
	{
		[DispId(1)]
		PINotificationContactTemplateLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("4A117DEE-E5CB-4E41-9456-931BDFCA4641")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePINotificationContactTemplateLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePINotificationContactTemplateLinks")]
	public class ApiResponsePINotificationContactTemplateLinks : ApiParentResponse, IApiResponsePINotificationContactTemplateLinks
	{
		public PINotificationContactTemplateLinks Data { get; set; }
		public ApiResponsePINotificationContactTemplateLinks(int statusCode, IDictionary<string, string> headers, PINotificationContactTemplateLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
