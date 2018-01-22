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
	[Guid("6E7BD09F-D3C3-42B8-8C8B-EEDD2F33BF34")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPropertyError
	{
		[DispId(1)]
		PIPropertyError Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("248551D3-2708-4811-B184-D5DC79E68B3D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPropertyError))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPropertyError")]
	public class ApiResponsePIPropertyError : ApiParentResponse, IApiResponsePIPropertyError
	{
		public PIPropertyError Data { get; set; }
		public ApiResponsePIPropertyError(int statusCode, IDictionary<string, string> headers, PIPropertyError data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
