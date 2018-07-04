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

	[Guid("D0774C87-D5AA-47F7-89F2-2BAAA509DCAC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAttribute
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
		string Type { get; set; }

		[DispId(7)]
		string TypeQualifier { get; set; }

		[DispId(8)]
		string DefaultUnitsName { get; set; }

		[DispId(9)]
		int DisplayDigits { get; set; }

		[DispId(10)]
		string DataReferencePlugIn { get; set; }

		[DispId(11)]
		string ConfigString { get; set; }

		[DispId(12)]
		bool IsConfigurationItem { get; set; }

		[DispId(13)]
		bool IsExcluded { get; set; }

		[DispId(14)]
		bool IsHidden { get; set; }

		[DispId(15)]
		bool IsManualDataEntry { get; set; }

		[DispId(16)]
		bool HasChildren { get; set; }

		[DispId(17)]
		string[] CategoryNames { get; set; }

		[DispId(18)]
		bool Step { get; set; }

		[DispId(19)]
		string TraitName { get; set; }

		[DispId(20)]
		string DefaultUnitsNameAbbreviation { get; set; }

		[DispId(21)]
		double Span { get; set; }

		[DispId(22)]
		double Zero { get; set; }

		[DispId(23)]
		PIAttributeLinks Links { get; set; }

		[DispId(24)]
		PIWebException WebException { get; set; }

	}

	[Guid("1EF21DE3-15AC-421F-B1CF-D66D3C0189A3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAttribute))]
	[ProgId("PIWebAPIWrapper.PIAttribute")]
	[DataContract]

	public class PIAttribute : IPIAttribute
	{
		public PIAttribute()
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

		[DataMember(Name = "Type", EmitDefaultValue = false)]
		public string Type { get; set; }

		[DataMember(Name = "TypeQualifier", EmitDefaultValue = false)]
		public string TypeQualifier { get; set; }

		[DataMember(Name = "DefaultUnitsName", EmitDefaultValue = false)]
		public string DefaultUnitsName { get; set; }

		[DataMember(Name = "DisplayDigits", EmitDefaultValue = false)]
		public int DisplayDigits { get; set; }

		[DataMember(Name = "DataReferencePlugIn", EmitDefaultValue = false)]
		public string DataReferencePlugIn { get; set; }

		[DataMember(Name = "ConfigString", EmitDefaultValue = false)]
		public string ConfigString { get; set; }

		[DataMember(Name = "IsConfigurationItem", EmitDefaultValue = false)]
		public bool IsConfigurationItem { get; set; }

		[DataMember(Name = "IsExcluded", EmitDefaultValue = false)]
		public bool IsExcluded { get; set; }

		[DataMember(Name = "IsHidden", EmitDefaultValue = false)]
		public bool IsHidden { get; set; }

		[DataMember(Name = "IsManualDataEntry", EmitDefaultValue = false)]
		public bool IsManualDataEntry { get; set; }

		[DataMember(Name = "HasChildren", EmitDefaultValue = false)]
		public bool HasChildren { get; set; }

		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public string[] CategoryNames { get; set; }

		[DataMember(Name = "Step", EmitDefaultValue = false)]
		public bool Step { get; set; }

		[DataMember(Name = "TraitName", EmitDefaultValue = false)]
		public string TraitName { get; set; }

		[DataMember(Name = "DefaultUnitsNameAbbreviation", EmitDefaultValue = false)]
		public string DefaultUnitsNameAbbreviation { get; set; }

		[DataMember(Name = "Span", EmitDefaultValue = false)]
		public double Span { get; set; }

		[DataMember(Name = "Zero", EmitDefaultValue = false)]
		public double Zero { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public PIAttributeLinks Links { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
