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
	[Guid("8AC9CE4F-AE34-4CA7-BC1B-1FA6BC654ED7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAssetServerLinks
	{
		[DispId(1)]
		PIAssetServerLinks Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("006DBD83-A6B2-481B-B52F-B348D5D0AFFE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAssetServerLinks))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAssetServerLinks")]
	public class ApiResponsePIAssetServerLinks : ApiParentResponse, IApiResponsePIAssetServerLinks
	{
		public PIAssetServerLinks Data { get; set; }
		public ApiResponsePIAssetServerLinks(int statusCode, IDictionary<string, string> headers, PIAssetServerLinks data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
