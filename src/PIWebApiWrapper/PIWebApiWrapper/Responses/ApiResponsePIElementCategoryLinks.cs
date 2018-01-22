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
	[Guid("09356DD9-DC28-48D7-94BD-D938369A9E30")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElementCategoryLinks
	{
		[DispId(1)]
		PIElementCategoryLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F6FC34B0-1F25-489B-BC87-0C978ACE9C58")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElementCategoryLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElementCategoryLinks")]
	public class ApiResponsePIElementCategoryLinks : ApiParentResponse, IApiResponsePIElementCategoryLinks
	{
		public PIElementCategoryLinks Data { get; set; }
		public ApiResponsePIElementCategoryLinks(int statusCode, IDictionary<string, string> headers, PIElementCategoryLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
