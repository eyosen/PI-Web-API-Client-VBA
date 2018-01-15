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
	[Guid("87E8F3D7-B897-411B-9499-17D8F5E5B4E1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamValue
	{
		[DispId(1)]
		PIItemsStreamValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("9EDF9ED2-E6E8-413F-9030-0AAF57504F7E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamValue")]
	public class ApiResponsePIItemsStreamValue : ApiParentResponse, IApiResponsePIItemsStreamValue
	{
		public PIItemsStreamValue Data { get; set; }
		public ApiResponsePIItemsStreamValue(int statusCode, IDictionary<string, string> headers, PIItemsStreamValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
