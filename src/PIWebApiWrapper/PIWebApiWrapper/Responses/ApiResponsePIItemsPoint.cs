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
	[Guid("E988B969-DED1-4428-9ABB-1FAA551EE146")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsPoint
	{
		[DispId(1)]
		PIItemsPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("69FF0BD7-23AE-415B-A7F7-9B98BF1F1C69")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsPoint))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsPoint")]
	public class ApiResponsePIItemsPoint : ApiParentResponse, IApiResponsePIItemsPoint
	{
		public PIItemsPoint Data { get; set; }
		public ApiResponsePIItemsPoint(int statusCode, IDictionary<string, string> headers, PIItemsPoint data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
