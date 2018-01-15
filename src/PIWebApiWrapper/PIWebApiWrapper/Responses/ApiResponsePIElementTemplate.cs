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
	[Guid("F3948132-D4E6-4916-8FC3-853EFD45755A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElementTemplate
	{
		[DispId(1)]
		PIElementTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("42F26FF5-D259-4A97-B170-AA09430C4C3F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElementTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElementTemplate")]
	public class ApiResponsePIElementTemplate : ApiParentResponse, IApiResponsePIElementTemplate
	{
		public PIElementTemplate Data { get; set; }
		public ApiResponsePIElementTemplate(int statusCode, IDictionary<string, string> headers, PIElementTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
