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

	[Guid("BADC775A-97DC-499F-A566-6B0B1FE473C3")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAssetServerLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Databases { get; set; }

		[DispId(3)]
		string NotificationContactTemplates { get; set; }

		[DispId(4)]
		string SecurityIdentities { get; set; }

		[DispId(5)]
		string SecurityMappings { get; set; }

		[DispId(6)]
		string UnitClasses { get; set; }

		[DispId(7)]
		string AnalysisRulePlugIns { get; set; }

		[DispId(8)]
		string TimeRulePlugIns { get; set; }

		[DispId(9)]
		string Security { get; set; }

		[DispId(10)]
		string SecurityEntries { get; set; }

	}

	[Guid("5F1E32BE-F925-4B30-9F50-5BA8BC0076B0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAssetServerLinks))]
	[ProgId("PIWebAPIWrapper.PIAssetServerLinks")]
	[DataContract]

	public class PIAssetServerLinks : IPIAssetServerLinks
	{
		public PIAssetServerLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Databases", EmitDefaultValue = false)]
		public string Databases { get; set; }

		[DataMember(Name = "NotificationContactTemplates", EmitDefaultValue = false)]
		public string NotificationContactTemplates { get; set; }

		[DataMember(Name = "SecurityIdentities", EmitDefaultValue = false)]
		public string SecurityIdentities { get; set; }

		[DataMember(Name = "SecurityMappings", EmitDefaultValue = false)]
		public string SecurityMappings { get; set; }

		[DataMember(Name = "UnitClasses", EmitDefaultValue = false)]
		public string UnitClasses { get; set; }

		[DataMember(Name = "AnalysisRulePlugIns", EmitDefaultValue = false)]
		public string AnalysisRulePlugIns { get; set; }

		[DataMember(Name = "TimeRulePlugIns", EmitDefaultValue = false)]
		public string TimeRulePlugIns { get; set; }

		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
