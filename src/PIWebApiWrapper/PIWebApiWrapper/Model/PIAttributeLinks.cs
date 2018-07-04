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

	[Guid("B252FF65-319D-47E4-B92B-145C34698B52")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAttributeLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Attributes { get; set; }

		[DispId(3)]
		string Element { get; set; }

		[DispId(4)]
		string EventFrame { get; set; }

		[DispId(5)]
		string Parent { get; set; }

		[DispId(6)]
		string Template { get; set; }

		[DispId(7)]
		string InterpolatedData { get; set; }

		[DispId(8)]
		string RecordedData { get; set; }

		[DispId(9)]
		string PlotData { get; set; }

		[DispId(10)]
		string SummaryData { get; set; }

		[DispId(11)]
		string Value { get; set; }

		[DispId(12)]
		string EndValue { get; set; }

		[DispId(13)]
		string Point { get; set; }

		[DispId(14)]
		string Categories { get; set; }

		[DispId(15)]
		string EnumerationSet { get; set; }

		[DispId(16)]
		string EnumerationValues { get; set; }

		[DispId(17)]
		string Trait { get; set; }

	}

	[Guid("4AB430EE-7259-4909-8401-D6F7693BE271")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAttributeLinks))]
	[ProgId("PIWebAPIWrapper.PIAttributeLinks")]
	[DataContract]

	public class PIAttributeLinks : IPIAttributeLinks
	{
		public PIAttributeLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Attributes", EmitDefaultValue = false)]
		public string Attributes { get; set; }

		[DataMember(Name = "Element", EmitDefaultValue = false)]
		public string Element { get; set; }

		[DataMember(Name = "EventFrame", EmitDefaultValue = false)]
		public string EventFrame { get; set; }

		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		[DataMember(Name = "Template", EmitDefaultValue = false)]
		public string Template { get; set; }

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

		[DataMember(Name = "Point", EmitDefaultValue = false)]
		public string Point { get; set; }

		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		[DataMember(Name = "EnumerationSet", EmitDefaultValue = false)]
		public string EnumerationSet { get; set; }

		[DataMember(Name = "EnumerationValues", EmitDefaultValue = false)]
		public string EnumerationValues { get; set; }

		[DataMember(Name = "Trait", EmitDefaultValue = false)]
		public string Trait { get; set; }

	}
}
