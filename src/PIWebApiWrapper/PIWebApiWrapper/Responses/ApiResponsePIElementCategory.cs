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
	[Guid("64275D83-C2B3-450F-BF1E-3692E4BE9ED7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElementCategory
	{
		[DispId(1)]
		PIElementCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("9D8ACAD4-6673-4CEA-B12E-C5E9C04827BE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElementCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElementCategory")]
	public class ApiResponsePIElementCategory : ApiParentResponse, IApiResponsePIElementCategory
	{
		public PIElementCategory Data { get; set; }
		public ApiResponsePIElementCategory(int statusCode, IDictionary<string, string> headers, PIElementCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
