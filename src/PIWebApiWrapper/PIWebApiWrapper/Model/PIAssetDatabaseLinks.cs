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

	[Guid("7FC5F6BE-6216-4FC9-B108-98DF177B007F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAssetDatabaseLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Elements { get; set; }

		[DispId(3)]
		string ElementTemplates { get; set; }

		[DispId(4)]
		string EventFrames { get; set; }

		[DispId(5)]
		string AssetServer { get; set; }

		[DispId(6)]
		string ElementCategories { get; set; }

		[DispId(7)]
		string AttributeCategories { get; set; }

		[DispId(8)]
		string TableCategories { get; set; }

		[DispId(9)]
		string AnalysisCategories { get; set; }

		[DispId(10)]
		string AnalysisTemplates { get; set; }

		[DispId(11)]
		string EnumerationSets { get; set; }

		[DispId(12)]
		string Tables { get; set; }

		[DispId(13)]
		string Security { get; set; }

		[DispId(14)]
		string SecurityEntries { get; set; }

	}

	[Guid("68ADCCF1-A00A-4C72-977E-14C510BDF83A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAssetDatabaseLinks))]
	[ProgId("PIWebAPIWrapper.PIAssetDatabaseLinks")]
	[DataContract]

	public class PIAssetDatabaseLinks : IPIAssetDatabaseLinks
	{
		public PIAssetDatabaseLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Elements", EmitDefaultValue = false)]
		public string Elements { get; set; }

		[DataMember(Name = "ElementTemplates", EmitDefaultValue = false)]
		public string ElementTemplates { get; set; }

		[DataMember(Name = "EventFrames", EmitDefaultValue = false)]
		public string EventFrames { get; set; }

		[DataMember(Name = "AssetServer", EmitDefaultValue = false)]
		public string AssetServer { get; set; }

		[DataMember(Name = "ElementCategories", EmitDefaultValue = false)]
		public string ElementCategories { get; set; }

		[DataMember(Name = "AttributeCategories", EmitDefaultValue = false)]
		public string AttributeCategories { get; set; }

		[DataMember(Name = "TableCategories", EmitDefaultValue = false)]
		public string TableCategories { get; set; }

		[DataMember(Name = "AnalysisCategories", EmitDefaultValue = false)]
		public string AnalysisCategories { get; set; }

		[DataMember(Name = "AnalysisTemplates", EmitDefaultValue = false)]
		public string AnalysisTemplates { get; set; }

		[DataMember(Name = "EnumerationSets", EmitDefaultValue = false)]
		public string EnumerationSets { get; set; }

		[DataMember(Name = "Tables", EmitDefaultValue = false)]
		public string Tables { get; set; }

		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
