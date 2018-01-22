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
	[Guid("E18F06C7-02DE-44FE-BE33-898FF87607AD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITableCategoryLinks
	{
		[DispId(1)]
		PITableCategoryLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("7D0F360E-1FE6-405B-8C9B-B9F19E8D9344")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITableCategoryLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITableCategoryLinks")]
	public class ApiResponsePITableCategoryLinks : ApiParentResponse, IApiResponsePITableCategoryLinks
	{
		public PITableCategoryLinks Data { get; set; }
		public ApiResponsePITableCategoryLinks(int statusCode, IDictionary<string, string> headers, PITableCategoryLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
