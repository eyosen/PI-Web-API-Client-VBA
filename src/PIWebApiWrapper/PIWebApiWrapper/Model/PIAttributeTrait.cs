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

	[Guid("EBCFEC78-5188-4B48-8C46-0D7235488EB4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAttributeTrait
	{
		[DispId(1)]
		string Name { get; set; }

		[DispId(2)]
		string Abbreviation { get; set; }

		[DispId(3)]
		bool AllowChildAttributes { get; set; }

		[DispId(4)]
		bool AllowDuplicates { get; set; }

		[DispId(5)]
		bool IsAllowedOnRootAttribute { get; set; }

		[DispId(6)]
		bool IsTypeInherited { get; set; }

		[DispId(7)]
		bool IsUOMInherited { get; set; }

		[DispId(8)]
		bool RequireNumeric { get; set; }

		[DispId(9)]
		bool RequireString { get; set; }

		[DispId(10)]
		object Links { get; set; }

	}

	[Guid("EDB00468-72C5-4DF2-84FC-A17EA19F6782")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAttributeTrait))]
	[ProgId("PIWebAPIWrapper.PIAttributeTrait")]
	[DataContract]

	public class PIAttributeTrait : IPIAttributeTrait
	{
		public PIAttributeTrait()
		{
		}

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Abbreviation", EmitDefaultValue = false)]
		public string Abbreviation { get; set; }

		[DataMember(Name = "AllowChildAttributes", EmitDefaultValue = false)]
		public bool AllowChildAttributes { get; set; }

		[DataMember(Name = "AllowDuplicates", EmitDefaultValue = false)]
		public bool AllowDuplicates { get; set; }

		[DataMember(Name = "IsAllowedOnRootAttribute", EmitDefaultValue = false)]
		public bool IsAllowedOnRootAttribute { get; set; }

		[DataMember(Name = "IsTypeInherited", EmitDefaultValue = false)]
		public bool IsTypeInherited { get; set; }

		[DataMember(Name = "IsUOMInherited", EmitDefaultValue = false)]
		public bool IsUOMInherited { get; set; }

		[DataMember(Name = "RequireNumeric", EmitDefaultValue = false)]
		public bool RequireNumeric { get; set; }

		[DataMember(Name = "RequireString", EmitDefaultValue = false)]
		public bool RequireString { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
