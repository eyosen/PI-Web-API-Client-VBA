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

	[Guid("9E92DAAD-608A-49A8-A4EB-B2960CFEDC85")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIStreamUpdatesRegister
	{
		[DispId(1)]
		string Status { get; set; }

		[DispId(2)]
		string Source { get; set; }

		[DispId(3)]
		string SourceName { get; set; }

		[DispId(4)]
		string SourcePath { get; set; }

		[DispId(5)]
		string LatestMarker { get; set; }

		[DispId(6)]
		PIErrors Exception { get; set; }

	}

	[Guid("15AA52E1-0008-4D40-A465-35705B9875E3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIStreamUpdatesRegister))]
	[ProgId("PIWebAPIWrapper.PIStreamUpdatesRegister")]
	[DataContract]

	public class PIStreamUpdatesRegister : IPIStreamUpdatesRegister
	{
		public PIStreamUpdatesRegister()
		{
		}

		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public string Status { get; set; }

		[DataMember(Name = "Source", EmitDefaultValue = false)]
		public string Source { get; set; }

		[DataMember(Name = "SourceName", EmitDefaultValue = false)]
		public string SourceName { get; set; }

		[DataMember(Name = "SourcePath", EmitDefaultValue = false)]
		public string SourcePath { get; set; }

		[DataMember(Name = "LatestMarker", EmitDefaultValue = false)]
		public string LatestMarker { get; set; }

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
