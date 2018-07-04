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
	[Guid("6BCBAA50-C5E4-48ED-8589-FC50E0FF1C60")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIMediaMetadataLinks
	{
		[DispId(1)]
		PIMediaMetadataLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5CB3E18A-8403-4517-A714-5A604C94D1C9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIMediaMetadataLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIMediaMetadataLinks")]
	public class ApiResponsePIMediaMetadataLinks : ApiParentResponse, IApiResponsePIMediaMetadataLinks
	{
		public PIMediaMetadataLinks Data { get; set; }
		public ApiResponsePIMediaMetadataLinks(int statusCode, IDictionary<string, string> headers, PIMediaMetadataLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
