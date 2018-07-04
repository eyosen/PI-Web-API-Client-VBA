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
	[Guid("99B51295-3B84-474D-9730-27C426C3FFE4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamUpdatesRetrieve
	{
		[DispId(1)]
		PIItemsStreamUpdatesRetrieve Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("9123C29C-AA52-423A-9D78-6E06A6B5050A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamUpdatesRetrieve))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamUpdatesRetrieve")]
	public class ApiResponsePIItemsStreamUpdatesRetrieve : ApiParentResponse, IApiResponsePIItemsStreamUpdatesRetrieve
	{
		public PIItemsStreamUpdatesRetrieve Data { get; set; }
		public ApiResponsePIItemsStreamUpdatesRetrieve(int statusCode, IDictionary<string, string> headers, PIItemsStreamUpdatesRetrieve data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
