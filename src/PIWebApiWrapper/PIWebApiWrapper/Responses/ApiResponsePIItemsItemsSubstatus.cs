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
	[Guid("144860CA-9591-4835-B940-D6BFF30DF991")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemsSubstatus
	{
		[DispId(1)]
		PIItemsItemsSubstatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("14128180-3799-46B3-BF52-BF9DFA0518EC")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemsSubstatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemsSubstatus")]
	public class ApiResponsePIItemsItemsSubstatus : ApiParentResponse, IApiResponsePIItemsItemsSubstatus
	{
		public PIItemsItemsSubstatus Data { get; set; }
		public ApiResponsePIItemsItemsSubstatus(int statusCode, IDictionary<string, string> headers, PIItemsItemsSubstatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
