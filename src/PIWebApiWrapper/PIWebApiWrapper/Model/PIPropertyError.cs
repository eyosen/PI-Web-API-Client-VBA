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

	[Guid("DFF43B76-09DA-414E-A6DC-3B8F30AF2048")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIPropertyError
	{
		[DispId(1)]
		string FieldName { get; set; }

		[DispId(2)]
		string[] Message { get; set; }

	}

	[Guid("93F3B7AA-25CE-4EDD-B765-6B9ED39FF5C4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIPropertyError))]
	[ProgId("PIWebAPIWrapper.PIPropertyError")]
	[DataContract]

	public class PIPropertyError : IPIPropertyError
	{
		public PIPropertyError()
		{
		}

		[DataMember(Name = "FieldName", EmitDefaultValue = false)]
		public string FieldName { get; set; }

		[DataMember(Name = "Message", EmitDefaultValue = false)]
		public string[] Message { get; set; }

	}
}
