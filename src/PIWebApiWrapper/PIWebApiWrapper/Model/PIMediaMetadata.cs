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

	[Guid("7769B330-08A1-45B6-AB35-2F34E3B32A38")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIMediaMetadata
	{
		[DispId(1)]
		string Author { get; set; }

		[DispId(2)]
		string ChangeDate { get; set; }

		[DispId(3)]
		string Description { get; set; }

		[DispId(4)]
		string Name { get; set; }

		[DispId(5)]
		double Size { get; set; }

		[DispId(6)]
		PIMediaMetadataLinks Links { get; set; }

		[DispId(7)]
		PIWebException WebException { get; set; }

	}

	[Guid("76CA78D1-C15C-4B50-9C76-485FC2E063ED")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIMediaMetadata))]
	[ProgId("PIWebAPIWrapper.PIMediaMetadata")]
	[DataContract]

	public class PIMediaMetadata : IPIMediaMetadata
	{
		public PIMediaMetadata()
		{
		}

		[DataMember(Name = "Author", EmitDefaultValue = false)]
		public string Author { get; set; }

		[DataMember(Name = "ChangeDate", EmitDefaultValue = false)]
		public string ChangeDate { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Size", EmitDefaultValue = false)]
		public double Size { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIMediaMetadataLinks Links { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
