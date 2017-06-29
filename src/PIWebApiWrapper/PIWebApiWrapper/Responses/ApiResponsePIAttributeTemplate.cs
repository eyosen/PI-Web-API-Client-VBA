// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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
	[Guid("50BACF8F-110F-4C37-AD14-66A61854F05B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeTemplate
	{
		[DispId(1)]
		PIAttributeTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("AE2FA1CF-0CEA-4E92-B63E-DC0DF0D1332B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeTemplate")]
	public class ApiResponsePIAttributeTemplate : ApiParentResponse, IApiResponsePIAttributeTemplate
	{
		public PIAttributeTemplate Data { get; set; }
		public ApiResponsePIAttributeTemplate(int statusCode, IDictionary<string, string> headers, PIAttributeTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
