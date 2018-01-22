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

	[Guid("7FA53FFC-F8EE-4380-B6BA-8B7DD98C2DEC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIPropertyError
	{
		[DispId(1)]
		string FieldName { get; set; }

		[DispId(2)]
		string[] Message { get; set; }

	}

	[Guid("B18644C1-19D4-4E0E-BA2F-2E2857D63697")]
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
