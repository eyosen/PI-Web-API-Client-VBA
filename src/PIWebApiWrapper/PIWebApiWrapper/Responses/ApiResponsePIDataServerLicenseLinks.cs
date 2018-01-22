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
	[Guid("2DE3038E-92E6-4C37-A66A-F639BA46B4F9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIDataServerLicenseLinks
	{
		[DispId(1)]
		PIDataServerLicenseLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E61DEC5D-69E9-43B2-B400-606BEF3B654D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIDataServerLicenseLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIDataServerLicenseLinks")]
	public class ApiResponsePIDataServerLicenseLinks : ApiParentResponse, IApiResponsePIDataServerLicenseLinks
	{
		public PIDataServerLicenseLinks Data { get; set; }
		public ApiResponsePIDataServerLicenseLinks(int statusCode, IDictionary<string, string> headers, PIDataServerLicenseLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
