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

	[Guid("E5B68070-BE1A-480B-9850-C38DE6FB2E67")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIUnitLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Class { get; set; }

		[DispId(3)]
		string ReferenceUnit { get; set; }

	}

	[Guid("1E1B5E13-E544-45B4-B868-E0A31EA0AE88")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIUnitLinks))]
	[ProgId("PIWebAPIWrapper.PIUnitLinks")]
	[DataContract]

	public class PIUnitLinks : IPIUnitLinks
	{
		public PIUnitLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Class", EmitDefaultValue = false)]
		public string Class { get; set; }

		[DataMember(Name = "ReferenceUnit", EmitDefaultValue = false)]
		public string ReferenceUnit { get; set; }

	}
}
