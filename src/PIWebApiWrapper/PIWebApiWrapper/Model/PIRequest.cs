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
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("544119C3-DE45-423F-B6BF-E2BB08D8097B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIRequest
	{
		[DispId(1)]
		string Method { get; set; }

		[DispId(2)]
		string Resource { get; set; }

		[DispId(3)]
		PIRequestTemplate RequestTemplate { get; set; }

		[DispId(4)]
		string[] Parameters { get; set; }

		[DispId(5)]
		object Headers { get; set; }

		[DispId(6)]
		string Content { get; set; }

		[DispId(7)]
		string[] ParentIds { get; set; }

	}

	[Guid("5A9A20E9-277C-47AF-9D7C-5AE4141C682A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIRequest))]
	[ProgId("PIWebAPIWrapper.PIRequest")]
	[DataContract]

	public class PIRequest : IPIRequest
	{
		public PIRequest()
		{
		}

		[DataMember(Name = "Method", EmitDefaultValue = false)]
		public string Method { get; set; }

		[DataMember(Name = "Resource", EmitDefaultValue = false)]
		public string Resource { get; set; }

		[DataMember(Name = "RequestTemplate", EmitDefaultValue = false)]
		public PIRequestTemplate RequestTemplate { get; set; }

		[DataMember(Name = "Parameters", EmitDefaultValue = false)]
		public string[] Parameters { get; set; }

		[DataMember(Name = "Headers", EmitDefaultValue = false)]
		public object Headers { get; set; }

		[DataMember(Name = "Content", EmitDefaultValue = false)]
		public string Content { get; set; }

		[DataMember(Name = "ParentIds", EmitDefaultValue = false)]
		public string[] ParentIds { get; set; }

	}
}
