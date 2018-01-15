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

	[Guid("92B98B21-4628-48E0-AD7B-E1F1FB57029F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIStreamValue
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Name { get; set; }

		[DispId(3)]
		string Path { get; set; }

		[DispId(4)]
		PITimedValue Value { get; set; }

		[DispId(5)]
		object Links { get; set; }

	}

	[Guid("FD260849-3023-4AE1-9510-BE73FA5D0D72")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIStreamValue))]
	[ProgId("PIWebAPIWrapper.PIStreamValue")]
	[DataContract]

	public class PIStreamValue : IPIStreamValue
	{
		public PIStreamValue()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public PITimedValue Value { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
