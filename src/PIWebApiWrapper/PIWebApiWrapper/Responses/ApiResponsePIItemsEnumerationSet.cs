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
	[Guid("DB1536A2-EDD4-4339-B8B1-1CA46AD039DB")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsEnumerationSet
	{
		[DispId(1)]
		PIItemsEnumerationSet Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("03371830-6E83-417A-905F-E491A2453411")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsEnumerationSet))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsEnumerationSet")]
	public class ApiResponsePIItemsEnumerationSet : ApiParentResponse, IApiResponsePIItemsEnumerationSet
	{
		public PIItemsEnumerationSet Data { get; set; }
		public ApiResponsePIItemsEnumerationSet(int statusCode, IDictionary<string, string> headers, PIItemsEnumerationSet data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
