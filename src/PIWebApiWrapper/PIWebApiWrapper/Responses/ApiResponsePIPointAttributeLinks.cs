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
	[Guid("37674F2B-61DF-47AE-A89E-038F416B681C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPointAttributeLinks
	{
		[DispId(1)]
		PIPointAttributeLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("EE8454A2-9F59-4021-971B-3600D33DD263")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPointAttributeLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPointAttributeLinks")]
	public class ApiResponsePIPointAttributeLinks : ApiParentResponse, IApiResponsePIPointAttributeLinks
	{
		public PIPointAttributeLinks Data { get; set; }
		public ApiResponsePIPointAttributeLinks(int statusCode, IDictionary<string, string> headers, PIPointAttributeLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
