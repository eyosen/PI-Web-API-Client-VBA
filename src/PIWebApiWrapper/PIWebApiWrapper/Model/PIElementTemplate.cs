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

	[Guid("AE4D6613-E05A-4F70-894C-96217828144F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIElementTemplate
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
		bool AllowElementToExtend { get; set; }

		[DispId(7)]
		string BaseTemplate { get; set; }

		[DispId(8)]
		string InstanceType { get; set; }

		[DispId(9)]
		string NamingPattern { get; set; }

		[DispId(10)]
		string[] CategoryNames { get; set; }

		[DispId(11)]
		object ExtendedProperties { get; set; }

		[DispId(12)]
		string Severity { get; set; }

		[DispId(13)]
		bool CanBeAcknowledged { get; set; }

		[DispId(14)]
		PIElementTemplateLinks Links { get; set; }

		[DispId(15)]
		PIWebException WebException { get; set; }

	}

	[Guid("FF685856-6BC7-4929-8018-4E1D76CD00CF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIElementTemplate))]
	[ProgId("PIWebAPIWrapper.PIElementTemplate")]
	[DataContract]

	public class PIElementTemplate : IPIElementTemplate
	{
		public PIElementTemplate()
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

		[DataMember(Name = "AllowElementToExtend", EmitDefaultValue = false)]
		public bool AllowElementToExtend { get; set; }

		[DataMember(Name = "BaseTemplate", EmitDefaultValue = false)]
		public string BaseTemplate { get; set; }

		[DataMember(Name = "InstanceType", EmitDefaultValue = false)]
		public string InstanceType { get; set; }

		[DataMember(Name = "NamingPattern", EmitDefaultValue = false)]
		public string NamingPattern { get; set; }

		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public string[] CategoryNames { get; set; }

		[DataMember(Name = "ExtendedProperties", EmitDefaultValue = false)]
		public object ExtendedProperties { get; set; }

		[DataMember(Name = "Severity", EmitDefaultValue = false)]
		public string Severity { get; set; }

		[DataMember(Name = "CanBeAcknowledged", EmitDefaultValue = false)]
		public bool CanBeAcknowledged { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIElementTemplateLinks Links { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
