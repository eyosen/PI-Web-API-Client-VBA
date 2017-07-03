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
	[Guid("51737AB5-26E1-4198-B716-1E38EFA2189F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITableData
	{
		[DispId(1)]
		PITableData Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E9CB4E17-746B-4D00-BAF5-23955D43EF03")]
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
