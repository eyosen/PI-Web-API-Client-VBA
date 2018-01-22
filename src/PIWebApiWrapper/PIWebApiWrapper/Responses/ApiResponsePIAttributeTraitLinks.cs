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
	[Guid("62110AE3-B650-4C5B-8FFB-C8F57F7A300C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeTraitLinks
	{
		[DispId(1)]
		PIAttributeTraitLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1281B7A7-62A3-4948-AD45-2C5DE9497982")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeTraitLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeTraitLinks")]
	public class ApiResponsePIAttributeTraitLinks : ApiParentResponse, IApiResponsePIAttributeTraitLinks
	{
		public PIAttributeTraitLinks Data { get; set; }
		public ApiResponsePIAttributeTraitLinks(int statusCode, IDictionary<string, string> headers, PIAttributeTraitLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
