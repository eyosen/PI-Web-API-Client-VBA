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
	[Guid("C1DB5A1E-E42E-44B7-B627-3486F9EF5501")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeTraitLinks
	{
		[DispId(1)]
		PIAttributeTraitLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("A0FE8B82-2E0E-4AE6-A63A-6F04D1F96C43")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeTraitLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeTraitLinks")]
	public class ApiResponsePIAttributeTraitLinks : ApiParentResponse, IApiResponsePIAttributeTraitLinks
	{
		public PIAttributeTraitLinks Data { get; set; }
		public ApiResponsePIAttributeTraitLinks(int statusCode, IDictionary<string, string> headers, PIAttributeTraitLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
