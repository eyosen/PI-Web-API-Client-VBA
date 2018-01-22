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

	[Guid("B6D71000-89DE-403A-A5C1-B6B653E0CDBF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIUnitClassLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string CanonicalUnit { get; set; }

		[DispId(3)]
		string Units { get; set; }

		[DispId(4)]
		string AssetServer { get; set; }

	}

	[Guid("F5854E6B-22E1-4899-8138-E078A4EB4C19")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIUnitClassLinks))]
	[ProgId("PIWebAPIWrapper.PIUnitClassLinks")]
	[DataContract]

	public class PIUnitClassLinks : IPIUnitClassLinks
	{
		public PIUnitClassLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "CanonicalUnit", EmitDefaultValue = false)]
		public string CanonicalUnit { get; set; }

		[DataMember(Name = "Units", EmitDefaultValue = false)]
		public string Units { get; set; }

		[DataMember(Name = "AssetServer", EmitDefaultValue = false)]
		public string AssetServer { get; set; }

	}
}
