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
	[Guid("EC211E85-960D-4500-80AA-BF26502F2BE6")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisCategoryLinks
	{
		[DispId(1)]
		PIAnalysisCategoryLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("FE342759-2329-434E-B71C-D9BCE16E8D49")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisCategoryLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisCategoryLinks")]
	public class ApiResponsePIAnalysisCategoryLinks : ApiParentResponse, IApiResponsePIAnalysisCategoryLinks
	{
		public PIAnalysisCategoryLinks Data { get; set; }
		public ApiResponsePIAnalysisCategoryLinks(int statusCode, IDictionary<string, string> headers, PIAnalysisCategoryLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
