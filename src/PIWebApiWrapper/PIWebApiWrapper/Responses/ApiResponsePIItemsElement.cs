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
	[Guid("94715C86-8E6F-4B1D-9248-0B6CB6B4AD71")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsElement
	{
		[DispId(1)]
		PIItemsElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("496470EE-1A9C-45D2-8E66-0C1B03FB9AB5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsElement")]
	public class ApiResponsePIItemsElement : ApiParentResponse, IApiResponsePIItemsElement
	{
		public PIItemsElement Data { get; set; }
		public ApiResponsePIItemsElement(int statusCode, IDictionary<string, string> headers, PIItemsElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
