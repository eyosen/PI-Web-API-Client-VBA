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

	[Guid("D8DC8E81-C2B0-49BF-A380-13F914C927B6")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIPointLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string DataServer { get; set; }

		[DispId(3)]
		string Attributes { get; set; }

		[DispId(4)]
		string InterpolatedData { get; set; }

		[DispId(5)]
		string RecordedData { get; set; }

		[DispId(6)]
		string PlotData { get; set; }

		[DispId(7)]
		string SummaryData { get; set; }

		[DispId(8)]
		string Value { get; set; }

		[DispId(9)]
		string EndValue { get; set; }

	}

	[Guid("17D1A8BA-A720-4DD0-88A8-E7953FE3F179")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIPointLinks))]
	[ProgId("PIWebAPIWrapper.PIPointLinks")]
	[DataContract]

	public class PIPointLinks : IPIPointLinks
	{
		public PIPointLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "DataServer", EmitDefaultValue = false)]
		public string DataServer { get; set; }

		[DataMember(Name = "Attributes", EmitDefaultValue = false)]
		public string Attributes { get; set; }

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

	}
}
