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
	[Guid("B7B7BA36-C340-49FF-B1BB-980EA3B5195C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityMapping
	{
		[DispId(1)]
		PIItemsSecurityMapping Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C95ED559-317A-474E-A7B0-5E8A5078A47C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSecurityMapping))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSecurityMapping")]
	public class ApiResponsePIItemsSecurityMapping : ApiParentResponse, IApiResponsePIItemsSecurityMapping
	{
		public PIItemsSecurityMapping Data { get; set; }
		public ApiResponsePIItemsSecurityMapping(int statusCode, IDictionary<string, string> headers, PIItemsSecurityMapping data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
