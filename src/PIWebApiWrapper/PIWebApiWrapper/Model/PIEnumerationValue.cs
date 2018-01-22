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

	[Guid("D2A77685-E4F1-45BC-AD4A-E67964E37B73")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIEnumerationValue
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Description { get; set; }

		[DispId(5)]
		int Value { get; set; }

		[DispId(6)]
		string Path { get; set; }

		[DispId(7)]
		string Parent { get; set; }

		[DispId(8)]
		PIEnumerationValueLinks Links { get; set; }

		[DispId(9)]
		bool SerializeWebId { get; set; }

		[DispId(10)]
		bool SerializeId { get; set; }

		[DispId(11)]
		bool SerializeDescription { get; set; }

		[DispId(12)]
		bool SerializePath { get; set; }

		[DispId(13)]
		bool SerializeLinks { get; set; }

		[DispId(14)]
		PIWebException WebException { get; set; }

	}

	[Guid("F8AC211B-F439-4D05-A3D0-14BD3AF3FEE5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIEnumerationValue))]
	[ProgId("PIWebAPIWrapper.PIEnumerationValue")]
	[DataContract]

	public class PIEnumerationValue : IPIEnumerationValue
	{
		public PIEnumerationValue()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public int Value { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIEnumerationValueLinks Links { get; set; }

		[DataMember(Name = "SerializeWebId", EmitDefaultValue = false)]
		public bool SerializeWebId { get; set; }

		[DataMember(Name = "SerializeId", EmitDefaultValue = false)]
		public bool SerializeId { get; set; }

		[DataMember(Name = "SerializeDescription", EmitDefaultValue = false)]
		public bool SerializeDescription { get; set; }

		[DataMember(Name = "SerializePath", EmitDefaultValue = false)]
		public bool SerializePath { get; set; }

		[DataMember(Name = "SerializeLinks", EmitDefaultValue = false)]
		public bool SerializeLinks { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
