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

	[Guid("85BF47C2-8D2F-4529-93D5-AAC74F8AD3A8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIEventFrameLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Attributes { get; set; }

		[DispId(3)]
		string EventFrames { get; set; }

		[DispId(4)]
		string Database { get; set; }

		[DispId(5)]
		string ReferencedElements { get; set; }

		[DispId(6)]
		string PrimaryReferencedElement { get; set; }

		[DispId(7)]
		string Parent { get; set; }

		[DispId(8)]
		string Template { get; set; }

		[DispId(9)]
		string DefaultAttribute { get; set; }

		[DispId(10)]
		string Categories { get; set; }

		[DispId(11)]
		string Annotations { get; set; }

		[DispId(12)]
		string InterpolatedData { get; set; }

		[DispId(13)]
		string RecordedData { get; set; }

		[DispId(14)]
		string PlotData { get; set; }

		[DispId(15)]
		string SummaryData { get; set; }

		[DispId(16)]
		string Value { get; set; }

		[DispId(17)]
		string EndValue { get; set; }

		[DispId(18)]
		string Security { get; set; }

		[DispId(19)]
		string SecurityEntries { get; set; }

	}

	[Guid("04A8867B-4F41-48BC-A1DD-1181E13EEF6F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIEventFrameLinks))]
	[ProgId("PIWebAPIWrapper.PIEventFrameLinks")]
	[DataContract]

	public class PIEventFrameLinks : IPIEventFrameLinks
	{
		public PIEventFrameLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Attributes", EmitDefaultValue = false)]
		public string Attributes { get; set; }

		[DataMember(Name = "EventFrames", EmitDefaultValue = false)]
		public string EventFrames { get; set; }

		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		[DataMember(Name = "ReferencedElements", EmitDefaultValue = false)]
		public string ReferencedElements { get; set; }

		[DataMember(Name = "PrimaryReferencedElement", EmitDefaultValue = false)]
		public string PrimaryReferencedElement { get; set; }

		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		[DataMember(Name = "Template", EmitDefaultValue = false)]
		public string Template { get; set; }

		[DataMember(Name = "DefaultAttribute", EmitDefaultValue = false)]
		public string DefaultAttribute { get; set; }

		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		[DataMember(Name = "Annotations", EmitDefaultValue = false)]
		public string Annotations { get; set; }

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

	}
}
