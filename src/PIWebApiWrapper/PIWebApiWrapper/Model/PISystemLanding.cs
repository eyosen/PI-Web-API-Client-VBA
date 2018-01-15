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

	[Guid("6A764835-FC4C-4818-B243-565010C0A8C6")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISystemLanding
	{
		[DispId(1)]
		string ProductTitle { get; set; }

		[DispId(2)]
		string ProductVersion { get; set; }

		[DispId(3)]
		object Links { get; set; }

	}

	[Guid("DCB65BDC-21DA-4F0B-8B4D-D8E510C74ADF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISystemLanding))]
	[ProgId("PIWebAPIWrapper.PISystemLanding")]
	[DataContract]

	public class PISystemLanding : IPISystemLanding
	{
		public PISystemLanding()
		{
		}

		[DataMember(Name = "ProductTitle", EmitDefaultValue = false)]
		public string ProductTitle { get; set; }

		[DataMember(Name = "ProductVersion", EmitDefaultValue = false)]
		public string ProductVersion { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
