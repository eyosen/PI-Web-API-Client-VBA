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
	[Guid("0E539EFD-B552-4DA1-BDCE-9F43C3D7620B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnnotationLinks
	{
		[DispId(1)]
		PIAnnotationLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("09263A02-F276-4F6E-B82C-8A878C209709")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnnotationLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnnotationLinks")]
	public class ApiResponsePIAnnotationLinks : ApiParentResponse, IApiResponsePIAnnotationLinks
	{
		public PIAnnotationLinks Data { get; set; }
		public ApiResponsePIAnnotationLinks(int statusCode, IDictionary<string, string> headers, PIAnnotationLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
