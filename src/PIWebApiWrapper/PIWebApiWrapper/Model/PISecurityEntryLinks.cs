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

	[Guid("C95CFA5D-6E44-4CEE-88B8-46FA7A5E5C32")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISecurityEntryLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string SecurableObject { get; set; }

		[DispId(3)]
		string SecurityIdentity { get; set; }

	}

	[Guid("A82471A2-7A7D-4EA1-A6C7-CA1200461311")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISecurityEntryLinks))]
	[ProgId("PIWebAPIWrapper.PISecurityEntryLinks")]
	[DataContract]

	public class PISecurityEntryLinks : IPISecurityEntryLinks
	{
		public PISecurityEntryLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "SecurableObject", EmitDefaultValue = false)]
		public string SecurableObject { get; set; }

		[DataMember(Name = "SecurityIdentity", EmitDefaultValue = false)]
		public string SecurityIdentity { get; set; }

	}
}
