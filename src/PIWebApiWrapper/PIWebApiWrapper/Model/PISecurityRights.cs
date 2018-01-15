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

	[Guid("D6B354D1-5FBA-4AA2-8539-C464FA175354")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISecurityRights
	{
		[DispId(1)]
		string OwnerWebId { get; set; }

		[DispId(2)]
		string SecurityItem { get; set; }

		[DispId(3)]
		string UserIdentity { get; set; }

		[DispId(4)]
		object Links { get; set; }

	}

	[Guid("BC71993F-7356-466C-ACAE-FF3213DFC12E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISecurityRights))]
	[ProgId("PIWebAPIWrapper.PISecurityRights")]
	[DataContract]

	public class PISecurityRights : IPISecurityRights
	{
		public PISecurityRights()
		{
		}

		[DataMember(Name = "OwnerWebId", EmitDefaultValue = false)]
		public string OwnerWebId { get; set; }

		[DataMember(Name = "SecurityItem", EmitDefaultValue = false)]
		public string SecurityItem { get; set; }

		[DataMember(Name = "UserIdentity", EmitDefaultValue = false)]
		public string UserIdentity { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
