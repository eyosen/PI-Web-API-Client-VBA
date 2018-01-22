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

	[Guid("0A829671-B06F-46D2-BCFB-5E48658BE68F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITableLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Database { get; set; }

		[DispId(3)]
		string Data { get; set; }

		[DispId(4)]
		string Categories { get; set; }

		[DispId(5)]
		string Security { get; set; }

		[DispId(6)]
		string SecurityEntries { get; set; }

	}

	[Guid("425BAC61-E36A-4663-BAF2-E909F51E035B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITableLinks))]
	[ProgId("PIWebAPIWrapper.PITableLinks")]
	[DataContract]

	public class PITableLinks : IPITableLinks
	{
		public PITableLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		[DataMember(Name = "Data", EmitDefaultValue = false)]
		public string Data { get; set; }

		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
