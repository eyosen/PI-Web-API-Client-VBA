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

	[Guid("FC8AFC85-FB5B-4DA9-B846-4A882DC492B9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIElement
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
		string TemplateName { get; set; }

		[DispId(7)]
		bool HasChildren { get; set; }

		[DispId(8)]
		string[] CategoryNames { get; set; }

		[DispId(9)]
		object ExtendedProperties { get; set; }

		[DispId(10)]
		object Links { get; set; }

	}

	[Guid("75BBE69C-5D51-43FA-8333-855B362E6283")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIElement))]
	[ProgId("PIWebAPIWrapper.PIElement")]
	[DataContract]

	public class PIElement : IPIElement
	{
		public PIElement()
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

		[DataMember(Name = "TemplateName", EmitDefaultValue = false)]
		public string TemplateName { get; set; }

		[DataMember(Name = "HasChildren", EmitDefaultValue = false)]
		public bool HasChildren { get; set; }

		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public string[] CategoryNames { get; set; }

		[DataMember(Name = "ExtendedProperties", EmitDefaultValue = false)]
		public object ExtendedProperties { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
