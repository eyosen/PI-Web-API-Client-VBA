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
	[Guid("10BA63B8-B6CA-43FE-847B-830C92A5A533")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeCategoryLinks
	{
		[DispId(1)]
		PIAttributeCategoryLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("830A2AA2-5B6C-48CF-B3E9-8B65AC517239")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeCategoryLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeCategoryLinks")]
	public class ApiResponsePIAttributeCategoryLinks : ApiParentResponse, IApiResponsePIAttributeCategoryLinks
	{
		public PIAttributeCategoryLinks Data { get; set; }
		public ApiResponsePIAttributeCategoryLinks(int statusCode, IDictionary<string, string> headers, PIAttributeCategoryLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
