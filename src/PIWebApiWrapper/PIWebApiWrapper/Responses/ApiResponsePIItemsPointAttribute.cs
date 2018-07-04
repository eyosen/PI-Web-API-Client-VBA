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
	[Guid("1CC874BB-608E-48B4-B67F-497990D35EF9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsPointAttribute
	{
		[DispId(1)]
		PIItemsPointAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("82E13CD7-9014-47C7-A04B-49094B016483")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsPointAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsPointAttribute")]
	public class ApiResponsePIItemsPointAttribute : ApiParentResponse, IApiResponsePIItemsPointAttribute
	{
		public PIItemsPointAttribute Data { get; set; }
		public ApiResponsePIItemsPointAttribute(int statusCode, IDictionary<string, string> headers, PIItemsPointAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
