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
	[Guid("C66A6A27-D516-4820-8135-AF74ACFE9B1E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIChannelInstance
	{
		[DispId(1)]
		PIChannelInstance Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("764E0DBC-A4CC-4C2B-AD65-630B55E04149")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIChannelInstance))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIChannelInstance")]
	public class ApiResponsePIChannelInstance : ApiParentResponse, IApiResponsePIChannelInstance
	{
		public PIChannelInstance Data { get; set; }
		public ApiResponsePIChannelInstance(int statusCode, IDictionary<string, string> headers, PIChannelInstance data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
