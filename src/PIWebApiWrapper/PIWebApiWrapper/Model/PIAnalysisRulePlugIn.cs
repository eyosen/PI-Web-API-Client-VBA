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

	[Guid("B24067B7-3CB4-4B4A-9642-80405AD9B4EF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAnalysisRulePlugIn
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
		string AssemblyFileName { get; set; }

		[DispId(7)]
		string AssemblyID { get; set; }

		[DispId(8)]
		string[] AssemblyLoadProperties { get; set; }

		[DispId(9)]
		string AssemblyTime { get; set; }

		[DispId(10)]
		int CompatibilityVersion { get; set; }

		[DispId(11)]
		bool IsBrowsable { get; set; }

		[DispId(12)]
		bool IsNonEditableConfig { get; set; }

		[DispId(13)]
		string LoadedAssemblyTime { get; set; }

		[DispId(14)]
		string LoadedVersion { get; set; }

		[DispId(15)]
		string Version { get; set; }

		[DispId(16)]
		object Links { get; set; }

	}

	[Guid("61E4E277-4664-49BC-BEC3-2F48D89558A3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAnalysisRulePlugIn))]
	[ProgId("PIWebAPIWrapper.PIAnalysisRulePlugIn")]
	[DataContract]

	public class PIAnalysisRulePlugIn : IPIAnalysisRulePlugIn
	{
		public PIAnalysisRulePlugIn()
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

		[DataMember(Name = "AssemblyFileName", EmitDefaultValue = false)]
		public string AssemblyFileName { get; set; }

		[DataMember(Name = "AssemblyID", EmitDefaultValue = false)]
		public string AssemblyID { get; set; }

		[DataMember(Name = "AssemblyLoadProperties", EmitDefaultValue = false)]
		public string[] AssemblyLoadProperties { get; set; }

		[DataMember(Name = "AssemblyTime", EmitDefaultValue = false)]
		public string AssemblyTime { get; set; }

		[DataMember(Name = "CompatibilityVersion", EmitDefaultValue = false)]
		public int CompatibilityVersion { get; set; }

		[DataMember(Name = "IsBrowsable", EmitDefaultValue = false)]
		public bool IsBrowsable { get; set; }

		[DataMember(Name = "IsNonEditableConfig", EmitDefaultValue = false)]
		public bool IsNonEditableConfig { get; set; }

		[DataMember(Name = "LoadedAssemblyTime", EmitDefaultValue = false)]
		public string LoadedAssemblyTime { get; set; }

		[DataMember(Name = "LoadedVersion", EmitDefaultValue = false)]
		public string LoadedVersion { get; set; }

		[DataMember(Name = "Version", EmitDefaultValue = false)]
		public string Version { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
