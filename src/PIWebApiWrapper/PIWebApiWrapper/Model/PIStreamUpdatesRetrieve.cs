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

	[Guid("EE941216-9B23-4C0E-8C98-E46CD7042ADC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIStreamUpdatesRetrieve
	{
		[DispId(1)]
		string Source { get; set; }

		[DispId(2)]
		string SourceName { get; set; }

		[DispId(3)]
		string SourcePath { get; set; }

		[DispId(4)]
		string RequestedMarker { get; set; }

		[DispId(5)]
		string LatestMarker { get; set; }

		[DispId(6)]
		string Status { get; set; }

		[DispId(7)]
		PIDataPipeEvent[] Events { get; set; }

		[DispId(8)]
		PIErrors Exception { get; set; }

	}

	[Guid("8ACC97A7-67CE-4890-A38D-AB640B62DD7E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIStreamUpdatesRetrieve))]
	[ProgId("PIWebAPIWrapper.PIStreamUpdatesRetrieve")]
	[DataContract]

	public class PIStreamUpdatesRetrieve : IPIStreamUpdatesRetrieve
	{
		public PIStreamUpdatesRetrieve()
		{
		}

		[DataMember(Name = "Source", EmitDefaultValue = false)]
		public string Source { get; set; }

		[DataMember(Name = "SourceName", EmitDefaultValue = false)]
		public string SourceName { get; set; }

		[DataMember(Name = "SourcePath", EmitDefaultValue = false)]
		public string SourcePath { get; set; }

		[DataMember(Name = "RequestedMarker", EmitDefaultValue = false)]
		public string RequestedMarker { get; set; }

		[DataMember(Name = "LatestMarker", EmitDefaultValue = false)]
		public string LatestMarker { get; set; }

		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public string Status { get; set; }

		[DataMember(Name = "Events", EmitDefaultValue = false)]
		public PIDataPipeEvent[] Events { get; set; }

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
