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
	[Guid("B52D452A-5DEB-4D2F-8031-E11AC7D5C037")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEnumerationValueLinks
	{
		[DispId(1)]
		PIEnumerationValueLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("16271E27-57AD-4A65-9E22-144779258788")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEnumerationValueLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEnumerationValueLinks")]
	public class ApiResponsePIEnumerationValueLinks : ApiParentResponse, IApiResponsePIEnumerationValueLinks
	{
		public PIEnumerationValueLinks Data { get; set; }
		public ApiResponsePIEnumerationValueLinks(int statusCode, IDictionary<string, string> headers, PIEnumerationValueLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
