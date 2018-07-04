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

	[Guid("BF134131-A664-4456-87EB-141AE10691B4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPILandingLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string AssetServers { get; set; }

		[DispId(3)]
		string DataServers { get; set; }

		[DispId(4)]
		string PIDirectory { get; set; }

		[DispId(5)]
		string Search { get; set; }

		[DispId(6)]
		string System { get; set; }

	}

	[Guid("163FCE28-5C46-4D3E-82EF-2C713F337905")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPILandingLinks))]
	[ProgId("PIWebAPIWrapper.PILandingLinks")]
	[DataContract]

	public class PILandingLinks : IPILandingLinks
	{
		public PILandingLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "AssetServers", EmitDefaultValue = false)]
		public string AssetServers { get; set; }

		[DataMember(Name = "DataServers", EmitDefaultValue = false)]
		public string DataServers { get; set; }

		[DataMember(Name = "PIDirectory", EmitDefaultValue = false)]
		public string PIDirectory { get; set; }

		[DataMember(Name = "Search", EmitDefaultValue = false)]
		public string Search { get; set; }

		[DataMember(Name = "System", EmitDefaultValue = false)]
		public string System { get; set; }

	}
}
