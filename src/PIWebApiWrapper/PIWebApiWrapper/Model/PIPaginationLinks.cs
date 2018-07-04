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

	[Guid("5644F181-1A21-40BB-82C4-D0D1579FAE49")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIPaginationLinks
	{
		[DispId(1)]
		string First { get; set; }

		[DispId(2)]
		string Previous { get; set; }

		[DispId(3)]
		string Next { get; set; }

		[DispId(4)]
		string Last { get; set; }

	}

	[Guid("D40B9FED-B554-4FBC-B54F-915CEEB113E4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIPaginationLinks))]
	[ProgId("PIWebAPIWrapper.PIPaginationLinks")]
	[DataContract]

	public class PIPaginationLinks : IPIPaginationLinks
	{
		public PIPaginationLinks()
		{
		}

		[DataMember(Name = "First", EmitDefaultValue = false)]
		public string First { get; set; }

		[DataMember(Name = "Previous", EmitDefaultValue = false)]
		public string Previous { get; set; }

		[DataMember(Name = "Next", EmitDefaultValue = false)]
		public string Next { get; set; }

		[DataMember(Name = "Last", EmitDefaultValue = false)]
		public string Last { get; set; }

	}
}
