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
	[Guid("1AC52D76-4D34-4868-84AB-9278B786F07C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIDataPipeEvent
	{
		[DispId(1)]
		PIDataPipeEvent Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("079C3093-2052-4CAC-A9F3-DEBBFB4D508D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIDataPipeEvent))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIDataPipeEvent")]
	public class ApiResponsePIDataPipeEvent : ApiParentResponse, IApiResponsePIDataPipeEvent
	{
		public PIDataPipeEvent Data { get; set; }
		public ApiResponsePIDataPipeEvent(int statusCode, IDictionary<string, string> headers, PIDataPipeEvent data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
