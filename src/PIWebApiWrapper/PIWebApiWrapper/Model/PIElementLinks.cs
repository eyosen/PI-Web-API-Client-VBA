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

	[Guid("A38F6FB5-BE59-41C7-A05B-B95758828224")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIElementLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Analyses { get; set; }

		[DispId(3)]
		string Attributes { get; set; }

		[DispId(4)]
		string Elements { get; set; }

		[DispId(5)]
		string Database { get; set; }

		[DispId(6)]
		string Parent { get; set; }

		[DispId(7)]
		string Template { get; set; }

		[DispId(8)]
		string Categories { get; set; }

		[DispId(9)]
		string DefaultAttribute { get; set; }

		[DispId(10)]
		string EventFrames { get; set; }

		[DispId(11)]
		string InterpolatedData { get; set; }

		[DispId(12)]
		string RecordedData { get; set; }

		[DispId(13)]
		string PlotData { get; set; }

		[DispId(14)]
		string SummaryData { get; set; }

		[DispId(15)]
		string Value { get; set; }

		[DispId(16)]
		string EndValue { get; set; }

		[DispId(17)]
		string Security { get; set; }

		[DispId(18)]
		string SecurityEntries { get; set; }

		[DispId(19)]
		string NotificationRules { get; set; }

	}

	[Guid("CCA65790-5BBA-42B4-9768-7D36715F6DCE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIElementLinks))]
	[ProgId("PIWebAPIWrapper.PIElementLinks")]
	[DataContract]

	public class PIElementLinks : IPIElementLinks
	{
		public PIElementLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Analyses", EmitDefaultValue = false)]
		public string Analyses { get; set; }

		[DataMember(Name = "Attributes", EmitDefaultValue = false)]
		public string Attributes { get; set; }

		[DataMember(Name = "Elements", EmitDefaultValue = false)]
		public string Elements { get; set; }

		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		[DataMember(Name = "Template", EmitDefaultValue = false)]
		public string Template { get; set; }

		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		[DataMember(Name = "DefaultAttribute", EmitDefaultValue = false)]
		public string DefaultAttribute { get; set; }

		[DataMember(Name = "EventFrames", EmitDefaultValue = false)]
		public string EventFrames { get; set; }

		[DataMember(Name = "InterpolatedData", EmitDefaultValue = false)]
		public string InterpolatedData { get; set; }

		[DataMember(Name = "RecordedData", EmitDefaultValue = false)]
		public string RecordedData { get; set; }

		[DataMember(Name = "PlotData", EmitDefaultValue = false)]
		public string PlotData { get; set; }

		[DataMember(Name = "SummaryData", EmitDefaultValue = false)]
		public string SummaryData { get; set; }

		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public string Value { get; set; }

		[DataMember(Name = "EndValue", EmitDefaultValue = false)]
		public string EndValue { get; set; }

		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

		[DataMember(Name = "NotificationRules", EmitDefaultValue = false)]
		public string NotificationRules { get; set; }

	}
}
