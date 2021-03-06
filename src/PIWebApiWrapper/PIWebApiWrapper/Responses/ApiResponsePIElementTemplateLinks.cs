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
	[Guid("AA895516-86A0-4D3E-93AE-ED31CD780AF9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElementTemplateLinks
	{
		[DispId(1)]
		PIElementTemplateLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("76C1EA31-3AE9-49B3-854C-BB95DCE167C1")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElementTemplateLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElementTemplateLinks")]
	public class ApiResponsePIElementTemplateLinks : ApiParentResponse, IApiResponsePIElementTemplateLinks
	{
		public PIElementTemplateLinks Data { get; set; }
		public ApiResponsePIElementTemplateLinks(int statusCode, IDictionary<string, string> headers, PIElementTemplateLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
