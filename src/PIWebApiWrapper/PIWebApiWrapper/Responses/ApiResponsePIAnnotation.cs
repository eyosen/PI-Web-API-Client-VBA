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
	[Guid("DC4E54B8-7A90-48D2-9E0F-3214335486CD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnnotation
	{
		[DispId(1)]
		PIAnnotation Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("6A20300E-204B-4EE9-8CDD-6FB8A27FC041")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnnotation))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnnotation")]
	public class ApiResponsePIAnnotation : ApiParentResponse, IApiResponsePIAnnotation
	{
		public PIAnnotation Data { get; set; }
		public ApiResponsePIAnnotation(int statusCode, IDictionary<string, string> headers, PIAnnotation data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
