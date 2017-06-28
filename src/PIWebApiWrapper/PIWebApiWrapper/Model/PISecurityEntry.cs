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

	[Guid("C086B5BF-ABBD-4C80-9D50-F223426B09E5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISecurityEntry
	{
		[DispId(1)]
		string Name { get; set; }

		[DispId(2)]
		string SecurityIdentityName { get; set; }

		[DispId(3)]
		string[] AllowRights { get; set; }

		[DispId(4)]
		string[] DenyRights { get; set; }

		[DispId(5)]
		object Links { get; set; }

	}

	[Guid("8C9E2946-A713-4E23-9D13-478D44BDD56D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISecurityEntry))]
	[ProgId("PIWebAPIWrapper.PISecurityEntry")]
	[DataContract]

	public class PISecurityEntry : IPISecurityEntry
	{
		public PISecurityEntry()
		{
		}

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "SecurityIdentityName", EmitDefaultValue = false)]
		public string SecurityIdentityName { get; set; }

		[DataMember(Name = "AllowRights", EmitDefaultValue = false)]
		public string[] AllowRights { get; set; }

		[DataMember(Name = "DenyRights", EmitDefaultValue = false)]
		public string[] DenyRights { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
