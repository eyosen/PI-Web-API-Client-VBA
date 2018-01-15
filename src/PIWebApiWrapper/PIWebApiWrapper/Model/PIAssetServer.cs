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

	[Guid("589F7892-1009-4B34-B5F7-CE9F87BCE7BB")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAssetServer
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Description { get; set; }

		[DispId(5)]
		string Path { get; set; }

		[DispId(6)]
		bool IsConnected { get; set; }

		[DispId(7)]
		string ServerVersion { get; set; }

		[DispId(8)]
		object ExtendedProperties { get; set; }

		[DispId(9)]
		object Links { get; set; }

	}

	[Guid("1F645A25-1411-4644-AAC0-19D84F073235")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAssetServer))]
	[ProgId("PIWebAPIWrapper.PIAssetServer")]
	[DataContract]

	public class PIAssetServer : IPIAssetServer
	{
		public PIAssetServer()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "IsConnected", EmitDefaultValue = false)]
		public bool IsConnected { get; set; }

		[DataMember(Name = "ServerVersion", EmitDefaultValue = false)]
		public string ServerVersion { get; set; }

		[DataMember(Name = "ExtendedProperties", EmitDefaultValue = false)]
		public object ExtendedProperties { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
