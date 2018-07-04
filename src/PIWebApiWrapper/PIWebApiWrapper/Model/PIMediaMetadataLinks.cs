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

	[Guid("5242C90F-95D8-4E57-BB04-57D229E6286F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIMediaMetadataLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Owner { get; set; }

		[DispId(3)]
		string MediaData { get; set; }

	}

	[Guid("3B8C8916-60ED-41EA-9FED-AE07CA53B0C8")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIMediaMetadataLinks))]
	[ProgId("PIWebAPIWrapper.PIMediaMetadataLinks")]
	[DataContract]

	public class PIMediaMetadataLinks : IPIMediaMetadataLinks
	{
		public PIMediaMetadataLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Owner", EmitDefaultValue = false)]
		public string Owner { get; set; }

		[DataMember(Name = "MediaData", EmitDefaultValue = false)]
		public string MediaData { get; set; }

	}
}
