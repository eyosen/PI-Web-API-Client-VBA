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
	[Guid("CC708C67-E77E-40F2-8945-A7300C161DB1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITableData
	{
		[DispId(1)]
		PITableData Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("A93D0A31-D2F7-47C7-85C9-273B364BA267")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITableData))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITableData")]
	public class ApiResponsePITableData : ApiParentResponse, IApiResponsePITableData
	{
		public PITableData Data { get; set; }
		public ApiResponsePITableData(int statusCode, IDictionary<string, string> headers, PITableData data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
