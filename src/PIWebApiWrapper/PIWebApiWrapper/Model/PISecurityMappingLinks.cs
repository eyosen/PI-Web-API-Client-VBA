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

	[Guid("210D5F24-6F33-436F-999A-C0FCB9C2CD7D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISecurityMappingLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string AssetServer { get; set; }

		[DispId(3)]
		string SecurityIdentity { get; set; }

		[DispId(4)]
		string Security { get; set; }

		[DispId(5)]
		string SecurityEntries { get; set; }

	}

	[Guid("BC60EDC8-40D7-4827-9304-5F6EA9209A87")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISecurityMappingLinks))]
	[ProgId("PIWebAPIWrapper.PISecurityMappingLinks")]
	[DataContract]

	public class PISecurityMappingLinks : IPISecurityMappingLinks
	{
		public PISecurityMappingLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "AssetServer", EmitDefaultValue = false)]
		public string AssetServer { get; set; }

		[DataMember(Name = "SecurityIdentity", EmitDefaultValue = false)]
		public string SecurityIdentity { get; set; }

		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
