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
	[Guid("98AE50EC-88F0-490E-ADE8-F37FCE2F0FF0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeTemplateLinks
	{
		[DispId(1)]
		PIAttributeTemplateLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("61555EE3-E8CD-4E17-922B-324C4EC5AFB9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeTemplateLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeTemplateLinks")]
	public class ApiResponsePIAttributeTemplateLinks : ApiParentResponse, IApiResponsePIAttributeTemplateLinks
	{
		public PIAttributeTemplateLinks Data { get; set; }
		public ApiResponsePIAttributeTemplateLinks(int statusCode, IDictionary<string, string> headers, PIAttributeTemplateLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
