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
	[Guid("5DC9EBE6-E1D2-4893-9760-DC32BD3DB13B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeLinks
	{
		[DispId(1)]
		PIAttributeLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("46180EA7-7788-44B6-8036-DA3F9AFB7A4E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeLinks")]
	public class ApiResponsePIAttributeLinks : ApiParentResponse, IApiResponsePIAttributeLinks
	{
		public PIAttributeLinks Data { get; set; }
		public ApiResponsePIAttributeLinks(int statusCode, IDictionary<string, string> headers, PIAttributeLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
