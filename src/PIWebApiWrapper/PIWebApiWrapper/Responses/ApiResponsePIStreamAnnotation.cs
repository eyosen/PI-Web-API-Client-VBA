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
	[Guid("B025B525-14AD-4DA5-AE73-B3A33695988A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamAnnotation
	{
		[DispId(1)]
		PIStreamAnnotation Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("4D5FAB70-680F-46CB-A12C-AC9AB8C71F76")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamAnnotation))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamAnnotation")]
	public class ApiResponsePIStreamAnnotation : ApiParentResponse, IApiResponsePIStreamAnnotation
	{
		public PIStreamAnnotation Data { get; set; }
		public ApiResponsePIStreamAnnotation(int statusCode, IDictionary<string, string> headers, PIStreamAnnotation data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
