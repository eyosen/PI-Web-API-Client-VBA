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
	[Guid("5110CBBB-A857-4059-A54A-5F2EFBCEFACE")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamUpdatesRetrieve
	{
		[DispId(1)]
		PIStreamUpdatesRetrieve Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("97F95C68-EEF3-454D-86CA-67533F3B3590")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamUpdatesRetrieve))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamUpdatesRetrieve")]
	public class ApiResponsePIStreamUpdatesRetrieve : ApiParentResponse, IApiResponsePIStreamUpdatesRetrieve
	{
		public PIStreamUpdatesRetrieve Data { get; set; }
		public ApiResponsePIStreamUpdatesRetrieve(int statusCode, IDictionary<string, string> headers, PIStreamUpdatesRetrieve data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
