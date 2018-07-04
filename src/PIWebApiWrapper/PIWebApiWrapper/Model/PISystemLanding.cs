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

	[Guid("99CEE8DB-64B5-4934-8950-84B3D46C904C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISystemLanding
	{
		[DispId(1)]
		string ProductTitle { get; set; }

		[DispId(2)]
		string ProductVersion { get; set; }

		[DispId(3)]
		PISystemLandingLinks Links { get; set; }

		[DispId(4)]
		PIWebException WebException { get; set; }

	}

	[Guid("396C7B98-563F-4520-91A1-D7DA91D6AC5E")]
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
		public PISystemLandingLinks Links { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
