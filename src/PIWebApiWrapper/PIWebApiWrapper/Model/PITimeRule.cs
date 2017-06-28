// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
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

	[Guid("ECD31D43-35B2-4004-A0DA-2A5C4146CCE9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITimeRule
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
		string Path { get; set; }

		[DispId(6)]
		string ConfigString { get; set; }

		[DispId(7)]
		string ConfigStringStored { get; set; }

		[DispId(8)]
		string DisplayString { get; set; }

		[DispId(9)]
		string EditorType { get; set; }

		[DispId(10)]
		bool IsConfigured { get; set; }

		[DispId(11)]
		bool IsInitializing { get; set; }

		[DispId(12)]
		bool MergeDuplicatedItems { get; set; }

		[DispId(13)]
		string PlugInName { get; set; }

		[DispId(14)]
		object Links { get; set; }

	}

	[Guid("A8FCD47B-AE1D-48A9-B64C-4950BD9C3F92")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITimeRule))]
	[ProgId("PIWebAPIWrapper.PITimeRule")]
	[DataContract]

	public class PITimeRule : IPITimeRule
	{
		public PITimeRule()
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

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "ConfigString", EmitDefaultValue = false)]
		public string ConfigString { get; set; }

		[DataMember(Name = "ConfigStringStored", EmitDefaultValue = false)]
		public string ConfigStringStored { get; set; }

		[DataMember(Name = "DisplayString", EmitDefaultValue = false)]
		public string DisplayString { get; set; }

		[DataMember(Name = "EditorType", EmitDefaultValue = false)]
		public string EditorType { get; set; }

		[DataMember(Name = "IsConfigured", EmitDefaultValue = false)]
		public bool IsConfigured { get; set; }

		[DataMember(Name = "IsInitializing", EmitDefaultValue = false)]
		public bool IsInitializing { get; set; }

		[DataMember(Name = "MergeDuplicatedItems", EmitDefaultValue = false)]
		public bool MergeDuplicatedItems { get; set; }

		[DataMember(Name = "PlugInName", EmitDefaultValue = false)]
		public string PlugInName { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
