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
	[Guid("C04F0978-C52D-43F3-AC2F-C429DB707A5E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurity
	{
		[DispId(1)]
		PISecurity Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("17416B1D-E0E2-4C7D-8C76-A797D4F975AF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurity))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurity")]
	public class ApiResponsePISecurity : ApiParentResponse, IApiResponsePISecurity
	{
		public PISecurity Data { get; set; }
		public ApiResponsePISecurity(int statusCode, IDictionary<string, string> headers, PISecurity data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
