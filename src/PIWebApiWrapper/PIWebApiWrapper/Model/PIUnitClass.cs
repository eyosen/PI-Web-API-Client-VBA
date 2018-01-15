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

	[Guid("A70049E9-3284-4E1D-AC20-968D663ED854")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIUnitClass
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
		string CanonicalUnitName { get; set; }

		[DispId(6)]
		string CanonicalUnitAbbreviation { get; set; }

		[DispId(7)]
		string Path { get; set; }

		[DispId(8)]
		object Links { get; set; }

	}

	[Guid("4A126BBB-907D-46A6-8310-6E5DD0AE7064")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIUnitClass))]
	[ProgId("PIWebAPIWrapper.PIUnitClass")]
	[DataContract]

	public class PIUnitClass : IPIUnitClass
	{
		public PIUnitClass()
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

		[DataMember(Name = "CanonicalUnitName", EmitDefaultValue = false)]
		public string CanonicalUnitName { get; set; }

		[DataMember(Name = "CanonicalUnitAbbreviation", EmitDefaultValue = false)]
		public string CanonicalUnitAbbreviation { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
