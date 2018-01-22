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
	[Guid("DA9ADA11-6460-45DD-9B49-DDD9DFE480CA")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIValueQuery
	{
		[DispId(1)]
		PIValueQuery Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("0B3DC4DC-B475-48B0-BBFA-999657420B40")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIValueQuery))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIValueQuery")]
	public class ApiResponsePIValueQuery : ApiParentResponse, IApiResponsePIValueQuery
	{
		public PIValueQuery Data { get; set; }
		public ApiResponsePIValueQuery(int statusCode, IDictionary<string, string> headers, PIValueQuery data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
