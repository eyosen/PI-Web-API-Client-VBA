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
	[Guid("95EA35AD-F7B5-47A6-B3AD-D6FEB4D81395")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePINotificationContactTemplate
	{
		[DispId(1)]
		PINotificationContactTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("661C6C1A-B53F-4E36-B7C0-438A6A3F970B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePINotificationContactTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePINotificationContactTemplate")]
	public class ApiResponsePINotificationContactTemplate : ApiParentResponse, IApiResponsePINotificationContactTemplate
	{
		public PINotificationContactTemplate Data { get; set; }
		public ApiResponsePINotificationContactTemplate(int statusCode, IDictionary<string, string> headers, PINotificationContactTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
