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

	[Guid("E99CD1BD-CEF5-430A-8A55-6DE5DD808FA2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISystemLandingLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string CacheInstances { get; set; }

		[DispId(3)]
		string Configuration { get; set; }

		[DispId(4)]
		string UserInfo { get; set; }

		[DispId(5)]
		string Versions { get; set; }

		[DispId(6)]
		string Status { get; set; }

	}

	[Guid("7FC07C72-3BEC-44E0-ABA6-29516211335A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISystemLandingLinks))]
	[ProgId("PIWebAPIWrapper.PISystemLandingLinks")]
	[DataContract]

	public class PISystemLandingLinks : IPISystemLandingLinks
	{
		public PISystemLandingLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "CacheInstances", EmitDefaultValue = false)]
		public string CacheInstances { get; set; }

		[DataMember(Name = "Configuration", EmitDefaultValue = false)]
		public string Configuration { get; set; }

		[DataMember(Name = "UserInfo", EmitDefaultValue = false)]
		public string UserInfo { get; set; }

		[DataMember(Name = "Versions", EmitDefaultValue = false)]
		public string Versions { get; set; }

		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public string Status { get; set; }

	}
}
