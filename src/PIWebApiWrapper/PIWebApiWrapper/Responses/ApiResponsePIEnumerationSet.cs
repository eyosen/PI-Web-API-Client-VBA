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
	[Guid("B7BEAF88-A7E2-47D7-8C67-DB33E55FAD23")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEnumerationSet
	{
		[DispId(1)]
		PIEnumerationSet Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("BB210721-7257-4E2E-9E05-93BB405382C0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEnumerationSet))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEnumerationSet")]
	public class ApiResponsePIEnumerationSet : ApiParentResponse, IApiResponsePIEnumerationSet
	{
		public PIEnumerationSet Data { get; set; }
		public ApiResponsePIEnumerationSet(int statusCode, IDictionary<string, string> headers, PIEnumerationSet data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
