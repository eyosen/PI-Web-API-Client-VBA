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

	[Guid("4EDA5D62-AB5B-4659-BCFA-39B6429DCC2D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIEnumerationSetLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Database { get; set; }

		[DispId(3)]
		string DataServer { get; set; }

		[DispId(4)]
		string Values { get; set; }

		[DispId(5)]
		string Security { get; set; }

		[DispId(6)]
		string SecurityEntries { get; set; }

	}

	[Guid("5E9E1EED-2E8D-4CE5-A0BC-F396385E7947")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIEnumerationSetLinks))]
	[ProgId("PIWebAPIWrapper.PIEnumerationSetLinks")]
	[DataContract]

	public class PIEnumerationSetLinks : IPIEnumerationSetLinks
	{
		public PIEnumerationSetLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		[DataMember(Name = "DataServer", EmitDefaultValue = false)]
		public string DataServer { get; set; }

		[DataMember(Name = "Values", EmitDefaultValue = false)]
		public string Values { get; set; }

		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
